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
    public ref struct CliFieldBuilder
    {
        readonly Span<MemberFieldSpec> Fields;

        ushort Index;

        [Op]
        public static CliFieldBuilder create(ushort? capacity = null)
            => new CliFieldBuilder(capacity ?? 20);

        [Op]
        public static FieldBuilder field(TypeBuilder tb, string name, string type, Address16? offset = null)
        {
            var fb = tb.DefineField(name, Type.GetType(type), FieldAttributes.Public);
            if(offset != null)
                fb.SetOffset(offset.Value);
            return fb;
        }

        [MethodImpl(Inline), Op]
        public static ModuleBuilder module(string name)
        {
            var ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.Run);
            return ab.DefineDynamicModule("Primary");
        }

        [MethodImpl(Inline), Op]
        public static TypeBuilder type(ModuleBuilder mb, string name, TypeAttributes attributes, Type parent)
            => mb.DefineType(name, attributes, parent);

        [MethodImpl(Inline), Op]
        public static TypeBuilder @struct(ModuleBuilder mb, string name, TypeAttributes attributes)
            => mb.DefineType(name, attributes, typeof(ValueType));

        const TypeAttributes Default = BeforeFieldInit | Public | Sealed | AnsiClass;

        public const TypeAttributes ExplicitAnsi
            = Default | ExplicitLayout;

        public const TypeAttributes SequentialAnsi
            = Default | SequentialLayout;

        [MethodImpl(Inline),Op]
        public CliFieldBuilder(uint capacity)
        {
            Index = 0;
            Fields = span<MemberFieldSpec>(capacity);
        }

        [MethodImpl(Inline),Op]
        public CliFieldBuilder WithField(in MemberFieldSpec src)
        {
            seek(Fields, Index++) = src;
            return this;
        }

        [MethodImpl(Inline),Op]
        public CliFieldBuilder WithField(PropertyInfo src)
            => WithField(new MemberFieldSpec(src.Name, src.PropertyType.Name, Index));

        [MethodImpl(Inline),Op]
        public CliFieldBuilder WithField(string name, Type type)
            => WithField(new MemberFieldSpec(name, type.Name, Index));

        [MethodImpl(Inline), Op]
        public CliFieldBuilder WithField(ClrFieldAdapter src)
            =>  WithField(new MemberFieldSpec(src.Name, src.FieldType.Name, Index));

        [MethodImpl(Inline), Op]
        public CliFieldBuilder WithFields(params PropertyInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(Inline), Op]
        public CliFieldBuilder WithFields(params FieldInfo[] src)
        {
            foreach(var item in src)
                WithField(item);
            return this;
        }

        [MethodImpl(NotInline), Op]
        public RecordSpec Complete(Name name)
        {
            var cells = Fields.Slice(0,(int)Index).ToArray();
            Fields.Clear();
            return new RecordSpec(name, cells);
        }
    }
}