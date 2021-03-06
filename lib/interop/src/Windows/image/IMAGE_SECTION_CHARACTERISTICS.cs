namespace Windows.Image
{
    using System;

    [Flags]
    public enum IMAGE_SECTION_CHARACTERISTICS : uint
    {
        IMAGE_SCN_TYPE_NO_PAD = 0x8u,
        IMAGE_SCN_CNT_CODE = 0x20u,
        IMAGE_SCN_CNT_INITIALIZED_DATA = 0x40u,
        IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x80u,
        IMAGE_SCN_LNK_OTHER = 0x100u,
        IMAGE_SCN_LNK_INFO = 0x200u,
        IMAGE_SCN_LNK_REMOVE = 0x800u,
        IMAGE_SCN_LNK_COMDAT = 0x1000u,
        IMAGE_SCN_NO_DEFER_SPEC_EXC = 0x4000u,
        IMAGE_SCN_GPREL = 0x8000u,
        IMAGE_SCN_MEM_FARDATA = 0x8000u,
        IMAGE_SCN_MEM_PURGEABLE = 0x20000u,
        IMAGE_SCN_MEM_16BIT = 0x20000u,
        IMAGE_SCN_MEM_LOCKED = 0x40000u,
        IMAGE_SCN_MEM_PRELOAD = 0x80000u,
        IMAGE_SCN_ALIGN_1BYTES = 0x100000u,
        IMAGE_SCN_ALIGN_2BYTES = 0x200000u,
        IMAGE_SCN_ALIGN_4BYTES = 0x300000u,
        IMAGE_SCN_ALIGN_8BYTES = 0x400000u,
        IMAGE_SCN_ALIGN_16BYTES = 0x500000u,
        IMAGE_SCN_ALIGN_32BYTES = 0x600000u,
        IMAGE_SCN_ALIGN_64BYTES = 0x700000u,
        IMAGE_SCN_ALIGN_128BYTES = 0x800000u,
        IMAGE_SCN_ALIGN_256BYTES = 0x900000u,
        IMAGE_SCN_ALIGN_512BYTES = 0xA00000u,
        IMAGE_SCN_ALIGN_1024BYTES = 0xB00000u,
        IMAGE_SCN_ALIGN_2048BYTES = 0xC00000u,
        IMAGE_SCN_ALIGN_4096BYTES = 0xD00000u,
        IMAGE_SCN_ALIGN_8192BYTES = 0xE00000u,
        IMAGE_SCN_ALIGN_MASK = 0xF00000u,
        IMAGE_SCN_LNK_NRELOC_OVFL = 0x1000000u,
        IMAGE_SCN_MEM_DISCARDABLE = 0x2000000u,
        IMAGE_SCN_MEM_NOT_CACHED = 0x4000000u,
        IMAGE_SCN_MEM_NOT_PAGED = 0x8000000u,
        IMAGE_SCN_MEM_SHARED = 0x10000000u,
        IMAGE_SCN_MEM_EXECUTE = 0x20000000u,
        IMAGE_SCN_MEM_READ = 0x40000000u,
        IMAGE_SCN_MEM_WRITE = 0x80000000u,
        IMAGE_SCN_SCALE_INDEX = 0x1u
    }
}
