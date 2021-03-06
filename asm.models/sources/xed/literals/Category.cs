//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-category-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymSource(xed)]
        public enum Category : byte
        {
            None,

            [Symbol("3DNOW")]
            _3DNOW,

            ADOX_ADCX,

            AES,

            AMX_TILE,

            AVX,

            AVX2,

            AVX2GATHER,

            AVX512,

            AVX512_4FMAPS,

            AVX512_4VNNIW,

            AVX512_BITALG,
            AVX512_VBMI,

            AVX512_VP2INTERSECT,

            BINARY,

            BITBYTE,

            BLEND,

            BMI1,

            BMI2,

            BROADCAST,

            CALL,

            CET,

            CLDEMOTE,

            CLFLUSHOPT,

            CLWB,

            CLZERO,

            CMOV,

            COMPRESS,

            COND_BR,

            CONFLICT,

            CONVERT,

            DATAXFER,

            DECIMAL,

            ENQCMD,

            EXPAND,

            FCMOV,

            FLAGOP,

            FMA4,

            GATHER,

            GFNI,

            HRESET,

            IFMA,

            INTERRUPT,

            IO,

            IOSTRINGOP,

            KEYLOCKER,

            KEYLOCKER_WIDE,

            KMASK,

            LEGACY,

            LOGICAL,

            LOGICAL_FP,

            LZCNT,

            MISC,

            MMX,

            MOVDIR,

            MPX,

            NOP,

            PCLMULQDQ,

            PCONFIG,

            PKU,

            POP,
            PREFETCH,
            PREFETCHWT1,
            PTWRITE,
            PUSH,
            RDPID,
            RDPRU,
            RDRAND,
            RDSEED,
            RDWRFSGS,
            RET,
            ROTATE,
            SCATTER,
            SEGOP,
            SEMAPHORE,
            SERIALIZE,
            SETCC,
            SGX,
            SHA,
            SHIFT,
            SMAP,
            SSE,
            STRINGOP,
            STTNI,
            SYSCALL,
            SYSRET,
            SYSTEM,
            TBM,
            TSX_LDTRK,
            UINTR,
            UNCOND_BR,
            VAES,
            VBMI2,
            VEX,
            VFMA,
            VIA_PADLOCK,
            VPCLMULQDQ,
            VTX,
            WAITPKG,
            WIDENOP,
            X87_ALU,
            XOP,
            XSAVE,
            XSAVEOPT,
        }
    }
}