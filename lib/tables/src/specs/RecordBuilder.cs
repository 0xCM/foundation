//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;

    using static System.Reflection.TypeAttributes;
    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct RecordBuilder
    {
        const TypeAttributes Default = BeforeFieldInit | Public | Sealed | AnsiClass;

        public const TypeAttributes ExplicitAnsi
            = Default | ExplicitLayout;

        public const TypeAttributes SequentialAnsi
            = Default | SequentialLayout;

        [Op]
        public static string format(in RecordSpec src)
        {
            var dst = text.build();
            dst.AppendLine(src.TypeName);
            for(var i=0; i<src.Fields.Length; i++)
                dst.AppendLine(src.Fields[i].ToString());
            return dst.ToString();
        }

        [MethodImpl(Inline), Op]
        public static RecordSpec table(Identifier type, params MemberFieldSpec[] Fields)
            => new RecordSpec(type, Fields);

        [MethodImpl(Inline), Op]
        public static MemberFieldSpec field(Identifier name, Identifier type, ushort position, ushort offset = default)
            => new MemberFieldSpec(name, type, position, offset);

        [Op]
        public static TypeBuilder type(ModuleBuilder mb, Identifier fullName, TypeAttributes attributes, Type parent)
            => mb.DefineType(fullName, attributes, parent);

        [Op]
        public static TypeBuilder valueType(ModuleBuilder mb, Identifier fullName, TypeAttributes attributes)
            => mb.DefineType(fullName, attributes, typeof(ValueType));

        [Op]
        public static FieldBuilder field(TypeBuilder tb, Identifier name, Identifier type, uint? offset = null)
        {
            var fb = tb.DefineField(name.Format(), Type.GetType(type.Format()), FieldAttributes.Public);
            if(offset != null)
                fb.SetOffset((int)offset.Value);
            return fb;
        }

        [Op]
        public static ModuleBuilder module(ClrAssemblyName name)
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(name, AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }

        [Op]
        public static RecordSpec clone(Type src)
        {
            Name name = src.Name;
            var declared = src.DeclaredInstanceFields();
            var count = declared.Length;
            var buffer = alloc<MemberFieldSpec>(count);
            var fields = @readonly(declared);
            var fieldOffsets = span(Clr.offsets(src, declared));
            var dst = span(buffer);
            for(ushort i=0; i<count; i++)
            {
                ref readonly var f = ref skip(fields, i);
                var offset = skip(fieldOffsets,i);
                seek(dst,i) = field(f.Name, f.FieldType.Name, i, skip(fieldOffsets,i));
            }

            return new RecordSpec(name, buffer);
        }

        /// <summary>
        /// Manufactures the type that reifies a supplied record definition
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline),Op]
        public static Type type(ClrAssemblyName assname, RecordSpec spec)
            => build(module(assname), spec);

        /// <summary>
        /// Manufactures the types that reify supplied record definitions
        /// </summary>
        /// <param name="spec">The record definition</param>
        [MethodImpl(NotInline), Op]
        public static Type[] types(ClrAssemblyName assname, params RecordSpec[] specs)
        {
            var count = specs.Length;
            var buffer = alloc<Type>(count);
            var dst = span(buffer);
            var src = @readonly(specs);
            var mb = module(assname);
            for(var i=0u; i<count; i++)
                seek(dst,i) = build(mb, skip(src,i));

            return buffer;
        }

        [Op]
        static Type build(ModuleBuilder mb, RecordSpec spec)
        {
            var tb = valueType(mb, spec.TypeName, ExplicitAnsi);
            var fields = spec.Fields;
            foreach(var f in fields)
                field(tb, f.FieldName, f.DataType, f.Offset);
            var type = tb.CreateType();
            return type;
        }
    }
}