// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    partial struct MinidumpRecords
    {
        public enum MinidumpProcessorArchitecture : ushort
        {
            Intel = 0,

            Mips = 1,

            Alpha = 2,

            Ppc = 3,

            Shx = 4,

            Arm = 5,

            Ia64 = 6,

            Alpha64 = 7,

            Msil = 8,

            Amd64 = 9,

            Ia32OnWin64 = 10,

            Arm64 = 12,

            Unknown = 0xffff,
        }
    }
}