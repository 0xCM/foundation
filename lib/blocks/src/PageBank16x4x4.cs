//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using B = PageBlocks.PageBlock16x4;

    [ApiHost]
    public class PageBank16x4x4
    {
        public static PageBank16x4x4 allocated()
            => Instance;

        public const uint BlockCount = 8;

        public const uint BlockSize = B.SZ;

        public const uint BankSize = BlockCount*BlockSize;

        public const uint TotalPageCount = B.PageCount*BlockCount;

        public const uint PagesPerBlock = B.PageCount;

        [MethodImpl(Inline), Op]
        public PageBlock Block(byte index)
            => new PageBlock(BlockIndex[index]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N0 n)
            => new PageBlock(BlockIndex[0]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N1 n)
            => new PageBlock(BlockIndex[1]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N2 n)
            => new PageBlock(BlockIndex[2]);

        [MethodImpl(Inline), Op]
        public PageBlock Block(N3 n)
            => new PageBlock(BlockIndex[3]);

        [MethodImpl(Inline), Op]
        public ref readonly PageBankInfo Describe()
            => ref Description;

        Index<MemoryRange> BlockIndex;

        PageBankInfo Description;

        PageBank16x4x4()
        {
            BlockIndex = new MemoryRange[4];
            ref var dst = ref BlockIndex.First;
            seek(dst,0) = new MemoryRange(address(Block16x4x0), _BlockSize);
            seek(dst,1) = new MemoryRange(address(Block16x4x1), _BlockSize);
            seek(dst,2) = new MemoryRange(address(Block16x4x2), _BlockSize);
            seek(dst,3) = new MemoryRange(address(Block16x4x3), _BlockSize);
            WinMem.liberate(address(Block16x4x0), size<B>());
            WinMem.liberate(address(Block16x4x1), size<B>());
            WinMem.liberate(address(Block16x4x2), size<B>());
            WinMem.liberate(address(Block16x4x3), size<B>());
            Description.BankSize = BankSize;
            Description.BlockCount = BlockCount;
            Description.BlockSize = BlockSize;
            Description.PageSize = PageBlocks.PageSize;
            Description.PagesPerBlock = PagesPerBlock;
            Description.TotalPageCount = TotalPageCount;
        }

        static PageBank16x4x4()
        {
            Instance = new PageBank16x4x4();
        }

        static ByteSize _BlockSize => size<B>();

        static PageBank16x4x4 Instance;

        [FixedAddressValueType]
        static B Block16x4x0;

        [FixedAddressValueType]
        static B Block16x4x1;

        [FixedAddressValueType]
        static B Block16x4x2;

        [FixedAddressValueType]
        static B Block16x4x3;
    }
}