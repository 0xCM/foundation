//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
	/// <summary>x86 instruction code</summary>
	public enum IceOpCodeId
	{
		/// <summary>It&apos;s an invalid instruction, eg. it&apos;s a new unknown instruction, garbage or there&apos;s not enough bytes to decode the instruction etc.</summary>
		INVALID = 0,
		/// <summary>A <c>db</c>/<c>.byte</c> asm directive that can store 1-16 bytes</summary>
		DeclareByte = 1,
		/// <summary>A <c>dw</c>/<c>.word</c> asm directive that can store 1-8 words</summary>
		DeclareWord = 2,
		/// <summary>A <c>dd</c>/<c>.int</c> asm directive that can store 1-4 dwords</summary>
		DeclareDword = 3,
		/// <summary>A <c>dq</c>/<c>.quad</c> asm directive that can store 1-2 qwords</summary>
		DeclareQword = 4,
		/// <summary><c>ADD r/m8, r8</c><br/>
		/// <br/>
		/// <c>00 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm8_r8 = 5,
		/// <summary><c>ADD r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 01 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm16_r16 = 6,
		/// <summary><c>ADD r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 01 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm32_r32 = 7,
		/// <summary><c>ADD r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 01 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Add_rm64_r64 = 8,
		/// <summary><c>ADD r8, r/m8</c><br/>
		/// <br/>
		/// <c>02 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_r8_rm8 = 9,
		/// <summary><c>ADD r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 03 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_r16_rm16 = 10,
		/// <summary><c>ADD r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 03 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_r32_rm32 = 11,
		/// <summary><c>ADD r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 03 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Add_r64_rm64 = 12,
		/// <summary><c>ADD AL, imm8</c><br/>
		/// <br/>
		/// <c>04 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_AL_imm8 = 13,
		/// <summary><c>ADD AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 05 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_AX_imm16 = 14,
		/// <summary><c>ADD EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 05 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_EAX_imm32 = 15,
		/// <summary><c>ADD RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 05 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Add_RAX_imm32 = 16,
		/// <summary><c>PUSH ES</c><br/>
		/// <br/>
		/// <c>o16 06</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushw_ES = 17,
		/// <summary><c>PUSH ES</c><br/>
		/// <br/>
		/// <c>o32 06</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_ES = 18,
		/// <summary><c>POP ES</c><br/>
		/// <br/>
		/// <c>o16 07</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popw_ES = 19,
		/// <summary><c>POP ES</c><br/>
		/// <br/>
		/// <c>o32 07</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popd_ES = 20,
		/// <summary><c>OR r/m8, r8</c><br/>
		/// <br/>
		/// <c>08 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm8_r8 = 21,
		/// <summary><c>OR r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 09 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm16_r16 = 22,
		/// <summary><c>OR r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 09 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm32_r32 = 23,
		/// <summary><c>OR r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 09 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Or_rm64_r64 = 24,
		/// <summary><c>OR r8, r/m8</c><br/>
		/// <br/>
		/// <c>0A /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_r8_rm8 = 25,
		/// <summary><c>OR r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0B /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_r16_rm16 = 26,
		/// <summary><c>OR r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0B /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_r32_rm32 = 27,
		/// <summary><c>OR r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0B /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Or_r64_rm64 = 28,
		/// <summary><c>OR AL, imm8</c><br/>
		/// <br/>
		/// <c>0C ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_AL_imm8 = 29,
		/// <summary><c>OR AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 0D iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_AX_imm16 = 30,
		/// <summary><c>OR EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 0D id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_EAX_imm32 = 31,
		/// <summary><c>OR RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 0D id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Or_RAX_imm32 = 32,
		/// <summary><c>PUSH CS</c><br/>
		/// <br/>
		/// <c>o16 0E</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushw_CS = 33,
		/// <summary><c>PUSH CS</c><br/>
		/// <br/>
		/// <c>o32 0E</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_CS = 34,
		/// <summary><c>POP CS</c><br/>
		/// <br/>
		/// <c>o16 0F</c><br/>
		/// <br/>
		/// <c>8086</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popw_CS = 35,
		/// <summary><c>ADC r/m8, r8</c><br/>
		/// <br/>
		/// <c>10 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm8_r8 = 36,
		/// <summary><c>ADC r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 11 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm16_r16 = 37,
		/// <summary><c>ADC r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 11 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm32_r32 = 38,
		/// <summary><c>ADC r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 11 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adc_rm64_r64 = 39,
		/// <summary><c>ADC r8, r/m8</c><br/>
		/// <br/>
		/// <c>12 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_r8_rm8 = 40,
		/// <summary><c>ADC r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 13 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_r16_rm16 = 41,
		/// <summary><c>ADC r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 13 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_r32_rm32 = 42,
		/// <summary><c>ADC r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 13 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adc_r64_rm64 = 43,
		/// <summary><c>ADC AL, imm8</c><br/>
		/// <br/>
		/// <c>14 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_AL_imm8 = 44,
		/// <summary><c>ADC AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 15 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_AX_imm16 = 45,
		/// <summary><c>ADC EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 15 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_EAX_imm32 = 46,
		/// <summary><c>ADC RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 15 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adc_RAX_imm32 = 47,
		/// <summary><c>PUSH SS</c><br/>
		/// <br/>
		/// <c>o16 16</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushw_SS = 48,
		/// <summary><c>PUSH SS</c><br/>
		/// <br/>
		/// <c>o32 16</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_SS = 49,
		/// <summary><c>POP SS</c><br/>
		/// <br/>
		/// <c>o16 17</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popw_SS = 50,
		/// <summary><c>POP SS</c><br/>
		/// <br/>
		/// <c>o32 17</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popd_SS = 51,
		/// <summary><c>SBB r/m8, r8</c><br/>
		/// <br/>
		/// <c>18 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm8_r8 = 52,
		/// <summary><c>SBB r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 19 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm16_r16 = 53,
		/// <summary><c>SBB r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 19 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm32_r32 = 54,
		/// <summary><c>SBB r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 19 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sbb_rm64_r64 = 55,
		/// <summary><c>SBB r8, r/m8</c><br/>
		/// <br/>
		/// <c>1A /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_r8_rm8 = 56,
		/// <summary><c>SBB r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 1B /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_r16_rm16 = 57,
		/// <summary><c>SBB r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 1B /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_r32_rm32 = 58,
		/// <summary><c>SBB r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 1B /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sbb_r64_rm64 = 59,
		/// <summary><c>SBB AL, imm8</c><br/>
		/// <br/>
		/// <c>1C ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_AL_imm8 = 60,
		/// <summary><c>SBB AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 1D iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_AX_imm16 = 61,
		/// <summary><c>SBB EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 1D id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_EAX_imm32 = 62,
		/// <summary><c>SBB RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 1D id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sbb_RAX_imm32 = 63,
		/// <summary><c>PUSH DS</c><br/>
		/// <br/>
		/// <c>o16 1E</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushw_DS = 64,
		/// <summary><c>PUSH DS</c><br/>
		/// <br/>
		/// <c>o32 1E</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_DS = 65,
		/// <summary><c>POP DS</c><br/>
		/// <br/>
		/// <c>o16 1F</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popw_DS = 66,
		/// <summary><c>POP DS</c><br/>
		/// <br/>
		/// <c>o32 1F</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popd_DS = 67,
		/// <summary><c>AND r/m8, r8</c><br/>
		/// <br/>
		/// <c>20 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm8_r8 = 68,
		/// <summary><c>AND r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 21 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm16_r16 = 69,
		/// <summary><c>AND r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 21 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm32_r32 = 70,
		/// <summary><c>AND r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 21 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		And_rm64_r64 = 71,
		/// <summary><c>AND r8, r/m8</c><br/>
		/// <br/>
		/// <c>22 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_r8_rm8 = 72,
		/// <summary><c>AND r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 23 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_r16_rm16 = 73,
		/// <summary><c>AND r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 23 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_r32_rm32 = 74,
		/// <summary><c>AND r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 23 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		And_r64_rm64 = 75,
		/// <summary><c>AND AL, imm8</c><br/>
		/// <br/>
		/// <c>24 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_AL_imm8 = 76,
		/// <summary><c>AND AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 25 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_AX_imm16 = 77,
		/// <summary><c>AND EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 25 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_EAX_imm32 = 78,
		/// <summary><c>AND RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 25 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		And_RAX_imm32 = 79,
		/// <summary><c>DAA</c><br/>
		/// <br/>
		/// <c>27</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Daa = 80,
		/// <summary><c>SUB r/m8, r8</c><br/>
		/// <br/>
		/// <c>28 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm8_r8 = 81,
		/// <summary><c>SUB r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 29 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm16_r16 = 82,
		/// <summary><c>SUB r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 29 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm32_r32 = 83,
		/// <summary><c>SUB r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 29 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sub_rm64_r64 = 84,
		/// <summary><c>SUB r8, r/m8</c><br/>
		/// <br/>
		/// <c>2A /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_r8_rm8 = 85,
		/// <summary><c>SUB r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 2B /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_r16_rm16 = 86,
		/// <summary><c>SUB r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 2B /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_r32_rm32 = 87,
		/// <summary><c>SUB r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 2B /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sub_r64_rm64 = 88,
		/// <summary><c>SUB AL, imm8</c><br/>
		/// <br/>
		/// <c>2C ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_AL_imm8 = 89,
		/// <summary><c>SUB AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 2D iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_AX_imm16 = 90,
		/// <summary><c>SUB EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 2D id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_EAX_imm32 = 91,
		/// <summary><c>SUB RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 2D id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sub_RAX_imm32 = 92,
		/// <summary><c>DAS</c><br/>
		/// <br/>
		/// <c>2F</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Das = 93,
		/// <summary><c>XOR r/m8, r8</c><br/>
		/// <br/>
		/// <c>30 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm8_r8 = 94,
		/// <summary><c>XOR r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 31 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm16_r16 = 95,
		/// <summary><c>XOR r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 31 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm32_r32 = 96,
		/// <summary><c>XOR r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 31 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xor_rm64_r64 = 97,
		/// <summary><c>XOR r8, r/m8</c><br/>
		/// <br/>
		/// <c>32 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_r8_rm8 = 98,
		/// <summary><c>XOR r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 33 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_r16_rm16 = 99,
		/// <summary><c>XOR r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 33 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_r32_rm32 = 100,
		/// <summary><c>XOR r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 33 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xor_r64_rm64 = 101,
		/// <summary><c>XOR AL, imm8</c><br/>
		/// <br/>
		/// <c>34 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_AL_imm8 = 102,
		/// <summary><c>XOR AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 35 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_AX_imm16 = 103,
		/// <summary><c>XOR EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 35 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_EAX_imm32 = 104,
		/// <summary><c>XOR RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 35 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xor_RAX_imm32 = 105,
		/// <summary><c>AAA</c><br/>
		/// <br/>
		/// <c>37</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Aaa = 106,
		/// <summary><c>CMP r/m8, r8</c><br/>
		/// <br/>
		/// <c>38 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm8_r8 = 107,
		/// <summary><c>CMP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 39 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm16_r16 = 108,
		/// <summary><c>CMP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 39 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm32_r32 = 109,
		/// <summary><c>CMP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 39 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmp_rm64_r64 = 110,
		/// <summary><c>CMP r8, r/m8</c><br/>
		/// <br/>
		/// <c>3A /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_r8_rm8 = 111,
		/// <summary><c>CMP r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 3B /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_r16_rm16 = 112,
		/// <summary><c>CMP r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 3B /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_r32_rm32 = 113,
		/// <summary><c>CMP r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 3B /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmp_r64_rm64 = 114,
		/// <summary><c>CMP AL, imm8</c><br/>
		/// <br/>
		/// <c>3C ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_AL_imm8 = 115,
		/// <summary><c>CMP AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 3D iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_AX_imm16 = 116,
		/// <summary><c>CMP EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 3D id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_EAX_imm32 = 117,
		/// <summary><c>CMP RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 3D id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmp_RAX_imm32 = 118,
		/// <summary><c>AAS</c><br/>
		/// <br/>
		/// <c>3F</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Aas = 119,
		/// <summary><c>INC r16</c><br/>
		/// <br/>
		/// <c>o16 40+rw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Inc_r16 = 120,
		/// <summary><c>INC r32</c><br/>
		/// <br/>
		/// <c>o32 40+rd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Inc_r32 = 121,
		/// <summary><c>DEC r16</c><br/>
		/// <br/>
		/// <c>o16 48+rw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Dec_r16 = 122,
		/// <summary><c>DEC r32</c><br/>
		/// <br/>
		/// <c>o32 48+rd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Dec_r32 = 123,
		/// <summary><c>PUSH r16</c><br/>
		/// <br/>
		/// <c>o16 50+rw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Push_r16 = 124,
		/// <summary><c>PUSH r32</c><br/>
		/// <br/>
		/// <c>o32 50+rd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Push_r32 = 125,
		/// <summary><c>PUSH r64</c><br/>
		/// <br/>
		/// <c>50+ro</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Push_r64 = 126,
		/// <summary><c>POP r16</c><br/>
		/// <br/>
		/// <c>o16 58+rw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pop_r16 = 127,
		/// <summary><c>POP r32</c><br/>
		/// <br/>
		/// <c>o32 58+rd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pop_r32 = 128,
		/// <summary><c>POP r64</c><br/>
		/// <br/>
		/// <c>58+ro</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pop_r64 = 129,
		/// <summary><c>PUSHA</c><br/>
		/// <br/>
		/// <c>o16 60</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushaw = 130,
		/// <summary><c>PUSHAD</c><br/>
		/// <br/>
		/// <c>o32 60</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushad = 131,
		/// <summary><c>POPA</c><br/>
		/// <br/>
		/// <c>o16 61</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popaw = 132,
		/// <summary><c>POPAD</c><br/>
		/// <br/>
		/// <c>o32 61</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popad = 133,
		/// <summary><c>BOUND r16, m16&amp;16</c><br/>
		/// <br/>
		/// <c>o16 62 /r</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bound_r16_m1616 = 134,
		/// <summary><c>BOUND r32, m32&amp;32</c><br/>
		/// <br/>
		/// <c>o32 62 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bound_r32_m3232 = 135,
		/// <summary><c>ARPL r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 63 /r</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Arpl_rm16_r16 = 136,
		/// <summary><c>ARPL r32/m16, r32</c><br/>
		/// <br/>
		/// <c>o32 63 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Arpl_r32m16_r32 = 137,
		/// <summary><c>MOVSXD r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 63 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movsxd_r16_rm16 = 138,
		/// <summary><c>MOVSXD r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 63 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movsxd_r32_rm32 = 139,
		/// <summary><c>MOVSXD r64, r/m32</c><br/>
		/// <br/>
		/// <c>REX.W 63 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movsxd_r64_rm32 = 140,
		/// <summary><c>PUSH imm16</c><br/>
		/// <br/>
		/// <c>o16 68 iw</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Push_imm16 = 141,
		/// <summary><c>PUSH imm32</c><br/>
		/// <br/>
		/// <c>o32 68 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_imm32 = 142,
		/// <summary><c>PUSH imm32</c><br/>
		/// <br/>
		/// <c>68 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pushq_imm32 = 143,
		/// <summary><c>IMUL r16, r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 69 /r iw</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_r16_rm16_imm16 = 144,
		/// <summary><c>IMUL r32, r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 69 /r id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_r32_rm32_imm32 = 145,
		/// <summary><c>IMUL r64, r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 69 /r id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Imul_r64_rm64_imm32 = 146,
		/// <summary><c>PUSH imm8</c><br/>
		/// <br/>
		/// <c>o16 6A ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pushw_imm8 = 147,
		/// <summary><c>PUSH imm8</c><br/>
		/// <br/>
		/// <c>o32 6A ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_imm8 = 148,
		/// <summary><c>PUSH imm8</c><br/>
		/// <br/>
		/// <c>6A ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pushq_imm8 = 149,
		/// <summary><c>IMUL r16, r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 6B /r ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_r16_rm16_imm8 = 150,
		/// <summary><c>IMUL r32, r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 6B /r ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_r32_rm32_imm8 = 151,
		/// <summary><c>IMUL r64, r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 6B /r ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Imul_r64_rm64_imm8 = 152,
		/// <summary><c>INSB</c><br/>
		/// <br/>
		/// <c>6C</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Insb_m8_DX = 153,
		/// <summary><c>INSW</c><br/>
		/// <br/>
		/// <c>o16 6D</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Insw_m16_DX = 154,
		/// <summary><c>INSD</c><br/>
		/// <br/>
		/// <c>o32 6D</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Insd_m32_DX = 155,
		/// <summary><c>OUTSB</c><br/>
		/// <br/>
		/// <c>6E</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Outsb_DX_m8 = 156,
		/// <summary><c>OUTSW</c><br/>
		/// <br/>
		/// <c>o16 6F</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Outsw_DX_m16 = 157,
		/// <summary><c>OUTSD</c><br/>
		/// <br/>
		/// <c>o32 6F</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Outsd_DX_m32 = 158,
		/// <summary><c>JO rel8</c><br/>
		/// <br/>
		/// <c>o16 70 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
        Jo_rel8_16 = 159,

		/// <summary><c>JO rel8</c><br/>
		/// <br/>
		/// <c>o32 70 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jo_rel8_32 = 160,

		/// <summary><c>JO rel8</c><br/>
		/// <br/>
		/// <c>70 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jo_rel8_64 = 161,

		/// <summary><c>JNO rel8</c><br/>
		/// <br/>
		/// <c>o16 71 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jno_rel8_16 = 162,

		/// <summary><c>JNO rel8</c><br/>
		/// <br/>
		/// <c>o32 71 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jno_rel8_32 = 163,

		/// <summary><c>JNO rel8</c><br/>
		/// <br/>
		/// <c>71 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jno_rel8_64 = 164,

		/// <summary><c>JB rel8</c><br/>
		/// <br/>
		/// <c>o16 72 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jb_rel8_16 = 165,

		/// <summary><c>JB rel8</c><br/>
		/// <br/>
		/// <c>o32 72 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jb_rel8_32 = 166,

		/// <summary><c>JB rel8</c><br/>
		/// <br/>
		/// <c>72 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jb_rel8_64 = 167,

		/// <summary><c>JAE rel8</c><br/>
		/// <br/>
		/// <c>o16 73 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jae_rel8_16 = 168,

		/// <summary><c>JAE rel8</c><br/>
		/// <br/>
		/// <c>o32 73 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jae_rel8_32 = 169,

		/// <summary><c>JAE rel8</c><br/>
		/// <br/>
		/// <c>73 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jae_rel8_64 = 170,

		/// <summary><c>JE rel8</c><br/>
		/// <br/>
		/// <c>o16 74 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Je_rel8_16 = 171,

		/// <summary><c>JE rel8</c><br/>
		/// <br/>
		/// <c>o32 74 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Je_rel8_32 = 172,

		/// <summary><c>JE rel8</c><br/>
		/// <br/>
		/// <c>74 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Je_rel8_64 = 173,

		/// <summary><c>JNE rel8</c><br/>
		/// <br/>
		/// <c>o16 75 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jne_rel8_16 = 174,

		/// <summary><c>JNE rel8</c><br/>
		/// <br/>
		/// <c>o32 75 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jne_rel8_32 = 175,

        /// <summary><c>JNE rel8</c><br/>
		/// <br/>
		/// <c>75 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jne_rel8_64 = 176,

		/// <summary><c>JBE rel8</c><br/>
		/// <br/>
		/// <c>o16 76 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jbe_rel8_16 = 177,

		/// <summary><c>JBE rel8</c><br/>
		/// <br/>
		/// <c>o32 76 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jbe_rel8_32 = 178,

		/// <summary><c>JBE rel8</c><br/>
		/// <br/>
		/// <c>76 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jbe_rel8_64 = 179,

		/// <summary><c>JA rel8</c><br/>
		/// <br/>
		/// <c>o16 77 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ja_rel8_16 = 180,

		/// <summary><c>JA rel8</c><br/>
		/// <br/>
		/// <c>o32 77 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Ja_rel8_32 = 181,

		/// <summary><c>JA rel8</c><br/>
		/// <br/>
		/// <c>77 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ja_rel8_64 = 182,

		/// <summary><c>JS rel8</c><br/>
		/// <br/>
		/// <c>o16 78 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Js_rel8_16 = 183,

		/// <summary><c>JS rel8</c><br/>
		/// <br/>
		/// <c>o32 78 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Js_rel8_32 = 184,

		/// <summary><c>JS rel8</c><br/>
		/// <br/>
		/// <c>78 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Js_rel8_64 = 185,

		/// <summary><c>JNS rel8</c><br/>
		/// <br/>
		/// <c>o16 79 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jns_rel8_16 = 186,

		/// <summary><c>JNS rel8</c><br/>
		/// <br/>
		/// <c>o32 79 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jns_rel8_32 = 187,

		/// <summary><c>JNS rel8</c><br/>
		/// <br/>
		/// <c>79 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jns_rel8_64 = 188,

		/// <summary><c>JP rel8</c><br/>
		/// <br/>
		/// <c>o16 7A cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jp_rel8_16 = 189,

		/// <summary><c>JP rel8</c><br/>
		/// <br/>
		/// <c>o32 7A cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jp_rel8_32 = 190,

		/// <summary><c>JP rel8</c><br/>
		/// <br/>
		/// <c>7A cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jp_rel8_64 = 191,

		/// <summary><c>JNP rel8</c><br/>
		/// <br/>
		/// <c>o16 7B cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jnp_rel8_16 = 192,

		/// <summary><c>JNP rel8</c><br/>
		/// <br/>
		/// <c>o32 7B cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jnp_rel8_32 = 193,

		/// <summary><c>JNP rel8</c><br/>
		/// <br/>
		/// <c>7B cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jnp_rel8_64 = 194,

		/// <summary><c>JL rel8</c><br/>
		/// <br/>
		/// <c>o16 7C cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jl_rel8_16 = 195,

		/// <summary><c>JL rel8</c><br/>
		/// <br/>
		/// <c>o32 7C cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jl_rel8_32 = 196,

		/// <summary><c>JL rel8</c><br/>
		/// <br/>
		/// <c>7C cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jl_rel8_64 = 197,
		/// <summary><c>JGE rel8</c><br/>
		/// <br/>
		/// <c>o16 7D cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jge_rel8_16 = 198,

		/// <summary><c>JGE rel8</c><br/>
		/// <br/>
		/// <c>o32 7D cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jge_rel8_32 = 199,

		/// <summary><c>JGE rel8</c><br/>
		/// <br/>
		/// <c>7D cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jge_rel8_64 = 200,

		/// <summary><c>JLE rel8</c><br/>
		/// <br/>
		/// <c>o16 7E cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jle_rel8_16 = 201,
		/// <summary><c>JLE rel8</c><br/>
		/// <br/>
		/// <c>o32 7E cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jle_rel8_32 = 202,
		/// <summary><c>JLE rel8</c><br/>
		/// <br/>
		/// <c>7E cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jle_rel8_64 = 203,
		/// <summary><c>JG rel8</c><br/>
		/// <br/>
		/// <c>o16 7F cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jg_rel8_16 = 204,
		/// <summary><c>JG rel8</c><br/>
		/// <br/>
		/// <c>o32 7F cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jg_rel8_32 = 205,
		/// <summary><c>JG rel8</c><br/>
		/// <br/>
		/// <c>7F cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jg_rel8_64 = 206,
		/// <summary><c>ADD r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /0 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm8_imm8 = 207,
		/// <summary><c>OR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /1 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm8_imm8 = 208,
		/// <summary><c>ADC r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /2 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm8_imm8 = 209,
		/// <summary><c>SBB r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /3 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm8_imm8 = 210,
		/// <summary><c>AND r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /4 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm8_imm8 = 211,
		/// <summary><c>SUB r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /5 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm8_imm8 = 212,
		/// <summary><c>XOR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /6 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm8_imm8 = 213,
		/// <summary><c>CMP r/m8, imm8</c><br/>
		/// <br/>
		/// <c>80 /7 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm8_imm8 = 214,
		/// <summary><c>ADD r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /0 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm16_imm16 = 215,
		/// <summary><c>ADD r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /0 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm32_imm32 = 216,
		/// <summary><c>ADD r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /0 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Add_rm64_imm32 = 217,
		/// <summary><c>OR r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /1 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm16_imm16 = 218,
		/// <summary><c>OR r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /1 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm32_imm32 = 219,
		/// <summary><c>OR r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /1 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Or_rm64_imm32 = 220,
		/// <summary><c>ADC r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /2 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm16_imm16 = 221,
		/// <summary><c>ADC r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /2 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm32_imm32 = 222,
		/// <summary><c>ADC r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /2 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adc_rm64_imm32 = 223,
		/// <summary><c>SBB r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /3 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm16_imm16 = 224,
		/// <summary><c>SBB r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /3 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm32_imm32 = 225,
		/// <summary><c>SBB r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /3 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sbb_rm64_imm32 = 226,
		/// <summary><c>AND r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /4 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm16_imm16 = 227,
		/// <summary><c>AND r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /4 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm32_imm32 = 228,
		/// <summary><c>AND r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /4 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		And_rm64_imm32 = 229,
		/// <summary><c>SUB r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /5 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm16_imm16 = 230,
		/// <summary><c>SUB r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /5 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm32_imm32 = 231,
		/// <summary><c>SUB r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /5 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sub_rm64_imm32 = 232,
		/// <summary><c>XOR r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /6 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm16_imm16 = 233,
		/// <summary><c>XOR r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /6 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm32_imm32 = 234,
		/// <summary><c>XOR r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /6 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xor_rm64_imm32 = 235,
		/// <summary><c>CMP r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 81 /7 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm16_imm16 = 236,
		/// <summary><c>CMP r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 81 /7 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm32_imm32 = 237,
		/// <summary><c>CMP r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W 81 /7 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmp_rm64_imm32 = 238,
		/// <summary><c>ADD r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /0 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Add_rm8_imm8_82 = 239,
		/// <summary><c>OR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /1 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Or_rm8_imm8_82 = 240,
		/// <summary><c>ADC r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /2 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Adc_rm8_imm8_82 = 241,
		/// <summary><c>SBB r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /3 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Sbb_rm8_imm8_82 = 242,
		/// <summary><c>AND r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /4 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		And_rm8_imm8_82 = 243,
		/// <summary><c>SUB r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /5 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Sub_rm8_imm8_82 = 244,
		/// <summary><c>XOR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /6 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Xor_rm8_imm8_82 = 245,
		/// <summary><c>CMP r/m8, imm8</c><br/>
		/// <br/>
		/// <c>82 /7 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Cmp_rm8_imm8_82 = 246,
		/// <summary><c>ADD r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /0 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm16_imm8 = 247,
		/// <summary><c>ADD r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /0 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Add_rm32_imm8 = 248,
		/// <summary><c>ADD r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /0 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Add_rm64_imm8 = 249,
		/// <summary><c>OR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /1 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm16_imm8 = 250,
		/// <summary><c>OR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /1 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Or_rm32_imm8 = 251,
		/// <summary><c>OR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /1 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Or_rm64_imm8 = 252,
		/// <summary><c>ADC r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /2 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm16_imm8 = 253,
		/// <summary><c>ADC r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /2 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adc_rm32_imm8 = 254,
		/// <summary><c>ADC r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /2 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adc_rm64_imm8 = 255,
		/// <summary><c>SBB r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /3 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm16_imm8 = 256,
		/// <summary><c>SBB r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /3 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sbb_rm32_imm8 = 257,
		/// <summary><c>SBB r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /3 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sbb_rm64_imm8 = 258,
		/// <summary><c>AND r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /4 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm16_imm8 = 259,
		/// <summary><c>AND r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /4 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		And_rm32_imm8 = 260,
		/// <summary><c>AND r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /4 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		And_rm64_imm8 = 261,
		/// <summary><c>SUB r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /5 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm16_imm8 = 262,
		/// <summary><c>SUB r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /5 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sub_rm32_imm8 = 263,
		/// <summary><c>SUB r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /5 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sub_rm64_imm8 = 264,
		/// <summary><c>XOR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /6 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm16_imm8 = 265,
		/// <summary><c>XOR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /6 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xor_rm32_imm8 = 266,
		/// <summary><c>XOR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /6 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xor_rm64_imm8 = 267,
		/// <summary><c>CMP r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 83 /7 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm16_imm8 = 268,
		/// <summary><c>CMP r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 83 /7 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmp_rm32_imm8 = 269,
		/// <summary><c>CMP r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 83 /7 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmp_rm64_imm8 = 270,
		/// <summary><c>TEST r/m8, r8</c><br/>
		/// <br/>
		/// <c>84 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm8_r8 = 271,
		/// <summary><c>TEST r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 85 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm16_r16 = 272,
		/// <summary><c>TEST r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 85 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm32_r32 = 273,
		/// <summary><c>TEST r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 85 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Test_rm64_r64 = 274,
		/// <summary><c>XCHG r/m8, r8</c><br/>
		/// <br/>
		/// <c>86 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xchg_rm8_r8 = 275,
		/// <summary><c>XCHG r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 87 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xchg_rm16_r16 = 276,
		/// <summary><c>XCHG r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 87 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xchg_rm32_r32 = 277,
		/// <summary><c>XCHG r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 87 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xchg_rm64_r64 = 278,
		/// <summary><c>MOV r/m8, r8</c><br/>
		/// <br/>
		/// <c>88 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm8_r8 = 279,
		/// <summary><c>MOV r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 89 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm16_r16 = 280,
		/// <summary><c>MOV r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 89 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm32_r32 = 281,
		/// <summary><c>MOV r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 89 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_rm64_r64 = 282,
		/// <summary><c>MOV r8, r/m8</c><br/>
		/// <br/>
		/// <c>8A /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r8_rm8 = 283,
		/// <summary><c>MOV r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 8B /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r16_rm16 = 284,
		/// <summary><c>MOV r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 8B /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r32_rm32 = 285,
		/// <summary><c>MOV r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 8B /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_r64_rm64 = 286,
		/// <summary><c>MOV r/m16, Sreg</c><br/>
		/// <br/>
		/// <c>o16 8C /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm16_Sreg = 287,
		/// <summary><c>MOV r32/m16, Sreg</c><br/>
		/// <br/>
		/// <c>o32 8C /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r32m16_Sreg = 288,
		/// <summary><c>MOV r64/m16, Sreg</c><br/>
		/// <br/>
		/// <c>REX.W 8C /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_r64m16_Sreg = 289,
		/// <summary><c>LEA r16, m</c><br/>
		/// <br/>
		/// <c>o16 8D /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lea_r16_m = 290,
		/// <summary><c>LEA r32, m</c><br/>
		/// <br/>
		/// <c>o32 8D /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lea_r32_m = 291,
		/// <summary><c>LEA r64, m</c><br/>
		/// <br/>
		/// <c>REX.W 8D /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lea_r64_m = 292,
		/// <summary><c>MOV Sreg, r/m16</c><br/>
		/// <br/>
		/// <c>o16 8E /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_Sreg_rm16 = 293,
		/// <summary><c>MOV Sreg, r32/m16</c><br/>
		/// <br/>
		/// <c>o32 8E /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_Sreg_r32m16 = 294,
		/// <summary><c>MOV Sreg, r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 8E /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_Sreg_r64m16 = 295,
		/// <summary><c>POP r/m16</c><br/>
		/// <br/>
		/// <c>o16 8F /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pop_rm16 = 296,
		/// <summary><c>POP r/m32</c><br/>
		/// <br/>
		/// <c>o32 8F /0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pop_rm32 = 297,
		/// <summary><c>POP r/m64</c><br/>
		/// <br/>
		/// <c>8F /0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pop_rm64 = 298,
		/// <summary><c>NOP</c><br/>
		/// <br/>
		/// <c>o16 90</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Nopw = 299,
		/// <summary><c>NOP</c><br/>
		/// <br/>
		/// <c>o32 90</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Nopd = 300,
		/// <summary><c>NOP</c><br/>
		/// <br/>
		/// <c>REX.W 90</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Nopq = 301,
		/// <summary><c>XCHG r16, AX</c><br/>
		/// <br/>
		/// <c>o16 90+rw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xchg_r16_AX = 302,
		/// <summary><c>XCHG r32, EAX</c><br/>
		/// <br/>
		/// <c>o32 90+rd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xchg_r32_EAX = 303,
		/// <summary><c>XCHG r64, RAX</c><br/>
		/// <br/>
		/// <c>REX.W 90+ro</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xchg_r64_RAX = 304,
		/// <summary><c>PAUSE</c><br/>
		/// <br/>
		/// <c>F3 90</c><br/>
		/// <br/>
		/// <c>Pentium 4 or later</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pause = 305,
		/// <summary><c>CBW</c><br/>
		/// <br/>
		/// <c>o16 98</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cbw = 306,
		/// <summary><c>CWDE</c><br/>
		/// <br/>
		/// <c>o32 98</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cwde = 307,
		/// <summary><c>CDQE</c><br/>
		/// <br/>
		/// <c>REX.W 98</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cdqe = 308,
		/// <summary><c>CWD</c><br/>
		/// <br/>
		/// <c>o16 99</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cwd = 309,
		/// <summary><c>CDQ</c><br/>
		/// <br/>
		/// <c>o32 99</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cdq = 310,
		/// <summary><c>CQO</c><br/>
		/// <br/>
		/// <c>REX.W 99</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cqo = 311,
		/// <summary><c>CALL ptr16:16</c><br/>
		/// <br/>
		/// <c>o16 9A cd</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Call_ptr1616 = 312,
		/// <summary><c>CALL ptr16:32</c><br/>
		/// <br/>
		/// <c>o32 9A cp</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Call_ptr1632 = 313,
		/// <summary><c>WAIT</c><br/>
		/// <br/>
		/// <c>9B</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wait = 314,
		/// <summary><c>PUSHF</c><br/>
		/// <br/>
		/// <c>o16 9C</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pushfw = 315,
		/// <summary><c>PUSHFD</c><br/>
		/// <br/>
		/// <c>o32 9C</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushfd = 316,
		/// <summary><c>PUSHFQ</c><br/>
		/// <br/>
		/// <c>9C</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pushfq = 317,
		/// <summary><c>POPF</c><br/>
		/// <br/>
		/// <c>o16 9D</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Popfw = 318,
		/// <summary><c>POPFD</c><br/>
		/// <br/>
		/// <c>o32 9D</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popfd = 319,
		/// <summary><c>POPFQ</c><br/>
		/// <br/>
		/// <c>9D</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Popfq = 320,
		/// <summary><c>SAHF</c><br/>
		/// <br/>
		/// <c>9E</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sahf = 321,
		/// <summary><c>LAHF</c><br/>
		/// <br/>
		/// <c>9F</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lahf = 322,
		/// <summary><c>MOV AL, moffs8</c><br/>
		/// <br/>
		/// <c>A0 mo</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_AL_moffs8 = 323,
		/// <summary><c>MOV AX, moffs16</c><br/>
		/// <br/>
		/// <c>o16 A1 mo</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_AX_moffs16 = 324,
		/// <summary><c>MOV EAX, moffs32</c><br/>
		/// <br/>
		/// <c>o32 A1 mo</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_EAX_moffs32 = 325,
		/// <summary><c>MOV RAX, moffs64</c><br/>
		/// <br/>
		/// <c>REX.W A1 mo</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_RAX_moffs64 = 326,
		/// <summary><c>MOV moffs8, AL</c><br/>
		/// <br/>
		/// <c>A2 mo</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_moffs8_AL = 327,
		/// <summary><c>MOV moffs16, AX</c><br/>
		/// <br/>
		/// <c>o16 A3 mo</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_moffs16_AX = 328,
		/// <summary><c>MOV moffs32, EAX</c><br/>
		/// <br/>
		/// <c>o32 A3 mo</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_moffs32_EAX = 329,
		/// <summary><c>MOV moffs64, RAX</c><br/>
		/// <br/>
		/// <c>REX.W A3 mo</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_moffs64_RAX = 330,
		/// <summary><c>MOVSB</c><br/>
		/// <br/>
		/// <c>A4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsb_m8_m8 = 331,
		/// <summary><c>MOVSW</c><br/>
		/// <br/>
		/// <c>o16 A5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsw_m16_m16 = 332,
		/// <summary><c>MOVSD</c><br/>
		/// <br/>
		/// <c>o32 A5</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsd_m32_m32 = 333,
		/// <summary><c>MOVSQ</c><br/>
		/// <br/>
		/// <c>REX.W A5</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movsq_m64_m64 = 334,
		/// <summary><c>CMPSB</c><br/>
		/// <br/>
		/// <c>A6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpsb_m8_m8 = 335,
		/// <summary><c>CMPSW</c><br/>
		/// <br/>
		/// <c>o16 A7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpsw_m16_m16 = 336,
		/// <summary><c>CMPSD</c><br/>
		/// <br/>
		/// <c>o32 A7</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpsd_m32_m32 = 337,
		/// <summary><c>CMPSQ</c><br/>
		/// <br/>
		/// <c>REX.W A7</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmpsq_m64_m64 = 338,
		/// <summary><c>TEST AL, imm8</c><br/>
		/// <br/>
		/// <c>A8 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_AL_imm8 = 339,
		/// <summary><c>TEST AX, imm16</c><br/>
		/// <br/>
		/// <c>o16 A9 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_AX_imm16 = 340,
		/// <summary><c>TEST EAX, imm32</c><br/>
		/// <br/>
		/// <c>o32 A9 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_EAX_imm32 = 341,
		/// <summary><c>TEST RAX, imm32</c><br/>
		/// <br/>
		/// <c>REX.W A9 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Test_RAX_imm32 = 342,
		/// <summary><c>STOSB</c><br/>
		/// <br/>
		/// <c>AA</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stosb_m8_AL = 343,
		/// <summary><c>STOSW</c><br/>
		/// <br/>
		/// <c>o16 AB</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stosw_m16_AX = 344,
		/// <summary><c>STOSD</c><br/>
		/// <br/>
		/// <c>o32 AB</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stosd_m32_EAX = 345,
		/// <summary><c>STOSQ</c><br/>
		/// <br/>
		/// <c>REX.W AB</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Stosq_m64_RAX = 346,
		/// <summary><c>LODSB</c><br/>
		/// <br/>
		/// <c>AC</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lodsb_AL_m8 = 347,
		/// <summary><c>LODSW</c><br/>
		/// <br/>
		/// <c>o16 AD</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lodsw_AX_m16 = 348,
		/// <summary><c>LODSD</c><br/>
		/// <br/>
		/// <c>o32 AD</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lodsd_EAX_m32 = 349,
		/// <summary><c>LODSQ</c><br/>
		/// <br/>
		/// <c>REX.W AD</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lodsq_RAX_m64 = 350,
		/// <summary><c>SCASB</c><br/>
		/// <br/>
		/// <c>AE</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Scasb_AL_m8 = 351,
		/// <summary><c>SCASW</c><br/>
		/// <br/>
		/// <c>o16 AF</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Scasw_AX_m16 = 352,
		/// <summary><c>SCASD</c><br/>
		/// <br/>
		/// <c>o32 AF</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Scasd_EAX_m32 = 353,
		/// <summary><c>SCASQ</c><br/>
		/// <br/>
		/// <c>REX.W AF</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Scasq_RAX_m64 = 354,
		/// <summary><c>MOV r8, imm8</c><br/>
		/// <br/>
		/// <c>B0+rb ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r8_imm8 = 355,
		/// <summary><c>MOV r16, imm16</c><br/>
		/// <br/>
		/// <c>o16 B8+rw iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r16_imm16 = 356,
		/// <summary><c>MOV r32, imm32</c><br/>
		/// <br/>
		/// <c>o32 B8+rd id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_r32_imm32 = 357,
		/// <summary><c>MOV r64, imm64</c><br/>
		/// <br/>
		/// <c>REX.W B8+ro io</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_r64_imm64 = 358,
		/// <summary><c>ROL r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /0 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm8_imm8 = 359,
		/// <summary><c>ROR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /1 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm8_imm8 = 360,
		/// <summary><c>RCL r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /2 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm8_imm8 = 361,
		/// <summary><c>RCR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /3 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm8_imm8 = 362,
		/// <summary><c>SHL r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /4 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm8_imm8 = 363,
		/// <summary><c>SHR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /5 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm8_imm8 = 364,
		/// <summary><c>SAL r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /6 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm8_imm8 = 365,
		/// <summary><c>SAR r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C0 /7 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm8_imm8 = 366,
		/// <summary><c>ROL r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /0 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm16_imm8 = 367,
		/// <summary><c>ROL r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /0 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm32_imm8 = 368,
		/// <summary><c>ROL r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /0 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rol_rm64_imm8 = 369,
		/// <summary><c>ROR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /1 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm16_imm8 = 370,
		/// <summary><c>ROR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /1 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm32_imm8 = 371,
		/// <summary><c>ROR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /1 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ror_rm64_imm8 = 372,
		/// <summary><c>RCL r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /2 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm16_imm8 = 373,
		/// <summary><c>RCL r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /2 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm32_imm8 = 374,
		/// <summary><c>RCL r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /2 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rcl_rm64_imm8 = 375,
		/// <summary><c>RCR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /3 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm16_imm8 = 376,
		/// <summary><c>RCR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /3 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm32_imm8 = 377,
		/// <summary><c>RCR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /3 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rcr_rm64_imm8 = 378,
		/// <summary><c>SHL r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /4 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm16_imm8 = 379,
		/// <summary><c>SHL r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /4 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm32_imm8 = 380,
		/// <summary><c>SHL r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /4 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shl_rm64_imm8 = 381,
		/// <summary><c>SHR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /5 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm16_imm8 = 382,
		/// <summary><c>SHR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /5 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm32_imm8 = 383,
		/// <summary><c>SHR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /5 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shr_rm64_imm8 = 384,
		/// <summary><c>SAL r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /6 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm16_imm8 = 385,
		/// <summary><c>SAL r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /6 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm32_imm8 = 386,
		/// <summary><c>SAL r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /6 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sal_rm64_imm8 = 387,
		/// <summary><c>SAR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C1 /7 ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm16_imm8 = 388,
		/// <summary><c>SAR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 C1 /7 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm32_imm8 = 389,
		/// <summary><c>SAR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W C1 /7 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sar_rm64_imm8 = 390,
		/// <summary><c>RET imm16</c><br/>
		/// <br/>
		/// <c>o16 C2 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Retnw_imm16 = 391,
		/// <summary><c>RET imm16</c><br/>
		/// <br/>
		/// <c>o32 C2 iw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Retnd_imm16 = 392,
		/// <summary><c>RET imm16</c><br/>
		/// <br/>
		/// <c>C2 iw</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Retnq_imm16 = 393,
		/// <summary><c>RET</c><br/>
		/// <br/>
		/// <c>o16 C3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Retnw = 394,
		/// <summary><c>RET</c><br/>
		/// <br/>
		/// <c>o32 C3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Retnd = 395,
		/// <summary><c>RET</c><br/>
		/// <br/>
		/// <c>C3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Retnq = 396,
		/// <summary><c>LES r16, m16:16</c><br/>
		/// <br/>
		/// <c>o16 C4 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Les_r16_m1616 = 397,
		/// <summary><c>LES r32, m16:32</c><br/>
		/// <br/>
		/// <c>o32 C4 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Les_r32_m1632 = 398,
		/// <summary><c>LDS r16, m16:16</c><br/>
		/// <br/>
		/// <c>o16 C5 /r</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Lds_r16_m1616 = 399,
		/// <summary><c>LDS r32, m16:32</c><br/>
		/// <br/>
		/// <c>o32 C5 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Lds_r32_m1632 = 400,
		/// <summary><c>MOV r/m8, imm8</c><br/>
		/// <br/>
		/// <c>C6 /0 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm8_imm8 = 401,
		/// <summary><c>XABORT imm8</c><br/>
		/// <br/>
		/// <c>C6 F8 ib</c><br/>
		/// <br/>
		/// <c>RTM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xabort_imm8 = 402,
		/// <summary><c>MOV r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 C7 /0 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm16_imm16 = 403,
		/// <summary><c>MOV r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 C7 /0 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mov_rm32_imm32 = 404,
		/// <summary><c>MOV r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W C7 /0 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_rm64_imm32 = 405,
		/// <summary><c>XBEGIN rel16</c><br/>
		/// <br/>
		/// <c>o16 C7 F8 cw</c><br/>
		/// <br/>
		/// <c>RTM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xbegin_rel16 = 406,
		/// <summary><c>XBEGIN rel32</c><br/>
		/// <br/>
		/// <c>o32 C7 F8 cd</c><br/>
		/// <br/>
		/// <c>RTM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xbegin_rel32 = 407,
		/// <summary><c>ENTER imm16, imm8</c><br/>
		/// <br/>
		/// <c>o16 C8 iw ib</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Enterw_imm16_imm8 = 408,
		/// <summary><c>ENTER imm16, imm8</c><br/>
		/// <br/>
		/// <c>o32 C8 iw ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Enterd_imm16_imm8 = 409,
		/// <summary><c>ENTER imm16, imm8</c><br/>
		/// <br/>
		/// <c>C8 iw ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Enterq_imm16_imm8 = 410,
		/// <summary><c>LEAVE</c><br/>
		/// <br/>
		/// <c>o16 C9</c><br/>
		/// <br/>
		/// <c>186+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Leavew = 411,
		/// <summary><c>LEAVE</c><br/>
		/// <br/>
		/// <c>o32 C9</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Leaved = 412,
		/// <summary><c>LEAVE</c><br/>
		/// <br/>
		/// <c>C9</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Leaveq = 413,
		/// <summary><c>RET imm16</c><br/>
		/// <br/>
		/// <c>o16 CA iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Retfw_imm16 = 414,
		/// <summary><c>RET imm16</c><br/>
		/// <br/>
		/// <c>o32 CA iw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Retfd_imm16 = 415,
		/// <summary><c>RET imm16</c><br/>
		/// <br/>
		/// <c>REX.W CA iw</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Retfq_imm16 = 416,
		/// <summary><c>RET</c><br/>
		/// <br/>
		/// <c>o16 CB</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Retfw = 417,
		/// <summary><c>RET</c><br/>
		/// <br/>
		/// <c>o32 CB</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Retfd = 418,
		/// <summary><c>RET</c><br/>
		/// <br/>
		/// <c>REX.W CB</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Retfq = 419,
		/// <summary><c>INT3</c><br/>
		/// <br/>
		/// <c>CC</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Int3 = 420,
		/// <summary><c>INT imm8</c><br/>
		/// <br/>
		/// <c>CD ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Int_imm8 = 421,
		/// <summary><c>INTO</c><br/>
		/// <br/>
		/// <c>CE</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Into = 422,
		/// <summary><c>IRET</c><br/>
		/// <br/>
		/// <c>o16 CF</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Iretw = 423,
		/// <summary><c>IRETD</c><br/>
		/// <br/>
		/// <c>o32 CF</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Iretd = 424,
		/// <summary><c>IRETQ</c><br/>
		/// <br/>
		/// <c>REX.W CF</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Iretq = 425,
		/// <summary><c>ROL r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm8_1 = 426,
		/// <summary><c>ROR r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /1</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm8_1 = 427,
		/// <summary><c>RCL r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm8_1 = 428,
		/// <summary><c>RCR r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm8_1 = 429,
		/// <summary><c>SHL r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm8_1 = 430,
		/// <summary><c>SHR r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm8_1 = 431,
		/// <summary><c>SAL r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm8_1 = 432,
		/// <summary><c>SAR r/m8, 1</c><br/>
		/// <br/>
		/// <c>D0 /7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm8_1 = 433,
		/// <summary><c>ROL r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm16_1 = 434,
		/// <summary><c>ROL r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm32_1 = 435,
		/// <summary><c>ROL r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rol_rm64_1 = 436,
		/// <summary><c>ROR r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /1</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm16_1 = 437,
		/// <summary><c>ROR r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm32_1 = 438,
		/// <summary><c>ROR r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /1</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ror_rm64_1 = 439,
		/// <summary><c>RCL r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm16_1 = 440,
		/// <summary><c>RCL r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /2</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm32_1 = 441,
		/// <summary><c>RCL r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /2</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rcl_rm64_1 = 442,
		/// <summary><c>RCR r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm16_1 = 443,
		/// <summary><c>RCR r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm32_1 = 444,
		/// <summary><c>RCR r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rcr_rm64_1 = 445,
		/// <summary><c>SHL r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm16_1 = 446,
		/// <summary><c>SHL r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /4</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm32_1 = 447,
		/// <summary><c>SHL r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /4</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shl_rm64_1 = 448,
		/// <summary><c>SHR r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm16_1 = 449,
		/// <summary><c>SHR r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /5</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm32_1 = 450,
		/// <summary><c>SHR r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /5</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shr_rm64_1 = 451,
		/// <summary><c>SAL r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm16_1 = 452,
		/// <summary><c>SAL r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /6</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm32_1 = 453,
		/// <summary><c>SAL r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /6</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sal_rm64_1 = 454,
		/// <summary><c>SAR r/m16, 1</c><br/>
		/// <br/>
		/// <c>o16 D1 /7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm16_1 = 455,
		/// <summary><c>SAR r/m32, 1</c><br/>
		/// <br/>
		/// <c>o32 D1 /7</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm32_1 = 456,
		/// <summary><c>SAR r/m64, 1</c><br/>
		/// <br/>
		/// <c>REX.W D1 /7</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sar_rm64_1 = 457,
		/// <summary><c>ROL r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm8_CL = 458,
		/// <summary><c>ROR r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /1</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm8_CL = 459,
		/// <summary><c>RCL r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm8_CL = 460,
		/// <summary><c>RCR r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm8_CL = 461,
		/// <summary><c>SHL r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm8_CL = 462,
		/// <summary><c>SHR r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm8_CL = 463,
		/// <summary><c>SAL r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm8_CL = 464,
		/// <summary><c>SAR r/m8, CL</c><br/>
		/// <br/>
		/// <c>D2 /7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm8_CL = 465,
		/// <summary><c>ROL r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm16_CL = 466,
		/// <summary><c>ROL r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rol_rm32_CL = 467,
		/// <summary><c>ROL r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rol_rm64_CL = 468,
		/// <summary><c>ROR r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /1</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm16_CL = 469,
		/// <summary><c>ROR r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ror_rm32_CL = 470,
		/// <summary><c>ROR r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /1</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ror_rm64_CL = 471,
		/// <summary><c>RCL r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm16_CL = 472,
		/// <summary><c>RCL r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /2</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcl_rm32_CL = 473,
		/// <summary><c>RCL r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /2</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rcl_rm64_CL = 474,
		/// <summary><c>RCR r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm16_CL = 475,
		/// <summary><c>RCR r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcr_rm32_CL = 476,
		/// <summary><c>RCR r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rcr_rm64_CL = 477,
		/// <summary><c>SHL r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm16_CL = 478,
		/// <summary><c>SHL r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /4</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shl_rm32_CL = 479,
		/// <summary><c>SHL r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /4</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shl_rm64_CL = 480,
		/// <summary><c>SHR r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm16_CL = 481,
		/// <summary><c>SHR r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /5</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shr_rm32_CL = 482,
		/// <summary><c>SHR r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /5</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shr_rm64_CL = 483,
		/// <summary><c>SAL r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm16_CL = 484,
		/// <summary><c>SAL r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /6</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sal_rm32_CL = 485,
		/// <summary><c>SAL r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /6</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sal_rm64_CL = 486,
		/// <summary><c>SAR r/m16, CL</c><br/>
		/// <br/>
		/// <c>o16 D3 /7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm16_CL = 487,
		/// <summary><c>SAR r/m32, CL</c><br/>
		/// <br/>
		/// <c>o32 D3 /7</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sar_rm32_CL = 488,
		/// <summary><c>SAR r/m64, CL</c><br/>
		/// <br/>
		/// <c>REX.W D3 /7</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sar_rm64_CL = 489,
		/// <summary><c>AAM imm8</c><br/>
		/// <br/>
		/// <c>D4 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Aam_imm8 = 490,
		/// <summary><c>AAD imm8</c><br/>
		/// <br/>
		/// <c>D5 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Aad_imm8 = 491,
		/// <summary><c>SALC</c><br/>
		/// <br/>
		/// <c>D6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Salc = 492,
		/// <summary><c>XLATB</c><br/>
		/// <br/>
		/// <c>D7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xlat_m8 = 493,
		/// <summary><c>FADD m32fp</c><br/>
		/// <br/>
		/// <c>D8 /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fadd_m32fp = 494,
		/// <summary><c>FMUL m32fp</c><br/>
		/// <br/>
		/// <c>D8 /1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fmul_m32fp = 495,
		/// <summary><c>FCOM m32fp</c><br/>
		/// <br/>
		/// <c>D8 /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcom_m32fp = 496,
		/// <summary><c>FCOMP m32fp</c><br/>
		/// <br/>
		/// <c>D8 /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomp_m32fp = 497,
		/// <summary><c>FSUB m32fp</c><br/>
		/// <br/>
		/// <c>D8 /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsub_m32fp = 498,
		/// <summary><c>FSUBR m32fp</c><br/>
		/// <br/>
		/// <c>D8 /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsubr_m32fp = 499,
		/// <summary><c>FDIV m32fp</c><br/>
		/// <br/>
		/// <c>D8 /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdiv_m32fp = 500,
		/// <summary><c>FDIVR m32fp</c><br/>
		/// <br/>
		/// <c>D8 /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdivr_m32fp = 501,
		/// <summary><c>FADD ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>D8 C0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fadd_st0_sti = 502,
		/// <summary><c>FMUL ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>D8 C8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fmul_st0_sti = 503,
		/// <summary><c>FCOM ST(i)</c><br/>
		/// <br/>
		/// <c>D8 D0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcom_st0_sti = 504,
		/// <summary><c>FCOMP ST(i)</c><br/>
		/// <br/>
		/// <c>D8 D8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomp_st0_sti = 505,
		/// <summary><c>FSUB ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>D8 E0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsub_st0_sti = 506,
		/// <summary><c>FSUBR ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>D8 E8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsubr_st0_sti = 507,
		/// <summary><c>FDIV ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>D8 F0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdiv_st0_sti = 508,
		/// <summary><c>FDIVR ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>D8 F8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdivr_st0_sti = 509,
		/// <summary><c>FLD m32fp</c><br/>
		/// <br/>
		/// <c>D9 /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fld_m32fp = 510,
		/// <summary><c>FST m32fp</c><br/>
		/// <br/>
		/// <c>D9 /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fst_m32fp = 511,
		/// <summary><c>FSTP m32fp</c><br/>
		/// <br/>
		/// <c>D9 /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstp_m32fp = 512,
		/// <summary><c>FLDENV m14byte</c><br/>
		/// <br/>
		/// <c>o16 D9 /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldenv_m14byte = 513,
		/// <summary><c>FLDENV m28byte</c><br/>
		/// <br/>
		/// <c>o32 D9 /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldenv_m28byte = 514,
		/// <summary><c>FLDCW m2byte</c><br/>
		/// <br/>
		/// <c>D9 /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldcw_m2byte = 515,
		/// <summary><c>FNSTENV m14byte</c><br/>
		/// <br/>
		/// <c>o16 D9 /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnstenv_m14byte = 516,
		/// <summary><c>FSTENV m14byte</c><br/>
		/// <br/>
		/// <c>9B o16 D9 /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstenv_m14byte = 517,
		/// <summary><c>FNSTENV m28byte</c><br/>
		/// <br/>
		/// <c>o32 D9 /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnstenv_m28byte = 518,
		/// <summary><c>FSTENV m28byte</c><br/>
		/// <br/>
		/// <c>9B o32 D9 /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstenv_m28byte = 519,
		/// <summary><c>FNSTCW m2byte</c><br/>
		/// <br/>
		/// <c>D9 /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnstcw_m2byte = 520,
		/// <summary><c>FSTCW m2byte</c><br/>
		/// <br/>
		/// <c>9B D9 /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstcw_m2byte = 521,
		/// <summary><c>FLD ST(i)</c><br/>
		/// <br/>
		/// <c>D9 C0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fld_st0_sti = 522,
		/// <summary><c>FXCH ST(i)</c><br/>
		/// <br/>
		/// <c>D9 C8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxch_st0_sti = 523,
		/// <summary><c>FNOP</c><br/>
		/// <br/>
		/// <c>D9 D0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnop = 524,
		/// <summary><c>FSTPNCE ST(i)</c><br/>
		/// <br/>
		/// <c>D9 D8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstpnce_sti = 525,
		/// <summary><c>FCHS</c><br/>
		/// <br/>
		/// <c>D9 E0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fchs = 526,
		/// <summary><c>FABS</c><br/>
		/// <br/>
		/// <c>D9 E1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fabs = 527,
		/// <summary><c>FTST</c><br/>
		/// <br/>
		/// <c>D9 E4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ftst = 528,
		/// <summary><c>FXAM</c><br/>
		/// <br/>
		/// <c>D9 E5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxam = 529,
		/// <summary><c>FLD1</c><br/>
		/// <br/>
		/// <c>D9 E8</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fld1 = 530,
		/// <summary><c>FLDL2T</c><br/>
		/// <br/>
		/// <c>D9 E9</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldl2t = 531,
		/// <summary><c>FLDL2E</c><br/>
		/// <br/>
		/// <c>D9 EA</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldl2e = 532,
		/// <summary><c>FLDPI</c><br/>
		/// <br/>
		/// <c>D9 EB</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldpi = 533,
		/// <summary><c>FLDLG2</c><br/>
		/// <br/>
		/// <c>D9 EC</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldlg2 = 534,
		/// <summary><c>FLDLN2</c><br/>
		/// <br/>
		/// <c>D9 ED</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldln2 = 535,
		/// <summary><c>FLDZ</c><br/>
		/// <br/>
		/// <c>D9 EE</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fldz = 536,
		/// <summary><c>F2XM1</c><br/>
		/// <br/>
		/// <c>D9 F0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		F2xm1 = 537,
		/// <summary><c>FYL2X</c><br/>
		/// <br/>
		/// <c>D9 F1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fyl2x = 538,
		/// <summary><c>FPTAN</c><br/>
		/// <br/>
		/// <c>D9 F2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fptan = 539,
		/// <summary><c>FPATAN</c><br/>
		/// <br/>
		/// <c>D9 F3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fpatan = 540,
		/// <summary><c>FXTRACT</c><br/>
		/// <br/>
		/// <c>D9 F4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxtract = 541,
		/// <summary><c>FPREM1</c><br/>
		/// <br/>
		/// <c>D9 F5</c><br/>
		/// <br/>
		/// <c>387+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fprem1 = 542,
		/// <summary><c>FDECSTP</c><br/>
		/// <br/>
		/// <c>D9 F6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdecstp = 543,
		/// <summary><c>FINCSTP</c><br/>
		/// <br/>
		/// <c>D9 F7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fincstp = 544,
		/// <summary><c>FPREM</c><br/>
		/// <br/>
		/// <c>D9 F8</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fprem = 545,
		/// <summary><c>FYL2XP1</c><br/>
		/// <br/>
		/// <c>D9 F9</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fyl2xp1 = 546,
		/// <summary><c>FSQRT</c><br/>
		/// <br/>
		/// <c>D9 FA</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsqrt = 547,
		/// <summary><c>FSINCOS</c><br/>
		/// <br/>
		/// <c>D9 FB</c><br/>
		/// <br/>
		/// <c>387+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsincos = 548,
		/// <summary><c>FRNDINT</c><br/>
		/// <br/>
		/// <c>D9 FC</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Frndint = 549,
		/// <summary><c>FSCALE</c><br/>
		/// <br/>
		/// <c>D9 FD</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fscale = 550,
		/// <summary><c>FSIN</c><br/>
		/// <br/>
		/// <c>D9 FE</c><br/>
		/// <br/>
		/// <c>387+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsin = 551,
		/// <summary><c>FCOS</c><br/>
		/// <br/>
		/// <c>D9 FF</c><br/>
		/// <br/>
		/// <c>387+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcos = 552,
		/// <summary><c>FIADD m32int</c><br/>
		/// <br/>
		/// <c>DA /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fiadd_m32int = 553,
		/// <summary><c>FIMUL m32int</c><br/>
		/// <br/>
		/// <c>DA /1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fimul_m32int = 554,
		/// <summary><c>FICOM m32int</c><br/>
		/// <br/>
		/// <c>DA /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ficom_m32int = 555,
		/// <summary><c>FICOMP m32int</c><br/>
		/// <br/>
		/// <c>DA /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ficomp_m32int = 556,
		/// <summary><c>FISUB m32int</c><br/>
		/// <br/>
		/// <c>DA /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisub_m32int = 557,
		/// <summary><c>FISUBR m32int</c><br/>
		/// <br/>
		/// <c>DA /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisubr_m32int = 558,
		/// <summary><c>FIDIV m32int</c><br/>
		/// <br/>
		/// <c>DA /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fidiv_m32int = 559,
		/// <summary><c>FIDIVR m32int</c><br/>
		/// <br/>
		/// <c>DA /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fidivr_m32int = 560,
		/// <summary><c>FCMOVB ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DA C0+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovb_st0_sti = 561,
		/// <summary><c>FCMOVE ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DA C8+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmove_st0_sti = 562,
		/// <summary><c>FCMOVBE ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DA D0+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovbe_st0_sti = 563,
		/// <summary><c>FCMOVU ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DA D8+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovu_st0_sti = 564,
		/// <summary><c>FUCOMPP</c><br/>
		/// <br/>
		/// <c>DA E9</c><br/>
		/// <br/>
		/// <c>387+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fucompp = 565,
		/// <summary><c>FILD m32int</c><br/>
		/// <br/>
		/// <c>DB /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fild_m32int = 566,
		/// <summary><c>FISTTP m32int</c><br/>
		/// <br/>
		/// <c>DB /1</c><br/>
		/// <br/>
		/// <c>8087+ and SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisttp_m32int = 567,
		/// <summary><c>FIST m32int</c><br/>
		/// <br/>
		/// <c>DB /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fist_m32int = 568,
		/// <summary><c>FISTP m32int</c><br/>
		/// <br/>
		/// <c>DB /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fistp_m32int = 569,
		/// <summary><c>FLD m80fp</c><br/>
		/// <br/>
		/// <c>DB /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fld_m80fp = 570,
		/// <summary><c>FSTP m80fp</c><br/>
		/// <br/>
		/// <c>DB /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstp_m80fp = 571,
		/// <summary><c>FCMOVNB ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DB C0+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovnb_st0_sti = 572,
		/// <summary><c>FCMOVNE ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DB C8+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovne_st0_sti = 573,
		/// <summary><c>FCMOVNBE ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DB D0+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovnbe_st0_sti = 574,
		/// <summary><c>FCMOVNU ST(0), ST(i)</c><br/>
		/// <br/>
		/// <c>DB D8+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcmovnu_st0_sti = 575,
		/// <summary><c>FNENI</c><br/>
		/// <br/>
		/// <c>DB E0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fneni = 576,
		/// <summary><c>FENI</c><br/>
		/// <br/>
		/// <c>9B DB E0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Feni = 577,
		/// <summary><c>FNDISI</c><br/>
		/// <br/>
		/// <c>DB E1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fndisi = 578,
		/// <summary><c>FDISI</c><br/>
		/// <br/>
		/// <c>9B DB E1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdisi = 579,
		/// <summary><c>FNCLEX</c><br/>
		/// <br/>
		/// <c>DB E2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnclex = 580,
		/// <summary><c>FCLEX</c><br/>
		/// <br/>
		/// <c>9B DB E2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fclex = 581,
		/// <summary><c>FNINIT</c><br/>
		/// <br/>
		/// <c>DB E3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fninit = 582,
		/// <summary><c>FINIT</c><br/>
		/// <br/>
		/// <c>9B DB E3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Finit = 583,
		/// <summary><c>FNSETPM</c><br/>
		/// <br/>
		/// <c>DB E4</c><br/>
		/// <br/>
		/// <c>287+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnsetpm = 584,
		/// <summary><c>FSETPM</c><br/>
		/// <br/>
		/// <c>9B DB E4</c><br/>
		/// <br/>
		/// <c>287+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsetpm = 585,
		/// <summary><c>FRSTPM</c><br/>
		/// <br/>
		/// <c>DB E5</c><br/>
		/// <br/>
		/// <c>287 XL</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Frstpm = 586,
		/// <summary><c>FUCOMI ST, ST(i)</c><br/>
		/// <br/>
		/// <c>DB E8+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fucomi_st0_sti = 587,
		/// <summary><c>FCOMI ST, ST(i)</c><br/>
		/// <br/>
		/// <c>DB F0+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomi_st0_sti = 588,
		/// <summary><c>FADD m64fp</c><br/>
		/// <br/>
		/// <c>DC /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fadd_m64fp = 589,
		/// <summary><c>FMUL m64fp</c><br/>
		/// <br/>
		/// <c>DC /1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fmul_m64fp = 590,
		/// <summary><c>FCOM m64fp</c><br/>
		/// <br/>
		/// <c>DC /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcom_m64fp = 591,
		/// <summary><c>FCOMP m64fp</c><br/>
		/// <br/>
		/// <c>DC /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomp_m64fp = 592,
		/// <summary><c>FSUB m64fp</c><br/>
		/// <br/>
		/// <c>DC /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsub_m64fp = 593,
		/// <summary><c>FSUBR m64fp</c><br/>
		/// <br/>
		/// <c>DC /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsubr_m64fp = 594,
		/// <summary><c>FDIV m64fp</c><br/>
		/// <br/>
		/// <c>DC /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdiv_m64fp = 595,
		/// <summary><c>FDIVR m64fp</c><br/>
		/// <br/>
		/// <c>DC /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdivr_m64fp = 596,
		/// <summary><c>FADD ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DC C0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fadd_sti_st0 = 597,
		/// <summary><c>FMUL ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DC C8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fmul_sti_st0 = 598,
		/// <summary><c>FCOM ST(i)</c><br/>
		/// <br/>
		/// <c>DC D0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcom_st0_sti_DCD0 = 599,
		/// <summary><c>FCOMP ST(i)</c><br/>
		/// <br/>
		/// <c>DC D8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomp_st0_sti_DCD8 = 600,
		/// <summary><c>FSUBR ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DC E0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsubr_sti_st0 = 601,
		/// <summary><c>FSUB ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DC E8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsub_sti_st0 = 602,
		/// <summary><c>FDIVR ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DC F0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdivr_sti_st0 = 603,
		/// <summary><c>FDIV ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DC F8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdiv_sti_st0 = 604,
		/// <summary><c>FLD m64fp</c><br/>
		/// <br/>
		/// <c>DD /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fld_m64fp = 605,
		/// <summary><c>FISTTP m64int</c><br/>
		/// <br/>
		/// <c>DD /1</c><br/>
		/// <br/>
		/// <c>8087+ and SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisttp_m64int = 606,
		/// <summary><c>FST m64fp</c><br/>
		/// <br/>
		/// <c>DD /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fst_m64fp = 607,
		/// <summary><c>FSTP m64fp</c><br/>
		/// <br/>
		/// <c>DD /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstp_m64fp = 608,
		/// <summary><c>FRSTOR m94byte</c><br/>
		/// <br/>
		/// <c>o16 DD /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Frstor_m94byte = 609,
		/// <summary><c>FRSTOR m108byte</c><br/>
		/// <br/>
		/// <c>o32 DD /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Frstor_m108byte = 610,
		/// <summary><c>FNSAVE m94byte</c><br/>
		/// <br/>
		/// <c>o16 DD /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnsave_m94byte = 611,
		/// <summary><c>FSAVE m94byte</c><br/>
		/// <br/>
		/// <c>9B o16 DD /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsave_m94byte = 612,
		/// <summary><c>FNSAVE m108byte</c><br/>
		/// <br/>
		/// <c>o32 DD /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnsave_m108byte = 613,
		/// <summary><c>FSAVE m108byte</c><br/>
		/// <br/>
		/// <c>9B o32 DD /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsave_m108byte = 614,
		/// <summary><c>FNSTSW m2byte</c><br/>
		/// <br/>
		/// <c>DD /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnstsw_m2byte = 615,
		/// <summary><c>FSTSW m2byte</c><br/>
		/// <br/>
		/// <c>9B DD /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstsw_m2byte = 616,
		/// <summary><c>FFREE ST(i)</c><br/>
		/// <br/>
		/// <c>DD C0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ffree_sti = 617,
		/// <summary><c>FXCH ST(i)</c><br/>
		/// <br/>
		/// <c>DD C8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxch_st0_sti_DDC8 = 618,
		/// <summary><c>FST ST(i)</c><br/>
		/// <br/>
		/// <c>DD D0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fst_sti = 619,
		/// <summary><c>FSTP ST(i)</c><br/>
		/// <br/>
		/// <c>DD D8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstp_sti = 620,
		/// <summary><c>FUCOM ST(i)</c><br/>
		/// <br/>
		/// <c>DD E0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fucom_st0_sti = 621,
		/// <summary><c>FUCOMP ST(i)</c><br/>
		/// <br/>
		/// <c>DD E8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fucomp_st0_sti = 622,
		/// <summary><c>FIADD m16int</c><br/>
		/// <br/>
		/// <c>DE /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fiadd_m16int = 623,
		/// <summary><c>FIMUL m16int</c><br/>
		/// <br/>
		/// <c>DE /1</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fimul_m16int = 624,
		/// <summary><c>FICOM m16int</c><br/>
		/// <br/>
		/// <c>DE /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ficom_m16int = 625,
		/// <summary><c>FICOMP m16int</c><br/>
		/// <br/>
		/// <c>DE /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ficomp_m16int = 626,
		/// <summary><c>FISUB m16int</c><br/>
		/// <br/>
		/// <c>DE /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisub_m16int = 627,
		/// <summary><c>FISUBR m16int</c><br/>
		/// <br/>
		/// <c>DE /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisubr_m16int = 628,
		/// <summary><c>FIDIV m16int</c><br/>
		/// <br/>
		/// <c>DE /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fidiv_m16int = 629,
		/// <summary><c>FIDIVR m16int</c><br/>
		/// <br/>
		/// <c>DE /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fidivr_m16int = 630,
		/// <summary><c>FADDP ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DE C0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Faddp_sti_st0 = 631,
		/// <summary><c>FMULP ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DE C8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fmulp_sti_st0 = 632,
		/// <summary><c>FCOMP ST(i)</c><br/>
		/// <br/>
		/// <c>DE D0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomp_st0_sti_DED0 = 633,
		/// <summary><c>FCOMPP</c><br/>
		/// <br/>
		/// <c>DE D9</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcompp = 634,
		/// <summary><c>FSUBRP ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DE E0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsubrp_sti_st0 = 635,
		/// <summary><c>FSUBP ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DE E8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fsubp_sti_st0 = 636,
		/// <summary><c>FDIVRP ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DE F0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdivrp_sti_st0 = 637,
		/// <summary><c>FDIVP ST(i), ST(0)</c><br/>
		/// <br/>
		/// <c>DE F8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fdivp_sti_st0 = 638,
		/// <summary><c>FILD m16int</c><br/>
		/// <br/>
		/// <c>DF /0</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fild_m16int = 639,
		/// <summary><c>FISTTP m16int</c><br/>
		/// <br/>
		/// <c>DF /1</c><br/>
		/// <br/>
		/// <c>8087+ and SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fisttp_m16int = 640,
		/// <summary><c>FIST m16int</c><br/>
		/// <br/>
		/// <c>DF /2</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fist_m16int = 641,
		/// <summary><c>FISTP m16int</c><br/>
		/// <br/>
		/// <c>DF /3</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fistp_m16int = 642,
		/// <summary><c>FBLD m80bcd</c><br/>
		/// <br/>
		/// <c>DF /4</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fbld_m80bcd = 643,
		/// <summary><c>FILD m64int</c><br/>
		/// <br/>
		/// <c>DF /5</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fild_m64int = 644,
		/// <summary><c>FBSTP m80bcd</c><br/>
		/// <br/>
		/// <c>DF /6</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fbstp_m80bcd = 645,
		/// <summary><c>FISTP m64int</c><br/>
		/// <br/>
		/// <c>DF /7</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fistp_m64int = 646,
		/// <summary><c>FFREEP ST(i)</c><br/>
		/// <br/>
		/// <c>DF C0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ffreep_sti = 647,
		/// <summary><c>FXCH ST(i)</c><br/>
		/// <br/>
		/// <c>DF C8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxch_st0_sti_DFC8 = 648,
		/// <summary><c>FSTP ST(i)</c><br/>
		/// <br/>
		/// <c>DF D0+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstp_sti_DFD0 = 649,
		/// <summary><c>FSTP ST(i)</c><br/>
		/// <br/>
		/// <c>DF D8+i</c><br/>
		/// <br/>
		/// <c>8087+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstp_sti_DFD8 = 650,
		/// <summary><c>FNSTSW AX</c><br/>
		/// <br/>
		/// <c>DF E0</c><br/>
		/// <br/>
		/// <c>287+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fnstsw_AX = 651,
		/// <summary><c>FSTSW AX</c><br/>
		/// <br/>
		/// <c>9B DF E0</c><br/>
		/// <br/>
		/// <c>287+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fstsw_AX = 652,
		/// <summary><c>FSTDW AX</c><br/>
		/// <br/>
		/// <c>DF E1</c><br/>
		/// <br/>
		/// <c>387 SL</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Fstdw_AX = 653,
		/// <summary><c>FSTSG AX</c><br/>
		/// <br/>
		/// <c>DF E2</c><br/>
		/// <br/>
		/// <c>387 SL</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Fstsg_AX = 654,
		/// <summary><c>FUCOMIP ST, ST(i)</c><br/>
		/// <br/>
		/// <c>DF E8+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fucomip_st0_sti = 655,
		/// <summary><c>FCOMIP ST, ST(i)</c><br/>
		/// <br/>
		/// <c>DF F0+i</c><br/>
		/// <br/>
		/// <c>8087+ and CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fcomip_st0_sti = 656,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>a16 o16 E0 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loopne_rel8_16_CX = 657,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>a16 o32 E0 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loopne_rel8_32_CX = 658,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>a32 o16 E0 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Loopne_rel8_16_ECX = 659,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>a32 o32 E0 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loopne_rel8_32_ECX = 660,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>a32 E0 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loopne_rel8_64_ECX = 661,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>o16 E0 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loopne_rel8_16_RCX = 662,
		/// <summary><c>LOOPNE rel8</c><br/>
		/// <br/>
		/// <c>E0 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loopne_rel8_64_RCX = 663,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>a16 o16 E1 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loope_rel8_16_CX = 664,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>a16 o32 E1 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loope_rel8_32_CX = 665,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>a32 o16 E1 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Loope_rel8_16_ECX = 666,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>a32 o32 E1 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loope_rel8_32_ECX = 667,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>a32 E1 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loope_rel8_64_ECX = 668,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>o16 E1 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loope_rel8_16_RCX = 669,
		/// <summary><c>LOOPE rel8</c><br/>
		/// <br/>
		/// <c>E1 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loope_rel8_64_RCX = 670,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>a16 o16 E2 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loop_rel8_16_CX = 671,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>a16 o32 E2 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loop_rel8_32_CX = 672,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>a32 o16 E2 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Loop_rel8_16_ECX = 673,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>a32 o32 E2 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loop_rel8_32_ECX = 674,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>a32 E2 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loop_rel8_64_ECX = 675,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>o16 E2 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loop_rel8_16_RCX = 676,
		/// <summary><c>LOOP rel8</c><br/>
		/// <br/>
		/// <c>E2 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Loop_rel8_64_RCX = 677,
		/// <summary><c>JCXZ rel8</c><br/>
		/// <br/>
		/// <c>a16 o16 E3 cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jcxz_rel8_16 = 678,
		/// <summary><c>JCXZ rel8</c><br/>
		/// <br/>
		/// <c>a16 o32 E3 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jcxz_rel8_32 = 679,
		/// <summary><c>JECXZ rel8</c><br/>
		/// <br/>
		/// <c>a32 o16 E3 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jecxz_rel8_16 = 680,
		/// <summary><c>JECXZ rel8</c><br/>
		/// <br/>
		/// <c>a32 o32 E3 cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jecxz_rel8_32 = 681,
		/// <summary><c>JECXZ rel8</c><br/>
		/// <br/>
		/// <c>a32 E3 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jecxz_rel8_64 = 682,
		/// <summary><c>JRCXZ rel8</c><br/>
		/// <br/>
		/// <c>o16 E3 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jrcxz_rel8_16 = 683,
		/// <summary><c>JRCXZ rel8</c><br/>
		/// <br/>
		/// <c>E3 cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jrcxz_rel8_64 = 684,
		/// <summary><c>IN AL, imm8</c><br/>
		/// <br/>
		/// <c>E4 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		In_AL_imm8 = 685,
		/// <summary><c>IN AX, imm8</c><br/>
		/// <br/>
		/// <c>o16 E5 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		In_AX_imm8 = 686,
		/// <summary><c>IN EAX, imm8</c><br/>
		/// <br/>
		/// <c>o32 E5 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		In_EAX_imm8 = 687,
		/// <summary><c>OUT imm8, AL</c><br/>
		/// <br/>
		/// <c>E6 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Out_imm8_AL = 688,
		/// <summary><c>OUT imm8, AX</c><br/>
		/// <br/>
		/// <c>o16 E7 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Out_imm8_AX = 689,
		/// <summary><c>OUT imm8, EAX</c><br/>
		/// <br/>
		/// <c>o32 E7 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Out_imm8_EAX = 690,
		/// <summary><c>CALL rel16</c><br/>
		/// <br/>
		/// <c>o16 E8 cw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Call_rel16 = 691,
		/// <summary><c>CALL rel32</c><br/>
		/// <br/>
		/// <c>o32 E8 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Call_rel32_32 = 692,
		/// <summary><c>CALL rel32</c><br/>
		/// <br/>
		/// <c>E8 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Call_rel32_64 = 693,
		/// <summary><c>JMP rel16</c><br/>
		/// <br/>
		/// <c>o16 E9 cw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jmp_rel16 = 694,
		/// <summary><c>JMP rel32</c><br/>
		/// <br/>
		/// <c>o32 E9 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmp_rel32_32 = 695,
		/// <summary><c>JMP rel32</c><br/>
		/// <br/>
		/// <c>E9 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jmp_rel32_64 = 696,
		/// <summary><c>JMP ptr16:16</c><br/>
		/// <br/>
		/// <c>o16 EA cd</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmp_ptr1616 = 697,
		/// <summary><c>JMP ptr16:32</c><br/>
		/// <br/>
		/// <c>o32 EA cp</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmp_ptr1632 = 698,
		/// <summary><c>JMP rel8</c><br/>
		/// <br/>
		/// <c>o16 EB cb</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jmp_rel8_16 = 699,
		/// <summary><c>JMP rel8</c><br/>
		/// <br/>
		/// <c>o32 EB cb</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmp_rel8_32 = 700,
		/// <summary><c>JMP rel8</c><br/>
		/// <br/>
		/// <c>EB cb</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jmp_rel8_64 = 701,
		/// <summary><c>IN AL, DX</c><br/>
		/// <br/>
		/// <c>EC</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		In_AL_DX = 702,
		/// <summary><c>IN AX, DX</c><br/>
		/// <br/>
		/// <c>o16 ED</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		In_AX_DX = 703,
		/// <summary><c>IN EAX, DX</c><br/>
		/// <br/>
		/// <c>o32 ED</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		In_EAX_DX = 704,
		/// <summary><c>OUT DX, AL</c><br/>
		/// <br/>
		/// <c>EE</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Out_DX_AL = 705,
		/// <summary><c>OUT DX, AX</c><br/>
		/// <br/>
		/// <c>o16 EF</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Out_DX_AX = 706,
		/// <summary><c>OUT DX, EAX</c><br/>
		/// <br/>
		/// <c>o32 EF</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Out_DX_EAX = 707,
		/// <summary><c>INT1</c><br/>
		/// <br/>
		/// <c>F1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Int1 = 708,
		/// <summary><c>HLT</c><br/>
		/// <br/>
		/// <c>F4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Hlt = 709,
		/// <summary><c>CMC</c><br/>
		/// <br/>
		/// <c>F5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmc = 710,
		/// <summary><c>TEST r/m8, imm8</c><br/>
		/// <br/>
		/// <c>F6 /0 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm8_imm8 = 711,
		/// <summary><c>TEST r/m8, imm8</c><br/>
		/// <br/>
		/// <c>F6 /1 ib</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm8_imm8_F6r1 = 712,
		/// <summary><c>NOT r/m8</c><br/>
		/// <br/>
		/// <c>F6 /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Not_rm8 = 713,
		/// <summary><c>NEG r/m8</c><br/>
		/// <br/>
		/// <c>F6 /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Neg_rm8 = 714,
		/// <summary><c>MUL r/m8</c><br/>
		/// <br/>
		/// <c>F6 /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mul_rm8 = 715,
		/// <summary><c>IMUL r/m8</c><br/>
		/// <br/>
		/// <c>F6 /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_rm8 = 716,
		/// <summary><c>DIV r/m8</c><br/>
		/// <br/>
		/// <c>F6 /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Div_rm8 = 717,
		/// <summary><c>IDIV r/m8</c><br/>
		/// <br/>
		/// <c>F6 /7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Idiv_rm8 = 718,
		/// <summary><c>TEST r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 F7 /0 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm16_imm16 = 719,
		/// <summary><c>TEST r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 F7 /0 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm32_imm32 = 720,
		/// <summary><c>TEST r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W F7 /0 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Test_rm64_imm32 = 721,
		/// <summary><c>TEST r/m16, imm16</c><br/>
		/// <br/>
		/// <c>o16 F7 /1 iw</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm16_imm16_F7r1 = 722,
		/// <summary><c>TEST r/m32, imm32</c><br/>
		/// <br/>
		/// <c>o32 F7 /1 id</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Test_rm32_imm32_F7r1 = 723,
		/// <summary><c>TEST r/m64, imm32</c><br/>
		/// <br/>
		/// <c>REX.W F7 /1 id</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Test_rm64_imm32_F7r1 = 724,
		/// <summary><c>NOT r/m16</c><br/>
		/// <br/>
		/// <c>o16 F7 /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Not_rm16 = 725,
		/// <summary><c>NOT r/m32</c><br/>
		/// <br/>
		/// <c>o32 F7 /2</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Not_rm32 = 726,
		/// <summary><c>NOT r/m64</c><br/>
		/// <br/>
		/// <c>REX.W F7 /2</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Not_rm64 = 727,
		/// <summary><c>NEG r/m16</c><br/>
		/// <br/>
		/// <c>o16 F7 /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Neg_rm16 = 728,
		/// <summary><c>NEG r/m32</c><br/>
		/// <br/>
		/// <c>o32 F7 /3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Neg_rm32 = 729,
		/// <summary><c>NEG r/m64</c><br/>
		/// <br/>
		/// <c>REX.W F7 /3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Neg_rm64 = 730,
		/// <summary><c>MUL r/m16</c><br/>
		/// <br/>
		/// <c>o16 F7 /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mul_rm16 = 731,
		/// <summary><c>MUL r/m32</c><br/>
		/// <br/>
		/// <c>o32 F7 /4</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mul_rm32 = 732,
		/// <summary><c>MUL r/m64</c><br/>
		/// <br/>
		/// <c>REX.W F7 /4</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mul_rm64 = 733,
		/// <summary><c>IMUL r/m16</c><br/>
		/// <br/>
		/// <c>o16 F7 /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_rm16 = 734,
		/// <summary><c>IMUL r/m32</c><br/>
		/// <br/>
		/// <c>o32 F7 /5</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_rm32 = 735,
		/// <summary><c>IMUL r/m64</c><br/>
		/// <br/>
		/// <c>REX.W F7 /5</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Imul_rm64 = 736,
		/// <summary><c>DIV r/m16</c><br/>
		/// <br/>
		/// <c>o16 F7 /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Div_rm16 = 737,
		/// <summary><c>DIV r/m32</c><br/>
		/// <br/>
		/// <c>o32 F7 /6</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Div_rm32 = 738,
		/// <summary><c>DIV r/m64</c><br/>
		/// <br/>
		/// <c>REX.W F7 /6</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Div_rm64 = 739,
		/// <summary><c>IDIV r/m16</c><br/>
		/// <br/>
		/// <c>o16 F7 /7</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Idiv_rm16 = 740,
		/// <summary><c>IDIV r/m32</c><br/>
		/// <br/>
		/// <c>o32 F7 /7</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Idiv_rm32 = 741,
		/// <summary><c>IDIV r/m64</c><br/>
		/// <br/>
		/// <c>REX.W F7 /7</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Idiv_rm64 = 742,
		/// <summary><c>CLC</c><br/>
		/// <br/>
		/// <c>F8</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clc = 743,
		/// <summary><c>STC</c><br/>
		/// <br/>
		/// <c>F9</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stc = 744,
		/// <summary><c>CLI</c><br/>
		/// <br/>
		/// <c>FA</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cli = 745,
		/// <summary><c>STI</c><br/>
		/// <br/>
		/// <c>FB</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sti = 746,
		/// <summary><c>CLD</c><br/>
		/// <br/>
		/// <c>FC</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cld = 747,
		/// <summary><c>STD</c><br/>
		/// <br/>
		/// <c>FD</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Std = 748,
		/// <summary><c>INC r/m8</c><br/>
		/// <br/>
		/// <c>FE /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Inc_rm8 = 749,
		/// <summary><c>DEC r/m8</c><br/>
		/// <br/>
		/// <c>FE /1</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Dec_rm8 = 750,
		/// <summary><c>INC r/m16</c><br/>
		/// <br/>
		/// <c>o16 FF /0</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Inc_rm16 = 751,
		/// <summary><c>INC r/m32</c><br/>
		/// <br/>
		/// <c>o32 FF /0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Inc_rm32 = 752,
		/// <summary><c>INC r/m64</c><br/>
		/// <br/>
		/// <c>REX.W FF /0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Inc_rm64 = 753,
		/// <summary><c>DEC r/m16</c><br/>
		/// <br/>
		/// <c>o16 FF /1</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Dec_rm16 = 754,
		/// <summary><c>DEC r/m32</c><br/>
		/// <br/>
		/// <c>o32 FF /1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Dec_rm32 = 755,
		/// <summary><c>DEC r/m64</c><br/>
		/// <br/>
		/// <c>REX.W FF /1</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Dec_rm64 = 756,
		/// <summary><c>CALL r/m16</c><br/>
		/// <br/>
		/// <c>o16 FF /2</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Call_rm16 = 757,
		/// <summary><c>CALL r/m32</c><br/>
		/// <br/>
		/// <c>o32 FF /2</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Call_rm32 = 758,
		/// <summary><c>CALL r/m64</c><br/>
		/// <br/>
		/// <c>FF /2</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Call_rm64 = 759,
		/// <summary><c>CALL m16:16</c><br/>
		/// <br/>
		/// <c>o16 FF /3</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Call_m1616 = 760,
		/// <summary><c>CALL m16:32</c><br/>
		/// <br/>
		/// <c>o32 FF /3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Call_m1632 = 761,
		/// <summary><c>CALL m16:64</c><br/>
		/// <br/>
		/// <c>REX.W FF /3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Call_m1664 = 762,
		/// <summary><c>JMP r/m16</c><br/>
		/// <br/>
		/// <c>o16 FF /4</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jmp_rm16 = 763,
		/// <summary><c>JMP r/m32</c><br/>
		/// <br/>
		/// <c>o32 FF /4</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmp_rm32 = 764,
		/// <summary><c>JMP r/m64</c><br/>
		/// <br/>
		/// <c>FF /4</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jmp_rm64 = 765,
		/// <summary><c>JMP m16:16</c><br/>
		/// <br/>
		/// <c>o16 FF /5</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jmp_m1616 = 766,
		/// <summary><c>JMP m16:32</c><br/>
		/// <br/>
		/// <c>o32 FF /5</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jmp_m1632 = 767,
		/// <summary><c>JMP m16:64</c><br/>
		/// <br/>
		/// <c>REX.W FF /5</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jmp_m1664 = 768,
		/// <summary><c>PUSH r/m16</c><br/>
		/// <br/>
		/// <c>o16 FF /6</c><br/>
		/// <br/>
		/// <c>8086+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Push_rm16 = 769,
		/// <summary><c>PUSH r/m32</c><br/>
		/// <br/>
		/// <c>o32 FF /6</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Push_rm32 = 770,
		/// <summary><c>PUSH r/m64</c><br/>
		/// <br/>
		/// <c>FF /6</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Push_rm64 = 771,
		/// <summary><c>SLDT r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /0</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sldt_rm16 = 772,
		/// <summary><c>SLDT r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sldt_r32m16 = 773,
		/// <summary><c>SLDT r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 00 /0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sldt_r64m16 = 774,
		/// <summary><c>STR r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /1</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Str_rm16 = 775,
		/// <summary><c>STR r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Str_r32m16 = 776,
		/// <summary><c>STR r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 00 /1</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Str_r64m16 = 777,
		/// <summary><c>LLDT r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /2</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lldt_rm16 = 778,
		/// <summary><c>LLDT r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /2</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lldt_r32m16 = 779,
		/// <summary><c>LLDT r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 00 /2</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lldt_r64m16 = 780,
		/// <summary><c>LTR r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /3</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ltr_rm16 = 781,
		/// <summary><c>LTR r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ltr_r32m16 = 782,
		/// <summary><c>LTR r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 00 /3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ltr_r64m16 = 783,
		/// <summary><c>VERR r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /4</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Verr_rm16 = 784,
		/// <summary><c>VERR r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /4</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Verr_r32m16 = 785,
		/// <summary><c>VERR r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 00 /4</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Verr_r64m16 = 786,
		/// <summary><c>VERW r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /5</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Verw_rm16 = 787,
		/// <summary><c>VERW r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /5</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Verw_r32m16 = 788,
		/// <summary><c>VERW r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 00 /5</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Verw_r64m16 = 789,
		/// <summary><c>JMPE r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 00 /6</c><br/>
		/// <br/>
		/// <c>IA-64</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmpe_rm16 = 790,
		/// <summary><c>JMPE r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 00 /6</c><br/>
		/// <br/>
		/// <c>IA-64</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmpe_rm32 = 791,
		/// <summary><c>SGDT m</c><br/>
		/// <br/>
		/// <c>o16 0F 01 /0</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Sgdt_m1632_16 = 792,
		/// <summary><c>SGDT m</c><br/>
		/// <br/>
		/// <c>o32 0F 01 /0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Sgdt_m1632 = 793,
		/// <summary><c>SGDT m</c><br/>
		/// <br/>
		/// <c>0F 01 /0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sgdt_m1664 = 794,
		/// <summary><c>SIDT m</c><br/>
		/// <br/>
		/// <c>o16 0F 01 /1</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Sidt_m1632_16 = 795,
		/// <summary><c>SIDT m</c><br/>
		/// <br/>
		/// <c>o32 0F 01 /1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Sidt_m1632 = 796,
		/// <summary><c>SIDT m</c><br/>
		/// <br/>
		/// <c>0F 01 /1</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sidt_m1664 = 797,
		/// <summary><c>LGDT m16&amp;32</c><br/>
		/// <br/>
		/// <c>o16 0F 01 /2</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Lgdt_m1632_16 = 798,
		/// <summary><c>LGDT m16&amp;32</c><br/>
		/// <br/>
		/// <c>o32 0F 01 /2</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Lgdt_m1632 = 799,
		/// <summary><c>LGDT m16&amp;64</c><br/>
		/// <br/>
		/// <c>0F 01 /2</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lgdt_m1664 = 800,
		/// <summary><c>LIDT m16&amp;32</c><br/>
		/// <br/>
		/// <c>o16 0F 01 /3</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Lidt_m1632_16 = 801,
		/// <summary><c>LIDT m16&amp;32</c><br/>
		/// <br/>
		/// <c>o32 0F 01 /3</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Lidt_m1632 = 802,
		/// <summary><c>LIDT m16&amp;64</c><br/>
		/// <br/>
		/// <c>0F 01 /3</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lidt_m1664 = 803,
		/// <summary><c>SMSW r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 01 /4</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Smsw_rm16 = 804,
		/// <summary><c>SMSW r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 01 /4</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Smsw_r32m16 = 805,
		/// <summary><c>SMSW r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 01 /4</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Smsw_r64m16 = 806,
		/// <summary><c>RSTORSSP m64</c><br/>
		/// <br/>
		/// <c>F3 0F 01 /5</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rstorssp_m64 = 807,
		/// <summary><c>LMSW r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 01 /6</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lmsw_rm16 = 808,
		/// <summary><c>LMSW r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 01 /6</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lmsw_r32m16 = 809,
		/// <summary><c>LMSW r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 01 /6</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lmsw_r64m16 = 810,
		/// <summary><c>INVLPG m</c><br/>
		/// <br/>
		/// <c>0F 01 /7</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Invlpg_m = 811,
		/// <summary><c>ENCLV</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C0</c><br/>
		/// <br/>
		/// <c>ENCLV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Enclv = 812,
		/// <summary><c>VMCALL</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C1</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmcall = 813,
		/// <summary><c>VMLAUNCH</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C2</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmlaunch = 814,
		/// <summary><c>VMRESUME</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C3</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmresume = 815,
		/// <summary><c>VMXOFF</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C4</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmxoff = 816,
		/// <summary><c>PCONFIG</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C5</c><br/>
		/// <br/>
		/// <c>PCONFIG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pconfig = 817,
		/// <summary><c>MONITOR</c><br/>
		/// <br/>
		/// <c>a16 NP 0F 01 C8</c><br/>
		/// <br/>
		/// <c>MONITOR</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Monitorw = 818,
		/// <summary><c>MONITOR</c><br/>
		/// <br/>
		/// <c>a32 NP 0F 01 C8</c><br/>
		/// <br/>
		/// <c>MONITOR</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Monitord = 819,
		/// <summary><c>MONITOR</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C8</c><br/>
		/// <br/>
		/// <c>MONITOR</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Monitorq = 820,
		/// <summary><c>MWAIT</c><br/>
		/// <br/>
		/// <c>NP 0F 01 C9</c><br/>
		/// <br/>
		/// <c>MONITOR</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mwait = 821,
		/// <summary><c>CLAC</c><br/>
		/// <br/>
		/// <c>NP 0F 01 CA</c><br/>
		/// <br/>
		/// <c>SMAP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clac = 822,
		/// <summary><c>STAC</c><br/>
		/// <br/>
		/// <c>NP 0F 01 CB</c><br/>
		/// <br/>
		/// <c>SMAP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stac = 823,
		/// <summary><c>ENCLS</c><br/>
		/// <br/>
		/// <c>NP 0F 01 CF</c><br/>
		/// <br/>
		/// <c>SGX1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Encls = 824,
		/// <summary><c>XGETBV</c><br/>
		/// <br/>
		/// <c>NP 0F 01 D0</c><br/>
		/// <br/>
		/// <c>XSAVE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xgetbv = 825,
		/// <summary><c>XSETBV</c><br/>
		/// <br/>
		/// <c>NP 0F 01 D1</c><br/>
		/// <br/>
		/// <c>XSAVE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsetbv = 826,
		/// <summary><c>VMFUNC</c><br/>
		/// <br/>
		/// <c>NP 0F 01 D4</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmfunc = 827,
		/// <summary><c>XEND</c><br/>
		/// <br/>
		/// <c>NP 0F 01 D5</c><br/>
		/// <br/>
		/// <c>RTM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xend = 828,
		/// <summary><c>XTEST</c><br/>
		/// <br/>
		/// <c>NP 0F 01 D6</c><br/>
		/// <br/>
		/// <c>HLE or RTM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xtest = 829,
		/// <summary><c>ENCLU</c><br/>
		/// <br/>
		/// <c>NP 0F 01 D7</c><br/>
		/// <br/>
		/// <c>SGX1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Enclu = 830,
		/// <summary><c>VMRUN</c><br/>
		/// <br/>
		/// <c>a16 0F 01 D8</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Vmrunw = 831,
		/// <summary><c>VMRUN</c><br/>
		/// <br/>
		/// <c>a32 0F 01 D8</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmrund = 832,
		/// <summary><c>VMRUN</c><br/>
		/// <br/>
		/// <c>0F 01 D8</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Vmrunq = 833,
		/// <summary><c>VMMCALL</c><br/>
		/// <br/>
		/// <c>0F 01 D9</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmmcall = 834,
		/// <summary><c>VMLOAD</c><br/>
		/// <br/>
		/// <c>a16 0F 01 DA</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Vmloadw = 835,
		/// <summary><c>VMLOAD</c><br/>
		/// <br/>
		/// <c>a32 0F 01 DA</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmloadd = 836,
		/// <summary><c>VMLOAD</c><br/>
		/// <br/>
		/// <c>0F 01 DA</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Vmloadq = 837,
		/// <summary><c>VMSAVE</c><br/>
		/// <br/>
		/// <c>a16 0F 01 DB</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Vmsavew = 838,
		/// <summary><c>VMSAVE</c><br/>
		/// <br/>
		/// <c>a32 0F 01 DB</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmsaved = 839,
		/// <summary><c>VMSAVE</c><br/>
		/// <br/>
		/// <c>0F 01 DB</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Vmsaveq = 840,
		/// <summary><c>STGI</c><br/>
		/// <br/>
		/// <c>0F 01 DC</c><br/>
		/// <br/>
		/// <c>SKINIT or SVML</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stgi = 841,
		/// <summary><c>CLGI</c><br/>
		/// <br/>
		/// <c>0F 01 DD</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clgi = 842,
		/// <summary><c>SKINIT</c><br/>
		/// <br/>
		/// <c>0F 01 DE</c><br/>
		/// <br/>
		/// <c>SKINIT or SVML</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Skinit = 843,
		/// <summary><c>INVLPGA</c><br/>
		/// <br/>
		/// <c>a16 0F 01 DF</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Invlpgaw = 844,
		/// <summary><c>INVLPGA</c><br/>
		/// <br/>
		/// <c>a32 0F 01 DF</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Invlpgad = 845,
		/// <summary><c>INVLPGA</c><br/>
		/// <br/>
		/// <c>0F 01 DF</c><br/>
		/// <br/>
		/// <c>SVM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Invlpgaq = 846,
		/// <summary><c>SETSSBSY</c><br/>
		/// <br/>
		/// <c>F3 0F 01 E8</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setssbsy = 847,
		/// <summary><c>SAVEPREVSSP</c><br/>
		/// <br/>
		/// <c>F3 0F 01 EA</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Saveprevssp = 848,
		/// <summary><c>RDPKRU</c><br/>
		/// <br/>
		/// <c>NP 0F 01 EE</c><br/>
		/// <br/>
		/// <c>PKU</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdpkru = 849,
		/// <summary><c>WRPKRU</c><br/>
		/// <br/>
		/// <c>NP 0F 01 EF</c><br/>
		/// <br/>
		/// <c>PKU</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wrpkru = 850,
		/// <summary><c>SWAPGS</c><br/>
		/// <br/>
		/// <c>0F 01 F8</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Swapgs = 851,
		/// <summary><c>RDTSCP</c><br/>
		/// <br/>
		/// <c>0F 01 F9</c><br/>
		/// <br/>
		/// <c>RDTSCP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdtscp = 852,
		/// <summary><c>MONITORX</c><br/>
		/// <br/>
		/// <c>a16 NP 0F 01 FA</c><br/>
		/// <br/>
		/// <c>MONITORX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Monitorxw = 853,
		/// <summary><c>MONITORX</c><br/>
		/// <br/>
		/// <c>a32 NP 0F 01 FA</c><br/>
		/// <br/>
		/// <c>MONITORX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Monitorxd = 854,
		/// <summary><c>MONITORX</c><br/>
		/// <br/>
		/// <c>NP 0F 01 FA</c><br/>
		/// <br/>
		/// <c>MONITORX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Monitorxq = 855,
		/// <summary><c>MCOMMIT</c><br/>
		/// <br/>
		/// <c>F3 0F 01 FA</c><br/>
		/// <br/>
		/// <c>MCOMMIT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mcommit = 856,
		/// <summary><c>MWAITX</c><br/>
		/// <br/>
		/// <c>0F 01 FB</c><br/>
		/// <br/>
		/// <c>MONITORX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mwaitx = 857,
		/// <summary><c>CLZERO</c><br/>
		/// <br/>
		/// <c>a16 0F 01 FC</c><br/>
		/// <br/>
		/// <c>CLZERO</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Clzerow = 858,
		/// <summary><c>CLZERO</c><br/>
		/// <br/>
		/// <c>a32 0F 01 FC</c><br/>
		/// <br/>
		/// <c>CLZERO</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clzerod = 859,
		/// <summary><c>CLZERO</c><br/>
		/// <br/>
		/// <c>0F 01 FC</c><br/>
		/// <br/>
		/// <c>CLZERO</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Clzeroq = 860,
		/// <summary><c>RDPRU</c><br/>
		/// <br/>
		/// <c>0F 01 FD</c><br/>
		/// <br/>
		/// <c>RDPRU</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdpru = 861,
		/// <summary><c>LAR r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 02 /r</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lar_r16_rm16 = 862,
		/// <summary><c>LAR r32, r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 02 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lar_r32_r32m16 = 863,
		/// <summary><c>LAR r64, r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 02 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lar_r64_r64m16 = 864,
		/// <summary><c>LSL r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 03 /r</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lsl_r16_rm16 = 865,
		/// <summary><c>LSL r32, r32/m16</c><br/>
		/// <br/>
		/// <c>o32 0F 03 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lsl_r32_r32m16 = 866,
		/// <summary><c>LSL r64, r64/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F 03 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lsl_r64_r64m16 = 867,
		/// <summary><c>LOADALL</c><br/>
		/// <br/>
		/// <c>0F 04</c><br/>
		/// <br/>
		/// <c>286</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loadallreset286 = 868,
		/// <summary><c>LOADALL</c><br/>
		/// <br/>
		/// <c>0F 05</c><br/>
		/// <br/>
		/// <c>286</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loadall286 = 869,
		/// <summary><c>SYSCALL</c><br/>
		/// <br/>
		/// <c>0F 05</c><br/>
		/// <br/>
		/// <c>SYSCALL</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Syscall = 870,
		/// <summary><c>CLTS</c><br/>
		/// <br/>
		/// <c>0F 06</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clts = 871,
		/// <summary><c>LOADALL</c><br/>
		/// <br/>
		/// <c>0F 07</c><br/>
		/// <br/>
		/// <c>386</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Loadall386 = 872,
		/// <summary><c>SYSRET</c><br/>
		/// <br/>
		/// <c>0F 07</c><br/>
		/// <br/>
		/// <c>SYSCALL</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sysretd = 873,
		/// <summary><c>SYSRET</c><br/>
		/// <br/>
		/// <c>REX.W 0F 07</c><br/>
		/// <br/>
		/// <c>SYSCALL</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sysretq = 874,
		/// <summary><c>INVD</c><br/>
		/// <br/>
		/// <c>0F 08</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Invd = 875,
		/// <summary><c>WBINVD</c><br/>
		/// <br/>
		/// <c>0F 09</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wbinvd = 876,
		/// <summary><c>WBNOINVD</c><br/>
		/// <br/>
		/// <c>F3 0F 09</c><br/>
		/// <br/>
		/// <c>WBNOINVD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wbnoinvd = 877,
		/// <summary><c>CL1INVMB</c><br/>
		/// <br/>
		/// <c>0F 0A</c><br/>
		/// <br/>
		/// <c>CL1INVMB</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cl1invmb = 878,
		/// <summary><c>UD2</c><br/>
		/// <br/>
		/// <c>0F 0B</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ud2 = 879,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 0D /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F0D = 880,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 0D /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F0D = 881,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 0D /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F0D = 882,
		/// <summary><c>PREFETCH m8</c><br/>
		/// <br/>
		/// <c>0F 0D /0</c><br/>
		/// <br/>
		/// <c>PREFETCHW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetch_m8 = 883,
		/// <summary><c>PREFETCHW m8</c><br/>
		/// <br/>
		/// <c>0F 0D /1</c><br/>
		/// <br/>
		/// <c>PREFETCHW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetchw_m8 = 884,
		/// <summary><c>PREFETCHWT1 m8</c><br/>
		/// <br/>
		/// <c>0F 0D /2</c><br/>
		/// <br/>
		/// <c>PREFETCHWT1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetchwt1_m8 = 885,
		/// <summary><c>FEMMS</c><br/>
		/// <br/>
		/// <c>0F 0E</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Femms = 886,
		/// <summary><c>UMOV r/m8, r8</c><br/>
		/// <br/>
		/// <c>0F 10 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umov_rm8_r8 = 887,
		/// <summary><c>UMOV r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 11 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umov_rm16_r16 = 888,
		/// <summary><c>UMOV r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 11 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umov_rm32_r32 = 889,
		/// <summary><c>UMOV r8, r/m8</c><br/>
		/// <br/>
		/// <c>0F 12 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umov_r8_rm8 = 890,
		/// <summary><c>UMOV r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 13 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umov_r16_rm16 = 891,
		/// <summary><c>UMOV r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 13 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umov_r32_rm32 = 892,
		/// <summary><c>MOVUPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 10 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movups_xmm_xmmm128 = 893,
		/// <summary><c>VMOVUPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovups_xmm_xmmm128 = 894,
		/// <summary><c>VMOVUPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovups_ymm_ymmm256 = 895,
		/// <summary><c>VMOVUPS xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovups_xmm_k1z_xmmm128 = 896,
		/// <summary><c>VMOVUPS ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovups_ymm_k1z_ymmm256 = 897,
		/// <summary><c>VMOVUPS zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovups_zmm_k1z_zmmm512 = 898,
		/// <summary><c>MOVUPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 10 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movupd_xmm_xmmm128 = 899,
		/// <summary><c>VMOVUPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovupd_xmm_xmmm128 = 900,
		/// <summary><c>VMOVUPD ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovupd_ymm_ymmm256 = 901,
		/// <summary><c>VMOVUPD xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovupd_xmm_k1z_xmmm128 = 902,
		/// <summary><c>VMOVUPD ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovupd_ymm_k1z_ymmm256 = 903,
		/// <summary><c>VMOVUPD zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovupd_zmm_k1z_zmmm512 = 904,
		/// <summary><c>MOVSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 10 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movss_xmm_xmmm32 = 905,
		/// <summary><c>VMOVSS xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovss_xmm_xmm_xmm = 906,
		/// <summary><c>VMOVSS xmm1, m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovss_xmm_m32 = 907,
		/// <summary><c>VMOVSS xmm1 {k1}{z}, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovss_xmm_k1z_xmm_xmm = 908,
		/// <summary><c>VMOVSS xmm1 {k1}{z}, m32</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovss_xmm_k1z_m32 = 909,
		/// <summary><c>MOVSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 10 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsd_xmm_xmmm64 = 910,
		/// <summary><c>VMOVSD xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovsd_xmm_xmm_xmm = 911,
		/// <summary><c>VMOVSD xmm1, m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 10 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovsd_xmm_m64 = 912,
		/// <summary><c>VMOVSD xmm1 {k1}{z}, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsd_xmm_k1z_xmm_xmm = 913,
		/// <summary><c>VMOVSD xmm1 {k1}{z}, m64</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsd_xmm_k1z_m64 = 914,
		/// <summary><c>MOVUPS xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>NP 0F 11 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movups_xmmm128_xmm = 915,
		/// <summary><c>VMOVUPS xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovups_xmmm128_xmm = 916,
		/// <summary><c>VMOVUPS ymm2/m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovups_ymmm256_ymm = 917,
		/// <summary><c>VMOVUPS xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovups_xmmm128_k1z_xmm = 918,
		/// <summary><c>VMOVUPS ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovups_ymmm256_k1z_ymm = 919,
		/// <summary><c>VMOVUPS zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovups_zmmm512_k1z_zmm = 920,
		/// <summary><c>MOVUPD xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F 11 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movupd_xmmm128_xmm = 921,
		/// <summary><c>VMOVUPD xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovupd_xmmm128_xmm = 922,
		/// <summary><c>VMOVUPD ymm2/m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovupd_ymmm256_ymm = 923,
		/// <summary><c>VMOVUPD xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovupd_xmmm128_k1z_xmm = 924,
		/// <summary><c>VMOVUPD ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovupd_ymmm256_k1z_ymm = 925,
		/// <summary><c>VMOVUPD zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovupd_zmmm512_k1z_zmm = 926,
		/// <summary><c>MOVSS xmm2/m32, xmm1</c><br/>
		/// <br/>
		/// <c>F3 0F 11 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movss_xmmm32_xmm = 927,
		/// <summary><c>VMOVSS xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovss_xmm_xmm_xmm_0F11 = 928,
		/// <summary><c>VMOVSS m32, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovss_m32_xmm = 929,
		/// <summary><c>VMOVSS xmm1 {k1}{z}, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovss_xmm_k1z_xmm_xmm_0F11 = 930,
		/// <summary><c>VMOVSS m32 {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovss_m32_k1_xmm = 931,
		/// <summary><c>MOVSD xmm1/m64, xmm2</c><br/>
		/// <br/>
		/// <c>F2 0F 11 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsd_xmmm64_xmm = 932,
		/// <summary><c>VMOVSD xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovsd_xmm_xmm_xmm_0F11 = 933,
		/// <summary><c>VMOVSD m64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 11 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovsd_m64_xmm = 934,
		/// <summary><c>VMOVSD xmm1 {k1}{z}, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsd_xmm_k1z_xmm_xmm_0F11 = 935,
		/// <summary><c>VMOVSD m64 {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsd_m64_k1_xmm = 936,
		/// <summary><c>MOVHLPS xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>NP 0F 12 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movhlps_xmm_xmm = 937,
		/// <summary><c>MOVLPS xmm1, m64</c><br/>
		/// <br/>
		/// <c>NP 0F 12 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movlps_xmm_m64 = 938,
		/// <summary><c>VMOVHLPS xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovhlps_xmm_xmm_xmm = 939,
		/// <summary><c>VMOVLPS xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovlps_xmm_xmm_m64 = 940,
		/// <summary><c>VMOVHLPS xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovhlps_xmm_xmm_xmm = 941,
		/// <summary><c>VMOVLPS xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovlps_xmm_xmm_m64 = 942,
		/// <summary><c>MOVLPD xmm1, m64</c><br/>
		/// <br/>
		/// <c>66 0F 12 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movlpd_xmm_m64 = 943,
		/// <summary><c>VMOVLPD xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovlpd_xmm_xmm_m64 = 944,
		/// <summary><c>VMOVLPD xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovlpd_xmm_xmm_m64 = 945,
		/// <summary><c>MOVSLDUP xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F3 0F 12 /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsldup_xmm_xmmm128 = 946,
		/// <summary><c>VMOVSLDUP xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovsldup_xmm_xmmm128 = 947,
		/// <summary><c>VMOVSLDUP ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovsldup_ymm_ymmm256 = 948,
		/// <summary><c>VMOVSLDUP xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsldup_xmm_k1z_xmmm128 = 949,
		/// <summary><c>VMOVSLDUP ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsldup_ymm_k1z_ymmm256 = 950,
		/// <summary><c>VMOVSLDUP zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovsldup_zmm_k1z_zmmm512 = 951,
		/// <summary><c>MOVDDUP xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 12 /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movddup_xmm_xmmm64 = 952,
		/// <summary><c>VMOVDDUP xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovddup_xmm_xmmm64 = 953,
		/// <summary><c>VMOVDDUP ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG 12 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovddup_ymm_ymmm256 = 954,
		/// <summary><c>VMOVDDUP xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovddup_xmm_k1z_xmmm64 = 955,
		/// <summary><c>VMOVDDUP ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovddup_ymm_k1z_ymmm256 = 956,
		/// <summary><c>VMOVDDUP zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovddup_zmm_k1z_zmmm512 = 957,
		/// <summary><c>MOVLPS m64, xmm1</c><br/>
		/// <br/>
		/// <c>NP 0F 13 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movlps_m64_xmm = 958,
		/// <summary><c>VMOVLPS m64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 13 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovlps_m64_xmm = 959,
		/// <summary><c>VMOVLPS m64, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovlps_m64_xmm = 960,
		/// <summary><c>MOVLPD m64, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F 13 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movlpd_m64_xmm = 961,
		/// <summary><c>VMOVLPD m64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 13 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovlpd_m64_xmm = 962,
		/// <summary><c>VMOVLPD m64, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovlpd_m64_xmm = 963,
		/// <summary><c>UNPCKLPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 14 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Unpcklps_xmm_xmmm128 = 964,
		/// <summary><c>VUNPCKLPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 14 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpcklps_xmm_xmm_xmmm128 = 965,
		/// <summary><c>VUNPCKLPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 14 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpcklps_ymm_ymm_ymmm256 = 966,
		/// <summary><c>VUNPCKLPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpcklps_xmm_k1z_xmm_xmmm128b32 = 967,
		/// <summary><c>VUNPCKLPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpcklps_ymm_k1z_ymm_ymmm256b32 = 968,
		/// <summary><c>VUNPCKLPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpcklps_zmm_k1z_zmm_zmmm512b32 = 969,
		/// <summary><c>UNPCKLPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 14 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Unpcklpd_xmm_xmmm128 = 970,
		/// <summary><c>VUNPCKLPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 14 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpcklpd_xmm_xmm_xmmm128 = 971,
		/// <summary><c>VUNPCKLPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 14 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpcklpd_ymm_ymm_ymmm256 = 972,
		/// <summary><c>VUNPCKLPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpcklpd_xmm_k1z_xmm_xmmm128b64 = 973,
		/// <summary><c>VUNPCKLPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpcklpd_ymm_k1z_ymm_ymmm256b64 = 974,
		/// <summary><c>VUNPCKLPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpcklpd_zmm_k1z_zmm_zmmm512b64 = 975,
		/// <summary><c>UNPCKHPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 15 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Unpckhps_xmm_xmmm128 = 976,
		/// <summary><c>VUNPCKHPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 15 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpckhps_xmm_xmm_xmmm128 = 977,
		/// <summary><c>VUNPCKHPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 15 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpckhps_ymm_ymm_ymmm256 = 978,
		/// <summary><c>VUNPCKHPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpckhps_xmm_k1z_xmm_xmmm128b32 = 979,
		/// <summary><c>VUNPCKHPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpckhps_ymm_k1z_ymm_ymmm256b32 = 980,
		/// <summary><c>VUNPCKHPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpckhps_zmm_k1z_zmm_zmmm512b32 = 981,
		/// <summary><c>UNPCKHPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 15 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Unpckhpd_xmm_xmmm128 = 982,
		/// <summary><c>VUNPCKHPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 15 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpckhpd_xmm_xmm_xmmm128 = 983,
		/// <summary><c>VUNPCKHPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 15 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vunpckhpd_ymm_ymm_ymmm256 = 984,
		/// <summary><c>VUNPCKHPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpckhpd_xmm_k1z_xmm_xmmm128b64 = 985,
		/// <summary><c>VUNPCKHPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpckhpd_ymm_k1z_ymm_ymmm256b64 = 986,
		/// <summary><c>VUNPCKHPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vunpckhpd_zmm_k1z_zmm_zmmm512b64 = 987,
		/// <summary><c>MOVLHPS xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>NP 0F 16 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movlhps_xmm_xmm = 988,
		/// <summary><c>VMOVLHPS xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 16 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovlhps_xmm_xmm_xmm = 989,
		/// <summary><c>VMOVLHPS xmm1, xmm2, xmm3</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovlhps_xmm_xmm_xmm = 990,
		/// <summary><c>MOVHPS xmm1, m64</c><br/>
		/// <br/>
		/// <c>NP 0F 16 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movhps_xmm_m64 = 991,
		/// <summary><c>VMOVHPS xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 16 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovhps_xmm_xmm_m64 = 992,
		/// <summary><c>VMOVHPS xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovhps_xmm_xmm_m64 = 993,
		/// <summary><c>MOVHPD xmm1, m64</c><br/>
		/// <br/>
		/// <c>66 0F 16 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movhpd_xmm_m64 = 994,
		/// <summary><c>VMOVHPD xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 16 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovhpd_xmm_xmm_m64 = 995,
		/// <summary><c>VMOVHPD xmm2, xmm1, m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovhpd_xmm_xmm_m64 = 996,
		/// <summary><c>MOVSHDUP xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F3 0F 16 /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movshdup_xmm_xmmm128 = 997,
		/// <summary><c>VMOVSHDUP xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 16 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovshdup_xmm_xmmm128 = 998,
		/// <summary><c>VMOVSHDUP ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG 16 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovshdup_ymm_ymmm256 = 999,
		/// <summary><c>VMOVSHDUP xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovshdup_xmm_k1z_xmmm128 = 1000,
		/// <summary><c>VMOVSHDUP ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovshdup_ymm_k1z_ymmm256 = 1001,
		/// <summary><c>VMOVSHDUP zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovshdup_zmm_k1z_zmmm512 = 1002,
		/// <summary><c>MOVHPS m64, xmm1</c><br/>
		/// <br/>
		/// <c>NP 0F 17 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movhps_m64_xmm = 1003,
		/// <summary><c>VMOVHPS m64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 17 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovhps_m64_xmm = 1004,
		/// <summary><c>VMOVHPS m64, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 17 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovhps_m64_xmm = 1005,
		/// <summary><c>MOVHPD m64, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F 17 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movhpd_m64_xmm = 1006,
		/// <summary><c>VMOVHPD m64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 17 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovhpd_m64_xmm = 1007,
		/// <summary><c>VMOVHPD m64, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 17 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovhpd_m64_xmm = 1008,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 18 /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F18 = 1009,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 18 /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F18 = 1010,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 18 /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F18 = 1011,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 19 /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F19 = 1012,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 19 /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F19 = 1013,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 19 /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F19 = 1014,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 1A /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F1A = 1015,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 1A /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F1A = 1016,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1A /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F1A = 1017,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 1B /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F1B = 1018,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 1B /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F1B = 1019,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1B /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F1B = 1020,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 1C /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F1C = 1021,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 1C /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F1C = 1022,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1C /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F1C = 1023,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 1D /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F1D = 1024,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 1D /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F1D = 1025,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1D /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F1D = 1026,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 1E /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F1E = 1027,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 1E /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F1E = 1028,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1E /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F1E = 1029,
		/// <summary><c>RESERVEDNOP r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 1F /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm16_r16_0F1F = 1030,
		/// <summary><c>RESERVEDNOP r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 1F /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		ReservedNop_rm32_r32_0F1F = 1031,
		/// <summary><c>RESERVEDNOP r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1F /r</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		ReservedNop_rm64_r64_0F1F = 1032,
		/// <summary><c>PREFETCHNTA m8</c><br/>
		/// <br/>
		/// <c>0F 18 /0</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetchnta_m8 = 1033,
		/// <summary><c>PREFETCHT0 m8</c><br/>
		/// <br/>
		/// <c>0F 18 /1</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetcht0_m8 = 1034,
		/// <summary><c>PREFETCHT1 m8</c><br/>
		/// <br/>
		/// <c>0F 18 /2</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetcht1_m8 = 1035,
		/// <summary><c>PREFETCHT2 m8</c><br/>
		/// <br/>
		/// <c>0F 18 /3</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Prefetcht2_m8 = 1036,
		/// <summary><c>BNDLDX bnd, mib</c><br/>
		/// <br/>
		/// <c>NP 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bndldx_bnd_mib = 1037,
		/// <summary><c>BNDMOV bnd1, bnd2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bndmov_bnd_bndm64 = 1038,
		/// <summary><c>BNDMOV bnd1, bnd2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bndmov_bnd_bndm128 = 1039,
		/// <summary><c>BNDCL bnd, r/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bndcl_bnd_rm32 = 1040,
		/// <summary><c>BNDCL bnd, r/m64</c><br/>
		/// <br/>
		/// <c>F3 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bndcl_bnd_rm64 = 1041,
		/// <summary><c>BNDCU bnd, r/m32</c><br/>
		/// <br/>
		/// <c>F2 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bndcu_bnd_rm32 = 1042,
		/// <summary><c>BNDCU bnd, r/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 1A /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bndcu_bnd_rm64 = 1043,
		/// <summary><c>BNDSTX mib, bnd</c><br/>
		/// <br/>
		/// <c>NP 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bndstx_mib_bnd = 1044,
		/// <summary><c>BNDMOV bnd1/m64, bnd2</c><br/>
		/// <br/>
		/// <c>66 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bndmov_bndm64_bnd = 1045,
		/// <summary><c>BNDMOV bnd1/m128, bnd2</c><br/>
		/// <br/>
		/// <c>66 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bndmov_bndm128_bnd = 1046,
		/// <summary><c>BNDMK bnd, m32</c><br/>
		/// <br/>
		/// <c>F3 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bndmk_bnd_m32 = 1047,
		/// <summary><c>BNDMK bnd, m64</c><br/>
		/// <br/>
		/// <c>F3 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bndmk_bnd_m64 = 1048,
		/// <summary><c>BNDCN bnd, r/m32</c><br/>
		/// <br/>
		/// <c>F2 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Bndcn_bnd_rm32 = 1049,
		/// <summary><c>BNDCN bnd, r/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 1B /r</c><br/>
		/// <br/>
		/// <c>MPX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bndcn_bnd_rm64 = 1050,
		/// <summary><c>CLDEMOTE m8</c><br/>
		/// <br/>
		/// <c>NP 0F 1C /0</c><br/>
		/// <br/>
		/// <c>CLDEMOTE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cldemote_m8 = 1051,
		/// <summary><c>RDSSPD r32</c><br/>
		/// <br/>
		/// <c>F3 0F 1E /1</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdsspd_r32 = 1052,
		/// <summary><c>RDSSPQ r64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F 1E /1</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdsspq_r64 = 1053,
		/// <summary><c>ENDBR64</c><br/>
		/// <br/>
		/// <c>F3 0F 1E FA</c><br/>
		/// <br/>
		/// <c>CET_IBT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Endbr64 = 1054,
		/// <summary><c>ENDBR32</c><br/>
		/// <br/>
		/// <c>F3 0F 1E FB</c><br/>
		/// <br/>
		/// <c>CET_IBT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Endbr32 = 1055,
		/// <summary><c>NOP r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 1F /0</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Nop_rm16 = 1056,
		/// <summary><c>NOP r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 1F /0</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Nop_rm32 = 1057,
		/// <summary><c>NOP r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 1F /0</c><br/>
		/// <br/>
		/// <c>CPUID.01H.EAX[Bits 11:8] = 0110B or 1111B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Nop_rm64 = 1058,
		/// <summary><c>MOV r32, cr</c><br/>
		/// <br/>
		/// <c>0F 20 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Mov_r32_cr = 1059,
		/// <summary><c>MOV r64, cr</c><br/>
		/// <br/>
		/// <c>0F 20 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_r64_cr = 1060,
		/// <summary><c>MOV r32, dr</c><br/>
		/// <br/>
		/// <c>0F 21 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Mov_r32_dr = 1061,
		/// <summary><c>MOV r64, dr</c><br/>
		/// <br/>
		/// <c>0F 21 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_r64_dr = 1062,
		/// <summary><c>MOV cr, r32</c><br/>
		/// <br/>
		/// <c>0F 22 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Mov_cr_r32 = 1063,
		/// <summary><c>MOV cr, r64</c><br/>
		/// <br/>
		/// <c>0F 22 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_cr_r64 = 1064,
		/// <summary><c>MOV dr, r32</c><br/>
		/// <br/>
		/// <c>0F 23 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Mov_dr_r32 = 1065,
		/// <summary><c>MOV dr, r64</c><br/>
		/// <br/>
		/// <c>0F 23 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Mov_dr_r64 = 1066,
		/// <summary><c>MOV r32, tr</c><br/>
		/// <br/>
		/// <c>0F 24 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Mov_r32_tr = 1067,
		/// <summary><c>MOV tr, r32</c><br/>
		/// <br/>
		/// <c>0F 26 /r</c><br/>
		/// <br/>
		/// <c>386/486</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Mov_tr_r32 = 1068,
		/// <summary><c>MOVAPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 28 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movaps_xmm_xmmm128 = 1069,
		/// <summary><c>VMOVAPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 28 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovaps_xmm_xmmm128 = 1070,
		/// <summary><c>VMOVAPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 28 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovaps_ymm_ymmm256 = 1071,
		/// <summary><c>VMOVAPS xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovaps_xmm_k1z_xmmm128 = 1072,
		/// <summary><c>VMOVAPS ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovaps_ymm_k1z_ymmm256 = 1073,
		/// <summary><c>VMOVAPS zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovaps_zmm_k1z_zmmm512 = 1074,
		/// <summary><c>MOVAPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 28 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movapd_xmm_xmmm128 = 1075,
		/// <summary><c>VMOVAPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 28 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovapd_xmm_xmmm128 = 1076,
		/// <summary><c>VMOVAPD ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 28 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovapd_ymm_ymmm256 = 1077,
		/// <summary><c>VMOVAPD xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovapd_xmm_k1z_xmmm128 = 1078,
		/// <summary><c>VMOVAPD ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovapd_ymm_k1z_ymmm256 = 1079,
		/// <summary><c>VMOVAPD zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovapd_zmm_k1z_zmmm512 = 1080,
		/// <summary><c>MOVAPS xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>NP 0F 29 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movaps_xmmm128_xmm = 1081,
		/// <summary><c>VMOVAPS xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 29 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovaps_xmmm128_xmm = 1082,
		/// <summary><c>VMOVAPS ymm2/m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 29 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovaps_ymmm256_ymm = 1083,
		/// <summary><c>VMOVAPS xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovaps_xmmm128_k1z_xmm = 1084,
		/// <summary><c>VMOVAPS ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovaps_ymmm256_k1z_ymm = 1085,
		/// <summary><c>VMOVAPS zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovaps_zmmm512_k1z_zmm = 1086,
		/// <summary><c>MOVAPD xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F 29 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movapd_xmmm128_xmm = 1087,
		/// <summary><c>VMOVAPD xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 29 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovapd_xmmm128_xmm = 1088,
		/// <summary><c>VMOVAPD ymm2/m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 29 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovapd_ymmm256_ymm = 1089,
		/// <summary><c>VMOVAPD xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovapd_xmmm128_k1z_xmm = 1090,
		/// <summary><c>VMOVAPD ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovapd_ymmm256_k1z_ymm = 1091,
		/// <summary><c>VMOVAPD zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovapd_zmmm512_k1z_zmm = 1092,
		/// <summary><c>CVTPI2PS xmm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 2A /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtpi2ps_xmm_mmm64 = 1093,
		/// <summary><c>CVTPI2PD xmm, mm/m64</c><br/>
		/// <br/>
		/// <c>66 0F 2A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtpi2pd_xmm_mmm64 = 1094,
		/// <summary><c>CVTSI2SS xmm1, r/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 2A /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtsi2ss_xmm_rm32 = 1095,
		/// <summary><c>CVTSI2SS xmm1, r/m64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F 2A /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cvtsi2ss_xmm_rm64 = 1096,
		/// <summary><c>VCVTSI2SS xmm1, xmm2, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtsi2ss_xmm_xmm_rm32 = 1097,
		/// <summary><c>VCVTSI2SS xmm1, xmm2, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vcvtsi2ss_xmm_xmm_rm64 = 1098,
		/// <summary><c>VCVTSI2SS xmm1, xmm2, r/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtsi2ss_xmm_xmm_rm32_er = 1099,
		/// <summary><c>VCVTSI2SS xmm1, xmm2, r/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtsi2ss_xmm_xmm_rm64_er = 1100,
		/// <summary><c>CVTSI2SD xmm1, r/m32</c><br/>
		/// <br/>
		/// <c>F2 0F 2A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtsi2sd_xmm_rm32 = 1101,
		/// <summary><c>CVTSI2SD xmm1, r/m64</c><br/>
		/// <br/>
		/// <c>F2 REX.W 0F 2A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cvtsi2sd_xmm_rm64 = 1102,
		/// <summary><c>VCVTSI2SD xmm1, xmm2, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtsi2sd_xmm_xmm_rm32 = 1103,
		/// <summary><c>VCVTSI2SD xmm1, xmm2, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vcvtsi2sd_xmm_xmm_rm64 = 1104,
		/// <summary><c>VCVTSI2SD xmm1, xmm2, r/m32</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtsi2sd_xmm_xmm_rm32_er = 1105,
		/// <summary><c>VCVTSI2SD xmm1, xmm2, r/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtsi2sd_xmm_xmm_rm64_er = 1106,
		/// <summary><c>MOVNTPS m128, xmm1</c><br/>
		/// <br/>
		/// <c>NP 0F 2B /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntps_m128_xmm = 1107,
		/// <summary><c>VMOVNTPS m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 2B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntps_m128_xmm = 1108,
		/// <summary><c>VMOVNTPS m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 2B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntps_m256_ymm = 1109,
		/// <summary><c>VMOVNTPS m128, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntps_m128_xmm = 1110,
		/// <summary><c>VMOVNTPS m256, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntps_m256_ymm = 1111,
		/// <summary><c>VMOVNTPS m512, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntps_m512_zmm = 1112,
		/// <summary><c>MOVNTPD m128, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F 2B /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntpd_m128_xmm = 1113,
		/// <summary><c>VMOVNTPD m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 2B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntpd_m128_xmm = 1114,
		/// <summary><c>VMOVNTPD m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 2B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntpd_m256_ymm = 1115,
		/// <summary><c>VMOVNTPD m128, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntpd_m128_xmm = 1116,
		/// <summary><c>VMOVNTPD m256, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntpd_m256_ymm = 1117,
		/// <summary><c>VMOVNTPD m512, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntpd_m512_zmm = 1118,
		/// <summary><c>MOVNTSS m32, xmm1</c><br/>
		/// <br/>
		/// <c>F3 0F 2B /r</c><br/>
		/// <br/>
		/// <c>SSE4A</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntss_m32_xmm = 1119,
		/// <summary><c>MOVNTSD m64, xmm1</c><br/>
		/// <br/>
		/// <c>F2 0F 2B /r</c><br/>
		/// <br/>
		/// <c>SSE4A</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntsd_m64_xmm = 1120,
		/// <summary><c>CVTTPS2PI mm, xmm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 2C /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvttps2pi_mm_xmmm64 = 1121,
		/// <summary><c>CVTTPD2PI mm, xmm/m128</c><br/>
		/// <br/>
		/// <c>66 0F 2C /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvttpd2pi_mm_xmmm128 = 1122,
		/// <summary><c>CVTTSS2SI r32, xmm1/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 2C /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvttss2si_r32_xmmm32 = 1123,
		/// <summary><c>CVTTSS2SI r64, xmm1/m32</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F 2C /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cvttss2si_r64_xmmm32 = 1124,
		/// <summary><c>VCVTTSS2SI r32, xmm1/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvttss2si_r32_xmmm32 = 1125,
		/// <summary><c>VCVTTSS2SI r64, xmm1/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vcvttss2si_r64_xmmm32 = 1126,
		/// <summary><c>VCVTTSS2SI r32, xmm1/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttss2si_r32_xmmm32_sae = 1127,
		/// <summary><c>VCVTTSS2SI r64, xmm1/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvttss2si_r64_xmmm32_sae = 1128,
		/// <summary><c>CVTTSD2SI r32, xmm1/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 2C /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvttsd2si_r32_xmmm64 = 1129,
		/// <summary><c>CVTTSD2SI r64, xmm1/m64</c><br/>
		/// <br/>
		/// <c>F2 REX.W 0F 2C /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cvttsd2si_r64_xmmm64 = 1130,
		/// <summary><c>VCVTTSD2SI r32, xmm1/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvttsd2si_r32_xmmm64 = 1131,
		/// <summary><c>VCVTTSD2SI r64, xmm1/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vcvttsd2si_r64_xmmm64 = 1132,
		/// <summary><c>VCVTTSD2SI r32, xmm1/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttsd2si_r32_xmmm64_sae = 1133,
		/// <summary><c>VCVTTSD2SI r64, xmm1/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvttsd2si_r64_xmmm64_sae = 1134,
		/// <summary><c>CVTPS2PI mm, xmm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 2D /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtps2pi_mm_xmmm64 = 1135,
		/// <summary><c>CVTPD2PI mm, xmm/m128</c><br/>
		/// <br/>
		/// <c>66 0F 2D /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtpd2pi_mm_xmmm128 = 1136,
		/// <summary><c>CVTSS2SI r32, xmm1/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 2D /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtss2si_r32_xmmm32 = 1137,
		/// <summary><c>CVTSS2SI r64, xmm1/m32</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F 2D /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cvtss2si_r64_xmmm32 = 1138,
		/// <summary><c>VCVTSS2SI r32, xmm1/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtss2si_r32_xmmm32 = 1139,
		/// <summary><c>VCVTSS2SI r64, xmm1/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.W1 2D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vcvtss2si_r64_xmmm32 = 1140,
		/// <summary><c>VCVTSS2SI r32, xmm1/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtss2si_r32_xmmm32_er = 1141,
		/// <summary><c>VCVTSS2SI r64, xmm1/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W1 2D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtss2si_r64_xmmm32_er = 1142,
		/// <summary><c>CVTSD2SI r32, xmm1/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 2D /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtsd2si_r32_xmmm64 = 1143,
		/// <summary><c>CVTSD2SI r64, xmm1/m64</c><br/>
		/// <br/>
		/// <c>F2 REX.W 0F 2D /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cvtsd2si_r64_xmmm64 = 1144,
		/// <summary><c>VCVTSD2SI r32, xmm1/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtsd2si_r32_xmmm64 = 1145,
		/// <summary><c>VCVTSD2SI r64, xmm1/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.W1 2D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vcvtsd2si_r64_xmmm64 = 1146,
		/// <summary><c>VCVTSD2SI r32, xmm1/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtsd2si_r32_xmmm64_er = 1147,
		/// <summary><c>VCVTSD2SI r64, xmm1/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 2D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtsd2si_r64_xmmm64_er = 1148,
		/// <summary><c>UCOMISS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 2E /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ucomiss_xmm_xmmm32 = 1149,
		/// <summary><c>VUCOMISS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.0F.WIG 2E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vucomiss_xmm_xmmm32 = 1150,
		/// <summary><c>VUCOMISS xmm1, xmm2/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.0F.W0 2E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vucomiss_xmm_xmmm32_sae = 1151,
		/// <summary><c>UCOMISD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 2E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ucomisd_xmm_xmmm64 = 1152,
		/// <summary><c>VUCOMISD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F.WIG 2E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vucomisd_xmm_xmmm64 = 1153,
		/// <summary><c>VUCOMISD xmm1, xmm2/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F.W1 2E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vucomisd_xmm_xmmm64_sae = 1154,
		/// <summary><c>COMISS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 2F /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Comiss_xmm_xmmm32 = 1155,
		/// <summary><c>COMISD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 2F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Comisd_xmm_xmmm64 = 1156,
		/// <summary><c>VCOMISS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.0F.WIG 2F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcomiss_xmm_xmmm32 = 1157,
		/// <summary><c>VCOMISD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F.WIG 2F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcomisd_xmm_xmmm64 = 1158,
		/// <summary><c>VCOMISS xmm1, xmm2/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.0F.W0 2F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcomiss_xmm_xmmm32_sae = 1159,
		/// <summary><c>VCOMISD xmm1, xmm2/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F.W1 2F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcomisd_xmm_xmmm64_sae = 1160,
		/// <summary><c>WRMSR</c><br/>
		/// <br/>
		/// <c>0F 30</c><br/>
		/// <br/>
		/// <c>MSR</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wrmsr = 1161,
		/// <summary><c>RDTSC</c><br/>
		/// <br/>
		/// <c>0F 31</c><br/>
		/// <br/>
		/// <c>TSC</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdtsc = 1162,
		/// <summary><c>RDMSR</c><br/>
		/// <br/>
		/// <c>0F 32</c><br/>
		/// <br/>
		/// <c>MSR</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdmsr = 1163,
		/// <summary><c>RDPMC</c><br/>
		/// <br/>
		/// <c>0F 33</c><br/>
		/// <br/>
		/// <c>Pentium MMX or later, or Pentium Pro or later</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdpmc = 1164,
		/// <summary><c>SYSENTER</c><br/>
		/// <br/>
		/// <c>0F 34</c><br/>
		/// <br/>
		/// <c>SEP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sysenter = 1165,
		/// <summary><c>SYSEXIT</c><br/>
		/// <br/>
		/// <c>0F 35</c><br/>
		/// <br/>
		/// <c>SEP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sysexitd = 1166,
		/// <summary><c>SYSEXIT</c><br/>
		/// <br/>
		/// <c>REX.W 0F 35</c><br/>
		/// <br/>
		/// <c>SEP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Sysexitq = 1167,
		/// <summary><c>GETSEC</c><br/>
		/// <br/>
		/// <c>NP 0F 37</c><br/>
		/// <br/>
		/// <c>SMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Getsec = 1168,
		/// <summary><c>CMOVO r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 40 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovo_r16_rm16 = 1169,
		/// <summary><c>CMOVO r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 40 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovo_r32_rm32 = 1170,
		/// <summary><c>CMOVO r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 40 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovo_r64_rm64 = 1171,
		/// <summary><c>CMOVNO r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 41 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovno_r16_rm16 = 1172,
		/// <summary><c>CMOVNO r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 41 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovno_r32_rm32 = 1173,
		/// <summary><c>CMOVNO r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 41 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovno_r64_rm64 = 1174,
		/// <summary><c>CMOVB r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 42 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovb_r16_rm16 = 1175,
		/// <summary><c>CMOVB r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 42 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovb_r32_rm32 = 1176,
		/// <summary><c>CMOVB r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 42 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovb_r64_rm64 = 1177,
		/// <summary><c>CMOVAE r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 43 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovae_r16_rm16 = 1178,
		/// <summary><c>CMOVAE r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 43 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovae_r32_rm32 = 1179,
		/// <summary><c>CMOVAE r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 43 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovae_r64_rm64 = 1180,
		/// <summary><c>CMOVE r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 44 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmove_r16_rm16 = 1181,
		/// <summary><c>CMOVE r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 44 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmove_r32_rm32 = 1182,
		/// <summary><c>CMOVE r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 44 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmove_r64_rm64 = 1183,
		/// <summary><c>CMOVNE r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 45 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovne_r16_rm16 = 1184,
		/// <summary><c>CMOVNE r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 45 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovne_r32_rm32 = 1185,
		/// <summary><c>CMOVNE r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 45 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovne_r64_rm64 = 1186,
		/// <summary><c>CMOVBE r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 46 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovbe_r16_rm16 = 1187,
		/// <summary><c>CMOVBE r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 46 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovbe_r32_rm32 = 1188,
		/// <summary><c>CMOVBE r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 46 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovbe_r64_rm64 = 1189,
		/// <summary><c>CMOVA r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 47 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmova_r16_rm16 = 1190,
		/// <summary><c>CMOVA r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 47 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmova_r32_rm32 = 1191,
		/// <summary><c>CMOVA r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 47 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmova_r64_rm64 = 1192,
		/// <summary><c>CMOVS r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 48 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovs_r16_rm16 = 1193,
		/// <summary><c>CMOVS r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 48 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovs_r32_rm32 = 1194,
		/// <summary><c>CMOVS r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 48 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovs_r64_rm64 = 1195,
		/// <summary><c>CMOVNS r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 49 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovns_r16_rm16 = 1196,
		/// <summary><c>CMOVNS r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 49 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovns_r32_rm32 = 1197,
		/// <summary><c>CMOVNS r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 49 /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovns_r64_rm64 = 1198,
		/// <summary><c>CMOVP r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 4A /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovp_r16_rm16 = 1199,
		/// <summary><c>CMOVP r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 4A /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovp_r32_rm32 = 1200,
		/// <summary><c>CMOVP r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 4A /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovp_r64_rm64 = 1201,
		/// <summary><c>CMOVNP r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 4B /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovnp_r16_rm16 = 1202,
		/// <summary><c>CMOVNP r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 4B /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovnp_r32_rm32 = 1203,
		/// <summary><c>CMOVNP r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 4B /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovnp_r64_rm64 = 1204,
		/// <summary><c>CMOVL r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 4C /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovl_r16_rm16 = 1205,
		/// <summary><c>CMOVL r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 4C /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovl_r32_rm32 = 1206,
		/// <summary><c>CMOVL r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 4C /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovl_r64_rm64 = 1207,
		/// <summary><c>CMOVGE r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 4D /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovge_r16_rm16 = 1208,
		/// <summary><c>CMOVGE r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 4D /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovge_r32_rm32 = 1209,
		/// <summary><c>CMOVGE r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 4D /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovge_r64_rm64 = 1210,
		/// <summary><c>CMOVLE r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 4E /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovle_r16_rm16 = 1211,
		/// <summary><c>CMOVLE r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 4E /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovle_r32_rm32 = 1212,
		/// <summary><c>CMOVLE r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 4E /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovle_r64_rm64 = 1213,
		/// <summary><c>CMOVG r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F 4F /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovg_r16_rm16 = 1214,
		/// <summary><c>CMOVG r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F 4F /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmovg_r32_rm32 = 1215,
		/// <summary><c>CMOVG r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 4F /r</c><br/>
		/// <br/>
		/// <c>CMOV</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmovg_r64_rm64 = 1216,
		/// <summary><c>KANDW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 41 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandw_k_k_k = 1217,
		/// <summary><c>KANDQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 41 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandq_k_k_k = 1218,
		/// <summary><c>KANDB k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 41 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandb_k_k_k = 1219,
		/// <summary><c>KANDD k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W1 41 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandd_k_k_k = 1220,
		/// <summary><c>KANDNW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandnw_k_k_k = 1221,
		/// <summary><c>KANDNQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandnq_k_k_k = 1222,
		/// <summary><c>KANDNB k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandnb_k_k_k = 1223,
		/// <summary><c>KANDND k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W1 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kandnd_k_k_k = 1224,
		/// <summary><c>KNOTW k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Knotw_k_k = 1225,
		/// <summary><c>KNOTQ k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W1 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Knotq_k_k = 1226,
		/// <summary><c>KNOTB k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Knotb_k_k = 1227,
		/// <summary><c>KNOTD k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W1 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Knotd_k_k = 1228,
		/// <summary><c>KORW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Korw_k_k_k = 1229,
		/// <summary><c>KORQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Korq_k_k_k = 1230,
		/// <summary><c>KORB k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Korb_k_k_k = 1231,
		/// <summary><c>KORD k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kord_k_k_k = 1232,
		/// <summary><c>KXNORW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxnorw_k_k_k = 1233,
		/// <summary><c>KXNORQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxnorq_k_k_k = 1234,
		/// <summary><c>KXNORB k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxnorb_k_k_k = 1235,
		/// <summary><c>KXNORD k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W1 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxnord_k_k_k = 1236,
		/// <summary><c>KXORW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxorw_k_k_k = 1237,
		/// <summary><c>KXORQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxorq_k_k_k = 1238,
		/// <summary><c>KXORB k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxorb_k_k_k = 1239,
		/// <summary><c>KXORD k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kxord_k_k_k = 1240,
		/// <summary><c>KADDW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 4A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kaddw_k_k_k = 1241,
		/// <summary><c>KADDQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 4A /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kaddq_k_k_k = 1242,
		/// <summary><c>KADDB k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 4A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kaddb_k_k_k = 1243,
		/// <summary><c>KADDD k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W1 4A /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kaddd_k_k_k = 1244,
		/// <summary><c>KUNPCKWD k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W0 4B /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kunpckwd_k_k_k = 1245,
		/// <summary><c>KUNPCKDQ k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.0F.W1 4B /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kunpckdq_k_k_k = 1246,
		/// <summary><c>KUNPCKBW k1, k2, k3</c><br/>
		/// <br/>
		/// <c>VEX.L1.66.0F.W0 4B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kunpckbw_k_k_k = 1247,
		/// <summary><c>MOVMSKPS r32, xmm</c><br/>
		/// <br/>
		/// <c>NP 0F 50 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movmskps_r32_xmm = 1248,
		/// <summary><c>MOVMSKPS r64, xmm</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F 50 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movmskps_r64_xmm = 1249,
		/// <summary><c>VMOVMSKPS r32, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovmskps_r32_xmm = 1250,
		/// <summary><c>VMOVMSKPS r64, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.W1 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vmovmskps_r64_xmm = 1251,
		/// <summary><c>VMOVMSKPS r32, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovmskps_r32_ymm = 1252,
		/// <summary><c>VMOVMSKPS r64, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.W1 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vmovmskps_r64_ymm = 1253,
		/// <summary><c>MOVMSKPD r32, xmm</c><br/>
		/// <br/>
		/// <c>66 0F 50 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movmskpd_r32_xmm = 1254,
		/// <summary><c>MOVMSKPD r64, xmm</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 50 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movmskpd_r64_xmm = 1255,
		/// <summary><c>VMOVMSKPD r32, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovmskpd_r32_xmm = 1256,
		/// <summary><c>VMOVMSKPD r64, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W1 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vmovmskpd_r64_xmm = 1257,
		/// <summary><c>VMOVMSKPD r32, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovmskpd_r32_ymm = 1258,
		/// <summary><c>VMOVMSKPD r64, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.W1 50 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vmovmskpd_r64_ymm = 1259,
		/// <summary><c>SQRTPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 51 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sqrtps_xmm_xmmm128 = 1260,
		/// <summary><c>VSQRTPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 51 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsqrtps_xmm_xmmm128 = 1261,
		/// <summary><c>VSQRTPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 51 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsqrtps_ymm_ymmm256 = 1262,
		/// <summary><c>VSQRTPS xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtps_xmm_k1z_xmmm128b32 = 1263,
		/// <summary><c>VSQRTPS ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtps_ymm_k1z_ymmm256b32 = 1264,
		/// <summary><c>VSQRTPS zmm1 {k1}{z}, zmm2/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtps_zmm_k1z_zmmm512b32_er = 1265,
		/// <summary><c>SQRTPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 51 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sqrtpd_xmm_xmmm128 = 1266,
		/// <summary><c>VSQRTPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 51 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsqrtpd_xmm_xmmm128 = 1267,
		/// <summary><c>VSQRTPD ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 51 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsqrtpd_ymm_ymmm256 = 1268,
		/// <summary><c>VSQRTPD xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtpd_xmm_k1z_xmmm128b64 = 1269,
		/// <summary><c>VSQRTPD ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtpd_ymm_k1z_ymmm256b64 = 1270,
		/// <summary><c>VSQRTPD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtpd_zmm_k1z_zmmm512b64_er = 1271,
		/// <summary><c>SQRTSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 51 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sqrtss_xmm_xmmm32 = 1272,
		/// <summary><c>VSQRTSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 51 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsqrtss_xmm_xmm_xmmm32 = 1273,
		/// <summary><c>VSQRTSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtss_xmm_k1z_xmm_xmmm32_er = 1274,
		/// <summary><c>SQRTSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 51 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sqrtsd_xmm_xmmm64 = 1275,
		/// <summary><c>VSQRTSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 51 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsqrtsd_xmm_xmm_xmmm64 = 1276,
		/// <summary><c>VSQRTSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsqrtsd_xmm_k1z_xmm_xmmm64_er = 1277,
		/// <summary><c>RSQRTPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 52 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rsqrtps_xmm_xmmm128 = 1278,
		/// <summary><c>VRSQRTPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 52 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vrsqrtps_xmm_xmmm128 = 1279,
		/// <summary><c>VRSQRTPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 52 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vrsqrtps_ymm_ymmm256 = 1280,
		/// <summary><c>RSQRTSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 52 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rsqrtss_xmm_xmmm32 = 1281,
		/// <summary><c>VRSQRTSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 52 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vrsqrtss_xmm_xmm_xmmm32 = 1282,
		/// <summary><c>RCPPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 53 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcpps_xmm_xmmm128 = 1283,
		/// <summary><c>VRCPPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 53 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vrcpps_xmm_xmmm128 = 1284,
		/// <summary><c>VRCPPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 53 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vrcpps_ymm_ymmm256 = 1285,
		/// <summary><c>RCPSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 53 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rcpss_xmm_xmmm32 = 1286,
		/// <summary><c>VRCPSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 53 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vrcpss_xmm_xmm_xmmm32 = 1287,
		/// <summary><c>ANDPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 54 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Andps_xmm_xmmm128 = 1288,
		/// <summary><c>VANDPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 54 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandps_xmm_xmm_xmmm128 = 1289,
		/// <summary><c>VANDPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 54 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandps_ymm_ymm_ymmm256 = 1290,
		/// <summary><c>VANDPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandps_xmm_k1z_xmm_xmmm128b32 = 1291,
		/// <summary><c>VANDPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandps_ymm_k1z_ymm_ymmm256b32 = 1292,
		/// <summary><c>VANDPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandps_zmm_k1z_zmm_zmmm512b32 = 1293,
		/// <summary><c>ANDPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 54 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Andpd_xmm_xmmm128 = 1294,
		/// <summary><c>VANDPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 54 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandpd_xmm_xmm_xmmm128 = 1295,
		/// <summary><c>VANDPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 54 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandpd_ymm_ymm_ymmm256 = 1296,
		/// <summary><c>VANDPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandpd_xmm_k1z_xmm_xmmm128b64 = 1297,
		/// <summary><c>VANDPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandpd_ymm_k1z_ymm_ymmm256b64 = 1298,
		/// <summary><c>VANDPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandpd_zmm_k1z_zmm_zmmm512b64 = 1299,
		/// <summary><c>ANDNPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 55 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Andnps_xmm_xmmm128 = 1300,
		/// <summary><c>VANDNPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 55 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandnps_xmm_xmm_xmmm128 = 1301,
		/// <summary><c>VANDNPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 55 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandnps_ymm_ymm_ymmm256 = 1302,
		/// <summary><c>VANDNPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandnps_xmm_k1z_xmm_xmmm128b32 = 1303,
		/// <summary><c>VANDNPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandnps_ymm_k1z_ymm_ymmm256b32 = 1304,
		/// <summary><c>VANDNPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandnps_zmm_k1z_zmm_zmmm512b32 = 1305,
		/// <summary><c>ANDNPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 55 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Andnpd_xmm_xmmm128 = 1306,
		/// <summary><c>VANDNPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 55 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandnpd_xmm_xmm_xmmm128 = 1307,
		/// <summary><c>VANDNPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 55 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vandnpd_ymm_ymm_ymmm256 = 1308,
		/// <summary><c>VANDNPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandnpd_xmm_k1z_xmm_xmmm128b64 = 1309,
		/// <summary><c>VANDNPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandnpd_ymm_k1z_ymm_ymmm256b64 = 1310,
		/// <summary><c>VANDNPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vandnpd_zmm_k1z_zmm_zmmm512b64 = 1311,
		/// <summary><c>ORPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 56 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Orps_xmm_xmmm128 = 1312,
		/// <summary><c>VORPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 56 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vorps_xmm_xmm_xmmm128 = 1313,
		/// <summary><c>VORPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 56 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vorps_ymm_ymm_ymmm256 = 1314,
		/// <summary><c>VORPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 56 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vorps_xmm_k1z_xmm_xmmm128b32 = 1315,
		/// <summary><c>VORPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 56 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vorps_ymm_k1z_ymm_ymmm256b32 = 1316,
		/// <summary><c>VORPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 56 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vorps_zmm_k1z_zmm_zmmm512b32 = 1317,
		/// <summary><c>ORPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 56 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Orpd_xmm_xmmm128 = 1318,
		/// <summary><c>VORPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 56 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vorpd_xmm_xmm_xmmm128 = 1319,
		/// <summary><c>VORPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 56 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vorpd_ymm_ymm_ymmm256 = 1320,
		/// <summary><c>VORPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 56 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vorpd_xmm_k1z_xmm_xmmm128b64 = 1321,
		/// <summary><c>VORPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 56 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vorpd_ymm_k1z_ymm_ymmm256b64 = 1322,
		/// <summary><c>VORPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 56 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vorpd_zmm_k1z_zmm_zmmm512b64 = 1323,
		/// <summary><c>XORPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 57 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xorps_xmm_xmmm128 = 1324,
		/// <summary><c>VXORPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 57 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vxorps_xmm_xmm_xmmm128 = 1325,
		/// <summary><c>VXORPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 57 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vxorps_ymm_ymm_ymmm256 = 1326,
		/// <summary><c>VXORPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 57 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vxorps_xmm_k1z_xmm_xmmm128b32 = 1327,
		/// <summary><c>VXORPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 57 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vxorps_ymm_k1z_ymm_ymmm256b32 = 1328,
		/// <summary><c>VXORPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 57 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vxorps_zmm_k1z_zmm_zmmm512b32 = 1329,
		/// <summary><c>XORPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 57 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xorpd_xmm_xmmm128 = 1330,
		/// <summary><c>VXORPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 57 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vxorpd_xmm_xmm_xmmm128 = 1331,
		/// <summary><c>VXORPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 57 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vxorpd_ymm_ymm_ymmm256 = 1332,
		/// <summary><c>VXORPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 57 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vxorpd_xmm_k1z_xmm_xmmm128b64 = 1333,
		/// <summary><c>VXORPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 57 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vxorpd_ymm_k1z_ymm_ymmm256b64 = 1334,
		/// <summary><c>VXORPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 57 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vxorpd_zmm_k1z_zmm_zmmm512b64 = 1335,
		/// <summary><c>ADDPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 58 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Addps_xmm_xmmm128 = 1336,
		/// <summary><c>VADDPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 58 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddps_xmm_xmm_xmmm128 = 1337,
		/// <summary><c>VADDPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 58 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddps_ymm_ymm_ymmm256 = 1338,
		/// <summary><c>VADDPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddps_xmm_k1z_xmm_xmmm128b32 = 1339,
		/// <summary><c>VADDPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddps_ymm_k1z_ymm_ymmm256b32 = 1340,
		/// <summary><c>VADDPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddps_zmm_k1z_zmm_zmmm512b32_er = 1341,
		/// <summary><c>ADDPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 58 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Addpd_xmm_xmmm128 = 1342,
		/// <summary><c>VADDPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 58 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddpd_xmm_xmm_xmmm128 = 1343,
		/// <summary><c>VADDPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 58 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddpd_ymm_ymm_ymmm256 = 1344,
		/// <summary><c>VADDPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddpd_xmm_k1z_xmm_xmmm128b64 = 1345,
		/// <summary><c>VADDPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddpd_ymm_k1z_ymm_ymmm256b64 = 1346,
		/// <summary><c>VADDPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddpd_zmm_k1z_zmm_zmmm512b64_er = 1347,
		/// <summary><c>ADDSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 58 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Addss_xmm_xmmm32 = 1348,
		/// <summary><c>VADDSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 58 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddss_xmm_xmm_xmmm32 = 1349,
		/// <summary><c>VADDSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddss_xmm_k1z_xmm_xmmm32_er = 1350,
		/// <summary><c>ADDSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 58 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Addsd_xmm_xmmm64 = 1351,
		/// <summary><c>VADDSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 58 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddsd_xmm_xmm_xmmm64 = 1352,
		/// <summary><c>VADDSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaddsd_xmm_k1z_xmm_xmmm64_er = 1353,
		/// <summary><c>MULPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 59 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mulps_xmm_xmmm128 = 1354,
		/// <summary><c>VMULPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 59 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmulps_xmm_xmm_xmmm128 = 1355,
		/// <summary><c>VMULPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 59 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmulps_ymm_ymm_ymmm256 = 1356,
		/// <summary><c>VMULPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulps_xmm_k1z_xmm_xmmm128b32 = 1357,
		/// <summary><c>VMULPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulps_ymm_k1z_ymm_ymmm256b32 = 1358,
		/// <summary><c>VMULPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulps_zmm_k1z_zmm_zmmm512b32_er = 1359,
		/// <summary><c>MULPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 59 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mulpd_xmm_xmmm128 = 1360,
		/// <summary><c>VMULPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 59 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmulpd_xmm_xmm_xmmm128 = 1361,
		/// <summary><c>VMULPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 59 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmulpd_ymm_ymm_ymmm256 = 1362,
		/// <summary><c>VMULPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulpd_xmm_k1z_xmm_xmmm128b64 = 1363,
		/// <summary><c>VMULPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulpd_ymm_k1z_ymm_ymmm256b64 = 1364,
		/// <summary><c>VMULPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulpd_zmm_k1z_zmm_zmmm512b64_er = 1365,
		/// <summary><c>MULSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 59 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mulss_xmm_xmmm32 = 1366,
		/// <summary><c>VMULSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 59 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmulss_xmm_xmm_xmmm32 = 1367,
		/// <summary><c>VMULSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulss_xmm_k1z_xmm_xmmm32_er = 1368,
		/// <summary><c>MULSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 59 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mulsd_xmm_xmmm64 = 1369,
		/// <summary><c>VMULSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 59 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmulsd_xmm_xmm_xmmm64 = 1370,
		/// <summary><c>VMULSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmulsd_xmm_k1z_xmm_xmmm64_er = 1371,
		/// <summary><c>CVTPS2PD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 5A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtps2pd_xmm_xmmm64 = 1372,
		/// <summary><c>VCVTPS2PD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 5A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtps2pd_xmm_xmmm64 = 1373,
		/// <summary><c>VCVTPS2PD ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 5A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtps2pd_ymm_xmmm128 = 1374,
		/// <summary><c>VCVTPS2PD xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2pd_xmm_k1z_xmmm64b32 = 1375,
		/// <summary><c>VCVTPS2PD ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2pd_ymm_k1z_xmmm128b32 = 1376,
		/// <summary><c>VCVTPS2PD zmm1 {k1}{z}, ymm2/m256/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2pd_zmm_k1z_ymmm256b32_sae = 1377,
		/// <summary><c>CVTPD2PS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 5A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtpd2ps_xmm_xmmm128 = 1378,
		/// <summary><c>VCVTPD2PS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 5A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtpd2ps_xmm_xmmm128 = 1379,
		/// <summary><c>VCVTPD2PS xmm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 5A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtpd2ps_xmm_ymmm256 = 1380,
		/// <summary><c>VCVTPD2PS xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2ps_xmm_k1z_xmmm128b64 = 1381,
		/// <summary><c>VCVTPD2PS xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2ps_xmm_k1z_ymmm256b64 = 1382,
		/// <summary><c>VCVTPD2PS ymm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2ps_ymm_k1z_zmmm512b64_er = 1383,
		/// <summary><c>CVTSS2SD xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 5A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtss2sd_xmm_xmmm32 = 1384,
		/// <summary><c>VCVTSS2SD xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 5A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtss2sd_xmm_xmm_xmmm32 = 1385,
		/// <summary><c>VCVTSS2SD xmm1 {k1}{z}, xmm2, xmm3/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtss2sd_xmm_k1z_xmm_xmmm32_sae = 1386,
		/// <summary><c>CVTSD2SS xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 5A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtsd2ss_xmm_xmmm64 = 1387,
		/// <summary><c>VCVTSD2SS xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 5A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtsd2ss_xmm_xmm_xmmm64 = 1388,
		/// <summary><c>VCVTSD2SS xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtsd2ss_xmm_k1z_xmm_xmmm64_er = 1389,
		/// <summary><c>CVTDQ2PS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 5B /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtdq2ps_xmm_xmmm128 = 1390,
		/// <summary><c>VCVTDQ2PS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 5B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtdq2ps_xmm_xmmm128 = 1391,
		/// <summary><c>VCVTDQ2PS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 5B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtdq2ps_ymm_ymmm256 = 1392,
		/// <summary><c>VCVTDQ2PS xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtdq2ps_xmm_k1z_xmmm128b32 = 1393,
		/// <summary><c>VCVTDQ2PS ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtdq2ps_ymm_k1z_ymmm256b32 = 1394,
		/// <summary><c>VCVTDQ2PS zmm1 {k1}{z}, zmm2/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtdq2ps_zmm_k1z_zmmm512b32_er = 1395,
		/// <summary><c>VCVTQQ2PS xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W1 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtqq2ps_xmm_k1z_xmmm128b64 = 1396,
		/// <summary><c>VCVTQQ2PS xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W1 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtqq2ps_xmm_k1z_ymmm256b64 = 1397,
		/// <summary><c>VCVTQQ2PS ymm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W1 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtqq2ps_ymm_k1z_zmmm512b64_er = 1398,
		/// <summary><c>CVTPS2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 5B /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtps2dq_xmm_xmmm128 = 1399,
		/// <summary><c>VCVTPS2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 5B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtps2dq_xmm_xmmm128 = 1400,
		/// <summary><c>VCVTPS2DQ ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 5B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtps2dq_ymm_ymmm256 = 1401,
		/// <summary><c>VCVTPS2DQ xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2dq_xmm_k1z_xmmm128b32 = 1402,
		/// <summary><c>VCVTPS2DQ ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2dq_ymm_k1z_ymmm256b32 = 1403,
		/// <summary><c>VCVTPS2DQ zmm1 {k1}{z}, zmm2/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2dq_zmm_k1z_zmmm512b32_er = 1404,
		/// <summary><c>CVTTPS2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F3 0F 5B /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvttps2dq_xmm_xmmm128 = 1405,
		/// <summary><c>VCVTTPS2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 5B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvttps2dq_xmm_xmmm128 = 1406,
		/// <summary><c>VCVTTPS2DQ ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG 5B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvttps2dq_ymm_ymmm256 = 1407,
		/// <summary><c>VCVTTPS2DQ xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2dq_xmm_k1z_xmmm128b32 = 1408,
		/// <summary><c>VCVTTPS2DQ ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2dq_ymm_k1z_ymmm256b32 = 1409,
		/// <summary><c>VCVTTPS2DQ zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2dq_zmm_k1z_zmmm512b32_sae = 1410,
		/// <summary><c>SUBPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 5C /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Subps_xmm_xmmm128 = 1411,
		/// <summary><c>VSUBPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 5C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsubps_xmm_xmm_xmmm128 = 1412,
		/// <summary><c>VSUBPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 5C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsubps_ymm_ymm_ymmm256 = 1413,
		/// <summary><c>VSUBPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubps_xmm_k1z_xmm_xmmm128b32 = 1414,
		/// <summary><c>VSUBPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubps_ymm_k1z_ymm_ymmm256b32 = 1415,
		/// <summary><c>VSUBPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubps_zmm_k1z_zmm_zmmm512b32_er = 1416,
		/// <summary><c>SUBPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 5C /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Subpd_xmm_xmmm128 = 1417,
		/// <summary><c>VSUBPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 5C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsubpd_xmm_xmm_xmmm128 = 1418,
		/// <summary><c>VSUBPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 5C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsubpd_ymm_ymm_ymmm256 = 1419,
		/// <summary><c>VSUBPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubpd_xmm_k1z_xmm_xmmm128b64 = 1420,
		/// <summary><c>VSUBPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubpd_ymm_k1z_ymm_ymmm256b64 = 1421,
		/// <summary><c>VSUBPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubpd_zmm_k1z_zmm_zmmm512b64_er = 1422,
		/// <summary><c>SUBSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 5C /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Subss_xmm_xmmm32 = 1423,
		/// <summary><c>VSUBSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 5C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsubss_xmm_xmm_xmmm32 = 1424,
		/// <summary><c>VSUBSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubss_xmm_k1z_xmm_xmmm32_er = 1425,
		/// <summary><c>SUBSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 5C /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Subsd_xmm_xmmm64 = 1426,
		/// <summary><c>VSUBSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 5C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vsubsd_xmm_xmm_xmmm64 = 1427,
		/// <summary><c>VSUBSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 5C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vsubsd_xmm_k1z_xmm_xmmm64_er = 1428,
		/// <summary><c>MINPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 5D /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Minps_xmm_xmmm128 = 1429,
		/// <summary><c>VMINPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 5D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vminps_xmm_xmm_xmmm128 = 1430,
		/// <summary><c>VMINPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 5D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vminps_ymm_ymm_ymmm256 = 1431,
		/// <summary><c>VMINPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminps_xmm_k1z_xmm_xmmm128b32 = 1432,
		/// <summary><c>VMINPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminps_ymm_k1z_ymm_ymmm256b32 = 1433,
		/// <summary><c>VMINPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminps_zmm_k1z_zmm_zmmm512b32_sae = 1434,
		/// <summary><c>MINPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 5D /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Minpd_xmm_xmmm128 = 1435,
		/// <summary><c>VMINPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 5D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vminpd_xmm_xmm_xmmm128 = 1436,
		/// <summary><c>VMINPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 5D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vminpd_ymm_ymm_ymmm256 = 1437,
		/// <summary><c>VMINPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminpd_xmm_k1z_xmm_xmmm128b64 = 1438,
		/// <summary><c>VMINPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminpd_ymm_k1z_ymm_ymmm256b64 = 1439,
		/// <summary><c>VMINPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminpd_zmm_k1z_zmm_zmmm512b64_sae = 1440,
		/// <summary><c>MINSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 5D /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Minss_xmm_xmmm32 = 1441,
		/// <summary><c>VMINSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 5D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vminss_xmm_xmm_xmmm32 = 1442,
		/// <summary><c>VMINSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminss_xmm_k1z_xmm_xmmm32_sae = 1443,
		/// <summary><c>MINSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 5D /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Minsd_xmm_xmmm64 = 1444,
		/// <summary><c>VMINSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 5D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vminsd_xmm_xmm_xmmm64 = 1445,
		/// <summary><c>VMINSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 5D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vminsd_xmm_k1z_xmm_xmmm64_sae = 1446,
		/// <summary><c>DIVPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 5E /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Divps_xmm_xmmm128 = 1447,
		/// <summary><c>VDIVPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 5E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdivps_xmm_xmm_xmmm128 = 1448,
		/// <summary><c>VDIVPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 5E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdivps_ymm_ymm_ymmm256 = 1449,
		/// <summary><c>VDIVPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivps_xmm_k1z_xmm_xmmm128b32 = 1450,
		/// <summary><c>VDIVPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivps_ymm_k1z_ymm_ymmm256b32 = 1451,
		/// <summary><c>VDIVPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivps_zmm_k1z_zmm_zmmm512b32_er = 1452,
		/// <summary><c>DIVPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 5E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Divpd_xmm_xmmm128 = 1453,
		/// <summary><c>VDIVPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 5E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdivpd_xmm_xmm_xmmm128 = 1454,
		/// <summary><c>VDIVPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 5E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdivpd_ymm_ymm_ymmm256 = 1455,
		/// <summary><c>VDIVPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivpd_xmm_k1z_xmm_xmmm128b64 = 1456,
		/// <summary><c>VDIVPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivpd_ymm_k1z_ymm_ymmm256b64 = 1457,
		/// <summary><c>VDIVPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivpd_zmm_k1z_zmm_zmmm512b64_er = 1458,
		/// <summary><c>DIVSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 5E /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Divss_xmm_xmmm32 = 1459,
		/// <summary><c>VDIVSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 5E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdivss_xmm_xmm_xmmm32 = 1460,
		/// <summary><c>VDIVSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivss_xmm_k1z_xmm_xmmm32_er = 1461,
		/// <summary><c>DIVSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 5E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Divsd_xmm_xmmm64 = 1462,
		/// <summary><c>VDIVSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 5E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdivsd_xmm_xmm_xmmm64 = 1463,
		/// <summary><c>VDIVSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 5E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdivsd_xmm_k1z_xmm_xmmm64_er = 1464,
		/// <summary><c>MAXPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 5F /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Maxps_xmm_xmmm128 = 1465,
		/// <summary><c>VMAXPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 5F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaxps_xmm_xmm_xmmm128 = 1466,
		/// <summary><c>VMAXPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 5F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaxps_ymm_ymm_ymmm256 = 1467,
		/// <summary><c>VMAXPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxps_xmm_k1z_xmm_xmmm128b32 = 1468,
		/// <summary><c>VMAXPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxps_ymm_k1z_ymm_ymmm256b32 = 1469,
		/// <summary><c>VMAXPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxps_zmm_k1z_zmm_zmmm512b32_sae = 1470,
		/// <summary><c>MAXPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 5F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Maxpd_xmm_xmmm128 = 1471,
		/// <summary><c>VMAXPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 5F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaxpd_xmm_xmm_xmmm128 = 1472,
		/// <summary><c>VMAXPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 5F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaxpd_ymm_ymm_ymmm256 = 1473,
		/// <summary><c>VMAXPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxpd_xmm_k1z_xmm_xmmm128b64 = 1474,
		/// <summary><c>VMAXPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxpd_ymm_k1z_ymm_ymmm256b64 = 1475,
		/// <summary><c>VMAXPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxpd_zmm_k1z_zmm_zmmm512b64_sae = 1476,
		/// <summary><c>MAXSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 5F /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Maxss_xmm_xmmm32 = 1477,
		/// <summary><c>VMAXSS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG 5F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaxss_xmm_xmm_xmmm32 = 1478,
		/// <summary><c>VMAXSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxss_xmm_k1z_xmm_xmmm32_sae = 1479,
		/// <summary><c>MAXSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F2 0F 5F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Maxsd_xmm_xmmm64 = 1480,
		/// <summary><c>VMAXSD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG 5F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaxsd_xmm_xmm_xmmm64 = 1481,
		/// <summary><c>VMAXSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 5F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmaxsd_xmm_k1z_xmm_xmmm64_sae = 1482,
		/// <summary><c>PUNPCKLBW mm, mm/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 60 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpcklbw_mm_mmm32 = 1483,
		/// <summary><c>PUNPCKLBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 60 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpcklbw_xmm_xmmm128 = 1484,
		/// <summary><c>VPUNPCKLBW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 60 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpcklbw_xmm_xmm_xmmm128 = 1485,
		/// <summary><c>VPUNPCKLBW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 60 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpcklbw_ymm_ymm_ymmm256 = 1486,
		/// <summary><c>VPUNPCKLBW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 60 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklbw_xmm_k1z_xmm_xmmm128 = 1487,
		/// <summary><c>VPUNPCKLBW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 60 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklbw_ymm_k1z_ymm_ymmm256 = 1488,
		/// <summary><c>VPUNPCKLBW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 60 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklbw_zmm_k1z_zmm_zmmm512 = 1489,
		/// <summary><c>PUNPCKLWD mm, mm/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 61 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpcklwd_mm_mmm32 = 1490,
		/// <summary><c>PUNPCKLWD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 61 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpcklwd_xmm_xmmm128 = 1491,
		/// <summary><c>VPUNPCKLWD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 61 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpcklwd_xmm_xmm_xmmm128 = 1492,
		/// <summary><c>VPUNPCKLWD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 61 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpcklwd_ymm_ymm_ymmm256 = 1493,
		/// <summary><c>VPUNPCKLWD xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 61 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklwd_xmm_k1z_xmm_xmmm128 = 1494,
		/// <summary><c>VPUNPCKLWD ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 61 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklwd_ymm_k1z_ymm_ymmm256 = 1495,
		/// <summary><c>VPUNPCKLWD zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 61 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklwd_zmm_k1z_zmm_zmmm512 = 1496,
		/// <summary><c>PUNPCKLDQ mm, mm/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 62 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckldq_mm_mmm32 = 1497,
		/// <summary><c>PUNPCKLDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 62 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckldq_xmm_xmmm128 = 1498,
		/// <summary><c>VPUNPCKLDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 62 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckldq_xmm_xmm_xmmm128 = 1499,
		/// <summary><c>VPUNPCKLDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 62 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckldq_ymm_ymm_ymmm256 = 1500,
		/// <summary><c>VPUNPCKLDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckldq_xmm_k1z_xmm_xmmm128b32 = 1501,
		/// <summary><c>VPUNPCKLDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckldq_ymm_k1z_ymm_ymmm256b32 = 1502,
		/// <summary><c>VPUNPCKLDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckldq_zmm_k1z_zmm_zmmm512b32 = 1503,
		/// <summary><c>PACKSSWB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 63 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packsswb_mm_mmm64 = 1504,
		/// <summary><c>PACKSSWB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 63 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packsswb_xmm_xmmm128 = 1505,
		/// <summary><c>VPACKSSWB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 63 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpacksswb_xmm_xmm_xmmm128 = 1506,
		/// <summary><c>VPACKSSWB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 63 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpacksswb_ymm_ymm_ymmm256 = 1507,
		/// <summary><c>VPACKSSWB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpacksswb_xmm_k1z_xmm_xmmm128 = 1508,
		/// <summary><c>VPACKSSWB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpacksswb_ymm_k1z_ymm_ymmm256 = 1509,
		/// <summary><c>VPACKSSWB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpacksswb_zmm_k1z_zmm_zmmm512 = 1510,
		/// <summary><c>PCMPGTB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 64 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtb_mm_mmm64 = 1511,
		/// <summary><c>PCMPGTB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 64 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtb_xmm_xmmm128 = 1512,
		/// <summary><c>VPCMPGTB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 64 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtb_xmm_xmm_xmmm128 = 1513,
		/// <summary><c>VPCMPGTB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 64 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtb_ymm_ymm_ymmm256 = 1514,
		/// <summary><c>VPCMPGTB k1 {k2}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtb_k_k1_xmm_xmmm128 = 1515,
		/// <summary><c>VPCMPGTB k1 {k2}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtb_k_k1_ymm_ymmm256 = 1516,
		/// <summary><c>VPCMPGTB k1 {k2}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtb_k_k1_zmm_zmmm512 = 1517,
		/// <summary><c>PCMPGTW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 65 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtw_mm_mmm64 = 1518,
		/// <summary><c>PCMPGTW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 65 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtw_xmm_xmmm128 = 1519,
		/// <summary><c>VPCMPGTW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 65 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtw_xmm_xmm_xmmm128 = 1520,
		/// <summary><c>VPCMPGTW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 65 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtw_ymm_ymm_ymmm256 = 1521,
		/// <summary><c>VPCMPGTW k1 {k2}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtw_k_k1_xmm_xmmm128 = 1522,
		/// <summary><c>VPCMPGTW k1 {k2}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtw_k_k1_ymm_ymmm256 = 1523,
		/// <summary><c>VPCMPGTW k1 {k2}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtw_k_k1_zmm_zmmm512 = 1524,
		/// <summary><c>PCMPGTD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 66 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtd_mm_mmm64 = 1525,
		/// <summary><c>PCMPGTD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 66 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtd_xmm_xmmm128 = 1526,
		/// <summary><c>VPCMPGTD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 66 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtd_xmm_xmm_xmmm128 = 1527,
		/// <summary><c>VPCMPGTD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 66 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtd_ymm_ymm_ymmm256 = 1528,
		/// <summary><c>VPCMPGTD k1 {k2}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtd_k_k1_xmm_xmmm128b32 = 1529,
		/// <summary><c>VPCMPGTD k1 {k2}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtd_k_k1_ymm_ymmm256b32 = 1530,
		/// <summary><c>VPCMPGTD k1 {k2}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtd_k_k1_zmm_zmmm512b32 = 1531,
		/// <summary><c>PACKUSWB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 67 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packuswb_mm_mmm64 = 1532,
		/// <summary><c>PACKUSWB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 67 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packuswb_xmm_xmmm128 = 1533,
		/// <summary><c>VPACKUSWB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 67 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpackuswb_xmm_xmm_xmmm128 = 1534,
		/// <summary><c>VPACKUSWB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 67 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpackuswb_ymm_ymm_ymmm256 = 1535,
		/// <summary><c>VPACKUSWB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 67 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackuswb_xmm_k1z_xmm_xmmm128 = 1536,
		/// <summary><c>VPACKUSWB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 67 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackuswb_ymm_k1z_ymm_ymmm256 = 1537,
		/// <summary><c>VPACKUSWB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 67 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackuswb_zmm_k1z_zmm_zmmm512 = 1538,
		/// <summary><c>PUNPCKHBW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 68 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhbw_mm_mmm64 = 1539,
		/// <summary><c>PUNPCKHBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 68 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhbw_xmm_xmmm128 = 1540,
		/// <summary><c>VPUNPCKHBW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 68 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhbw_xmm_xmm_xmmm128 = 1541,
		/// <summary><c>VPUNPCKHBW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 68 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhbw_ymm_ymm_ymmm256 = 1542,
		/// <summary><c>VPUNPCKHBW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhbw_xmm_k1z_xmm_xmmm128 = 1543,
		/// <summary><c>VPUNPCKHBW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhbw_ymm_k1z_ymm_ymmm256 = 1544,
		/// <summary><c>VPUNPCKHBW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhbw_zmm_k1z_zmm_zmmm512 = 1545,
		/// <summary><c>PUNPCKHWD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 69 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhwd_mm_mmm64 = 1546,
		/// <summary><c>PUNPCKHWD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 69 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhwd_xmm_xmmm128 = 1547,
		/// <summary><c>VPUNPCKHWD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 69 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhwd_xmm_xmm_xmmm128 = 1548,
		/// <summary><c>VPUNPCKHWD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 69 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhwd_ymm_ymm_ymmm256 = 1549,
		/// <summary><c>VPUNPCKHWD xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 69 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhwd_xmm_k1z_xmm_xmmm128 = 1550,
		/// <summary><c>VPUNPCKHWD ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 69 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhwd_ymm_k1z_ymm_ymmm256 = 1551,
		/// <summary><c>VPUNPCKHWD zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 69 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhwd_zmm_k1z_zmm_zmmm512 = 1552,
		/// <summary><c>PUNPCKHDQ mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 6A /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhdq_mm_mmm64 = 1553,
		/// <summary><c>PUNPCKHDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 6A /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhdq_xmm_xmmm128 = 1554,
		/// <summary><c>VPUNPCKHDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 6A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhdq_xmm_xmm_xmmm128 = 1555,
		/// <summary><c>VPUNPCKHDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 6A /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhdq_ymm_ymm_ymmm256 = 1556,
		/// <summary><c>VPUNPCKHDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 6A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhdq_xmm_k1z_xmm_xmmm128b32 = 1557,
		/// <summary><c>VPUNPCKHDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 6A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhdq_ymm_k1z_ymm_ymmm256b32 = 1558,
		/// <summary><c>VPUNPCKHDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 6A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhdq_zmm_k1z_zmm_zmmm512b32 = 1559,
		/// <summary><c>PACKSSDW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 6B /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packssdw_mm_mmm64 = 1560,
		/// <summary><c>PACKSSDW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 6B /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packssdw_xmm_xmmm128 = 1561,
		/// <summary><c>VPACKSSDW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 6B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpackssdw_xmm_xmm_xmmm128 = 1562,
		/// <summary><c>VPACKSSDW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 6B /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpackssdw_ymm_ymm_ymmm256 = 1563,
		/// <summary><c>VPACKSSDW xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 6B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackssdw_xmm_k1z_xmm_xmmm128b32 = 1564,
		/// <summary><c>VPACKSSDW ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 6B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackssdw_ymm_k1z_ymm_ymmm256b32 = 1565,
		/// <summary><c>VPACKSSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 6B /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackssdw_zmm_k1z_zmm_zmmm512b32 = 1566,
		/// <summary><c>PUNPCKLQDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 6C /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpcklqdq_xmm_xmmm128 = 1567,
		/// <summary><c>VPUNPCKLQDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 6C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpcklqdq_xmm_xmm_xmmm128 = 1568,
		/// <summary><c>VPUNPCKLQDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 6C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpcklqdq_ymm_ymm_ymmm256 = 1569,
		/// <summary><c>VPUNPCKLQDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 6C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklqdq_xmm_k1z_xmm_xmmm128b64 = 1570,
		/// <summary><c>VPUNPCKLQDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 6C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklqdq_ymm_k1z_ymm_ymmm256b64 = 1571,
		/// <summary><c>VPUNPCKLQDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 6C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpcklqdq_zmm_k1z_zmm_zmmm512b64 = 1572,
		/// <summary><c>PUNPCKHQDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 6D /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Punpckhqdq_xmm_xmmm128 = 1573,
		/// <summary><c>VPUNPCKHQDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 6D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhqdq_xmm_xmm_xmmm128 = 1574,
		/// <summary><c>VPUNPCKHQDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 6D /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpunpckhqdq_ymm_ymm_ymmm256 = 1575,
		/// <summary><c>VPUNPCKHQDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 6D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhqdq_xmm_k1z_xmm_xmmm128b64 = 1576,
		/// <summary><c>VPUNPCKHQDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 6D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhqdq_ymm_k1z_ymm_ymmm256b64 = 1577,
		/// <summary><c>VPUNPCKHQDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 6D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpunpckhqdq_zmm_k1z_zmm_zmmm512b64 = 1578,
		/// <summary><c>MOVD mm, r/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 6E /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movd_mm_rm32 = 1579,
		/// <summary><c>MOVQ mm, r/m64</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F 6E /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movq_mm_rm64 = 1580,
		/// <summary><c>MOVD xmm, r/m32</c><br/>
		/// <br/>
		/// <c>66 0F 6E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movd_xmm_rm32 = 1581,
		/// <summary><c>MOVQ xmm, r/m64</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 6E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movq_xmm_rm64 = 1582,
		/// <summary><c>VMOVD xmm1, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W0 6E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovd_xmm_rm32 = 1583,
		/// <summary><c>VMOVQ xmm1, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W1 6E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vmovq_xmm_rm64 = 1584,
		/// <summary><c>VMOVD xmm1, r/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 6E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovd_xmm_rm32 = 1585,
		/// <summary><c>VMOVQ xmm1, r/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 6E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vmovq_xmm_rm64 = 1586,
		/// <summary><c>MOVQ mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 6F /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movq_mm_mmm64 = 1587,
		/// <summary><c>MOVDQA xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 6F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdqa_xmm_xmmm128 = 1588,
		/// <summary><c>VMOVDQA xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 6F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqa_xmm_xmmm128 = 1589,
		/// <summary><c>VMOVDQA ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 6F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqa_ymm_ymmm256 = 1590,
		/// <summary><c>VMOVDQA32 xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa32_xmm_k1z_xmmm128 = 1591,
		/// <summary><c>VMOVDQA32 ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa32_ymm_k1z_ymmm256 = 1592,
		/// <summary><c>VMOVDQA32 zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa32_zmm_k1z_zmmm512 = 1593,
		/// <summary><c>VMOVDQA64 xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa64_xmm_k1z_xmmm128 = 1594,
		/// <summary><c>VMOVDQA64 ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa64_ymm_k1z_ymmm256 = 1595,
		/// <summary><c>VMOVDQA64 zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa64_zmm_k1z_zmmm512 = 1596,
		/// <summary><c>MOVDQU xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F3 0F 6F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdqu_xmm_xmmm128 = 1597,
		/// <summary><c>VMOVDQU xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 6F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqu_xmm_xmmm128 = 1598,
		/// <summary><c>VMOVDQU ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG 6F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqu_ymm_ymmm256 = 1599,
		/// <summary><c>VMOVDQU32 xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu32_xmm_k1z_xmmm128 = 1600,
		/// <summary><c>VMOVDQU32 ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu32_ymm_k1z_ymmm256 = 1601,
		/// <summary><c>VMOVDQU32 zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu32_zmm_k1z_zmmm512 = 1602,
		/// <summary><c>VMOVDQU64 xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu64_xmm_k1z_xmmm128 = 1603,
		/// <summary><c>VMOVDQU64 ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu64_ymm_k1z_ymmm256 = 1604,
		/// <summary><c>VMOVDQU64 zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu64_zmm_k1z_zmmm512 = 1605,
		/// <summary><c>VMOVDQU8 xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu8_xmm_k1z_xmmm128 = 1606,
		/// <summary><c>VMOVDQU8 ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu8_ymm_k1z_ymmm256 = 1607,
		/// <summary><c>VMOVDQU8 zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W0 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu8_zmm_k1z_zmmm512 = 1608,
		/// <summary><c>VMOVDQU16 xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu16_xmm_k1z_xmmm128 = 1609,
		/// <summary><c>VMOVDQU16 ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu16_ymm_k1z_ymmm256 = 1610,
		/// <summary><c>VMOVDQU16 zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W1 6F /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu16_zmm_k1z_zmmm512 = 1611,
		/// <summary><c>PSHUFW mm1, mm2/m64, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 70 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pshufw_mm_mmm64_imm8 = 1612,
		/// <summary><c>PSHUFD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 70 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pshufd_xmm_xmmm128_imm8 = 1613,
		/// <summary><c>VPSHUFD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshufd_xmm_xmmm128_imm8 = 1614,
		/// <summary><c>VPSHUFD ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshufd_ymm_ymmm256_imm8 = 1615,
		/// <summary><c>VPSHUFD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufd_xmm_k1z_xmmm128b32_imm8 = 1616,
		/// <summary><c>VPSHUFD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufd_ymm_k1z_ymmm256b32_imm8 = 1617,
		/// <summary><c>VPSHUFD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufd_zmm_k1z_zmmm512b32_imm8 = 1618,
		/// <summary><c>PSHUFHW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>F3 0F 70 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pshufhw_xmm_xmmm128_imm8 = 1619,
		/// <summary><c>VPSHUFHW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshufhw_xmm_xmmm128_imm8 = 1620,
		/// <summary><c>VPSHUFHW ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshufhw_ymm_ymmm256_imm8 = 1621,
		/// <summary><c>VPSHUFHW xmm1 {k1}{z}, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufhw_xmm_k1z_xmmm128_imm8 = 1622,
		/// <summary><c>VPSHUFHW ymm1 {k1}{z}, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufhw_ymm_k1z_ymmm256_imm8 = 1623,
		/// <summary><c>VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufhw_zmm_k1z_zmmm512_imm8 = 1624,
		/// <summary><c>PSHUFLW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>F2 0F 70 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pshuflw_xmm_xmmm128_imm8 = 1625,
		/// <summary><c>VPSHUFLW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshuflw_xmm_xmmm128_imm8 = 1626,
		/// <summary><c>VPSHUFLW ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshuflw_ymm_ymmm256_imm8 = 1627,
		/// <summary><c>VPSHUFLW xmm1 {k1}{z}, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshuflw_xmm_k1z_xmmm128_imm8 = 1628,
		/// <summary><c>VPSHUFLW ymm1 {k1}{z}, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshuflw_ymm_k1z_ymmm256_imm8 = 1629,
		/// <summary><c>VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.WIG 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshuflw_zmm_k1z_zmmm512_imm8 = 1630,
		/// <summary><c>PSRLW mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 71 /2 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlw_mm_imm8 = 1631,
		/// <summary><c>PSRLW xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 71 /2 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlw_xmm_imm8 = 1632,
		/// <summary><c>VPSRLW xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 71 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlw_xmm_xmm_imm8 = 1633,
		/// <summary><c>VPSRLW ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 71 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlw_ymm_ymm_imm8 = 1634,
		/// <summary><c>VPSRLW xmm1 {k1}{z}, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 71 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlw_xmm_k1z_xmmm128_imm8 = 1635,
		/// <summary><c>VPSRLW ymm1 {k1}{z}, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 71 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlw_ymm_k1z_ymmm256_imm8 = 1636,
		/// <summary><c>VPSRLW zmm1 {k1}{z}, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 71 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlw_zmm_k1z_zmmm512_imm8 = 1637,
		/// <summary><c>PSRAW mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 71 /4 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psraw_mm_imm8 = 1638,
		/// <summary><c>PSRAW xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 71 /4 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psraw_xmm_imm8 = 1639,
		/// <summary><c>VPSRAW xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 71 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsraw_xmm_xmm_imm8 = 1640,
		/// <summary><c>VPSRAW ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 71 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsraw_ymm_ymm_imm8 = 1641,
		/// <summary><c>VPSRAW xmm1 {k1}{z}, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 71 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraw_xmm_k1z_xmmm128_imm8 = 1642,
		/// <summary><c>VPSRAW ymm1 {k1}{z}, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 71 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraw_ymm_k1z_ymmm256_imm8 = 1643,
		/// <summary><c>VPSRAW zmm1 {k1}{z}, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 71 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraw_zmm_k1z_zmmm512_imm8 = 1644,
		/// <summary><c>PSLLW mm1, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 71 /6 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllw_mm_imm8 = 1645,
		/// <summary><c>PSLLW xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 71 /6 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllw_xmm_imm8 = 1646,
		/// <summary><c>VPSLLW xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 71 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllw_xmm_xmm_imm8 = 1647,
		/// <summary><c>VPSLLW ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 71 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllw_ymm_ymm_imm8 = 1648,
		/// <summary><c>VPSLLW xmm1 {k1}{z}, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 71 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllw_xmm_k1z_xmmm128_imm8 = 1649,
		/// <summary><c>VPSLLW ymm1 {k1}{z}, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 71 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllw_ymm_k1z_ymmm256_imm8 = 1650,
		/// <summary><c>VPSLLW zmm1 {k1}{z}, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 71 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllw_zmm_k1z_zmmm512_imm8 = 1651,
		/// <summary><c>VPRORD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 72 /0 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprord_xmm_k1z_xmmm128b32_imm8 = 1652,
		/// <summary><c>VPRORD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 72 /0 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprord_ymm_k1z_ymmm256b32_imm8 = 1653,
		/// <summary><c>VPRORD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 72 /0 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprord_zmm_k1z_zmmm512b32_imm8 = 1654,
		/// <summary><c>VPRORQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 72 /0 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorq_xmm_k1z_xmmm128b64_imm8 = 1655,
		/// <summary><c>VPRORQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 72 /0 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorq_ymm_k1z_ymmm256b64_imm8 = 1656,
		/// <summary><c>VPRORQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 72 /0 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorq_zmm_k1z_zmmm512b64_imm8 = 1657,
		/// <summary><c>VPROLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 72 /1 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprold_xmm_k1z_xmmm128b32_imm8 = 1658,
		/// <summary><c>VPROLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 72 /1 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprold_ymm_k1z_ymmm256b32_imm8 = 1659,
		/// <summary><c>VPROLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 72 /1 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprold_zmm_k1z_zmmm512b32_imm8 = 1660,
		/// <summary><c>VPROLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 72 /1 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolq_xmm_k1z_xmmm128b64_imm8 = 1661,
		/// <summary><c>VPROLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 72 /1 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolq_ymm_k1z_ymmm256b64_imm8 = 1662,
		/// <summary><c>VPROLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 72 /1 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolq_zmm_k1z_zmmm512b64_imm8 = 1663,
		/// <summary><c>PSRLD mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 72 /2 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrld_mm_imm8 = 1664,
		/// <summary><c>PSRLD xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 72 /2 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrld_xmm_imm8 = 1665,
		/// <summary><c>VPSRLD xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 72 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrld_xmm_xmm_imm8 = 1666,
		/// <summary><c>VPSRLD ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 72 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrld_ymm_ymm_imm8 = 1667,
		/// <summary><c>VPSRLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 72 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrld_xmm_k1z_xmmm128b32_imm8 = 1668,
		/// <summary><c>VPSRLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 72 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrld_ymm_k1z_ymmm256b32_imm8 = 1669,
		/// <summary><c>VPSRLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 72 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrld_zmm_k1z_zmmm512b32_imm8 = 1670,
		/// <summary><c>PSRAD mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 72 /4 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrad_mm_imm8 = 1671,
		/// <summary><c>PSRAD xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 72 /4 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrad_xmm_imm8 = 1672,
		/// <summary><c>VPSRAD xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrad_xmm_xmm_imm8 = 1673,
		/// <summary><c>VPSRAD ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrad_ymm_ymm_imm8 = 1674,
		/// <summary><c>VPSRAD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrad_xmm_k1z_xmmm128b32_imm8 = 1675,
		/// <summary><c>VPSRAD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrad_ymm_k1z_ymmm256b32_imm8 = 1676,
		/// <summary><c>VPSRAD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrad_zmm_k1z_zmmm512b32_imm8 = 1677,
		/// <summary><c>VPSRAQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraq_xmm_k1z_xmmm128b64_imm8 = 1678,
		/// <summary><c>VPSRAQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraq_ymm_k1z_ymmm256b64_imm8 = 1679,
		/// <summary><c>VPSRAQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 72 /4 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraq_zmm_k1z_zmmm512b64_imm8 = 1680,
		/// <summary><c>PSLLD mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 72 /6 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pslld_mm_imm8 = 1681,
		/// <summary><c>PSLLD xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 72 /6 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pslld_xmm_imm8 = 1682,
		/// <summary><c>VPSLLD xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 72 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpslld_xmm_xmm_imm8 = 1683,
		/// <summary><c>VPSLLD ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 72 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpslld_ymm_ymm_imm8 = 1684,
		/// <summary><c>VPSLLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 72 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslld_xmm_k1z_xmmm128b32_imm8 = 1685,
		/// <summary><c>VPSLLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 72 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslld_ymm_k1z_ymmm256b32_imm8 = 1686,
		/// <summary><c>VPSLLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 72 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslld_zmm_k1z_zmmm512b32_imm8 = 1687,
		/// <summary><c>PSRLQ mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 73 /2 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlq_mm_imm8 = 1688,
		/// <summary><c>PSRLQ xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 73 /2 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlq_xmm_imm8 = 1689,
		/// <summary><c>VPSRLQ xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 73 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlq_xmm_xmm_imm8 = 1690,
		/// <summary><c>VPSRLQ ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 73 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlq_ymm_ymm_imm8 = 1691,
		/// <summary><c>VPSRLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 73 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlq_xmm_k1z_xmmm128b64_imm8 = 1692,
		/// <summary><c>VPSRLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 73 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlq_ymm_k1z_ymmm256b64_imm8 = 1693,
		/// <summary><c>VPSRLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 73 /2 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlq_zmm_k1z_zmmm512b64_imm8 = 1694,
		/// <summary><c>PSRLDQ xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 73 /3 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrldq_xmm_imm8 = 1695,
		/// <summary><c>VPSRLDQ xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 73 /3 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrldq_xmm_xmm_imm8 = 1696,
		/// <summary><c>VPSRLDQ ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 73 /3 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrldq_ymm_ymm_imm8 = 1697,
		/// <summary><c>VPSRLDQ xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 73 /3 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrldq_xmm_xmmm128_imm8 = 1698,
		/// <summary><c>VPSRLDQ ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 73 /3 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrldq_ymm_ymmm256_imm8 = 1699,
		/// <summary><c>VPSRLDQ zmm1, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 73 /3 ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrldq_zmm_zmmm512_imm8 = 1700,
		/// <summary><c>PSLLQ mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 73 /6 ib</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllq_mm_imm8 = 1701,
		/// <summary><c>PSLLQ xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 73 /6 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllq_xmm_imm8 = 1702,
		/// <summary><c>VPSLLQ xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 73 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllq_xmm_xmm_imm8 = 1703,
		/// <summary><c>VPSLLQ ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 73 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllq_ymm_ymm_imm8 = 1704,
		/// <summary><c>VPSLLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 73 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllq_xmm_k1z_xmmm128b64_imm8 = 1705,
		/// <summary><c>VPSLLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 73 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllq_ymm_k1z_ymmm256b64_imm8 = 1706,
		/// <summary><c>VPSLLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 73 /6 ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllq_zmm_k1z_zmmm512b64_imm8 = 1707,
		/// <summary><c>PSLLDQ xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 73 /7 ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pslldq_xmm_imm8 = 1708,
		/// <summary><c>VPSLLDQ xmm1, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 73 /7 ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpslldq_xmm_xmm_imm8 = 1709,
		/// <summary><c>VPSLLDQ ymm1, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 73 /7 ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpslldq_ymm_ymm_imm8 = 1710,
		/// <summary><c>VPSLLDQ xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 73 /7 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslldq_xmm_xmmm128_imm8 = 1711,
		/// <summary><c>VPSLLDQ ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 73 /7 ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslldq_ymm_ymmm256_imm8 = 1712,
		/// <summary><c>VPSLLDQ zmm1, zmm2/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 73 /7 ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslldq_zmm_zmmm512_imm8 = 1713,
		/// <summary><c>PCMPEQB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 74 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqb_mm_mmm64 = 1714,
		/// <summary><c>PCMPEQB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 74 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqb_xmm_xmmm128 = 1715,
		/// <summary><c>VPCMPEQB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 74 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqb_xmm_xmm_xmmm128 = 1716,
		/// <summary><c>VPCMPEQB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 74 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqb_ymm_ymm_ymmm256 = 1717,
		/// <summary><c>VPCMPEQB k1 {k2}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 74 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqb_k_k1_xmm_xmmm128 = 1718,
		/// <summary><c>VPCMPEQB k1 {k2}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 74 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqb_k_k1_ymm_ymmm256 = 1719,
		/// <summary><c>VPCMPEQB k1 {k2}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 74 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqb_k_k1_zmm_zmmm512 = 1720,
		/// <summary><c>PCMPEQW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 75 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqw_mm_mmm64 = 1721,
		/// <summary><c>PCMPEQW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 75 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqw_xmm_xmmm128 = 1722,
		/// <summary><c>VPCMPEQW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 75 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqw_xmm_xmm_xmmm128 = 1723,
		/// <summary><c>VPCMPEQW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 75 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqw_ymm_ymm_ymmm256 = 1724,
		/// <summary><c>VPCMPEQW k1 {k2}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqw_k_k1_xmm_xmmm128 = 1725,
		/// <summary><c>VPCMPEQW k1 {k2}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqw_k_k1_ymm_ymmm256 = 1726,
		/// <summary><c>VPCMPEQW k1 {k2}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqw_k_k1_zmm_zmmm512 = 1727,
		/// <summary><c>PCMPEQD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 76 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqd_mm_mmm64 = 1728,
		/// <summary><c>PCMPEQD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 76 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqd_xmm_xmmm128 = 1729,
		/// <summary><c>VPCMPEQD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 76 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqd_xmm_xmm_xmmm128 = 1730,
		/// <summary><c>VPCMPEQD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 76 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqd_ymm_ymm_ymmm256 = 1731,
		/// <summary><c>VPCMPEQD k1 {k2}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqd_k_k1_xmm_xmmm128b32 = 1732,
		/// <summary><c>VPCMPEQD k1 {k2}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqd_k_k1_ymm_ymmm256b32 = 1733,
		/// <summary><c>VPCMPEQD k1 {k2}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqd_k_k1_zmm_zmmm512b32 = 1734,
		/// <summary><c>EMMS</c><br/>
		/// <br/>
		/// <c>NP 0F 77</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Emms = 1735,
		/// <summary><c>VZEROUPPER</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG 77</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vzeroupper = 1736,
		/// <summary><c>VZEROALL</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG 77</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vzeroall = 1737,
		/// <summary><c>VMREAD r/m32, r32</c><br/>
		/// <br/>
		/// <c>NP 0F 78 /r</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Vmread_rm32_r32 = 1738,
		/// <summary><c>VMREAD r/m64, r64</c><br/>
		/// <br/>
		/// <c>NP 0F 78 /r</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Vmread_rm64_r64 = 1739,
		/// <summary><c>VCVTTPS2UDQ xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2udq_xmm_k1z_xmmm128b32 = 1740,
		/// <summary><c>VCVTTPS2UDQ ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2udq_ymm_k1z_ymmm256b32 = 1741,
		/// <summary><c>VCVTTPS2UDQ zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2udq_zmm_k1z_zmmm512b32_sae = 1742,
		/// <summary><c>VCVTTPD2UDQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2udq_xmm_k1z_xmmm128b64 = 1743,
		/// <summary><c>VCVTTPD2UDQ xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2udq_xmm_k1z_ymmm256b64 = 1744,
		/// <summary><c>VCVTTPD2UDQ ymm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2udq_ymm_k1z_zmmm512b64_sae = 1745,
		/// <summary><c>EXTRQ xmm1, imm8, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 78 /0 ib ib</c><br/>
		/// <br/>
		/// <c>SSE4A</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Extrq_xmm_imm8_imm8 = 1746,
		/// <summary><c>VCVTTPS2UQQ xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2uqq_xmm_k1z_xmmm64b32 = 1747,
		/// <summary><c>VCVTTPS2UQQ ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2uqq_ymm_k1z_xmmm128b32 = 1748,
		/// <summary><c>VCVTTPS2UQQ zmm1 {k1}{z}, ymm2/m256/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2uqq_zmm_k1z_ymmm256b32_sae = 1749,
		/// <summary><c>VCVTTPD2UQQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2uqq_xmm_k1z_xmmm128b64 = 1750,
		/// <summary><c>VCVTTPD2UQQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2uqq_ymm_k1z_ymmm256b64 = 1751,
		/// <summary><c>VCVTTPD2UQQ zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2uqq_zmm_k1z_zmmm512b64_sae = 1752,
		/// <summary><c>VCVTTSS2USI r32, xmm1/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttss2usi_r32_xmmm32_sae = 1753,
		/// <summary><c>VCVTTSS2USI r64, xmm1/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvttss2usi_r64_xmmm32_sae = 1754,
		/// <summary><c>INSERTQ xmm1, xmm2, imm8, imm8</c><br/>
		/// <br/>
		/// <c>F2 0F 78 /r ib ib</c><br/>
		/// <br/>
		/// <c>SSE4A</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Insertq_xmm_xmm_imm8_imm8 = 1755,
		/// <summary><c>VCVTTSD2USI r32, xmm1/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttsd2usi_r32_xmmm64_sae = 1756,
		/// <summary><c>VCVTTSD2USI r64, xmm1/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvttsd2usi_r64_xmmm64_sae = 1757,
		/// <summary><c>VMWRITE r32, r/m32</c><br/>
		/// <br/>
		/// <c>NP 0F 79 /r</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Vmwrite_r32_rm32 = 1758,
		/// <summary><c>VMWRITE r64, r/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 79 /r</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Vmwrite_r64_rm64 = 1759,
		/// <summary><c>VCVTPS2UDQ xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2udq_xmm_k1z_xmmm128b32 = 1760,
		/// <summary><c>VCVTPS2UDQ ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2udq_ymm_k1z_ymmm256b32 = 1761,
		/// <summary><c>VCVTPS2UDQ zmm1 {k1}{z}, zmm2/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2udq_zmm_k1z_zmmm512b32_er = 1762,
		/// <summary><c>VCVTPD2UDQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2udq_xmm_k1z_xmmm128b64 = 1763,
		/// <summary><c>VCVTPD2UDQ xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2udq_xmm_k1z_ymmm256b64 = 1764,
		/// <summary><c>VCVTPD2UDQ ymm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2udq_ymm_k1z_zmmm512b64_er = 1765,
		/// <summary><c>EXTRQ xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>66 0F 79 /r</c><br/>
		/// <br/>
		/// <c>SSE4A</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Extrq_xmm_xmm = 1766,
		/// <summary><c>VCVTPS2UQQ xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2uqq_xmm_k1z_xmmm64b32 = 1767,
		/// <summary><c>VCVTPS2UQQ ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2uqq_ymm_k1z_xmmm128b32 = 1768,
		/// <summary><c>VCVTPS2UQQ zmm1 {k1}{z}, ymm2/m256/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2uqq_zmm_k1z_ymmm256b32_er = 1769,
		/// <summary><c>VCVTPD2UQQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2uqq_xmm_k1z_xmmm128b64 = 1770,
		/// <summary><c>VCVTPD2UQQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2uqq_ymm_k1z_ymmm256b64 = 1771,
		/// <summary><c>VCVTPD2UQQ zmm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2uqq_zmm_k1z_zmmm512b64_er = 1772,
		/// <summary><c>VCVTSS2USI r32, xmm1/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtss2usi_r32_xmmm32_er = 1773,
		/// <summary><c>VCVTSS2USI r64, xmm1/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtss2usi_r64_xmmm32_er = 1774,
		/// <summary><c>INSERTQ xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>F2 0F 79 /r</c><br/>
		/// <br/>
		/// <c>SSE4A</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Insertq_xmm_xmm = 1775,
		/// <summary><c>VCVTSD2USI r32, xmm1/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtsd2usi_r32_xmmm64_er = 1776,
		/// <summary><c>VCVTSD2USI r64, xmm1/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtsd2usi_r64_xmmm64_er = 1777,
		/// <summary><c>VCVTTPS2QQ xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2qq_xmm_k1z_xmmm64b32 = 1778,
		/// <summary><c>VCVTTPS2QQ ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2qq_ymm_k1z_xmmm128b32 = 1779,
		/// <summary><c>VCVTTPS2QQ zmm1 {k1}{z}, ymm2/m256/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttps2qq_zmm_k1z_ymmm256b32_sae = 1780,
		/// <summary><c>VCVTTPD2QQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2qq_xmm_k1z_xmmm128b64 = 1781,
		/// <summary><c>VCVTTPD2QQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2qq_ymm_k1z_ymmm256b64 = 1782,
		/// <summary><c>VCVTTPD2QQ zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2qq_zmm_k1z_zmmm512b64_sae = 1783,
		/// <summary><c>VCVTUDQ2PD xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtudq2pd_xmm_k1z_xmmm64b32 = 1784,
		/// <summary><c>VCVTUDQ2PD ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtudq2pd_ymm_k1z_xmmm128b32 = 1785,
		/// <summary><c>VCVTUDQ2PD zmm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtudq2pd_zmm_k1z_ymmm256b32 = 1786,
		/// <summary><c>VCVTUQQ2PD xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtuqq2pd_xmm_k1z_xmmm128b64 = 1787,
		/// <summary><c>VCVTUQQ2PD ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtuqq2pd_ymm_k1z_ymmm256b64 = 1788,
		/// <summary><c>VCVTUQQ2PD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtuqq2pd_zmm_k1z_zmmm512b64_er = 1789,
		/// <summary><c>VCVTUDQ2PS xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtudq2ps_xmm_k1z_xmmm128b32 = 1790,
		/// <summary><c>VCVTUDQ2PS ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtudq2ps_ymm_k1z_ymmm256b32 = 1791,
		/// <summary><c>VCVTUDQ2PS zmm1 {k1}{z}, zmm2/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtudq2ps_zmm_k1z_zmmm512b32_er = 1792,
		/// <summary><c>VCVTUQQ2PS xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtuqq2ps_xmm_k1z_xmmm128b64 = 1793,
		/// <summary><c>VCVTUQQ2PS xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtuqq2ps_xmm_k1z_ymmm256b64 = 1794,
		/// <summary><c>VCVTUQQ2PS ymm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W1 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtuqq2ps_ymm_k1z_zmmm512b64_er = 1795,
		/// <summary><c>VCVTPS2QQ xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2qq_xmm_k1z_xmmm64b32 = 1796,
		/// <summary><c>VCVTPS2QQ ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2qq_ymm_k1z_xmmm128b32 = 1797,
		/// <summary><c>VCVTPS2QQ zmm1 {k1}{z}, ymm2/m256/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2qq_zmm_k1z_ymmm256b32_er = 1798,
		/// <summary><c>VCVTPD2QQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2qq_xmm_k1z_xmmm128b64 = 1799,
		/// <summary><c>VCVTPD2QQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2qq_ymm_k1z_ymmm256b64 = 1800,
		/// <summary><c>VCVTPD2QQ zmm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2qq_zmm_k1z_zmmm512b64_er = 1801,
		/// <summary><c>VCVTUSI2SS xmm1, xmm2, r/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtusi2ss_xmm_xmm_rm32_er = 1802,
		/// <summary><c>VCVTUSI2SS xmm1, xmm2, r/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W1 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtusi2ss_xmm_xmm_rm64_er = 1803,
		/// <summary><c>VCVTUSI2SD xmm1, xmm2, r/m32</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtusi2sd_xmm_xmm_rm32_er = 1804,
		/// <summary><c>VCVTUSI2SD xmm1, xmm2, r/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vcvtusi2sd_xmm_xmm_rm64_er = 1805,
		/// <summary><c>HADDPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 7C /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Haddpd_xmm_xmmm128 = 1806,
		/// <summary><c>VHADDPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 7C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhaddpd_xmm_xmm_xmmm128 = 1807,
		/// <summary><c>VHADDPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 7C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhaddpd_ymm_ymm_ymmm256 = 1808,
		/// <summary><c>HADDPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F2 0F 7C /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Haddps_xmm_xmmm128 = 1809,
		/// <summary><c>VHADDPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG 7C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhaddps_xmm_xmm_xmmm128 = 1810,
		/// <summary><c>VHADDPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG 7C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhaddps_ymm_ymm_ymmm256 = 1811,
		/// <summary><c>HSUBPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 7D /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Hsubpd_xmm_xmmm128 = 1812,
		/// <summary><c>VHSUBPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 7D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhsubpd_xmm_xmm_xmmm128 = 1813,
		/// <summary><c>VHSUBPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 7D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhsubpd_ymm_ymm_ymmm256 = 1814,
		/// <summary><c>HSUBPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F2 0F 7D /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Hsubps_xmm_xmmm128 = 1815,
		/// <summary><c>VHSUBPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG 7D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhsubps_xmm_xmm_xmmm128 = 1816,
		/// <summary><c>VHSUBPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG 7D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vhsubps_ymm_ymm_ymmm256 = 1817,
		/// <summary><c>MOVD r/m32, mm</c><br/>
		/// <br/>
		/// <c>NP 0F 7E /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movd_rm32_mm = 1818,
		/// <summary><c>MOVQ r/m64, mm</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F 7E /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movq_rm64_mm = 1819,
		/// <summary><c>MOVD r/m32, xmm</c><br/>
		/// <br/>
		/// <c>66 0F 7E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movd_rm32_xmm = 1820,
		/// <summary><c>MOVQ r/m64, xmm</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 7E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movq_rm64_xmm = 1821,
		/// <summary><c>VMOVD r/m32, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W0 7E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovd_rm32_xmm = 1822,
		/// <summary><c>VMOVQ r/m64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W1 7E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vmovq_rm64_xmm = 1823,
		/// <summary><c>VMOVD r/m32, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovd_rm32_xmm = 1824,
		/// <summary><c>VMOVQ r/m64, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vmovq_rm64_xmm = 1825,
		/// <summary><c>MOVQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F3 0F 7E /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movq_xmm_xmmm64 = 1826,
		/// <summary><c>VMOVQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 7E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovq_xmm_xmmm64 = 1827,
		/// <summary><c>VMOVQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W1 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovq_xmm_xmmm64 = 1828,
		/// <summary><c>MOVQ mm/m64, mm</c><br/>
		/// <br/>
		/// <c>NP 0F 7F /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movq_mmm64_mm = 1829,
		/// <summary><c>MOVDQA xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F 7F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdqa_xmmm128_xmm = 1830,
		/// <summary><c>VMOVDQA xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG 7F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqa_xmmm128_xmm = 1831,
		/// <summary><c>VMOVDQA ymm2/m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG 7F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqa_ymmm256_ymm = 1832,
		/// <summary><c>VMOVDQA32 xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa32_xmmm128_k1z_xmm = 1833,
		/// <summary><c>VMOVDQA32 ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa32_ymmm256_k1z_ymm = 1834,
		/// <summary><c>VMOVDQA32 zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa32_zmmm512_k1z_zmm = 1835,
		/// <summary><c>VMOVDQA64 xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa64_xmmm128_k1z_xmm = 1836,
		/// <summary><c>VMOVDQA64 ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa64_ymmm256_k1z_ymm = 1837,
		/// <summary><c>VMOVDQA64 zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqa64_zmmm512_k1z_zmm = 1838,
		/// <summary><c>MOVDQU xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>F3 0F 7F /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdqu_xmmm128_xmm = 1839,
		/// <summary><c>VMOVDQU xmm2/m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG 7F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqu_xmmm128_xmm = 1840,
		/// <summary><c>VMOVDQU ymm2/m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG 7F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovdqu_ymmm256_ymm = 1841,
		/// <summary><c>VMOVDQU32 xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu32_xmmm128_k1z_xmm = 1842,
		/// <summary><c>VMOVDQU32 ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu32_ymmm256_k1z_ymm = 1843,
		/// <summary><c>VMOVDQU32 zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu32_zmmm512_k1z_zmm = 1844,
		/// <summary><c>VMOVDQU64 xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu64_xmmm128_k1z_xmm = 1845,
		/// <summary><c>VMOVDQU64 ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu64_ymmm256_k1z_ymm = 1846,
		/// <summary><c>VMOVDQU64 zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu64_zmmm512_k1z_zmm = 1847,
		/// <summary><c>VMOVDQU8 xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu8_xmmm128_k1z_xmm = 1848,
		/// <summary><c>VMOVDQU8 ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu8_ymmm256_k1z_ymm = 1849,
		/// <summary><c>VMOVDQU8 zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu8_zmmm512_k1z_zmm = 1850,
		/// <summary><c>VMOVDQU16 xmm2/m128 {k1}{z}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu16_xmmm128_k1z_xmm = 1851,
		/// <summary><c>VMOVDQU16 ymm2/m256 {k1}{z}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu16_ymmm256_k1z_ymm = 1852,
		/// <summary><c>VMOVDQU16 zmm2/m512 {k1}{z}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovdqu16_zmmm512_k1z_zmm = 1853,
		/// <summary><c>JO rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 80 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jo_rel16 = 1854,
		/// <summary><c>JO rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 80 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jo_rel32_32 = 1855,
		/// <summary><c>JO rel32</c><br/>
		/// <br/>
		/// <c>0F 80 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jo_rel32_64 = 1856,
		/// <summary><c>JNO rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 81 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jno_rel16 = 1857,
		/// <summary><c>JNO rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 81 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jno_rel32_32 = 1858,
		/// <summary><c>JNO rel32</c><br/>
		/// <br/>
		/// <c>0F 81 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jno_rel32_64 = 1859,
		/// <summary><c>JB rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 82 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jb_rel16 = 1860,
		/// <summary><c>JB rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 82 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jb_rel32_32 = 1861,
		/// <summary><c>JB rel32</c><br/>
		/// <br/>
		/// <c>0F 82 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jb_rel32_64 = 1862,
		/// <summary><c>JAE rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 83 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jae_rel16 = 1863,
		/// <summary><c>JAE rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 83 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jae_rel32_32 = 1864,
		/// <summary><c>JAE rel32</c><br/>
		/// <br/>
		/// <c>0F 83 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jae_rel32_64 = 1865,
		/// <summary><c>JE rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 84 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Je_rel16 = 1866,
		/// <summary><c>JE rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 84 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Je_rel32_32 = 1867,
		/// <summary><c>JE rel32</c><br/>
		/// <br/>
		/// <c>0F 84 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Je_rel32_64 = 1868,
		/// <summary><c>JNE rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 85 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jne_rel16 = 1869,
		/// <summary><c>JNE rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 85 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jne_rel32_32 = 1870,
		/// <summary><c>JNE rel32</c><br/>
		/// <br/>
		/// <c>0F 85 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jne_rel32_64 = 1871,
		/// <summary><c>JBE rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 86 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jbe_rel16 = 1872,
		/// <summary><c>JBE rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 86 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jbe_rel32_32 = 1873,
		/// <summary><c>JBE rel32</c><br/>
		/// <br/>
		/// <c>0F 86 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jbe_rel32_64 = 1874,
		/// <summary><c>JA rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 87 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ja_rel16 = 1875,
		/// <summary><c>JA rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 87 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Ja_rel32_32 = 1876,
		/// <summary><c>JA rel32</c><br/>
		/// <br/>
		/// <c>0F 87 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ja_rel32_64 = 1877,
		/// <summary><c>JS rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 88 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Js_rel16 = 1878,
		/// <summary><c>JS rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 88 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Js_rel32_32 = 1879,
		/// <summary><c>JS rel32</c><br/>
		/// <br/>
		/// <c>0F 88 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Js_rel32_64 = 1880,
		/// <summary><c>JNS rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 89 cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jns_rel16 = 1881,
		/// <summary><c>JNS rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 89 cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jns_rel32_32 = 1882,
		/// <summary><c>JNS rel32</c><br/>
		/// <br/>
		/// <c>0F 89 cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jns_rel32_64 = 1883,
		/// <summary><c>JP rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 8A cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jp_rel16 = 1884,
		/// <summary><c>JP rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 8A cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jp_rel32_32 = 1885,
		/// <summary><c>JP rel32</c><br/>
		/// <br/>
		/// <c>0F 8A cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jp_rel32_64 = 1886,
		/// <summary><c>JNP rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 8B cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jnp_rel16 = 1887,
		/// <summary><c>JNP rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 8B cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jnp_rel32_32 = 1888,
		/// <summary><c>JNP rel32</c><br/>
		/// <br/>
		/// <c>0F 8B cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jnp_rel32_64 = 1889,
		/// <summary><c>JL rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 8C cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jl_rel16 = 1890,
		/// <summary><c>JL rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 8C cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jl_rel32_32 = 1891,
		/// <summary><c>JL rel32</c><br/>
		/// <br/>
		/// <c>0F 8C cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jl_rel32_64 = 1892,
		/// <summary><c>JGE rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 8D cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jge_rel16 = 1893,
		/// <summary><c>JGE rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 8D cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jge_rel32_32 = 1894,
		/// <summary><c>JGE rel32</c><br/>
		/// <br/>
		/// <c>0F 8D cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jge_rel32_64 = 1895,
		/// <summary><c>JLE rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 8E cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jle_rel16 = 1896,
		/// <summary><c>JLE rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 8E cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jle_rel32_32 = 1897,
		/// <summary><c>JLE rel32</c><br/>
		/// <br/>
		/// <c>0F 8E cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jle_rel32_64 = 1898,
		/// <summary><c>JG rel16</c><br/>
		/// <br/>
		/// <c>o16 0F 8F cw</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Jg_rel16 = 1899,
		/// <summary><c>JG rel32</c><br/>
		/// <br/>
		/// <c>o32 0F 8F cd</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jg_rel32_32 = 1900,
		/// <summary><c>JG rel32</c><br/>
		/// <br/>
		/// <c>0F 8F cd</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Jg_rel32_64 = 1901,
		/// <summary><c>SETO r/m8</c><br/>
		/// <br/>
		/// <c>0F 90 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Seto_rm8 = 1902,
		/// <summary><c>SETNO r/m8</c><br/>
		/// <br/>
		/// <c>0F 91 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setno_rm8 = 1903,
		/// <summary><c>SETB r/m8</c><br/>
		/// <br/>
		/// <c>0F 92 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setb_rm8 = 1904,
		/// <summary><c>SETAE r/m8</c><br/>
		/// <br/>
		/// <c>0F 93 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setae_rm8 = 1905,
		/// <summary><c>SETE r/m8</c><br/>
		/// <br/>
		/// <c>0F 94 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sete_rm8 = 1906,
		/// <summary><c>SETNE r/m8</c><br/>
		/// <br/>
		/// <c>0F 95 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setne_rm8 = 1907,
		/// <summary><c>SETBE r/m8</c><br/>
		/// <br/>
		/// <c>0F 96 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setbe_rm8 = 1908,
		/// <summary><c>SETA r/m8</c><br/>
		/// <br/>
		/// <c>0F 97 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Seta_rm8 = 1909,
		/// <summary><c>SETS r/m8</c><br/>
		/// <br/>
		/// <c>0F 98 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sets_rm8 = 1910,
		/// <summary><c>SETNS r/m8</c><br/>
		/// <br/>
		/// <c>0F 99 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setns_rm8 = 1911,
		/// <summary><c>SETP r/m8</c><br/>
		/// <br/>
		/// <c>0F 9A /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setp_rm8 = 1912,
		/// <summary><c>SETNP r/m8</c><br/>
		/// <br/>
		/// <c>0F 9B /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setnp_rm8 = 1913,
		/// <summary><c>SETL r/m8</c><br/>
		/// <br/>
		/// <c>0F 9C /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setl_rm8 = 1914,
		/// <summary><c>SETGE r/m8</c><br/>
		/// <br/>
		/// <c>0F 9D /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setge_rm8 = 1915,
		/// <summary><c>SETLE r/m8</c><br/>
		/// <br/>
		/// <c>0F 9E /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setle_rm8 = 1916,
		/// <summary><c>SETG r/m8</c><br/>
		/// <br/>
		/// <c>0F 9F /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Setg_rm8 = 1917,
		/// <summary><c>KMOVW k1, k2/m16</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 90 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovw_k_km16 = 1918,
		/// <summary><c>KMOVQ k1, k2/m64</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W1 90 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovq_k_km64 = 1919,
		/// <summary><c>KMOVB k1, k2/m8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 90 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovb_k_km8 = 1920,
		/// <summary><c>KMOVD k1, k2/m32</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W1 90 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovd_k_km32 = 1921,
		/// <summary><c>KMOVW m16, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 91 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovw_m16_k = 1922,
		/// <summary><c>KMOVQ m64, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W1 91 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovq_m64_k = 1923,
		/// <summary><c>KMOVB m8, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 91 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovb_m8_k = 1924,
		/// <summary><c>KMOVD m32, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W1 91 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovd_m32_k = 1925,
		/// <summary><c>KMOVW k1, r32</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 92 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovw_k_r32 = 1926,
		/// <summary><c>KMOVB k1, r32</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 92 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovb_k_r32 = 1927,
		/// <summary><c>KMOVD k1, r32</c><br/>
		/// <br/>
		/// <c>VEX.L0.F2.0F.W0 92 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovd_k_r32 = 1928,
		/// <summary><c>KMOVQ k1, r64</c><br/>
		/// <br/>
		/// <c>VEX.L0.F2.0F.W1 92 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Kmovq_k_r64 = 1929,
		/// <summary><c>KMOVW r32, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 93 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovw_r32_k = 1930,
		/// <summary><c>KMOVB r32, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 93 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovb_r32_k = 1931,
		/// <summary><c>KMOVD r32, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.F2.0F.W0 93 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kmovd_r32_k = 1932,
		/// <summary><c>KMOVQ r64, k1</c><br/>
		/// <br/>
		/// <c>VEX.L0.F2.0F.W1 93 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Kmovq_r64_k = 1933,
		/// <summary><c>KORTESTW k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kortestw_k_k = 1934,
		/// <summary><c>KORTESTQ k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W1 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kortestq_k_k = 1935,
		/// <summary><c>KORTESTB k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kortestb_k_k = 1936,
		/// <summary><c>KORTESTD k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W1 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kortestd_k_k = 1937,
		/// <summary><c>KTESTW k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W0 99 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Ktestw_k_k = 1938,
		/// <summary><c>KTESTQ k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.0F.W1 99 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Ktestq_k_k = 1939,
		/// <summary><c>KTESTB k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W0 99 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Ktestb_k_k = 1940,
		/// <summary><c>KTESTD k1, k2</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F.W1 99 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Ktestd_k_k = 1941,
		/// <summary><c>PUSH FS</c><br/>
		/// <br/>
		/// <c>o16 0F A0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pushw_FS = 1942,
		/// <summary><c>PUSH FS</c><br/>
		/// <br/>
		/// <c>o32 0F A0</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_FS = 1943,
		/// <summary><c>PUSH FS</c><br/>
		/// <br/>
		/// <c>0F A0</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pushq_FS = 1944,
		/// <summary><c>POP FS</c><br/>
		/// <br/>
		/// <c>o16 0F A1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Popw_FS = 1945,
		/// <summary><c>POP FS</c><br/>
		/// <br/>
		/// <c>o32 0F A1</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popd_FS = 1946,
		/// <summary><c>POP FS</c><br/>
		/// <br/>
		/// <c>0F A1</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Popq_FS = 1947,
		/// <summary><c>CPUID</c><br/>
		/// <br/>
		/// <c>0F A2</c><br/>
		/// <br/>
		/// <c>CPUID</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cpuid = 1948,
		/// <summary><c>BT r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F A3 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bt_rm16_r16 = 1949,
		/// <summary><c>BT r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F A3 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bt_rm32_r32 = 1950,
		/// <summary><c>BT r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F A3 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bt_rm64_r64 = 1951,
		/// <summary><c>SHLD r/m16, r16, imm8</c><br/>
		/// <br/>
		/// <c>o16 0F A4 /r ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shld_rm16_r16_imm8 = 1952,
		/// <summary><c>SHLD r/m32, r32, imm8</c><br/>
		/// <br/>
		/// <c>o32 0F A4 /r ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shld_rm32_r32_imm8 = 1953,
		/// <summary><c>SHLD r/m64, r64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 0F A4 /r ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shld_rm64_r64_imm8 = 1954,
		/// <summary><c>SHLD r/m16, r16, CL</c><br/>
		/// <br/>
		/// <c>o16 0F A5 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shld_rm16_r16_CL = 1955,
		/// <summary><c>SHLD r/m32, r32, CL</c><br/>
		/// <br/>
		/// <c>o32 0F A5 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shld_rm32_r32_CL = 1956,
		/// <summary><c>SHLD r/m64, r64, CL</c><br/>
		/// <br/>
		/// <c>REX.W 0F A5 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shld_rm64_r64_CL = 1957,
		/// <summary><c>MONTMUL</c><br/>
		/// <br/>
		/// <c>a16 0F A6 C0</c><br/>
		/// <br/>
		/// <c>PADLOCK_PMM</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Montmul_16 = 1958,
		/// <summary><c>MONTMUL</c><br/>
		/// <br/>
		/// <c>a32 0F A6 C0</c><br/>
		/// <br/>
		/// <c>PADLOCK_PMM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Montmul_32 = 1959,
		/// <summary><c>MONTMUL</c><br/>
		/// <br/>
		/// <c>0F A6 C0</c><br/>
		/// <br/>
		/// <c>PADLOCK_PMM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Montmul_64 = 1960,
		/// <summary><c>XSHA1</c><br/>
		/// <br/>
		/// <c>a16 0F A6 C8</c><br/>
		/// <br/>
		/// <c>PADLOCK_PHE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Xsha1_16 = 1961,
		/// <summary><c>XSHA1</c><br/>
		/// <br/>
		/// <c>a32 0F A6 C8</c><br/>
		/// <br/>
		/// <c>PADLOCK_PHE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsha1_32 = 1962,
		/// <summary><c>XSHA1</c><br/>
		/// <br/>
		/// <c>0F A6 C8</c><br/>
		/// <br/>
		/// <c>PADLOCK_PHE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xsha1_64 = 1963,
		/// <summary><c>XSHA256</c><br/>
		/// <br/>
		/// <c>a16 0F A6 D0</c><br/>
		/// <br/>
		/// <c>PADLOCK_PHE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Xsha256_16 = 1964,
		/// <summary><c>XSHA256</c><br/>
		/// <br/>
		/// <c>a32 0F A6 D0</c><br/>
		/// <br/>
		/// <c>PADLOCK_PHE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsha256_32 = 1965,
		/// <summary><c>XSHA256</c><br/>
		/// <br/>
		/// <c>0F A6 D0</c><br/>
		/// <br/>
		/// <c>PADLOCK_PHE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xsha256_64 = 1966,
		/// <summary><c>XBTS r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F A6 /r</c><br/>
		/// <br/>
		/// <c>386 A0</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Xbts_r16_rm16 = 1967,
		/// <summary><c>XBTS r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F A6 /r</c><br/>
		/// <br/>
		/// <c>386 A0</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Xbts_r32_rm32 = 1968,
		/// <summary><c>XSTORE</c><br/>
		/// <br/>
		/// <c>a16 0F A7 C0</c><br/>
		/// <br/>
		/// <c>PADLOCK_RNG</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Xstore_16 = 1969,
		/// <summary><c>XSTORE</c><br/>
		/// <br/>
		/// <c>a32 0F A7 C0</c><br/>
		/// <br/>
		/// <c>PADLOCK_RNG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xstore_32 = 1970,
		/// <summary><c>XSTORE</c><br/>
		/// <br/>
		/// <c>0F A7 C0</c><br/>
		/// <br/>
		/// <c>PADLOCK_RNG</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xstore_64 = 1971,
		/// <summary><c>XCRYPTECB</c><br/>
		/// <br/>
		/// <c>a16 0F A7 C8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		XcryptEcb_16 = 1972,
		/// <summary><c>XCRYPTECB</c><br/>
		/// <br/>
		/// <c>a32 0F A7 C8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XcryptEcb_32 = 1973,
		/// <summary><c>XCRYPTECB</c><br/>
		/// <br/>
		/// <c>0F A7 C8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XcryptEcb_64 = 1974,
		/// <summary><c>XCRYPTCBC</c><br/>
		/// <br/>
		/// <c>a16 0F A7 D0</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		XcryptCbc_16 = 1975,
		/// <summary><c>XCRYPTCBC</c><br/>
		/// <br/>
		/// <c>a32 0F A7 D0</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XcryptCbc_32 = 1976,
		/// <summary><c>XCRYPTCBC</c><br/>
		/// <br/>
		/// <c>0F A7 D0</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XcryptCbc_64 = 1977,
		/// <summary><c>XCRYPTCTR</c><br/>
		/// <br/>
		/// <c>a16 0F A7 D8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		XcryptCtr_16 = 1978,
		/// <summary><c>XCRYPTCTR</c><br/>
		/// <br/>
		/// <c>a32 0F A7 D8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XcryptCtr_32 = 1979,
		/// <summary><c>XCRYPTCTR</c><br/>
		/// <br/>
		/// <c>0F A7 D8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XcryptCtr_64 = 1980,
		/// <summary><c>XCRYPTCFB</c><br/>
		/// <br/>
		/// <c>a16 0F A7 E0</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		XcryptCfb_16 = 1981,
		/// <summary><c>XCRYPTCFB</c><br/>
		/// <br/>
		/// <c>a32 0F A7 E0</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XcryptCfb_32 = 1982,
		/// <summary><c>XCRYPTCFB</c><br/>
		/// <br/>
		/// <c>0F A7 E0</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XcryptCfb_64 = 1983,
		/// <summary><c>XCRYPTOFB</c><br/>
		/// <br/>
		/// <c>a16 0F A7 E8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		XcryptOfb_16 = 1984,
		/// <summary><c>XCRYPTOFB</c><br/>
		/// <br/>
		/// <c>a32 0F A7 E8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XcryptOfb_32 = 1985,
		/// <summary><c>XCRYPTOFB</c><br/>
		/// <br/>
		/// <c>0F A7 E8</c><br/>
		/// <br/>
		/// <c>PADLOCK_ACE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XcryptOfb_64 = 1986,
		/// <summary><c>IBTS r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F A7 /r</c><br/>
		/// <br/>
		/// <c>386 A0</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Ibts_rm16_r16 = 1987,
		/// <summary><c>IBTS r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F A7 /r</c><br/>
		/// <br/>
		/// <c>386 A0</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Ibts_rm32_r32 = 1988,
		/// <summary><c>CMPXCHG r/m8, r8</c><br/>
		/// <br/>
		/// <c>0F A6 /r</c><br/>
		/// <br/>
		/// <c>486 A</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Cmpxchg486_rm8_r8 = 1989,
		/// <summary><c>CMPXCHG r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F A7 /r</c><br/>
		/// <br/>
		/// <c>486 A</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Cmpxchg486_rm16_r16 = 1990,
		/// <summary><c>CMPXCHG r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F A7 /r</c><br/>
		/// <br/>
		/// <c>486 A</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Cmpxchg486_rm32_r32 = 1991,
		/// <summary><c>PUSH GS</c><br/>
		/// <br/>
		/// <c>o16 0F A8</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pushw_GS = 1992,
		/// <summary><c>PUSH GS</c><br/>
		/// <br/>
		/// <c>o32 0F A8</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pushd_GS = 1993,
		/// <summary><c>PUSH GS</c><br/>
		/// <br/>
		/// <c>0F A8</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pushq_GS = 1994,
		/// <summary><c>POP GS</c><br/>
		/// <br/>
		/// <c>o16 0F A9</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Popw_GS = 1995,
		/// <summary><c>POP GS</c><br/>
		/// <br/>
		/// <c>o32 0F A9</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Popd_GS = 1996,
		/// <summary><c>POP GS</c><br/>
		/// <br/>
		/// <c>0F A9</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Popq_GS = 1997,
		/// <summary><c>RSM</c><br/>
		/// <br/>
		/// <c>0F AA</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rsm = 1998,
		/// <summary><c>BTS r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F AB /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bts_rm16_r16 = 1999,
		/// <summary><c>BTS r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F AB /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bts_rm32_r32 = 2000,
		/// <summary><c>BTS r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F AB /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bts_rm64_r64 = 2001,
		/// <summary><c>SHRD r/m16, r16, imm8</c><br/>
		/// <br/>
		/// <c>o16 0F AC /r ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shrd_rm16_r16_imm8 = 2002,
		/// <summary><c>SHRD r/m32, r32, imm8</c><br/>
		/// <br/>
		/// <c>o32 0F AC /r ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shrd_rm32_r32_imm8 = 2003,
		/// <summary><c>SHRD r/m64, r64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 0F AC /r ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shrd_rm64_r64_imm8 = 2004,
		/// <summary><c>SHRD r/m16, r16, CL</c><br/>
		/// <br/>
		/// <c>o16 0F AD /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shrd_rm16_r16_CL = 2005,
		/// <summary><c>SHRD r/m32, r32, CL</c><br/>
		/// <br/>
		/// <c>o32 0F AD /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shrd_rm32_r32_CL = 2006,
		/// <summary><c>SHRD r/m64, r64, CL</c><br/>
		/// <br/>
		/// <c>REX.W 0F AD /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Shrd_rm64_r64_CL = 2007,
		/// <summary><c>FXSAVE m512byte</c><br/>
		/// <br/>
		/// <c>NP 0F AE /0</c><br/>
		/// <br/>
		/// <c>FXSR</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxsave_m512byte = 2008,
		/// <summary><c>FXSAVE64 m512byte</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F AE /0</c><br/>
		/// <br/>
		/// <c>FXSR</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Fxsave64_m512byte = 2009,
		/// <summary><c>RDFSBASE r32</c><br/>
		/// <br/>
		/// <c>F3 0F AE /0</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdfsbase_r32 = 2010,
		/// <summary><c>RDFSBASE r64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F AE /0</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdfsbase_r64 = 2011,
		/// <summary><c>FXRSTOR m512byte</c><br/>
		/// <br/>
		/// <c>NP 0F AE /1</c><br/>
		/// <br/>
		/// <c>FXSR</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Fxrstor_m512byte = 2012,
		/// <summary><c>FXRSTOR64 m512byte</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F AE /1</c><br/>
		/// <br/>
		/// <c>FXSR</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Fxrstor64_m512byte = 2013,
		/// <summary><c>RDGSBASE r32</c><br/>
		/// <br/>
		/// <c>F3 0F AE /1</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdgsbase_r32 = 2014,
		/// <summary><c>RDGSBASE r64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F AE /1</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdgsbase_r64 = 2015,
		/// <summary><c>LDMXCSR m32</c><br/>
		/// <br/>
		/// <c>NP 0F AE /2</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ldmxcsr_m32 = 2016,
		/// <summary><c>WRFSBASE r32</c><br/>
		/// <br/>
		/// <c>F3 0F AE /2</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Wrfsbase_r32 = 2017,
		/// <summary><c>WRFSBASE r64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F AE /2</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Wrfsbase_r64 = 2018,
		/// <summary><c>VLDMXCSR m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F.WIG AE /2</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vldmxcsr_m32 = 2019,
		/// <summary><c>STMXCSR m32</c><br/>
		/// <br/>
		/// <c>NP 0F AE /3</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Stmxcsr_m32 = 2020,
		/// <summary><c>WRGSBASE r32</c><br/>
		/// <br/>
		/// <c>F3 0F AE /3</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Wrgsbase_r32 = 2021,
		/// <summary><c>WRGSBASE r64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F AE /3</c><br/>
		/// <br/>
		/// <c>FSGSBASE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Wrgsbase_r64 = 2022,
		/// <summary><c>VSTMXCSR m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F.WIG AE /3</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vstmxcsr_m32 = 2023,
		/// <summary><c>XSAVE mem</c><br/>
		/// <br/>
		/// <c>NP 0F AE /4</c><br/>
		/// <br/>
		/// <c>XSAVE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsave_mem = 2024,
		/// <summary><c>XSAVE64 mem</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F AE /4</c><br/>
		/// <br/>
		/// <c>XSAVE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xsave64_mem = 2025,
		/// <summary><c>PTWRITE r/m32</c><br/>
		/// <br/>
		/// <c>F3 0F AE /4</c><br/>
		/// <br/>
		/// <c>PTWRITE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ptwrite_rm32 = 2026,
		/// <summary><c>PTWRITE r/m64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F AE /4</c><br/>
		/// <br/>
		/// <c>PTWRITE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ptwrite_rm64 = 2027,
		/// <summary><c>XRSTOR mem</c><br/>
		/// <br/>
		/// <c>NP 0F AE /5</c><br/>
		/// <br/>
		/// <c>XSAVE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xrstor_mem = 2028,
		/// <summary><c>XRSTOR64 mem</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F AE /5</c><br/>
		/// <br/>
		/// <c>XSAVE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xrstor64_mem = 2029,
		/// <summary><c>INCSSPD r32</c><br/>
		/// <br/>
		/// <c>F3 0F AE /5</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Incsspd_r32 = 2030,
		/// <summary><c>INCSSPQ r64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F AE /5</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Incsspq_r64 = 2031,
		/// <summary><c>XSAVEOPT mem</c><br/>
		/// <br/>
		/// <c>NP 0F AE /6</c><br/>
		/// <br/>
		/// <c>XSAVEOPT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsaveopt_mem = 2032,
		/// <summary><c>XSAVEOPT64 mem</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F AE /6</c><br/>
		/// <br/>
		/// <c>XSAVEOPT</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xsaveopt64_mem = 2033,
		/// <summary><c>CLWB m8</c><br/>
		/// <br/>
		/// <c>66 0F AE /6</c><br/>
		/// <br/>
		/// <c>CLWB</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clwb_m8 = 2034,
		/// <summary><c>TPAUSE r32, &lt;edx&gt;, &lt;eax&gt;</c><br/>
		/// <br/>
		/// <c>66 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Tpause_r32 = 2035,
		/// <summary><c>TPAUSE r64, &lt;edx&gt;, &lt;eax&gt;</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Tpause_r64 = 2036,
		/// <summary><c>CLRSSBSY m64</c><br/>
		/// <br/>
		/// <c>F3 0F AE /6</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clrssbsy_m64 = 2037,
		/// <summary><c>UMONITOR r16</c><br/>
		/// <br/>
		/// <c>a16 F3 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Umonitor_r16 = 2038,
		/// <summary><c>UMONITOR r32</c><br/>
		/// <br/>
		/// <c>a32 F3 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Umonitor_r32 = 2039,
		/// <summary><c>UMONITOR r64</c><br/>
		/// <br/>
		/// <c>F3 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Umonitor_r64 = 2040,
		/// <summary><c>UMWAIT r32, &lt;edx&gt;, &lt;eax&gt;</c><br/>
		/// <br/>
		/// <c>F2 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Umwait_r32 = 2041,
		/// <summary><c>UMWAIT r64, &lt;edx&gt;, &lt;eax&gt;</c><br/>
		/// <br/>
		/// <c>F2 REX.W 0F AE /6</c><br/>
		/// <br/>
		/// <c>WAITPKG</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Umwait_r64 = 2042,
		/// <summary><c>CLFLUSH m8</c><br/>
		/// <br/>
		/// <c>NP 0F AE /7</c><br/>
		/// <br/>
		/// <c>CLFSH</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clflush_m8 = 2043,
		/// <summary><c>CLFLUSHOPT m8</c><br/>
		/// <br/>
		/// <c>66 0F AE /7</c><br/>
		/// <br/>
		/// <c>CLFLUSHOPT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Clflushopt_m8 = 2044,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE E8</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence = 2045,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE E9</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_E9 = 2046,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE EA</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_EA = 2047,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE EB</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_EB = 2048,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE EC</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_EC = 2049,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE ED</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_ED = 2050,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE EE</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_EE = 2051,
		/// <summary><c>LFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE EF</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfence_EF = 2052,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F0</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence = 2053,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F1</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F1 = 2054,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F2</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F2 = 2055,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F3</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F3 = 2056,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F4</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F4 = 2057,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F5</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F5 = 2058,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F6</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F6 = 2059,
		/// <summary><c>MFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F7</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mfence_F7 = 2060,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F8</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence = 2061,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE F9</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_F9 = 2062,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE FA</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_FA = 2063,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE FB</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_FB = 2064,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE FC</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_FC = 2065,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE FD</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_FD = 2066,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE FE</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_FE = 2067,
		/// <summary><c>SFENCE</c><br/>
		/// <br/>
		/// <c>NP 0F AE FF</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sfence_FF = 2068,
		/// <summary><c>PCOMMIT</c><br/>
		/// <br/>
		/// <c>66 0F AE F8</c><br/>
		/// <br/>
		/// <c>PCOMMIT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcommit = 2069,
		/// <summary><c>IMUL r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F AF /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_r16_rm16 = 2070,
		/// <summary><c>IMUL r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F AF /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Imul_r32_rm32 = 2071,
		/// <summary><c>IMUL r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F AF /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Imul_r64_rm64 = 2072,
		/// <summary><c>CMPXCHG r/m8, r8</c><br/>
		/// <br/>
		/// <c>0F B0 /r</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpxchg_rm8_r8 = 2073,
		/// <summary><c>CMPXCHG r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F B1 /r</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpxchg_rm16_r16 = 2074,
		/// <summary><c>CMPXCHG r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F B1 /r</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpxchg_rm32_r32 = 2075,
		/// <summary><c>CMPXCHG r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F B1 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmpxchg_rm64_r64 = 2076,
		/// <summary><c>LSS r16, m16:16</c><br/>
		/// <br/>
		/// <c>o16 0F B2 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lss_r16_m1616 = 2077,
		/// <summary><c>LSS r32, m16:32</c><br/>
		/// <br/>
		/// <c>o32 0F B2 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lss_r32_m1632 = 2078,
		/// <summary><c>LSS r64, m16:64</c><br/>
		/// <br/>
		/// <c>REX.W 0F B2 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lss_r64_m1664 = 2079,
		/// <summary><c>BTR r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F B3 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btr_rm16_r16 = 2080,
		/// <summary><c>BTR r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F B3 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btr_rm32_r32 = 2081,
		/// <summary><c>BTR r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F B3 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Btr_rm64_r64 = 2082,
		/// <summary><c>LFS r16, m16:16</c><br/>
		/// <br/>
		/// <c>o16 0F B4 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfs_r16_m1616 = 2083,
		/// <summary><c>LFS r32, m16:32</c><br/>
		/// <br/>
		/// <c>o32 0F B4 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lfs_r32_m1632 = 2084,
		/// <summary><c>LFS r64, m16:64</c><br/>
		/// <br/>
		/// <c>REX.W 0F B4 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lfs_r64_m1664 = 2085,
		/// <summary><c>LGS r16, m16:16</c><br/>
		/// <br/>
		/// <c>o16 0F B5 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lgs_r16_m1616 = 2086,
		/// <summary><c>LGS r32, m16:32</c><br/>
		/// <br/>
		/// <c>o32 0F B5 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lgs_r32_m1632 = 2087,
		/// <summary><c>LGS r64, m16:64</c><br/>
		/// <br/>
		/// <c>REX.W 0F B5 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lgs_r64_m1664 = 2088,
		/// <summary><c>MOVZX r16, r/m8</c><br/>
		/// <br/>
		/// <c>o16 0F B6 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movzx_r16_rm8 = 2089,
		/// <summary><c>MOVZX r32, r/m8</c><br/>
		/// <br/>
		/// <c>o32 0F B6 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movzx_r32_rm8 = 2090,
		/// <summary><c>MOVZX r64, r/m8</c><br/>
		/// <br/>
		/// <c>REX.W 0F B6 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movzx_r64_rm8 = 2091,
		/// <summary><c>MOVZX r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F B7 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movzx_r16_rm16 = 2092,
		/// <summary><c>MOVZX r32, r/m16</c><br/>
		/// <br/>
		/// <c>o32 0F B7 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movzx_r32_rm16 = 2093,
		/// <summary><c>MOVZX r64, r/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F B7 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movzx_r64_rm16 = 2094,
		/// <summary><c>JMPE disp16</c><br/>
		/// <br/>
		/// <c>o16 0F B8 cw</c><br/>
		/// <br/>
		/// <c>IA-64</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmpe_disp16 = 2095,
		/// <summary><c>JMPE disp32</c><br/>
		/// <br/>
		/// <c>o32 0F B8 cd</c><br/>
		/// <br/>
		/// <c>IA-64</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Jmpe_disp32 = 2096,
		/// <summary><c>POPCNT r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 F3 0F B8 /r</c><br/>
		/// <br/>
		/// <c>POPCNT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Popcnt_r16_rm16 = 2097,
		/// <summary><c>POPCNT r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 F3 0F B8 /r</c><br/>
		/// <br/>
		/// <c>POPCNT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Popcnt_r32_rm32 = 2098,
		/// <summary><c>POPCNT r64, r/m64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F B8 /r</c><br/>
		/// <br/>
		/// <c>POPCNT</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Popcnt_r64_rm64 = 2099,
		/// <summary><c>UD1 r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F B9 /r</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ud1_r16_rm16 = 2100,
		/// <summary><c>UD1 r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F B9 /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ud1_r32_rm32 = 2101,
		/// <summary><c>UD1 r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F B9 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ud1_r64_rm64 = 2102,
		/// <summary><c>BT r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 0F BA /4 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bt_rm16_imm8 = 2103,
		/// <summary><c>BT r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 0F BA /4 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bt_rm32_imm8 = 2104,
		/// <summary><c>BT r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 0F BA /4 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bt_rm64_imm8 = 2105,
		/// <summary><c>BTS r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 0F BA /5 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bts_rm16_imm8 = 2106,
		/// <summary><c>BTS r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 0F BA /5 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bts_rm32_imm8 = 2107,
		/// <summary><c>BTS r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 0F BA /5 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bts_rm64_imm8 = 2108,
		/// <summary><c>BTR r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 0F BA /6 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btr_rm16_imm8 = 2109,
		/// <summary><c>BTR r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 0F BA /6 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btr_rm32_imm8 = 2110,
		/// <summary><c>BTR r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 0F BA /6 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Btr_rm64_imm8 = 2111,
		/// <summary><c>BTC r/m16, imm8</c><br/>
		/// <br/>
		/// <c>o16 0F BA /7 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btc_rm16_imm8 = 2112,
		/// <summary><c>BTC r/m32, imm8</c><br/>
		/// <br/>
		/// <c>o32 0F BA /7 ib</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btc_rm32_imm8 = 2113,
		/// <summary><c>BTC r/m64, imm8</c><br/>
		/// <br/>
		/// <c>REX.W 0F BA /7 ib</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Btc_rm64_imm8 = 2114,
		/// <summary><c>BTC r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F BB /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btc_rm16_r16 = 2115,
		/// <summary><c>BTC r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F BB /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Btc_rm32_r32 = 2116,
		/// <summary><c>BTC r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F BB /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Btc_rm64_r64 = 2117,
		/// <summary><c>BSF r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F BC /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bsf_r16_rm16 = 2118,
		/// <summary><c>BSF r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F BC /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bsf_r32_rm32 = 2119,
		/// <summary><c>BSF r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F BC /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bsf_r64_rm64 = 2120,
		/// <summary><c>TZCNT r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 F3 0F BC /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Tzcnt_r16_rm16 = 2121,
		/// <summary><c>TZCNT r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 F3 0F BC /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Tzcnt_r32_rm32 = 2122,
		/// <summary><c>TZCNT r64, r/m64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F BC /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Tzcnt_r64_rm64 = 2123,
		/// <summary><c>BSR r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F BD /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bsr_r16_rm16 = 2124,
		/// <summary><c>BSR r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F BD /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bsr_r32_rm32 = 2125,
		/// <summary><c>BSR r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F BD /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bsr_r64_rm64 = 2126,
		/// <summary><c>LZCNT r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 F3 0F BD /r</c><br/>
		/// <br/>
		/// <c>LZCNT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lzcnt_r16_rm16 = 2127,
		/// <summary><c>LZCNT r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 F3 0F BD /r</c><br/>
		/// <br/>
		/// <c>LZCNT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lzcnt_r32_rm32 = 2128,
		/// <summary><c>LZCNT r64, r/m64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F BD /r</c><br/>
		/// <br/>
		/// <c>LZCNT</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Lzcnt_r64_rm64 = 2129,
		/// <summary><c>MOVSX r16, r/m8</c><br/>
		/// <br/>
		/// <c>o16 0F BE /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsx_r16_rm8 = 2130,
		/// <summary><c>MOVSX r32, r/m8</c><br/>
		/// <br/>
		/// <c>o32 0F BE /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsx_r32_rm8 = 2131,
		/// <summary><c>MOVSX r64, r/m8</c><br/>
		/// <br/>
		/// <c>REX.W 0F BE /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movsx_r64_rm8 = 2132,
		/// <summary><c>MOVSX r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F BF /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsx_r16_rm16 = 2133,
		/// <summary><c>MOVSX r32, r/m16</c><br/>
		/// <br/>
		/// <c>o32 0F BF /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movsx_r32_rm16 = 2134,
		/// <summary><c>MOVSX r64, r/m16</c><br/>
		/// <br/>
		/// <c>REX.W 0F BF /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movsx_r64_rm16 = 2135,
		/// <summary><c>XADD r/m8, r8</c><br/>
		/// <br/>
		/// <c>0F C0 /r</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xadd_rm8_r8 = 2136,
		/// <summary><c>XADD r/m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F C1 /r</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xadd_rm16_r16 = 2137,
		/// <summary><c>XADD r/m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F C1 /r</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xadd_rm32_r32 = 2138,
		/// <summary><c>XADD r/m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F C1 /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xadd_rm64_r64 = 2139,
		/// <summary><c>CMPPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F C2 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpps_xmm_xmmm128_imm8 = 2140,
		/// <summary><c>VCMPPS xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcmpps_xmm_xmm_xmmm128_imm8 = 2141,
		/// <summary><c>VCMPPS ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcmpps_ymm_ymm_ymmm256_imm8 = 2142,
		/// <summary><c>VCMPPS k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmpps_k_k1_xmm_xmmm128b32_imm8 = 2143,
		/// <summary><c>VCMPPS k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmpps_k_k1_ymm_ymmm256b32_imm8 = 2144,
		/// <summary><c>VCMPPS k1 {k2}, zmm2, zmm3/m512/m32bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmpps_k_k1_zmm_zmmm512b32_imm8_sae = 2145,
		/// <summary><c>CMPPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F C2 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmppd_xmm_xmmm128_imm8 = 2146,
		/// <summary><c>VCMPPD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcmppd_xmm_xmm_xmmm128_imm8 = 2147,
		/// <summary><c>VCMPPD ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcmppd_ymm_ymm_ymmm256_imm8 = 2148,
		/// <summary><c>VCMPPD k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmppd_k_k1_xmm_xmmm128b64_imm8 = 2149,
		/// <summary><c>VCMPPD k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmppd_k_k1_ymm_ymmm256b64_imm8 = 2150,
		/// <summary><c>VCMPPD k1 {k2}, zmm2, zmm3/m512/m64bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmppd_k_k1_zmm_zmmm512b64_imm8_sae = 2151,
		/// <summary><c>CMPSS xmm1, xmm2/m32, imm8</c><br/>
		/// <br/>
		/// <c>F3 0F C2 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpss_xmm_xmmm32_imm8 = 2152,
		/// <summary><c>VCMPSS xmm1, xmm2, xmm3/m32, imm8</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F3.0F.WIG C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcmpss_xmm_xmm_xmmm32_imm8 = 2153,
		/// <summary><c>VCMPSS k1 {k2}, xmm2, xmm3/m32{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F3.0F.W0 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmpss_k_k1_xmm_xmmm32_imm8_sae = 2154,
		/// <summary><c>CMPSD xmm1, xmm2/m64, imm8</c><br/>
		/// <br/>
		/// <c>F2 0F C2 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpsd_xmm_xmmm64_imm8 = 2155,
		/// <summary><c>VCMPSD xmm1, xmm2, xmm3/m64, imm8</c><br/>
		/// <br/>
		/// <c>VEX.LIG.F2.0F.WIG C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcmpsd_xmm_xmm_xmmm64_imm8 = 2156,
		/// <summary><c>VCMPSD k1 {k2}, xmm2, xmm3/m64{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F.W1 C2 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcmpsd_k_k1_xmm_xmmm64_imm8_sae = 2157,
		/// <summary><c>MOVNTI m32, r32</c><br/>
		/// <br/>
		/// <c>NP 0F C3 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movnti_m32_r32 = 2158,
		/// <summary><c>MOVNTI m64, r64</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F C3 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movnti_m64_r64 = 2159,
		/// <summary><c>PINSRW mm, r32/m16, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F C4 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pinsrw_mm_r32m16_imm8 = 2160,
		/// <summary><c>PINSRW mm, r64/m16, imm8</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F C4 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pinsrw_mm_r64m16_imm8 = 2161,
		/// <summary><c>PINSRW xmm, r32/m16, imm8</c><br/>
		/// <br/>
		/// <c>66 0F C4 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pinsrw_xmm_r32m16_imm8 = 2162,
		/// <summary><c>PINSRW xmm, r64/m16, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F C4 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pinsrw_xmm_r64m16_imm8 = 2163,
		/// <summary><c>VPINSRW xmm1, xmm2, r32/m16, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W0 C4 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpinsrw_xmm_xmm_r32m16_imm8 = 2164,
		/// <summary><c>VPINSRW xmm1, xmm2, r64/m16, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W1 C4 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpinsrw_xmm_xmm_r64m16_imm8 = 2165,
		/// <summary><c>VPINSRW xmm1, xmm2, r32/m16, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 C4 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpinsrw_xmm_xmm_r32m16_imm8 = 2166,
		/// <summary><c>VPINSRW xmm1, xmm2, r64/m16, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 C4 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpinsrw_xmm_xmm_r64m16_imm8 = 2167,
		/// <summary><c>PEXTRW r32, mm, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F C5 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pextrw_r32_mm_imm8 = 2168,
		/// <summary><c>PEXTRW r64, mm, imm8</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F C5 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pextrw_r64_mm_imm8 = 2169,
		/// <summary><c>PEXTRW r32, xmm, imm8</c><br/>
		/// <br/>
		/// <c>66 0F C5 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pextrw_r32_xmm_imm8 = 2170,
		/// <summary><c>PEXTRW r64, xmm, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F C5 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pextrw_r64_xmm_imm8 = 2171,
		/// <summary><c>VPEXTRW r32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W0 C5 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpextrw_r32_xmm_imm8 = 2172,
		/// <summary><c>VPEXTRW r64, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W1 C5 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpextrw_r64_xmm_imm8 = 2173,
		/// <summary><c>VPEXTRW r32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 C5 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpextrw_r32_xmm_imm8 = 2174,
		/// <summary><c>VPEXTRW r64, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 C5 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpextrw_r64_xmm_imm8 = 2175,
		/// <summary><c>SHUFPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F C6 /r ib</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shufps_xmm_xmmm128_imm8 = 2176,
		/// <summary><c>VSHUFPS xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.0F.WIG C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vshufps_xmm_xmm_xmmm128_imm8 = 2177,
		/// <summary><c>VSHUFPS ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.0F.WIG C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vshufps_ymm_ymm_ymmm256_imm8 = 2178,
		/// <summary><c>VSHUFPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.0F.W0 C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufps_xmm_k1z_xmm_xmmm128b32_imm8 = 2179,
		/// <summary><c>VSHUFPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.0F.W0 C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufps_ymm_k1z_ymm_ymmm256b32_imm8 = 2180,
		/// <summary><c>VSHUFPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.0F.W0 C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufps_zmm_k1z_zmm_zmmm512b32_imm8 = 2181,
		/// <summary><c>SHUFPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F C6 /r ib</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Shufpd_xmm_xmmm128_imm8 = 2182,
		/// <summary><c>VSHUFPD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vshufpd_xmm_xmm_xmmm128_imm8 = 2183,
		/// <summary><c>VSHUFPD ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vshufpd_ymm_ymm_ymmm256_imm8 = 2184,
		/// <summary><c>VSHUFPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufpd_xmm_k1z_xmm_xmmm128b64_imm8 = 2185,
		/// <summary><c>VSHUFPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufpd_ymm_k1z_ymm_ymmm256b64_imm8 = 2186,
		/// <summary><c>VSHUFPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 C6 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufpd_zmm_k1z_zmm_zmmm512b64_imm8 = 2187,
		/// <summary><c>CMPXCHG8B m64</c><br/>
		/// <br/>
		/// <c>0F C7 /1</c><br/>
		/// <br/>
		/// <c>CX8</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cmpxchg8b_m64 = 2188,
		/// <summary><c>CMPXCHG16B m128</c><br/>
		/// <br/>
		/// <c>REX.W 0F C7 /1</c><br/>
		/// <br/>
		/// <c>CMPXCHG16B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Cmpxchg16b_m128 = 2189,
		/// <summary><c>XRSTORS mem</c><br/>
		/// <br/>
		/// <c>NP 0F C7 /3</c><br/>
		/// <br/>
		/// <c>XSAVES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xrstors_mem = 2190,
		/// <summary><c>XRSTORS64 mem</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F C7 /3</c><br/>
		/// <br/>
		/// <c>XSAVES</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xrstors64_mem = 2191,
		/// <summary><c>XSAVEC mem</c><br/>
		/// <br/>
		/// <c>NP 0F C7 /4</c><br/>
		/// <br/>
		/// <c>XSAVEC</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsavec_mem = 2192,
		/// <summary><c>XSAVEC64 mem</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F C7 /4</c><br/>
		/// <br/>
		/// <c>XSAVEC</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xsavec64_mem = 2193,
		/// <summary><c>XSAVES mem</c><br/>
		/// <br/>
		/// <c>NP 0F C7 /5</c><br/>
		/// <br/>
		/// <c>XSAVES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsaves_mem = 2194,
		/// <summary><c>XSAVES64 mem</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F C7 /5</c><br/>
		/// <br/>
		/// <c>XSAVES</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Xsaves64_mem = 2195,
		/// <summary><c>VMPTRLD m64</c><br/>
		/// <br/>
		/// <c>NP 0F C7 /6</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmptrld_m64 = 2196,
		/// <summary><c>VMCLEAR m64</c><br/>
		/// <br/>
		/// <c>66 0F C7 /6</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmclear_m64 = 2197,
		/// <summary><c>VMXON m64</c><br/>
		/// <br/>
		/// <c>F3 0F C7 /6</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmxon_m64 = 2198,
		/// <summary><c>RDRAND r16</c><br/>
		/// <br/>
		/// <c>o16 0F C7 /6</c><br/>
		/// <br/>
		/// <c>RDRAND</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdrand_r16 = 2199,
		/// <summary><c>RDRAND r32</c><br/>
		/// <br/>
		/// <c>o32 0F C7 /6</c><br/>
		/// <br/>
		/// <c>RDRAND</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdrand_r32 = 2200,
		/// <summary><c>RDRAND r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F C7 /6</c><br/>
		/// <br/>
		/// <c>RDRAND</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdrand_r64 = 2201,
		/// <summary><c>VMPTRST m64</c><br/>
		/// <br/>
		/// <c>NP 0F C7 /7</c><br/>
		/// <br/>
		/// <c>VMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Vmptrst_m64 = 2202,
		/// <summary><c>RDSEED r16</c><br/>
		/// <br/>
		/// <c>o16 0F C7 /7</c><br/>
		/// <br/>
		/// <c>RDSEED</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdseed_r16 = 2203,
		/// <summary><c>RDSEED r32</c><br/>
		/// <br/>
		/// <c>o32 0F C7 /7</c><br/>
		/// <br/>
		/// <c>RDSEED</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Rdseed_r32 = 2204,
		/// <summary><c>RDSEED r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F C7 /7</c><br/>
		/// <br/>
		/// <c>RDSEED</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdseed_r64 = 2205,
		/// <summary><c>RDPID r32</c><br/>
		/// <br/>
		/// <c>F3 0F C7 /7</c><br/>
		/// <br/>
		/// <c>RDPID</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Rdpid_r32 = 2206,
		/// <summary><c>RDPID r64</c><br/>
		/// <br/>
		/// <c>F3 0F C7 /7</c><br/>
		/// <br/>
		/// <c>RDPID</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rdpid_r64 = 2207,
		/// <summary><c>BSWAP r16</c><br/>
		/// <br/>
		/// <c>o16 0F C8+rw</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bswap_r16 = 2208,
		/// <summary><c>BSWAP r32</c><br/>
		/// <br/>
		/// <c>o32 0F C8+rd</c><br/>
		/// <br/>
		/// <c>486+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Bswap_r32 = 2209,
		/// <summary><c>BSWAP r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F C8+ro</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Bswap_r64 = 2210,
		/// <summary><c>ADDSUBPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D0 /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Addsubpd_xmm_xmmm128 = 2211,
		/// <summary><c>VADDSUBPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddsubpd_xmm_xmm_xmmm128 = 2212,
		/// <summary><c>VADDSUBPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddsubpd_ymm_ymm_ymmm256 = 2213,
		/// <summary><c>ADDSUBPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F2 0F D0 /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Addsubps_xmm_xmmm128 = 2214,
		/// <summary><c>VADDSUBPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG D0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddsubps_xmm_xmm_xmmm128 = 2215,
		/// <summary><c>VADDSUBPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG D0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaddsubps_ymm_ymm_ymmm256 = 2216,
		/// <summary><c>PSRLW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D1 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlw_mm_mmm64 = 2217,
		/// <summary><c>PSRLW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D1 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlw_xmm_xmmm128 = 2218,
		/// <summary><c>VPSRLW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D1 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlw_xmm_xmm_xmmm128 = 2219,
		/// <summary><c>VPSRLW ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D1 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlw_ymm_ymm_xmmm128 = 2220,
		/// <summary><c>VPSRLW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG D1 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlw_xmm_k1z_xmm_xmmm128 = 2221,
		/// <summary><c>VPSRLW ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG D1 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlw_ymm_k1z_ymm_xmmm128 = 2222,
		/// <summary><c>VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG D1 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlw_zmm_k1z_zmm_xmmm128 = 2223,
		/// <summary><c>PSRLD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D2 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrld_mm_mmm64 = 2224,
		/// <summary><c>PSRLD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D2 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrld_xmm_xmmm128 = 2225,
		/// <summary><c>VPSRLD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D2 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrld_xmm_xmm_xmmm128 = 2226,
		/// <summary><c>VPSRLD ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D2 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrld_ymm_ymm_xmmm128 = 2227,
		/// <summary><c>VPSRLD xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 D2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrld_xmm_k1z_xmm_xmmm128 = 2228,
		/// <summary><c>VPSRLD ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 D2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrld_ymm_k1z_ymm_xmmm128 = 2229,
		/// <summary><c>VPSRLD zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 D2 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrld_zmm_k1z_zmm_xmmm128 = 2230,
		/// <summary><c>PSRLQ mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D3 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlq_mm_mmm64 = 2231,
		/// <summary><c>PSRLQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D3 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrlq_xmm_xmmm128 = 2232,
		/// <summary><c>VPSRLQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D3 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlq_xmm_xmm_xmmm128 = 2233,
		/// <summary><c>VPSRLQ ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D3 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlq_ymm_ymm_xmmm128 = 2234,
		/// <summary><c>VPSRLQ xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 D3 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlq_xmm_k1z_xmm_xmmm128 = 2235,
		/// <summary><c>VPSRLQ ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 D3 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlq_ymm_k1z_ymm_xmmm128 = 2236,
		/// <summary><c>VPSRLQ zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 D3 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlq_zmm_k1z_zmm_xmmm128 = 2237,
		/// <summary><c>PADDQ mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D4 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddq_mm_mmm64 = 2238,
		/// <summary><c>PADDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D4 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddq_xmm_xmmm128 = 2239,
		/// <summary><c>VPADDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D4 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddq_xmm_xmm_xmmm128 = 2240,
		/// <summary><c>VPADDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D4 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddq_ymm_ymm_ymmm256 = 2241,
		/// <summary><c>VPADDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 D4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddq_xmm_k1z_xmm_xmmm128b64 = 2242,
		/// <summary><c>VPADDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 D4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddq_ymm_k1z_ymm_ymmm256b64 = 2243,
		/// <summary><c>VPADDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 D4 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddq_zmm_k1z_zmm_zmmm512b64 = 2244,
		/// <summary><c>PMULLW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D5 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmullw_mm_mmm64 = 2245,
		/// <summary><c>PMULLW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D5 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmullw_xmm_xmmm128 = 2246,
		/// <summary><c>VPMULLW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D5 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmullw_xmm_xmm_xmmm128 = 2247,
		/// <summary><c>VPMULLW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D5 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmullw_ymm_ymm_ymmm256 = 2248,
		/// <summary><c>VPMULLW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG D5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmullw_xmm_k1z_xmm_xmmm128 = 2249,
		/// <summary><c>VPMULLW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG D5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmullw_ymm_k1z_ymm_ymmm256 = 2250,
		/// <summary><c>VPMULLW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG D5 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmullw_zmm_k1z_zmm_zmmm512 = 2251,
		/// <summary><c>MOVQ xmm2/m64, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F D6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movq_xmmm64_xmm = 2252,
		/// <summary><c>VMOVQ xmm1/m64, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovq_xmmm64_xmm = 2253,
		/// <summary><c>VMOVQ xmm1/m64, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 D6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovq_xmmm64_xmm = 2254,
		/// <summary><c>MOVQ2DQ xmm, mm</c><br/>
		/// <br/>
		/// <c>F3 0F D6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movq2dq_xmm_mm = 2255,
		/// <summary><c>MOVDQ2Q mm, xmm</c><br/>
		/// <br/>
		/// <c>F2 0F D6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdq2q_mm_xmm = 2256,
		/// <summary><c>PMOVMSKB r32, mm</c><br/>
		/// <br/>
		/// <c>NP 0F D7 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovmskb_r32_mm = 2257,
		/// <summary><c>PMOVMSKB r64, mm</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F D7 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pmovmskb_r64_mm = 2258,
		/// <summary><c>PMOVMSKB r32, xmm</c><br/>
		/// <br/>
		/// <c>66 0F D7 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovmskb_r32_xmm = 2259,
		/// <summary><c>PMOVMSKB r64, xmm</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F D7 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pmovmskb_r64_xmm = 2260,
		/// <summary><c>VPMOVMSKB r32, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W0 D7 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovmskb_r32_xmm = 2261,
		/// <summary><c>VPMOVMSKB r64, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.W1 D7 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpmovmskb_r64_xmm = 2262,
		/// <summary><c>VPMOVMSKB r32, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.W0 D7 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovmskb_r32_ymm = 2263,
		/// <summary><c>VPMOVMSKB r64, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.W1 D7 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpmovmskb_r64_ymm = 2264,
		/// <summary><c>PSUBUSB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D8 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubusb_mm_mmm64 = 2265,
		/// <summary><c>PSUBUSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D8 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubusb_xmm_xmmm128 = 2266,
		/// <summary><c>VPSUBUSB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D8 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubusb_xmm_xmm_xmmm128 = 2267,
		/// <summary><c>VPSUBUSB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D8 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubusb_ymm_ymm_ymmm256 = 2268,
		/// <summary><c>VPSUBUSB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG D8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubusb_xmm_k1z_xmm_xmmm128 = 2269,
		/// <summary><c>VPSUBUSB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG D8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubusb_ymm_k1z_ymm_ymmm256 = 2270,
		/// <summary><c>VPSUBUSB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG D8 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubusb_zmm_k1z_zmm_zmmm512 = 2271,
		/// <summary><c>PSUBUSW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F D9 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubusw_mm_mmm64 = 2272,
		/// <summary><c>PSUBUSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F D9 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubusw_xmm_xmmm128 = 2273,
		/// <summary><c>VPSUBUSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG D9 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubusw_xmm_xmm_xmmm128 = 2274,
		/// <summary><c>VPSUBUSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG D9 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubusw_ymm_ymm_ymmm256 = 2275,
		/// <summary><c>VPSUBUSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG D9 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubusw_xmm_k1z_xmm_xmmm128 = 2276,
		/// <summary><c>VPSUBUSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG D9 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubusw_ymm_k1z_ymm_ymmm256 = 2277,
		/// <summary><c>VPSUBUSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG D9 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubusw_zmm_k1z_zmm_zmmm512 = 2278,
		/// <summary><c>PMINUB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F DA /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminub_mm_mmm64 = 2279,
		/// <summary><c>PMINUB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F DA /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminub_xmm_xmmm128 = 2280,
		/// <summary><c>VPMINUB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG DA /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminub_xmm_xmm_xmmm128 = 2281,
		/// <summary><c>VPMINUB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG DA /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminub_ymm_ymm_ymmm256 = 2282,
		/// <summary><c>VPMINUB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG DA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminub_xmm_k1z_xmm_xmmm128 = 2283,
		/// <summary><c>VPMINUB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG DA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminub_ymm_k1z_ymm_ymmm256 = 2284,
		/// <summary><c>VPMINUB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG DA /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminub_zmm_k1z_zmm_zmmm512 = 2285,
		/// <summary><c>PAND mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F DB /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pand_mm_mmm64 = 2286,
		/// <summary><c>PAND xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F DB /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pand_xmm_xmmm128 = 2287,
		/// <summary><c>VPAND xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG DB /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpand_xmm_xmm_xmmm128 = 2288,
		/// <summary><c>VPAND ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG DB /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpand_ymm_ymm_ymmm256 = 2289,
		/// <summary><c>VPANDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 DB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandd_xmm_k1z_xmm_xmmm128b32 = 2290,
		/// <summary><c>VPANDD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 DB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandd_ymm_k1z_ymm_ymmm256b32 = 2291,
		/// <summary><c>VPANDD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 DB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandd_zmm_k1z_zmm_zmmm512b32 = 2292,
		/// <summary><c>VPANDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 DB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandq_xmm_k1z_xmm_xmmm128b64 = 2293,
		/// <summary><c>VPANDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 DB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandq_ymm_k1z_ymm_ymmm256b64 = 2294,
		/// <summary><c>VPANDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 DB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandq_zmm_k1z_zmm_zmmm512b64 = 2295,
		/// <summary><c>PADDUSB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F DC /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddusb_mm_mmm64 = 2296,
		/// <summary><c>PADDUSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F DC /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddusb_xmm_xmmm128 = 2297,
		/// <summary><c>VPADDUSB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddusb_xmm_xmm_xmmm128 = 2298,
		/// <summary><c>VPADDUSB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddusb_ymm_ymm_ymmm256 = 2299,
		/// <summary><c>VPADDUSB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddusb_xmm_k1z_xmm_xmmm128 = 2300,
		/// <summary><c>VPADDUSB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddusb_ymm_k1z_ymm_ymmm256 = 2301,
		/// <summary><c>VPADDUSB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddusb_zmm_k1z_zmm_zmmm512 = 2302,
		/// <summary><c>PADDUSW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F DD /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddusw_mm_mmm64 = 2303,
		/// <summary><c>PADDUSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F DD /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddusw_xmm_xmmm128 = 2304,
		/// <summary><c>VPADDUSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddusw_xmm_xmm_xmmm128 = 2305,
		/// <summary><c>VPADDUSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddusw_ymm_ymm_ymmm256 = 2306,
		/// <summary><c>VPADDUSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddusw_xmm_k1z_xmm_xmmm128 = 2307,
		/// <summary><c>VPADDUSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddusw_ymm_k1z_ymm_ymmm256 = 2308,
		/// <summary><c>VPADDUSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddusw_zmm_k1z_zmm_zmmm512 = 2309,
		/// <summary><c>PMAXUB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F DE /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxub_mm_mmm64 = 2310,
		/// <summary><c>PMAXUB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F DE /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxub_xmm_xmmm128 = 2311,
		/// <summary><c>VPMAXUB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxub_xmm_xmm_xmmm128 = 2312,
		/// <summary><c>VPMAXUB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxub_ymm_ymm_ymmm256 = 2313,
		/// <summary><c>VPMAXUB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxub_xmm_k1z_xmm_xmmm128 = 2314,
		/// <summary><c>VPMAXUB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxub_ymm_k1z_ymm_ymmm256 = 2315,
		/// <summary><c>VPMAXUB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxub_zmm_k1z_zmm_zmmm512 = 2316,
		/// <summary><c>PANDN mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F DF /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pandn_mm_mmm64 = 2317,
		/// <summary><c>PANDN xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F DF /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pandn_xmm_xmmm128 = 2318,
		/// <summary><c>VPANDN xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG DF /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpandn_xmm_xmm_xmmm128 = 2319,
		/// <summary><c>VPANDN ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG DF /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpandn_ymm_ymm_ymmm256 = 2320,
		/// <summary><c>VPANDND xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 DF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandnd_xmm_k1z_xmm_xmmm128b32 = 2321,
		/// <summary><c>VPANDND ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 DF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandnd_ymm_k1z_ymm_ymmm256b32 = 2322,
		/// <summary><c>VPANDND zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 DF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandnd_zmm_k1z_zmm_zmmm512b32 = 2323,
		/// <summary><c>VPANDNQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 DF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandnq_xmm_k1z_xmm_xmmm128b64 = 2324,
		/// <summary><c>VPANDNQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 DF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandnq_ymm_k1z_ymm_ymmm256b64 = 2325,
		/// <summary><c>VPANDNQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 DF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpandnq_zmm_k1z_zmm_zmmm512b64 = 2326,
		/// <summary><c>PAVGB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E0 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pavgb_mm_mmm64 = 2327,
		/// <summary><c>PAVGB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E0 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pavgb_xmm_xmmm128 = 2328,
		/// <summary><c>VPAVGB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpavgb_xmm_xmm_xmmm128 = 2329,
		/// <summary><c>VPAVGB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E0 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpavgb_ymm_ymm_ymmm256 = 2330,
		/// <summary><c>VPAVGB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E0 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpavgb_xmm_k1z_xmm_xmmm128 = 2331,
		/// <summary><c>VPAVGB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E0 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpavgb_ymm_k1z_ymm_ymmm256 = 2332,
		/// <summary><c>VPAVGB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E0 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpavgb_zmm_k1z_zmm_zmmm512 = 2333,
		/// <summary><c>PSRAW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E1 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psraw_mm_mmm64 = 2334,
		/// <summary><c>PSRAW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E1 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psraw_xmm_xmmm128 = 2335,
		/// <summary><c>VPSRAW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E1 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsraw_xmm_xmm_xmmm128 = 2336,
		/// <summary><c>VPSRAW ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E1 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsraw_ymm_ymm_xmmm128 = 2337,
		/// <summary><c>VPSRAW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E1 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraw_xmm_k1z_xmm_xmmm128 = 2338,
		/// <summary><c>VPSRAW ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E1 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraw_ymm_k1z_ymm_xmmm128 = 2339,
		/// <summary><c>VPSRAW zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E1 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraw_zmm_k1z_zmm_xmmm128 = 2340,
		/// <summary><c>PSRAD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E2 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrad_mm_mmm64 = 2341,
		/// <summary><c>PSRAD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E2 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psrad_xmm_xmmm128 = 2342,
		/// <summary><c>VPSRAD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E2 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrad_xmm_xmm_xmmm128 = 2343,
		/// <summary><c>VPSRAD ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E2 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrad_ymm_ymm_xmmm128 = 2344,
		/// <summary><c>VPSRAD xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 E2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrad_xmm_k1z_xmm_xmmm128 = 2345,
		/// <summary><c>VPSRAD ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 E2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrad_ymm_k1z_ymm_xmmm128 = 2346,
		/// <summary><c>VPSRAD zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 E2 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrad_zmm_k1z_zmm_xmmm128 = 2347,
		/// <summary><c>VPSRAQ xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 E2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraq_xmm_k1z_xmm_xmmm128 = 2348,
		/// <summary><c>VPSRAQ ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 E2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraq_ymm_k1z_ymm_xmmm128 = 2349,
		/// <summary><c>VPSRAQ zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 E2 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsraq_zmm_k1z_zmm_xmmm128 = 2350,
		/// <summary><c>PAVGW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E3 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pavgw_mm_mmm64 = 2351,
		/// <summary><c>PAVGW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E3 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pavgw_xmm_xmmm128 = 2352,
		/// <summary><c>VPAVGW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E3 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpavgw_xmm_xmm_xmmm128 = 2353,
		/// <summary><c>VPAVGW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E3 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpavgw_ymm_ymm_ymmm256 = 2354,
		/// <summary><c>VPAVGW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E3 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpavgw_xmm_k1z_xmm_xmmm128 = 2355,
		/// <summary><c>VPAVGW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E3 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpavgw_ymm_k1z_ymm_ymmm256 = 2356,
		/// <summary><c>VPAVGW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E3 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpavgw_zmm_k1z_zmm_zmmm512 = 2357,
		/// <summary><c>PMULHUW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E4 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulhuw_mm_mmm64 = 2358,
		/// <summary><c>PMULHUW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E4 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulhuw_xmm_xmmm128 = 2359,
		/// <summary><c>VPMULHUW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E4 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulhuw_xmm_xmm_xmmm128 = 2360,
		/// <summary><c>VPMULHUW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E4 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulhuw_ymm_ymm_ymmm256 = 2361,
		/// <summary><c>VPMULHUW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhuw_xmm_k1z_xmm_xmmm128 = 2362,
		/// <summary><c>VPMULHUW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhuw_ymm_k1z_ymm_ymmm256 = 2363,
		/// <summary><c>VPMULHUW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E4 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhuw_zmm_k1z_zmm_zmmm512 = 2364,
		/// <summary><c>PMULHW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E5 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulhw_mm_mmm64 = 2365,
		/// <summary><c>PMULHW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E5 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulhw_xmm_xmmm128 = 2366,
		/// <summary><c>VPMULHW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E5 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulhw_xmm_xmm_xmmm128 = 2367,
		/// <summary><c>VPMULHW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E5 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulhw_ymm_ymm_ymmm256 = 2368,
		/// <summary><c>VPMULHW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhw_xmm_k1z_xmm_xmmm128 = 2369,
		/// <summary><c>VPMULHW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhw_ymm_k1z_ymm_ymmm256 = 2370,
		/// <summary><c>VPMULHW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E5 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhw_zmm_k1z_zmm_zmmm512 = 2371,
		/// <summary><c>CVTTPD2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvttpd2dq_xmm_xmmm128 = 2372,
		/// <summary><c>VCVTTPD2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvttpd2dq_xmm_xmmm128 = 2373,
		/// <summary><c>VCVTTPD2DQ xmm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvttpd2dq_xmm_ymmm256 = 2374,
		/// <summary><c>VCVTTPD2DQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2dq_xmm_k1z_xmmm128b64 = 2375,
		/// <summary><c>VCVTTPD2DQ xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2dq_xmm_k1z_ymmm256b64 = 2376,
		/// <summary><c>VCVTTPD2DQ ymm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvttpd2dq_ymm_k1z_zmmm512b64_sae = 2377,
		/// <summary><c>CVTDQ2PD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>F3 0F E6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtdq2pd_xmm_xmmm64 = 2378,
		/// <summary><c>VCVTDQ2PD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.F3.0F.WIG E6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtdq2pd_xmm_xmmm64 = 2379,
		/// <summary><c>VCVTDQ2PD ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.F3.0F.WIG E6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtdq2pd_ymm_xmmm128 = 2380,
		/// <summary><c>VCVTDQ2PD xmm1 {k1}{z}, xmm2/m64/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W0 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtdq2pd_xmm_k1z_xmmm64b32 = 2381,
		/// <summary><c>VCVTDQ2PD ymm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W0 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtdq2pd_ymm_k1z_xmmm128b32 = 2382,
		/// <summary><c>VCVTDQ2PD zmm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W0 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtdq2pd_zmm_k1z_ymmm256b32 = 2383,
		/// <summary><c>VCVTQQ2PD xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtqq2pd_xmm_k1z_xmmm128b64 = 2384,
		/// <summary><c>VCVTQQ2PD ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtqq2pd_ymm_k1z_ymmm256b64 = 2385,
		/// <summary><c>VCVTQQ2PD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtqq2pd_zmm_k1z_zmmm512b64_er = 2386,
		/// <summary><c>CVTPD2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>F2 0F E6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Cvtpd2dq_xmm_xmmm128 = 2387,
		/// <summary><c>VCVTPD2DQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG E6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtpd2dq_xmm_xmmm128 = 2388,
		/// <summary><c>VCVTPD2DQ xmm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG E6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtpd2dq_xmm_ymmm256 = 2389,
		/// <summary><c>VCVTPD2DQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2dq_xmm_k1z_xmmm128b64 = 2390,
		/// <summary><c>VCVTPD2DQ xmm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2dq_xmm_k1z_ymmm256b64 = 2391,
		/// <summary><c>VCVTPD2DQ ymm1 {k1}{z}, zmm2/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F.W1 E6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtpd2dq_ymm_k1z_zmmm512b64_er = 2392,
		/// <summary><c>MOVNTQ m64, mm</c><br/>
		/// <br/>
		/// <c>NP 0F E7 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntq_m64_mm = 2393,
		/// <summary><c>MOVNTDQ m128, xmm1</c><br/>
		/// <br/>
		/// <c>66 0F E7 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntdq_m128_xmm = 2394,
		/// <summary><c>VMOVNTDQ m128, xmm1</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E7 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntdq_m128_xmm = 2395,
		/// <summary><c>VMOVNTDQ m256, ymm1</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E7 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntdq_m256_ymm = 2396,
		/// <summary><c>VMOVNTDQ m128, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 E7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntdq_m128_xmm = 2397,
		/// <summary><c>VMOVNTDQ m256, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 E7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntdq_m256_ymm = 2398,
		/// <summary><c>VMOVNTDQ m512, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 E7 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntdq_m512_zmm = 2399,
		/// <summary><c>PSUBSB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E8 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubsb_mm_mmm64 = 2400,
		/// <summary><c>PSUBSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E8 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubsb_xmm_xmmm128 = 2401,
		/// <summary><c>VPSUBSB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E8 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubsb_xmm_xmm_xmmm128 = 2402,
		/// <summary><c>VPSUBSB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E8 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubsb_ymm_ymm_ymmm256 = 2403,
		/// <summary><c>VPSUBSB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubsb_xmm_k1z_xmm_xmmm128 = 2404,
		/// <summary><c>VPSUBSB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubsb_ymm_k1z_ymm_ymmm256 = 2405,
		/// <summary><c>VPSUBSB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E8 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubsb_zmm_k1z_zmm_zmmm512 = 2406,
		/// <summary><c>PSUBSW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F E9 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubsw_mm_mmm64 = 2407,
		/// <summary><c>PSUBSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F E9 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubsw_xmm_xmmm128 = 2408,
		/// <summary><c>VPSUBSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG E9 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubsw_xmm_xmm_xmmm128 = 2409,
		/// <summary><c>VPSUBSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG E9 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubsw_ymm_ymm_ymmm256 = 2410,
		/// <summary><c>VPSUBSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG E9 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubsw_xmm_k1z_xmm_xmmm128 = 2411,
		/// <summary><c>VPSUBSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG E9 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubsw_ymm_k1z_ymm_ymmm256 = 2412,
		/// <summary><c>VPSUBSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG E9 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubsw_zmm_k1z_zmm_zmmm512 = 2413,
		/// <summary><c>PMINSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F EA /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminsw_mm_mmm64 = 2414,
		/// <summary><c>PMINSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F EA /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminsw_xmm_xmmm128 = 2415,
		/// <summary><c>VPMINSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG EA /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminsw_xmm_xmm_xmmm128 = 2416,
		/// <summary><c>VPMINSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG EA /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminsw_ymm_ymm_ymmm256 = 2417,
		/// <summary><c>VPMINSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG EA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsw_xmm_k1z_xmm_xmmm128 = 2418,
		/// <summary><c>VPMINSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG EA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsw_ymm_k1z_ymm_ymmm256 = 2419,
		/// <summary><c>VPMINSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG EA /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsw_zmm_k1z_zmm_zmmm512 = 2420,
		/// <summary><c>POR mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F EB /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Por_mm_mmm64 = 2421,
		/// <summary><c>POR xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F EB /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Por_xmm_xmmm128 = 2422,
		/// <summary><c>VPOR xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG EB /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpor_xmm_xmm_xmmm128 = 2423,
		/// <summary><c>VPOR ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG EB /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpor_ymm_ymm_ymmm256 = 2424,
		/// <summary><c>VPORD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 EB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpord_xmm_k1z_xmm_xmmm128b32 = 2425,
		/// <summary><c>VPORD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 EB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpord_ymm_k1z_ymm_ymmm256b32 = 2426,
		/// <summary><c>VPORD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 EB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpord_zmm_k1z_zmm_zmmm512b32 = 2427,
		/// <summary><c>VPORQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 EB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vporq_xmm_k1z_xmm_xmmm128b64 = 2428,
		/// <summary><c>VPORQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 EB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vporq_ymm_k1z_ymm_ymmm256b64 = 2429,
		/// <summary><c>VPORQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 EB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vporq_zmm_k1z_zmm_zmmm512b64 = 2430,
		/// <summary><c>PADDSB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F EC /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddsb_mm_mmm64 = 2431,
		/// <summary><c>PADDSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F EC /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddsb_xmm_xmmm128 = 2432,
		/// <summary><c>VPADDSB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG EC /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddsb_xmm_xmm_xmmm128 = 2433,
		/// <summary><c>VPADDSB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG EC /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddsb_ymm_ymm_ymmm256 = 2434,
		/// <summary><c>VPADDSB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG EC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddsb_xmm_k1z_xmm_xmmm128 = 2435,
		/// <summary><c>VPADDSB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG EC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddsb_ymm_k1z_ymm_ymmm256 = 2436,
		/// <summary><c>VPADDSB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG EC /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddsb_zmm_k1z_zmm_zmmm512 = 2437,
		/// <summary><c>PADDSW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F ED /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddsw_mm_mmm64 = 2438,
		/// <summary><c>PADDSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F ED /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddsw_xmm_xmmm128 = 2439,
		/// <summary><c>VPADDSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG ED /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddsw_xmm_xmm_xmmm128 = 2440,
		/// <summary><c>VPADDSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG ED /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddsw_ymm_ymm_ymmm256 = 2441,
		/// <summary><c>VPADDSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG ED /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddsw_xmm_k1z_xmm_xmmm128 = 2442,
		/// <summary><c>VPADDSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG ED /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddsw_ymm_k1z_ymm_ymmm256 = 2443,
		/// <summary><c>VPADDSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG ED /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddsw_zmm_k1z_zmm_zmmm512 = 2444,
		/// <summary><c>PMAXSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F EE /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxsw_mm_mmm64 = 2445,
		/// <summary><c>PMAXSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F EE /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxsw_xmm_xmmm128 = 2446,
		/// <summary><c>VPMAXSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG EE /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxsw_xmm_xmm_xmmm128 = 2447,
		/// <summary><c>VPMAXSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG EE /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxsw_ymm_ymm_ymmm256 = 2448,
		/// <summary><c>VPMAXSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG EE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsw_xmm_k1z_xmm_xmmm128 = 2449,
		/// <summary><c>VPMAXSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG EE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsw_ymm_k1z_ymm_ymmm256 = 2450,
		/// <summary><c>VPMAXSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG EE /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsw_zmm_k1z_zmm_zmmm512 = 2451,
		/// <summary><c>PXOR mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F EF /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pxor_mm_mmm64 = 2452,
		/// <summary><c>PXOR xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F EF /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pxor_xmm_xmmm128 = 2453,
		/// <summary><c>VPXOR xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG EF /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpxor_xmm_xmm_xmmm128 = 2454,
		/// <summary><c>VPXOR ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG EF /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpxor_ymm_ymm_ymmm256 = 2455,
		/// <summary><c>VPXORD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 EF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpxord_xmm_k1z_xmm_xmmm128b32 = 2456,
		/// <summary><c>VPXORD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 EF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpxord_ymm_k1z_ymm_ymmm256b32 = 2457,
		/// <summary><c>VPXORD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 EF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpxord_zmm_k1z_zmm_zmmm512b32 = 2458,
		/// <summary><c>VPXORQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 EF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpxorq_xmm_k1z_xmm_xmmm128b64 = 2459,
		/// <summary><c>VPXORQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 EF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpxorq_ymm_k1z_ymm_ymmm256b64 = 2460,
		/// <summary><c>VPXORQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 EF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpxorq_zmm_k1z_zmm_zmmm512b64 = 2461,
		/// <summary><c>LDDQU xmm1, m128</c><br/>
		/// <br/>
		/// <c>F2 0F F0 /r</c><br/>
		/// <br/>
		/// <c>SSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Lddqu_xmm_m128 = 2462,
		/// <summary><c>VLDDQU xmm1, m128</c><br/>
		/// <br/>
		/// <c>VEX.128.F2.0F.WIG F0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vlddqu_xmm_m128 = 2463,
		/// <summary><c>VLDDQU ymm1, m256</c><br/>
		/// <br/>
		/// <c>VEX.256.F2.0F.WIG F0 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vlddqu_ymm_m256 = 2464,
		/// <summary><c>PSLLW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F1 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllw_mm_mmm64 = 2465,
		/// <summary><c>PSLLW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F1 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllw_xmm_xmmm128 = 2466,
		/// <summary><c>VPSLLW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F1 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllw_xmm_xmm_xmmm128 = 2467,
		/// <summary><c>VPSLLW ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F1 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllw_ymm_ymm_xmmm128 = 2468,
		/// <summary><c>VPSLLW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG F1 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllw_xmm_k1z_xmm_xmmm128 = 2469,
		/// <summary><c>VPSLLW ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG F1 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllw_ymm_k1z_ymm_xmmm128 = 2470,
		/// <summary><c>VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG F1 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllw_zmm_k1z_zmm_xmmm128 = 2471,
		/// <summary><c>PSLLD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F2 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pslld_mm_mmm64 = 2472,
		/// <summary><c>PSLLD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F2 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pslld_xmm_xmmm128 = 2473,
		/// <summary><c>VPSLLD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F2 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpslld_xmm_xmm_xmmm128 = 2474,
		/// <summary><c>VPSLLD ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F2 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpslld_ymm_ymm_xmmm128 = 2475,
		/// <summary><c>VPSLLD xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 F2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslld_xmm_k1z_xmm_xmmm128 = 2476,
		/// <summary><c>VPSLLD ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 F2 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslld_ymm_k1z_ymm_xmmm128 = 2477,
		/// <summary><c>VPSLLD zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 F2 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpslld_zmm_k1z_zmm_xmmm128 = 2478,
		/// <summary><c>PSLLQ mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F3 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllq_mm_mmm64 = 2479,
		/// <summary><c>PSLLQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F3 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psllq_xmm_xmmm128 = 2480,
		/// <summary><c>VPSLLQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F3 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllq_xmm_xmm_xmmm128 = 2481,
		/// <summary><c>VPSLLQ ymm1, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F3 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllq_ymm_ymm_xmmm128 = 2482,
		/// <summary><c>VPSLLQ xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 F3 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllq_xmm_k1z_xmm_xmmm128 = 2483,
		/// <summary><c>VPSLLQ ymm1 {k1}{z}, ymm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 F3 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllq_ymm_k1z_ymm_xmmm128 = 2484,
		/// <summary><c>VPSLLQ zmm1 {k1}{z}, zmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 F3 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllq_zmm_k1z_zmm_xmmm128 = 2485,
		/// <summary><c>PMULUDQ mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F4 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmuludq_mm_mmm64 = 2486,
		/// <summary><c>PMULUDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F4 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmuludq_xmm_xmmm128 = 2487,
		/// <summary><c>VPMULUDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F4 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmuludq_xmm_xmm_xmmm128 = 2488,
		/// <summary><c>VPMULUDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F4 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmuludq_ymm_ymm_ymmm256 = 2489,
		/// <summary><c>VPMULUDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 F4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmuludq_xmm_k1z_xmm_xmmm128b64 = 2490,
		/// <summary><c>VPMULUDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 F4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmuludq_ymm_k1z_ymm_ymmm256b64 = 2491,
		/// <summary><c>VPMULUDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 F4 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmuludq_zmm_k1z_zmm_zmmm512b64 = 2492,
		/// <summary><c>PMADDWD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F5 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaddwd_mm_mmm64 = 2493,
		/// <summary><c>PMADDWD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F5 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaddwd_xmm_xmmm128 = 2494,
		/// <summary><c>VPMADDWD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F5 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaddwd_xmm_xmm_xmmm128 = 2495,
		/// <summary><c>VPMADDWD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F5 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaddwd_ymm_ymm_ymmm256 = 2496,
		/// <summary><c>VPMADDWD xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG F5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaddwd_xmm_k1z_xmm_xmmm128 = 2497,
		/// <summary><c>VPMADDWD ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG F5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaddwd_ymm_k1z_ymm_ymmm256 = 2498,
		/// <summary><c>VPMADDWD zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG F5 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaddwd_zmm_k1z_zmm_zmmm512 = 2499,
		/// <summary><c>PSADBW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F6 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psadbw_mm_mmm64 = 2500,
		/// <summary><c>PSADBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F6 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psadbw_xmm_xmmm128 = 2501,
		/// <summary><c>VPSADBW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F6 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsadbw_xmm_xmm_xmmm128 = 2502,
		/// <summary><c>VPSADBW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F6 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsadbw_ymm_ymm_ymmm256 = 2503,
		/// <summary><c>VPSADBW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG F6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsadbw_xmm_xmm_xmmm128 = 2504,
		/// <summary><c>VPSADBW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG F6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsadbw_ymm_ymm_ymmm256 = 2505,
		/// <summary><c>VPSADBW zmm1, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG F6 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsadbw_zmm_zmm_zmmm512 = 2506,
		/// <summary><c>MASKMOVQ mm1, mm2</c><br/>
		/// <br/>
		/// <c>NP 0F F7 /r</c><br/>
		/// <br/>
		/// <c>SSE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Maskmovq_rDI_mm_mm = 2507,
		/// <summary><c>MASKMOVDQU xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>66 0F F7 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Maskmovdqu_rDI_xmm_xmm = 2508,
		/// <summary><c>VMASKMOVDQU xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F7 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovdqu_rDI_xmm_xmm = 2509,
		/// <summary><c>PSUBB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F8 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubb_mm_mmm64 = 2510,
		/// <summary><c>PSUBB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F8 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubb_xmm_xmmm128 = 2511,
		/// <summary><c>VPSUBB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F8 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubb_xmm_xmm_xmmm128 = 2512,
		/// <summary><c>VPSUBB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F8 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubb_ymm_ymm_ymmm256 = 2513,
		/// <summary><c>VPSUBB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG F8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubb_xmm_k1z_xmm_xmmm128 = 2514,
		/// <summary><c>VPSUBB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG F8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubb_ymm_k1z_ymm_ymmm256 = 2515,
		/// <summary><c>VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG F8 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubb_zmm_k1z_zmm_zmmm512 = 2516,
		/// <summary><c>PSUBW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F F9 /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubw_mm_mmm64 = 2517,
		/// <summary><c>PSUBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F F9 /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubw_xmm_xmmm128 = 2518,
		/// <summary><c>VPSUBW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG F9 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubw_xmm_xmm_xmmm128 = 2519,
		/// <summary><c>VPSUBW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG F9 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubw_ymm_ymm_ymmm256 = 2520,
		/// <summary><c>VPSUBW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG F9 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubw_xmm_k1z_xmm_xmmm128 = 2521,
		/// <summary><c>VPSUBW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG F9 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubw_ymm_k1z_ymm_ymmm256 = 2522,
		/// <summary><c>VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG F9 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubw_zmm_k1z_zmm_zmmm512 = 2523,
		/// <summary><c>PSUBD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F FA /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubd_mm_mmm64 = 2524,
		/// <summary><c>PSUBD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F FA /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubd_xmm_xmmm128 = 2525,
		/// <summary><c>VPSUBD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG FA /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubd_xmm_xmm_xmmm128 = 2526,
		/// <summary><c>VPSUBD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG FA /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubd_ymm_ymm_ymmm256 = 2527,
		/// <summary><c>VPSUBD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 FA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubd_xmm_k1z_xmm_xmmm128b32 = 2528,
		/// <summary><c>VPSUBD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 FA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubd_ymm_k1z_ymm_ymmm256b32 = 2529,
		/// <summary><c>VPSUBD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 FA /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubd_zmm_k1z_zmm_zmmm512b32 = 2530,
		/// <summary><c>PSUBQ mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F FB /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubq_mm_mmm64 = 2531,
		/// <summary><c>PSUBQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F FB /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psubq_xmm_xmmm128 = 2532,
		/// <summary><c>VPSUBQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG FB /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubq_xmm_xmm_xmmm128 = 2533,
		/// <summary><c>VPSUBQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG FB /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsubq_ymm_ymm_ymmm256 = 2534,
		/// <summary><c>VPSUBQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W1 FB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubq_xmm_k1z_xmm_xmmm128b64 = 2535,
		/// <summary><c>VPSUBQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W1 FB /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubq_ymm_k1z_ymm_ymmm256b64 = 2536,
		/// <summary><c>VPSUBQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W1 FB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsubq_zmm_k1z_zmm_zmmm512b64 = 2537,
		/// <summary><c>PADDB mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F FC /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddb_mm_mmm64 = 2538,
		/// <summary><c>PADDB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F FC /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddb_xmm_xmmm128 = 2539,
		/// <summary><c>VPADDB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG FC /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddb_xmm_xmm_xmmm128 = 2540,
		/// <summary><c>VPADDB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG FC /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddb_ymm_ymm_ymmm256 = 2541,
		/// <summary><c>VPADDB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG FC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddb_xmm_k1z_xmm_xmmm128 = 2542,
		/// <summary><c>VPADDB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG FC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddb_ymm_k1z_ymm_ymmm256 = 2543,
		/// <summary><c>VPADDB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG FC /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddb_zmm_k1z_zmm_zmmm512 = 2544,
		/// <summary><c>PADDW mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F FD /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddw_mm_mmm64 = 2545,
		/// <summary><c>PADDW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F FD /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddw_xmm_xmmm128 = 2546,
		/// <summary><c>VPADDW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG FD /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddw_xmm_xmm_xmmm128 = 2547,
		/// <summary><c>VPADDW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG FD /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddw_ymm_ymm_ymmm256 = 2548,
		/// <summary><c>VPADDW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.WIG FD /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddw_xmm_k1z_xmm_xmmm128 = 2549,
		/// <summary><c>VPADDW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.WIG FD /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddw_ymm_k1z_ymm_ymmm256 = 2550,
		/// <summary><c>VPADDW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.WIG FD /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddw_zmm_k1z_zmm_zmmm512 = 2551,
		/// <summary><c>PADDD mm, mm/m64</c><br/>
		/// <br/>
		/// <c>NP 0F FE /r</c><br/>
		/// <br/>
		/// <c>MMX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddd_mm_mmm64 = 2552,
		/// <summary><c>PADDD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F FE /r</c><br/>
		/// <br/>
		/// <c>SSE2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Paddd_xmm_xmmm128 = 2553,
		/// <summary><c>VPADDD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F.WIG FE /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddd_xmm_xmm_xmmm128 = 2554,
		/// <summary><c>VPADDD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F.WIG FE /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpaddd_ymm_ymm_ymmm256 = 2555,
		/// <summary><c>VPADDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F.W0 FE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddd_xmm_k1z_xmm_xmmm128b32 = 2556,
		/// <summary><c>VPADDD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F.W0 FE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddd_ymm_k1z_ymm_ymmm256b32 = 2557,
		/// <summary><c>VPADDD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F.W0 FE /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpaddd_zmm_k1z_zmm_zmmm512b32 = 2558,
		/// <summary><c>UD0 r16, r/m16</c><br/>
		/// <br/>
		/// <c>o16 0F FF /r</c><br/>
		/// <br/>
		/// <c>286+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ud0_r16_rm16 = 2559,
		/// <summary><c>UD0 r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 0F FF /r</c><br/>
		/// <br/>
		/// <c>386+</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ud0_r32_rm32 = 2560,
		/// <summary><c>UD0 r64, r/m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F FF /r</c><br/>
		/// <br/>
		/// <c>X64</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Ud0_r64_rm64 = 2561,
		/// <summary><c>PSHUFB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 00 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pshufb_mm_mmm64 = 2562,
		/// <summary><c>PSHUFB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 00 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pshufb_xmm_xmmm128 = 2563,
		/// <summary><c>VPSHUFB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 00 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshufb_xmm_xmm_xmmm128 = 2564,
		/// <summary><c>VPSHUFB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 00 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpshufb_ymm_ymm_ymmm256 = 2565,
		/// <summary><c>VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 00 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufb_xmm_k1z_xmm_xmmm128 = 2566,
		/// <summary><c>VPSHUFB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 00 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufb_ymm_k1z_ymm_ymmm256 = 2567,
		/// <summary><c>VPSHUFB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 00 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufb_zmm_k1z_zmm_zmmm512 = 2568,
		/// <summary><c>PHADDW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 01 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phaddw_mm_mmm64 = 2569,
		/// <summary><c>PHADDW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 01 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phaddw_xmm_xmmm128 = 2570,
		/// <summary><c>VPHADDW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 01 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphaddw_xmm_xmm_xmmm128 = 2571,
		/// <summary><c>VPHADDW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 01 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphaddw_ymm_ymm_ymmm256 = 2572,
		/// <summary><c>PHADDD mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 02 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phaddd_mm_mmm64 = 2573,
		/// <summary><c>PHADDD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 02 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phaddd_xmm_xmmm128 = 2574,
		/// <summary><c>VPHADDD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 02 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphaddd_xmm_xmm_xmmm128 = 2575,
		/// <summary><c>VPHADDD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 02 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphaddd_ymm_ymm_ymmm256 = 2576,
		/// <summary><c>PHADDSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 03 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phaddsw_mm_mmm64 = 2577,
		/// <summary><c>PHADDSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 03 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phaddsw_xmm_xmmm128 = 2578,
		/// <summary><c>VPHADDSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 03 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphaddsw_xmm_xmm_xmmm128 = 2579,
		/// <summary><c>VPHADDSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 03 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphaddsw_ymm_ymm_ymmm256 = 2580,
		/// <summary><c>PMADDUBSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 04 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaddubsw_mm_mmm64 = 2581,
		/// <summary><c>PMADDUBSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 04 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaddubsw_xmm_xmmm128 = 2582,
		/// <summary><c>VPMADDUBSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 04 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaddubsw_xmm_xmm_xmmm128 = 2583,
		/// <summary><c>VPMADDUBSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 04 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaddubsw_ymm_ymm_ymmm256 = 2584,
		/// <summary><c>VPMADDUBSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 04 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaddubsw_xmm_k1z_xmm_xmmm128 = 2585,
		/// <summary><c>VPMADDUBSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 04 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaddubsw_ymm_k1z_ymm_ymmm256 = 2586,
		/// <summary><c>VPMADDUBSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 04 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaddubsw_zmm_k1z_zmm_zmmm512 = 2587,
		/// <summary><c>PHSUBW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 05 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phsubw_mm_mmm64 = 2588,
		/// <summary><c>PHSUBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 05 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phsubw_xmm_xmmm128 = 2589,
		/// <summary><c>VPHSUBW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 05 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphsubw_xmm_xmm_xmmm128 = 2590,
		/// <summary><c>VPHSUBW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 05 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphsubw_ymm_ymm_ymmm256 = 2591,
		/// <summary><c>PHSUBD mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 06 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phsubd_mm_mmm64 = 2592,
		/// <summary><c>PHSUBD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 06 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phsubd_xmm_xmmm128 = 2593,
		/// <summary><c>VPHSUBD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 06 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphsubd_xmm_xmm_xmmm128 = 2594,
		/// <summary><c>VPHSUBD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 06 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphsubd_ymm_ymm_ymmm256 = 2595,
		/// <summary><c>PHSUBSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 07 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phsubsw_mm_mmm64 = 2596,
		/// <summary><c>PHSUBSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 07 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phsubsw_xmm_xmmm128 = 2597,
		/// <summary><c>VPHSUBSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 07 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphsubsw_xmm_xmm_xmmm128 = 2598,
		/// <summary><c>VPHSUBSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 07 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphsubsw_ymm_ymm_ymmm256 = 2599,
		/// <summary><c>PSIGNB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 08 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psignb_mm_mmm64 = 2600,
		/// <summary><c>PSIGNB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 08 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psignb_xmm_xmmm128 = 2601,
		/// <summary><c>VPSIGNB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 08 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsignb_xmm_xmm_xmmm128 = 2602,
		/// <summary><c>VPSIGNB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 08 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsignb_ymm_ymm_ymmm256 = 2603,
		/// <summary><c>PSIGNW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 09 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psignw_mm_mmm64 = 2604,
		/// <summary><c>PSIGNW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 09 /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psignw_xmm_xmmm128 = 2605,
		/// <summary><c>VPSIGNW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 09 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsignw_xmm_xmm_xmmm128 = 2606,
		/// <summary><c>VPSIGNW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 09 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsignw_ymm_ymm_ymmm256 = 2607,
		/// <summary><c>PSIGND mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 0A /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psignd_mm_mmm64 = 2608,
		/// <summary><c>PSIGND xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 0A /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Psignd_xmm_xmmm128 = 2609,
		/// <summary><c>VPSIGND xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 0A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsignd_xmm_xmm_xmmm128 = 2610,
		/// <summary><c>VPSIGND ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 0A /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsignd_ymm_ymm_ymmm256 = 2611,
		/// <summary><c>PMULHRSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 0B /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulhrsw_mm_mmm64 = 2612,
		/// <summary><c>PMULHRSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 0B /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulhrsw_xmm_xmmm128 = 2613,
		/// <summary><c>VPMULHRSW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 0B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulhrsw_xmm_xmm_xmmm128 = 2614,
		/// <summary><c>VPMULHRSW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 0B /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulhrsw_ymm_ymm_ymmm256 = 2615,
		/// <summary><c>VPMULHRSW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 0B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhrsw_xmm_k1z_xmm_xmmm128 = 2616,
		/// <summary><c>VPMULHRSW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 0B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhrsw_ymm_k1z_ymm_ymmm256 = 2617,
		/// <summary><c>VPMULHRSW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 0B /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulhrsw_zmm_k1z_zmm_zmmm512 = 2618,
		/// <summary><c>VPERMILPS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 0C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilps_xmm_xmm_xmmm128 = 2619,
		/// <summary><c>VPERMILPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 0C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilps_ymm_ymm_ymmm256 = 2620,
		/// <summary><c>VPERMILPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 0C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilps_xmm_k1z_xmm_xmmm128b32 = 2621,
		/// <summary><c>VPERMILPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 0C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilps_ymm_k1z_ymm_ymmm256b32 = 2622,
		/// <summary><c>VPERMILPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 0C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilps_zmm_k1z_zmm_zmmm512b32 = 2623,
		/// <summary><c>VPERMILPD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 0D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilpd_xmm_xmm_xmmm128 = 2624,
		/// <summary><c>VPERMILPD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 0D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilpd_ymm_ymm_ymmm256 = 2625,
		/// <summary><c>VPERMILPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 0D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilpd_xmm_k1z_xmm_xmmm128b64 = 2626,
		/// <summary><c>VPERMILPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 0D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilpd_ymm_k1z_ymm_ymmm256b64 = 2627,
		/// <summary><c>VPERMILPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 0D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilpd_zmm_k1z_zmm_zmmm512b64 = 2628,
		/// <summary><c>VTESTPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 0E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vtestps_xmm_xmmm128 = 2629,
		/// <summary><c>VTESTPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 0E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vtestps_ymm_ymmm256 = 2630,
		/// <summary><c>VTESTPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 0F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vtestpd_xmm_xmmm128 = 2631,
		/// <summary><c>VTESTPD ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 0F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vtestpd_ymm_ymmm256 = 2632,
		/// <summary><c>PBLENDVB xmm1, xmm2/m128, &lt;XMM0&gt;</c><br/>
		/// <br/>
		/// <c>66 0F 38 10 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pblendvb_xmm_xmmm128 = 2633,
		/// <summary><c>VPSRLVW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvw_xmm_k1z_xmm_xmmm128 = 2634,
		/// <summary><c>VPSRLVW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvw_ymm_k1z_ymm_ymmm256 = 2635,
		/// <summary><c>VPSRLVW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvw_zmm_k1z_zmm_zmmm512 = 2636,
		/// <summary><c>VPMOVUSWB xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovuswb_xmmm64_k1z_xmm = 2637,
		/// <summary><c>VPMOVUSWB xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovuswb_xmmm128_k1z_ymm = 2638,
		/// <summary><c>VPMOVUSWB ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 10 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovuswb_ymmm256_k1z_zmm = 2639,
		/// <summary><c>VPSRAVW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravw_xmm_k1z_xmm_xmmm128 = 2640,
		/// <summary><c>VPSRAVW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravw_ymm_k1z_ymm_ymmm256 = 2641,
		/// <summary><c>VPSRAVW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravw_zmm_k1z_zmm_zmmm512 = 2642,
		/// <summary><c>VPMOVUSDB xmm1/m32 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusdb_xmmm32_k1z_xmm = 2643,
		/// <summary><c>VPMOVUSDB xmm1/m64 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusdb_xmmm64_k1z_ymm = 2644,
		/// <summary><c>VPMOVUSDB xmm1/m128 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 11 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusdb_xmmm128_k1z_zmm = 2645,
		/// <summary><c>VPSLLVW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvw_xmm_k1z_xmm_xmmm128 = 2646,
		/// <summary><c>VPSLLVW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvw_ymm_k1z_ymm_ymmm256 = 2647,
		/// <summary><c>VPSLLVW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvw_zmm_k1z_zmm_zmmm512 = 2648,
		/// <summary><c>VPMOVUSQB xmm1/m16 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqb_xmmm16_k1z_xmm = 2649,
		/// <summary><c>VPMOVUSQB xmm1/m32 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqb_xmmm32_k1z_ymm = 2650,
		/// <summary><c>VPMOVUSQB xmm1/m64 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 12 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqb_xmmm64_k1z_zmm = 2651,
		/// <summary><c>VCVTPH2PS xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>F16C</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtph2ps_xmm_xmmm64 = 2652,
		/// <summary><c>VCVTPH2PS ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>F16C</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtph2ps_ymm_xmmm128 = 2653,
		/// <summary><c>VCVTPH2PS xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtph2ps_xmm_k1z_xmmm64 = 2654,
		/// <summary><c>VCVTPH2PS ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtph2ps_ymm_k1z_xmmm128 = 2655,
		/// <summary><c>VCVTPH2PS zmm1 {k1}{z}, ymm2/m256{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtph2ps_zmm_k1z_ymmm256_sae = 2656,
		/// <summary><c>VPMOVUSDW xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusdw_xmmm64_k1z_xmm = 2657,
		/// <summary><c>VPMOVUSDW xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusdw_xmmm128_k1z_ymm = 2658,
		/// <summary><c>VPMOVUSDW ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 13 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusdw_ymmm256_k1z_zmm = 2659,
		/// <summary><c>BLENDVPS xmm1, xmm2/m128, &lt;XMM0&gt;</c><br/>
		/// <br/>
		/// <c>66 0F 38 14 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Blendvps_xmm_xmmm128 = 2660,
		/// <summary><c>VPRORVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorvd_xmm_k1z_xmm_xmmm128b32 = 2661,
		/// <summary><c>VPRORVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorvd_ymm_k1z_ymm_ymmm256b32 = 2662,
		/// <summary><c>VPRORVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorvd_zmm_k1z_zmm_zmmm512b32 = 2663,
		/// <summary><c>VPRORVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorvq_xmm_k1z_xmm_xmmm128b64 = 2664,
		/// <summary><c>VPRORVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorvq_ymm_k1z_ymm_ymmm256b64 = 2665,
		/// <summary><c>VPRORVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprorvq_zmm_k1z_zmm_zmmm512b64 = 2666,
		/// <summary><c>VPMOVUSQW xmm1/m32 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqw_xmmm32_k1z_xmm = 2667,
		/// <summary><c>VPMOVUSQW xmm1/m64 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqw_xmmm64_k1z_ymm = 2668,
		/// <summary><c>VPMOVUSQW xmm1/m128 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 14 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqw_xmmm128_k1z_zmm = 2669,
		/// <summary><c>BLENDVPD xmm1, xmm2/m128, &lt;XMM0&gt;</c><br/>
		/// <br/>
		/// <c>66 0F 38 15 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Blendvpd_xmm_xmmm128 = 2670,
		/// <summary><c>VPROLVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolvd_xmm_k1z_xmm_xmmm128b32 = 2671,
		/// <summary><c>VPROLVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolvd_ymm_k1z_ymm_ymmm256b32 = 2672,
		/// <summary><c>VPROLVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolvd_zmm_k1z_zmm_zmmm512b32 = 2673,
		/// <summary><c>VPROLVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolvq_xmm_k1z_xmm_xmmm128b64 = 2674,
		/// <summary><c>VPROLVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolvq_ymm_k1z_ymm_ymmm256b64 = 2675,
		/// <summary><c>VPROLVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vprolvq_zmm_k1z_zmm_zmmm512b64 = 2676,
		/// <summary><c>VPMOVUSQD xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqd_xmmm64_k1z_xmm = 2677,
		/// <summary><c>VPMOVUSQD xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqd_xmmm128_k1z_ymm = 2678,
		/// <summary><c>VPMOVUSQD ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 15 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovusqd_ymmm256_k1z_zmm = 2679,
		/// <summary><c>VPERMPS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermps_ymm_ymm_ymmm256 = 2680,
		/// <summary><c>VPERMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermps_ymm_k1z_ymm_ymmm256b32 = 2681,
		/// <summary><c>VPERMPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermps_zmm_k1z_zmm_zmmm512b32 = 2682,
		/// <summary><c>VPERMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermpd_ymm_k1z_ymm_ymmm256b64 = 2683,
		/// <summary><c>VPERMPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 16 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermpd_zmm_k1z_zmm_zmmm512b64 = 2684,
		/// <summary><c>PTEST xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 17 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Ptest_xmm_xmmm128 = 2685,
		/// <summary><c>VPTEST xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 17 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vptest_xmm_xmmm128 = 2686,
		/// <summary><c>VPTEST ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 17 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vptest_ymm_ymmm256 = 2687,
		/// <summary><c>VBROADCASTSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 18 /r</c><br/>
		/// <br/>
		/// <c>AVX (reg,mem) or AVX2 (reg,reg)</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vbroadcastss_xmm_xmmm32 = 2688,
		/// <summary><c>VBROADCASTSS ymm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 18 /r</c><br/>
		/// <br/>
		/// <c>AVX (reg,mem) or AVX2 (reg,reg)</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vbroadcastss_ymm_xmmm32 = 2689,
		/// <summary><c>VBROADCASTSS xmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 18 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastss_xmm_k1z_xmmm32 = 2690,
		/// <summary><c>VBROADCASTSS ymm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 18 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastss_ymm_k1z_xmmm32 = 2691,
		/// <summary><c>VBROADCASTSS zmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 18 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastss_zmm_k1z_xmmm32 = 2692,
		/// <summary><c>VBROADCASTSD ymm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 19 /r</c><br/>
		/// <br/>
		/// <c>AVX (reg,mem) or AVX2 (reg,reg)</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vbroadcastsd_ymm_xmmm64 = 2693,
		/// <summary><c>VBROADCASTF32X2 ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 19 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf32x2_ymm_k1z_xmmm64 = 2694,
		/// <summary><c>VBROADCASTF32X2 zmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 19 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf32x2_zmm_k1z_xmmm64 = 2695,
		/// <summary><c>VBROADCASTSD ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 19 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastsd_ymm_k1z_xmmm64 = 2696,
		/// <summary><c>VBROADCASTSD zmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 19 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastsd_zmm_k1z_xmmm64 = 2697,
		/// <summary><c>VBROADCASTF128 ymm1, m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 1A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vbroadcastf128_ymm_m128 = 2698,
		/// <summary><c>VBROADCASTF32X4 ymm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 1A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf32x4_ymm_k1z_m128 = 2699,
		/// <summary><c>VBROADCASTF32X4 zmm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 1A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf32x4_zmm_k1z_m128 = 2700,
		/// <summary><c>VBROADCASTF64X2 ymm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 1A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf64x2_ymm_k1z_m128 = 2701,
		/// <summary><c>VBROADCASTF64X2 zmm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 1A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf64x2_zmm_k1z_m128 = 2702,
		/// <summary><c>VBROADCASTF32X8 zmm1 {k1}{z}, m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 1B /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf32x8_zmm_k1z_m256 = 2703,
		/// <summary><c>VBROADCASTF64X4 zmm1 {k1}{z}, m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 1B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcastf64x4_zmm_k1z_m256 = 2704,
		/// <summary><c>PABSB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 1C /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pabsb_mm_mmm64 = 2705,
		/// <summary><c>PABSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 1C /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pabsb_xmm_xmmm128 = 2706,
		/// <summary><c>VPABSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 1C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpabsb_xmm_xmmm128 = 2707,
		/// <summary><c>VPABSB ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 1C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpabsb_ymm_ymmm256 = 2708,
		/// <summary><c>VPABSB xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 1C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsb_xmm_k1z_xmmm128 = 2709,
		/// <summary><c>VPABSB ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 1C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsb_ymm_k1z_ymmm256 = 2710,
		/// <summary><c>VPABSB zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 1C /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsb_zmm_k1z_zmmm512 = 2711,
		/// <summary><c>PABSW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 1D /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pabsw_mm_mmm64 = 2712,
		/// <summary><c>PABSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 1D /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pabsw_xmm_xmmm128 = 2713,
		/// <summary><c>VPABSW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 1D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpabsw_xmm_xmmm128 = 2714,
		/// <summary><c>VPABSW ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 1D /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpabsw_ymm_ymmm256 = 2715,
		/// <summary><c>VPABSW xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 1D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsw_xmm_k1z_xmmm128 = 2716,
		/// <summary><c>VPABSW ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 1D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsw_ymm_k1z_ymmm256 = 2717,
		/// <summary><c>VPABSW zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 1D /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsw_zmm_k1z_zmmm512 = 2718,
		/// <summary><c>PABSD mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>NP 0F 38 1E /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pabsd_mm_mmm64 = 2719,
		/// <summary><c>PABSD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 1E /r</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pabsd_xmm_xmmm128 = 2720,
		/// <summary><c>VPABSD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 1E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpabsd_xmm_xmmm128 = 2721,
		/// <summary><c>VPABSD ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 1E /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpabsd_ymm_ymmm256 = 2722,
		/// <summary><c>VPABSD xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 1E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsd_xmm_k1z_xmmm128b32 = 2723,
		/// <summary><c>VPABSD ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 1E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsd_ymm_k1z_ymmm256b32 = 2724,
		/// <summary><c>VPABSD zmm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 1E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsd_zmm_k1z_zmmm512b32 = 2725,
		/// <summary><c>VPABSQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 1F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsq_xmm_k1z_xmmm128b64 = 2726,
		/// <summary><c>VPABSQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 1F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsq_ymm_k1z_ymmm256b64 = 2727,
		/// <summary><c>VPABSQ zmm1 {k1}{z}, zmm2/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 1F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpabsq_zmm_k1z_zmmm512b64 = 2728,
		/// <summary><c>PMOVSXBW xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 38 20 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovsxbw_xmm_xmmm64 = 2729,
		/// <summary><c>VPMOVSXBW xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 20 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxbw_xmm_xmmm64 = 2730,
		/// <summary><c>VPMOVSXBW ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 20 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxbw_ymm_xmmm128 = 2731,
		/// <summary><c>VPMOVSXBW xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 20 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbw_xmm_k1z_xmmm64 = 2732,
		/// <summary><c>VPMOVSXBW ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 20 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbw_ymm_k1z_xmmm128 = 2733,
		/// <summary><c>VPMOVSXBW zmm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 20 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbw_zmm_k1z_ymmm256 = 2734,
		/// <summary><c>VPMOVSWB xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 20 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovswb_xmmm64_k1z_xmm = 2735,
		/// <summary><c>VPMOVSWB xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 20 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovswb_xmmm128_k1z_ymm = 2736,
		/// <summary><c>VPMOVSWB ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 20 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovswb_ymmm256_k1z_zmm = 2737,
		/// <summary><c>PMOVSXBD xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>66 0F 38 21 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovsxbd_xmm_xmmm32 = 2738,
		/// <summary><c>VPMOVSXBD xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 21 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxbd_xmm_xmmm32 = 2739,
		/// <summary><c>VPMOVSXBD ymm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 21 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxbd_ymm_xmmm64 = 2740,
		/// <summary><c>VPMOVSXBD xmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 21 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbd_xmm_k1z_xmmm32 = 2741,
		/// <summary><c>VPMOVSXBD ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 21 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbd_ymm_k1z_xmmm64 = 2742,
		/// <summary><c>VPMOVSXBD zmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 21 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbd_zmm_k1z_xmmm128 = 2743,
		/// <summary><c>VPMOVSDB xmm1/m32 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 21 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsdb_xmmm32_k1z_xmm = 2744,
		/// <summary><c>VPMOVSDB xmm1/m64 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 21 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsdb_xmmm64_k1z_ymm = 2745,
		/// <summary><c>VPMOVSDB xmm1/m128 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 21 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsdb_xmmm128_k1z_zmm = 2746,
		/// <summary><c>PMOVSXBQ xmm1, xmm2/m16</c><br/>
		/// <br/>
		/// <c>66 0F 38 22 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovsxbq_xmm_xmmm16 = 2747,
		/// <summary><c>VPMOVSXBQ xmm1, xmm2/m16</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 22 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxbq_xmm_xmmm16 = 2748,
		/// <summary><c>VPMOVSXBQ ymm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 22 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxbq_ymm_xmmm32 = 2749,
		/// <summary><c>VPMOVSXBQ xmm1 {k1}{z}, xmm2/m16</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 22 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbq_xmm_k1z_xmmm16 = 2750,
		/// <summary><c>VPMOVSXBQ ymm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 22 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbq_ymm_k1z_xmmm32 = 2751,
		/// <summary><c>VPMOVSXBQ zmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 22 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxbq_zmm_k1z_xmmm64 = 2752,
		/// <summary><c>VPMOVSQB xmm1/m16 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 22 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqb_xmmm16_k1z_xmm = 2753,
		/// <summary><c>VPMOVSQB xmm1/m32 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 22 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqb_xmmm32_k1z_ymm = 2754,
		/// <summary><c>VPMOVSQB xmm1/m64 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 22 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqb_xmmm64_k1z_zmm = 2755,
		/// <summary><c>PMOVSXWD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 38 23 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovsxwd_xmm_xmmm64 = 2756,
		/// <summary><c>VPMOVSXWD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 23 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxwd_xmm_xmmm64 = 2757,
		/// <summary><c>VPMOVSXWD ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 23 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxwd_ymm_xmmm128 = 2758,
		/// <summary><c>VPMOVSXWD xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 23 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxwd_xmm_k1z_xmmm64 = 2759,
		/// <summary><c>VPMOVSXWD ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 23 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxwd_ymm_k1z_xmmm128 = 2760,
		/// <summary><c>VPMOVSXWD zmm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 23 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxwd_zmm_k1z_ymmm256 = 2761,
		/// <summary><c>VPMOVSDW xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 23 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsdw_xmmm64_k1z_xmm = 2762,
		/// <summary><c>VPMOVSDW xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 23 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsdw_xmmm128_k1z_ymm = 2763,
		/// <summary><c>VPMOVSDW ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 23 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsdw_ymmm256_k1z_zmm = 2764,
		/// <summary><c>PMOVSXWQ xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>66 0F 38 24 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovsxwq_xmm_xmmm32 = 2765,
		/// <summary><c>VPMOVSXWQ xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 24 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxwq_xmm_xmmm32 = 2766,
		/// <summary><c>VPMOVSXWQ ymm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 24 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxwq_ymm_xmmm64 = 2767,
		/// <summary><c>VPMOVSXWQ xmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 24 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxwq_xmm_k1z_xmmm32 = 2768,
		/// <summary><c>VPMOVSXWQ ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 24 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxwq_ymm_k1z_xmmm64 = 2769,
		/// <summary><c>VPMOVSXWQ zmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 24 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxwq_zmm_k1z_xmmm128 = 2770,
		/// <summary><c>VPMOVSQW xmm1/m32 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 24 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqw_xmmm32_k1z_xmm = 2771,
		/// <summary><c>VPMOVSQW xmm1/m64 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 24 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqw_xmmm64_k1z_ymm = 2772,
		/// <summary><c>VPMOVSQW xmm1/m128 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 24 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqw_xmmm128_k1z_zmm = 2773,
		/// <summary><c>PMOVSXDQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 38 25 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovsxdq_xmm_xmmm64 = 2774,
		/// <summary><c>VPMOVSXDQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 25 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxdq_xmm_xmmm64 = 2775,
		/// <summary><c>VPMOVSXDQ ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 25 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovsxdq_ymm_xmmm128 = 2776,
		/// <summary><c>VPMOVSXDQ xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 25 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxdq_xmm_k1z_xmmm64 = 2777,
		/// <summary><c>VPMOVSXDQ ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 25 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxdq_ymm_k1z_xmmm128 = 2778,
		/// <summary><c>VPMOVSXDQ zmm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 25 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsxdq_zmm_k1z_ymmm256 = 2779,
		/// <summary><c>VPMOVSQD xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 25 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqd_xmmm64_k1z_xmm = 2780,
		/// <summary><c>VPMOVSQD xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 25 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqd_xmmm128_k1z_ymm = 2781,
		/// <summary><c>VPMOVSQD ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 25 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovsqd_ymmm256_k1z_zmm = 2782,
		/// <summary><c>VPTESTMB k2 {k1}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmb_k_k1_xmm_xmmm128 = 2783,
		/// <summary><c>VPTESTMB k2 {k1}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmb_k_k1_ymm_ymmm256 = 2784,
		/// <summary><c>VPTESTMB k2 {k1}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmb_k_k1_zmm_zmmm512 = 2785,
		/// <summary><c>VPTESTMW k2 {k1}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmw_k_k1_xmm_xmmm128 = 2786,
		/// <summary><c>VPTESTMW k2 {k1}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmw_k_k1_ymm_ymmm256 = 2787,
		/// <summary><c>VPTESTMW k2 {k1}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmw_k_k1_zmm_zmmm512 = 2788,
		/// <summary><c>VPTESTNMB k2 {k1}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmb_k_k1_xmm_xmmm128 = 2789,
		/// <summary><c>VPTESTNMB k2 {k1}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmb_k_k1_ymm_ymmm256 = 2790,
		/// <summary><c>VPTESTNMB k2 {k1}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmb_k_k1_zmm_zmmm512 = 2791,
		/// <summary><c>VPTESTNMW k2 {k1}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmw_k_k1_xmm_xmmm128 = 2792,
		/// <summary><c>VPTESTNMW k2 {k1}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmw_k_k1_ymm_ymmm256 = 2793,
		/// <summary><c>VPTESTNMW k2 {k1}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 26 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmw_k_k1_zmm_zmmm512 = 2794,
		/// <summary><c>VPTESTMD k2 {k1}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmd_k_k1_xmm_xmmm128b32 = 2795,
		/// <summary><c>VPTESTMD k2 {k1}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmd_k_k1_ymm_ymmm256b32 = 2796,
		/// <summary><c>VPTESTMD k2 {k1}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmd_k_k1_zmm_zmmm512b32 = 2797,
		/// <summary><c>VPTESTMQ k2 {k1}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmq_k_k1_xmm_xmmm128b64 = 2798,
		/// <summary><c>VPTESTMQ k2 {k1}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmq_k_k1_ymm_ymmm256b64 = 2799,
		/// <summary><c>VPTESTMQ k2 {k1}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestmq_k_k1_zmm_zmmm512b64 = 2800,
		/// <summary><c>VPTESTNMD k2 {k1}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmd_k_k1_xmm_xmmm128b32 = 2801,
		/// <summary><c>VPTESTNMD k2 {k1}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmd_k_k1_ymm_ymmm256b32 = 2802,
		/// <summary><c>VPTESTNMD k2 {k1}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmd_k_k1_zmm_zmmm512b32 = 2803,
		/// <summary><c>VPTESTNMQ k2 {k1}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmq_k_k1_xmm_xmmm128b64 = 2804,
		/// <summary><c>VPTESTNMQ k2 {k1}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmq_k_k1_ymm_ymmm256b64 = 2805,
		/// <summary><c>VPTESTNMQ k2 {k1}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 27 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vptestnmq_k_k1_zmm_zmmm512b64 = 2806,
		/// <summary><c>PMULDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 28 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmuldq_xmm_xmmm128 = 2807,
		/// <summary><c>VPMULDQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 28 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmuldq_xmm_xmm_xmmm128 = 2808,
		/// <summary><c>VPMULDQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 28 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmuldq_ymm_ymm_ymmm256 = 2809,
		/// <summary><c>VPMULDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmuldq_xmm_k1z_xmm_xmmm128b64 = 2810,
		/// <summary><c>VPMULDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmuldq_ymm_k1z_ymm_ymmm256b64 = 2811,
		/// <summary><c>VPMULDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmuldq_zmm_k1z_zmm_zmmm512b64 = 2812,
		/// <summary><c>VPMOVM2B xmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2b_xmm_k = 2813,
		/// <summary><c>VPMOVM2B ymm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2b_ymm_k = 2814,
		/// <summary><c>VPMOVM2B zmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2b_zmm_k = 2815,
		/// <summary><c>VPMOVM2W xmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2w_xmm_k = 2816,
		/// <summary><c>VPMOVM2W ymm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2w_ymm_k = 2817,
		/// <summary><c>VPMOVM2W zmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 28 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2w_zmm_k = 2818,
		/// <summary><c>PCMPEQQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 29 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpeqq_xmm_xmmm128 = 2819,
		/// <summary><c>VPCMPEQQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 29 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqq_xmm_xmm_xmmm128 = 2820,
		/// <summary><c>VPCMPEQQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 29 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpeqq_ymm_ymm_ymmm256 = 2821,
		/// <summary><c>VPCMPEQQ k1 {k2}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqq_k_k1_xmm_xmmm128b64 = 2822,
		/// <summary><c>VPCMPEQQ k1 {k2}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqq_k_k1_ymm_ymmm256b64 = 2823,
		/// <summary><c>VPCMPEQQ k1 {k2}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpeqq_k_k1_zmm_zmmm512b64 = 2824,
		/// <summary><c>VPMOVB2M k1, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovb2m_k_xmm = 2825,
		/// <summary><c>VPMOVB2M k1, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovb2m_k_ymm = 2826,
		/// <summary><c>VPMOVB2M k1, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovb2m_k_zmm = 2827,
		/// <summary><c>VPMOVW2M k1, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovw2m_k_xmm = 2828,
		/// <summary><c>VPMOVW2M k1, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovw2m_k_ymm = 2829,
		/// <summary><c>VPMOVW2M k1, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 29 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovw2m_k_zmm = 2830,
		/// <summary><c>MOVNTDQA xmm1, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 2A /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movntdqa_xmm_m128 = 2831,
		/// <summary><c>VMOVNTDQA xmm1, m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 2A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntdqa_xmm_m128 = 2832,
		/// <summary><c>VMOVNTDQA ymm1, m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 2A /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmovntdqa_ymm_m256 = 2833,
		/// <summary><c>VMOVNTDQA xmm1, m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntdqa_xmm_m128 = 2834,
		/// <summary><c>VMOVNTDQA ymm1, m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntdqa_ymm_m256 = 2835,
		/// <summary><c>VMOVNTDQA zmm1, m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vmovntdqa_zmm_m512 = 2836,
		/// <summary><c>VPBROADCASTMB2Q xmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastmb2q_xmm_k = 2837,
		/// <summary><c>VPBROADCASTMB2Q ymm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastmb2q_ymm_k = 2838,
		/// <summary><c>VPBROADCASTMB2Q zmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 2A /r</c><br/>
		/// <br/>
		/// <c>AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastmb2q_zmm_k = 2839,
		/// <summary><c>PACKUSDW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 2B /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Packusdw_xmm_xmmm128 = 2840,
		/// <summary><c>VPACKUSDW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 2B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpackusdw_xmm_xmm_xmmm128 = 2841,
		/// <summary><c>VPACKUSDW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 2B /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpackusdw_ymm_ymm_ymmm256 = 2842,
		/// <summary><c>VPACKUSDW xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackusdw_xmm_k1z_xmm_xmmm128b32 = 2843,
		/// <summary><c>VPACKUSDW ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackusdw_ymm_k1z_ymm_ymmm256b32 = 2844,
		/// <summary><c>VPACKUSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 2B /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpackusdw_zmm_k1z_zmm_zmmm512b32 = 2845,
		/// <summary><c>VMASKMOVPS xmm1, xmm2, m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovps_xmm_xmm_m128 = 2846,
		/// <summary><c>VMASKMOVPS ymm1, ymm2, m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovps_ymm_ymm_m256 = 2847,
		/// <summary><c>VSCALEFPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefps_xmm_k1z_xmm_xmmm128b32 = 2848,
		/// <summary><c>VSCALEFPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefps_ymm_k1z_ymm_ymmm256b32 = 2849,
		/// <summary><c>VSCALEFPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefps_zmm_k1z_zmm_zmmm512b32_er = 2850,
		/// <summary><c>VSCALEFPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefpd_xmm_k1z_xmm_xmmm128b64 = 2851,
		/// <summary><c>VSCALEFPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefpd_ymm_k1z_ymm_ymmm256b64 = 2852,
		/// <summary><c>VSCALEFPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 2C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefpd_zmm_k1z_zmm_zmmm512b64_er = 2853,
		/// <summary><c>VMASKMOVPD xmm1, xmm2, m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovpd_xmm_xmm_m128 = 2854,
		/// <summary><c>VMASKMOVPD ymm1, ymm2, m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovpd_ymm_ymm_m256 = 2855,
		/// <summary><c>VSCALEFSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 2D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefss_xmm_k1z_xmm_xmmm32_er = 2856,
		/// <summary><c>VSCALEFSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 2D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscalefsd_xmm_k1z_xmm_xmmm64_er = 2857,
		/// <summary><c>VMASKMOVPS m128, xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 2E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovps_m128_xmm_xmm = 2858,
		/// <summary><c>VMASKMOVPS m256, ymm1, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 2E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovps_m256_ymm_ymm = 2859,
		/// <summary><c>VMASKMOVPD m128, xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 2F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovpd_m128_xmm_xmm = 2860,
		/// <summary><c>VMASKMOVPD m256, ymm1, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 2F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmaskmovpd_m256_ymm_ymm = 2861,
		/// <summary><c>PMOVZXBW xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 38 30 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovzxbw_xmm_xmmm64 = 2862,
		/// <summary><c>VPMOVZXBW xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 30 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxbw_xmm_xmmm64 = 2863,
		/// <summary><c>VPMOVZXBW ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 30 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxbw_ymm_xmmm128 = 2864,
		/// <summary><c>VPMOVZXBW xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 30 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbw_xmm_k1z_xmmm64 = 2865,
		/// <summary><c>VPMOVZXBW ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 30 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbw_ymm_k1z_xmmm128 = 2866,
		/// <summary><c>VPMOVZXBW zmm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 30 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbw_zmm_k1z_ymmm256 = 2867,
		/// <summary><c>VPMOVWB xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 30 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovwb_xmmm64_k1z_xmm = 2868,
		/// <summary><c>VPMOVWB xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 30 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovwb_xmmm128_k1z_ymm = 2869,
		/// <summary><c>VPMOVWB ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 30 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovwb_ymmm256_k1z_zmm = 2870,
		/// <summary><c>PMOVZXBD xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>66 0F 38 31 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovzxbd_xmm_xmmm32 = 2871,
		/// <summary><c>VPMOVZXBD xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 31 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxbd_xmm_xmmm32 = 2872,
		/// <summary><c>VPMOVZXBD ymm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 31 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxbd_ymm_xmmm64 = 2873,
		/// <summary><c>VPMOVZXBD xmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 31 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbd_xmm_k1z_xmmm32 = 2874,
		/// <summary><c>VPMOVZXBD ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 31 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbd_ymm_k1z_xmmm64 = 2875,
		/// <summary><c>VPMOVZXBD zmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 31 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbd_zmm_k1z_xmmm128 = 2876,
		/// <summary><c>VPMOVDB xmm1/m32 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 31 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovdb_xmmm32_k1z_xmm = 2877,
		/// <summary><c>VPMOVDB xmm1/m64 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 31 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovdb_xmmm64_k1z_ymm = 2878,
		/// <summary><c>VPMOVDB xmm1/m128 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 31 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovdb_xmmm128_k1z_zmm = 2879,
		/// <summary><c>PMOVZXBQ xmm1, xmm2/m16</c><br/>
		/// <br/>
		/// <c>66 0F 38 32 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovzxbq_xmm_xmmm16 = 2880,
		/// <summary><c>VPMOVZXBQ xmm1, xmm2/m16</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 32 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxbq_xmm_xmmm16 = 2881,
		/// <summary><c>VPMOVZXBQ ymm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 32 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxbq_ymm_xmmm32 = 2882,
		/// <summary><c>VPMOVZXBQ xmm1 {k1}{z}, xmm2/m16</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 32 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbq_xmm_k1z_xmmm16 = 2883,
		/// <summary><c>VPMOVZXBQ ymm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 32 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbq_ymm_k1z_xmmm32 = 2884,
		/// <summary><c>VPMOVZXBQ zmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 32 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxbq_zmm_k1z_xmmm64 = 2885,
		/// <summary><c>VPMOVQB xmm1/m16 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 32 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqb_xmmm16_k1z_xmm = 2886,
		/// <summary><c>VPMOVQB xmm1/m32 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 32 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqb_xmmm32_k1z_ymm = 2887,
		/// <summary><c>VPMOVQB xmm1/m64 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 32 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqb_xmmm64_k1z_zmm = 2888,
		/// <summary><c>PMOVZXWD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 38 33 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovzxwd_xmm_xmmm64 = 2889,
		/// <summary><c>VPMOVZXWD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 33 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxwd_xmm_xmmm64 = 2890,
		/// <summary><c>VPMOVZXWD ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 33 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxwd_ymm_xmmm128 = 2891,
		/// <summary><c>VPMOVZXWD xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 33 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxwd_xmm_k1z_xmmm64 = 2892,
		/// <summary><c>VPMOVZXWD ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 33 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxwd_ymm_k1z_xmmm128 = 2893,
		/// <summary><c>VPMOVZXWD zmm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 33 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxwd_zmm_k1z_ymmm256 = 2894,
		/// <summary><c>VPMOVDW xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 33 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovdw_xmmm64_k1z_xmm = 2895,
		/// <summary><c>VPMOVDW xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 33 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovdw_xmmm128_k1z_ymm = 2896,
		/// <summary><c>VPMOVDW ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 33 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovdw_ymmm256_k1z_zmm = 2897,
		/// <summary><c>PMOVZXWQ xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>66 0F 38 34 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovzxwq_xmm_xmmm32 = 2898,
		/// <summary><c>VPMOVZXWQ xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 34 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxwq_xmm_xmmm32 = 2899,
		/// <summary><c>VPMOVZXWQ ymm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 34 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxwq_ymm_xmmm64 = 2900,
		/// <summary><c>VPMOVZXWQ xmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 34 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxwq_xmm_k1z_xmmm32 = 2901,
		/// <summary><c>VPMOVZXWQ ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 34 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxwq_ymm_k1z_xmmm64 = 2902,
		/// <summary><c>VPMOVZXWQ zmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 34 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxwq_zmm_k1z_xmmm128 = 2903,
		/// <summary><c>VPMOVQW xmm1/m32 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 34 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqw_xmmm32_k1z_xmm = 2904,
		/// <summary><c>VPMOVQW xmm1/m64 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 34 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqw_xmmm64_k1z_ymm = 2905,
		/// <summary><c>VPMOVQW xmm1/m128 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 34 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqw_xmmm128_k1z_zmm = 2906,
		/// <summary><c>PMOVZXDQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>66 0F 38 35 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmovzxdq_xmm_xmmm64 = 2907,
		/// <summary><c>VPMOVZXDQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 35 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxdq_xmm_xmmm64 = 2908,
		/// <summary><c>VPMOVZXDQ ymm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 35 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmovzxdq_ymm_xmmm128 = 2909,
		/// <summary><c>VPMOVZXDQ xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 35 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxdq_xmm_k1z_xmmm64 = 2910,
		/// <summary><c>VPMOVZXDQ ymm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 35 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxdq_ymm_k1z_xmmm128 = 2911,
		/// <summary><c>VPMOVZXDQ zmm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 35 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovzxdq_zmm_k1z_ymmm256 = 2912,
		/// <summary><c>VPMOVQD xmm1/m64 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 35 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqd_xmmm64_k1z_xmm = 2913,
		/// <summary><c>VPMOVQD xmm1/m128 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 35 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqd_xmmm128_k1z_ymm = 2914,
		/// <summary><c>VPMOVQD ymm1/m256 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 35 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovqd_ymmm256_k1z_zmm = 2915,
		/// <summary><c>VPERMD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 36 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermd_ymm_ymm_ymmm256 = 2916,
		/// <summary><c>VPERMD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 36 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermd_ymm_k1z_ymm_ymmm256b32 = 2917,
		/// <summary><c>VPERMD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 36 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermd_zmm_k1z_zmm_zmmm512b32 = 2918,
		/// <summary><c>VPERMQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 36 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermq_ymm_k1z_ymm_ymmm256b64 = 2919,
		/// <summary><c>VPERMQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 36 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermq_zmm_k1z_zmm_zmmm512b64 = 2920,
		/// <summary><c>PCMPGTQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 37 /r</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpgtq_xmm_xmmm128 = 2921,
		/// <summary><c>VPCMPGTQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 37 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtq_xmm_xmm_xmmm128 = 2922,
		/// <summary><c>VPCMPGTQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 37 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpgtq_ymm_ymm_ymmm256 = 2923,
		/// <summary><c>VPCMPGTQ k1 {k2}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 37 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtq_k_k1_xmm_xmmm128b64 = 2924,
		/// <summary><c>VPCMPGTQ k1 {k2}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 37 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtq_k_k1_ymm_ymmm256b64 = 2925,
		/// <summary><c>VPCMPGTQ k1 {k2}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 37 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpgtq_k_k1_zmm_zmmm512b64 = 2926,
		/// <summary><c>PMINSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 38 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminsb_xmm_xmmm128 = 2927,
		/// <summary><c>VPMINSB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 38 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminsb_xmm_xmm_xmmm128 = 2928,
		/// <summary><c>VPMINSB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 38 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminsb_ymm_ymm_ymmm256 = 2929,
		/// <summary><c>VPMINSB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsb_xmm_k1z_xmm_xmmm128 = 2930,
		/// <summary><c>VPMINSB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsb_ymm_k1z_ymm_ymmm256 = 2931,
		/// <summary><c>VPMINSB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsb_zmm_k1z_zmm_zmmm512 = 2932,
		/// <summary><c>VPMOVM2D xmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2d_xmm_k = 2933,
		/// <summary><c>VPMOVM2D ymm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2d_ymm_k = 2934,
		/// <summary><c>VPMOVM2D zmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2d_zmm_k = 2935,
		/// <summary><c>VPMOVM2Q xmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2q_xmm_k = 2936,
		/// <summary><c>VPMOVM2Q ymm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2q_ymm_k = 2937,
		/// <summary><c>VPMOVM2Q zmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 38 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovm2q_zmm_k = 2938,
		/// <summary><c>PMINSD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 39 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminsd_xmm_xmmm128 = 2939,
		/// <summary><c>VPMINSD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 39 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminsd_xmm_xmm_xmmm128 = 2940,
		/// <summary><c>VPMINSD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 39 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminsd_ymm_ymm_ymmm256 = 2941,
		/// <summary><c>VPMINSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsd_xmm_k1z_xmm_xmmm128b32 = 2942,
		/// <summary><c>VPMINSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsd_ymm_k1z_ymm_ymmm256b32 = 2943,
		/// <summary><c>VPMINSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsd_zmm_k1z_zmm_zmmm512b32 = 2944,
		/// <summary><c>VPMINSQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsq_xmm_k1z_xmm_xmmm128b64 = 2945,
		/// <summary><c>VPMINSQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsq_ymm_k1z_ymm_ymmm256b64 = 2946,
		/// <summary><c>VPMINSQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminsq_zmm_k1z_zmm_zmmm512b64 = 2947,
		/// <summary><c>VPMOVD2M k1, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovd2m_k_xmm = 2948,
		/// <summary><c>VPMOVD2M k1, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovd2m_k_ymm = 2949,
		/// <summary><c>VPMOVD2M k1, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovd2m_k_zmm = 2950,
		/// <summary><c>VPMOVQ2M k1, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W1 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovq2m_k_xmm = 2951,
		/// <summary><c>VPMOVQ2M k1, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W1 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovq2m_k_ymm = 2952,
		/// <summary><c>VPMOVQ2M k1, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W1 39 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmovq2m_k_zmm = 2953,
		/// <summary><c>PMINUW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 3A /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminuw_xmm_xmmm128 = 2954,
		/// <summary><c>VPMINUW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 3A /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminuw_xmm_xmm_xmmm128 = 2955,
		/// <summary><c>VPMINUW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 3A /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminuw_ymm_ymm_ymmm256 = 2956,
		/// <summary><c>VPMINUW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 3A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminuw_xmm_k1z_xmm_xmmm128 = 2957,
		/// <summary><c>VPMINUW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 3A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminuw_ymm_k1z_ymm_ymmm256 = 2958,
		/// <summary><c>VPMINUW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 3A /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminuw_zmm_k1z_zmm_zmmm512 = 2959,
		/// <summary><c>VPBROADCASTMW2D xmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 3A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastmw2d_xmm_k = 2960,
		/// <summary><c>VPBROADCASTMW2D ymm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 3A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastmw2d_ymm_k = 2961,
		/// <summary><c>VPBROADCASTMW2D zmm1, k1</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 3A /r</c><br/>
		/// <br/>
		/// <c>AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastmw2d_zmm_k = 2962,
		/// <summary><c>PMINUD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 3B /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pminud_xmm_xmmm128 = 2963,
		/// <summary><c>VPMINUD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 3B /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminud_xmm_xmm_xmmm128 = 2964,
		/// <summary><c>VPMINUD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 3B /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpminud_ymm_ymm_ymmm256 = 2965,
		/// <summary><c>VPMINUD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 3B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminud_xmm_k1z_xmm_xmmm128b32 = 2966,
		/// <summary><c>VPMINUD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 3B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminud_ymm_k1z_ymm_ymmm256b32 = 2967,
		/// <summary><c>VPMINUD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 3B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminud_zmm_k1z_zmm_zmmm512b32 = 2968,
		/// <summary><c>VPMINUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 3B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminuq_xmm_k1z_xmm_xmmm128b64 = 2969,
		/// <summary><c>VPMINUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 3B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminuq_ymm_k1z_ymm_ymmm256b64 = 2970,
		/// <summary><c>VPMINUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 3B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpminuq_zmm_k1z_zmm_zmmm512b64 = 2971,
		/// <summary><c>PMAXSB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 3C /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxsb_xmm_xmmm128 = 2972,
		/// <summary><c>VPMAXSB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 3C /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxsb_xmm_xmm_xmmm128 = 2973,
		/// <summary><c>VPMAXSB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 3C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxsb_ymm_ymm_ymmm256 = 2974,
		/// <summary><c>VPMAXSB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 3C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsb_xmm_k1z_xmm_xmmm128 = 2975,
		/// <summary><c>VPMAXSB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 3C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsb_ymm_k1z_ymm_ymmm256 = 2976,
		/// <summary><c>VPMAXSB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 3C /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsb_zmm_k1z_zmm_zmmm512 = 2977,
		/// <summary><c>PMAXSD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 3D /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxsd_xmm_xmmm128 = 2978,
		/// <summary><c>VPMAXSD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 3D /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxsd_xmm_xmm_xmmm128 = 2979,
		/// <summary><c>VPMAXSD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 3D /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxsd_ymm_ymm_ymmm256 = 2980,
		/// <summary><c>VPMAXSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 3D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsd_xmm_k1z_xmm_xmmm128b32 = 2981,
		/// <summary><c>VPMAXSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 3D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsd_ymm_k1z_ymm_ymmm256b32 = 2982,
		/// <summary><c>VPMAXSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 3D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsd_zmm_k1z_zmm_zmmm512b32 = 2983,
		/// <summary><c>VPMAXSQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 3D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsq_xmm_k1z_xmm_xmmm128b64 = 2984,
		/// <summary><c>VPMAXSQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 3D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsq_ymm_k1z_ymm_ymmm256b64 = 2985,
		/// <summary><c>VPMAXSQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 3D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxsq_zmm_k1z_zmm_zmmm512b64 = 2986,
		/// <summary><c>PMAXUW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 3E /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxuw_xmm_xmmm128 = 2987,
		/// <summary><c>VPMAXUW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 3E /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxuw_xmm_xmm_xmmm128 = 2988,
		/// <summary><c>VPMAXUW ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 3E /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxuw_ymm_ymm_ymmm256 = 2989,
		/// <summary><c>VPMAXUW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG 3E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxuw_xmm_k1z_xmm_xmmm128 = 2990,
		/// <summary><c>VPMAXUW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG 3E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxuw_ymm_k1z_ymm_ymmm256 = 2991,
		/// <summary><c>VPMAXUW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG 3E /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxuw_zmm_k1z_zmm_zmmm512 = 2992,
		/// <summary><c>PMAXUD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 3F /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmaxud_xmm_xmmm128 = 2993,
		/// <summary><c>VPMAXUD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 3F /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxud_xmm_xmm_xmmm128 = 2994,
		/// <summary><c>VPMAXUD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 3F /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaxud_ymm_ymm_ymmm256 = 2995,
		/// <summary><c>VPMAXUD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 3F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxud_xmm_k1z_xmm_xmmm128b32 = 2996,
		/// <summary><c>VPMAXUD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 3F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxud_ymm_k1z_ymm_ymmm256b32 = 2997,
		/// <summary><c>VPMAXUD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 3F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxud_zmm_k1z_zmm_zmmm512b32 = 2998,
		/// <summary><c>VPMAXUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 3F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxuq_xmm_k1z_xmm_xmmm128b64 = 2999,
		/// <summary><c>VPMAXUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 3F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxuq_ymm_k1z_ymm_ymmm256b64 = 3000,
		/// <summary><c>VPMAXUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 3F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmaxuq_zmm_k1z_zmm_zmmm512b64 = 3001,
		/// <summary><c>PMULLD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 40 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pmulld_xmm_xmmm128 = 3002,
		/// <summary><c>VPMULLD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 40 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulld_xmm_xmm_xmmm128 = 3003,
		/// <summary><c>VPMULLD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG 40 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmulld_ymm_ymm_ymmm256 = 3004,
		/// <summary><c>VPMULLD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 40 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulld_xmm_k1z_xmm_xmmm128b32 = 3005,
		/// <summary><c>VPMULLD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 40 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulld_ymm_k1z_ymm_ymmm256b32 = 3006,
		/// <summary><c>VPMULLD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 40 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmulld_zmm_k1z_zmm_zmmm512b32 = 3007,
		/// <summary><c>VPMULLQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 40 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmullq_xmm_k1z_xmm_xmmm128b64 = 3008,
		/// <summary><c>VPMULLQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 40 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmullq_ymm_k1z_ymm_ymmm256b64 = 3009,
		/// <summary><c>VPMULLQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 40 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmullq_zmm_k1z_zmm_zmmm512b64 = 3010,
		/// <summary><c>PHMINPOSUW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 41 /r</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Phminposuw_xmm_xmmm128 = 3011,
		/// <summary><c>VPHMINPOSUW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG 41 /r</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vphminposuw_xmm_xmmm128 = 3012,
		/// <summary><c>VGETEXPPS xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexpps_xmm_k1z_xmmm128b32 = 3013,
		/// <summary><c>VGETEXPPS ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexpps_ymm_k1z_ymmm256b32 = 3014,
		/// <summary><c>VGETEXPPS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexpps_zmm_k1z_zmmm512b32_sae = 3015,
		/// <summary><c>VGETEXPPD xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexppd_xmm_k1z_xmmm128b64 = 3016,
		/// <summary><c>VGETEXPPD ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexppd_ymm_k1z_ymmm256b64 = 3017,
		/// <summary><c>VGETEXPPD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 42 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexppd_zmm_k1z_zmmm512b64_sae = 3018,
		/// <summary><c>VGETEXPSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 43 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexpss_xmm_k1z_xmm_xmmm32_sae = 3019,
		/// <summary><c>VGETEXPSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 43 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetexpsd_xmm_k1z_xmm_xmmm64_sae = 3020,
		/// <summary><c>VPLZCNTD xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vplzcntd_xmm_k1z_xmmm128b32 = 3021,
		/// <summary><c>VPLZCNTD ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vplzcntd_ymm_k1z_ymmm256b32 = 3022,
		/// <summary><c>VPLZCNTD zmm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vplzcntd_zmm_k1z_zmmm512b32 = 3023,
		/// <summary><c>VPLZCNTQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vplzcntq_xmm_k1z_xmmm128b64 = 3024,
		/// <summary><c>VPLZCNTQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vplzcntq_ymm_k1z_ymmm256b64 = 3025,
		/// <summary><c>VPLZCNTQ zmm1 {k1}{z}, zmm2/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 44 /r</c><br/>
		/// <br/>
		/// <c>AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vplzcntq_zmm_k1z_zmmm512b64 = 3026,
		/// <summary><c>VPSRLVD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlvd_xmm_xmm_xmmm128 = 3027,
		/// <summary><c>VPSRLVD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlvd_ymm_ymm_ymmm256 = 3028,
		/// <summary><c>VPSRLVQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlvq_xmm_xmm_xmmm128 = 3029,
		/// <summary><c>VPSRLVQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsrlvq_ymm_ymm_ymmm256 = 3030,
		/// <summary><c>VPSRLVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvd_xmm_k1z_xmm_xmmm128b32 = 3031,
		/// <summary><c>VPSRLVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvd_ymm_k1z_ymm_ymmm256b32 = 3032,
		/// <summary><c>VPSRLVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvd_zmm_k1z_zmm_zmmm512b32 = 3033,
		/// <summary><c>VPSRLVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvq_xmm_k1z_xmm_xmmm128b64 = 3034,
		/// <summary><c>VPSRLVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvq_ymm_k1z_ymm_ymmm256b64 = 3035,
		/// <summary><c>VPSRLVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 45 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsrlvq_zmm_k1z_zmm_zmmm512b64 = 3036,
		/// <summary><c>VPSRAVD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsravd_xmm_xmm_xmmm128 = 3037,
		/// <summary><c>VPSRAVD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsravd_ymm_ymm_ymmm256 = 3038,
		/// <summary><c>VPSRAVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravd_xmm_k1z_xmm_xmmm128b32 = 3039,
		/// <summary><c>VPSRAVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravd_ymm_k1z_ymm_ymmm256b32 = 3040,
		/// <summary><c>VPSRAVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravd_zmm_k1z_zmm_zmmm512b32 = 3041,
		/// <summary><c>VPSRAVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravq_xmm_k1z_xmm_xmmm128b64 = 3042,
		/// <summary><c>VPSRAVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravq_ymm_k1z_ymm_ymmm256b64 = 3043,
		/// <summary><c>VPSRAVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 46 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsravq_zmm_k1z_zmm_zmmm512b64 = 3044,
		/// <summary><c>VPSLLVD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllvd_xmm_xmm_xmmm128 = 3045,
		/// <summary><c>VPSLLVD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllvd_ymm_ymm_ymmm256 = 3046,
		/// <summary><c>VPSLLVQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllvq_xmm_xmm_xmmm128 = 3047,
		/// <summary><c>VPSLLVQ ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpsllvq_ymm_ymm_ymmm256 = 3048,
		/// <summary><c>VPSLLVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvd_xmm_k1z_xmm_xmmm128b32 = 3049,
		/// <summary><c>VPSLLVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvd_ymm_k1z_ymm_ymmm256b32 = 3050,
		/// <summary><c>VPSLLVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvd_zmm_k1z_zmm_zmmm512b32 = 3051,
		/// <summary><c>VPSLLVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvq_xmm_k1z_xmm_xmmm128b64 = 3052,
		/// <summary><c>VPSLLVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvq_ymm_k1z_ymm_ymmm256b64 = 3053,
		/// <summary><c>VPSLLVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 47 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpsllvq_zmm_k1z_zmm_zmmm512b64 = 3054,
		/// <summary><c>VRCP14PS xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 4C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14ps_xmm_k1z_xmmm128b32 = 3055,
		/// <summary><c>VRCP14PS ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 4C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14ps_ymm_k1z_ymmm256b32 = 3056,
		/// <summary><c>VRCP14PS zmm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 4C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14ps_zmm_k1z_zmmm512b32 = 3057,
		/// <summary><c>VRCP14PD xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 4C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14pd_xmm_k1z_xmmm128b64 = 3058,
		/// <summary><c>VRCP14PD ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 4C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14pd_ymm_k1z_ymmm256b64 = 3059,
		/// <summary><c>VRCP14PD zmm1 {k1}{z}, zmm2/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 4C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14pd_zmm_k1z_zmmm512b64 = 3060,
		/// <summary><c>VRCP14SS xmm1 {k1}{z}, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 4D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14ss_xmm_k1z_xmm_xmmm32 = 3061,
		/// <summary><c>VRCP14SD xmm1 {k1}{z}, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 4D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp14sd_xmm_k1z_xmm_xmmm64 = 3062,
		/// <summary><c>VRSQRT14PS xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 4E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14ps_xmm_k1z_xmmm128b32 = 3063,
		/// <summary><c>VRSQRT14PS ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 4E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14ps_ymm_k1z_ymmm256b32 = 3064,
		/// <summary><c>VRSQRT14PS zmm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 4E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14ps_zmm_k1z_zmmm512b32 = 3065,
		/// <summary><c>VRSQRT14PD xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 4E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14pd_xmm_k1z_xmmm128b64 = 3066,
		/// <summary><c>VRSQRT14PD ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 4E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14pd_ymm_k1z_ymmm256b64 = 3067,
		/// <summary><c>VRSQRT14PD zmm1 {k1}{z}, zmm2/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 4E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14pd_zmm_k1z_zmmm512b64 = 3068,
		/// <summary><c>VRSQRT14SS xmm1 {k1}{z}, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 4F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14ss_xmm_k1z_xmm_xmmm32 = 3069,
		/// <summary><c>VRSQRT14SD xmm1 {k1}{z}, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 4F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt14sd_xmm_k1z_xmm_xmmm64 = 3070,
		/// <summary><c>VPDPBUSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpbusd_xmm_k1z_xmm_xmmm128b32 = 3071,
		/// <summary><c>VPDPBUSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpbusd_ymm_k1z_ymm_ymmm256b32 = 3072,
		/// <summary><c>VPDPBUSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 50 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpbusd_zmm_k1z_zmm_zmmm512b32 = 3073,
		/// <summary><c>VPDPBUSDS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpbusds_xmm_k1z_xmm_xmmm128b32 = 3074,
		/// <summary><c>VPDPBUSDS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpbusds_ymm_k1z_ymm_ymmm256b32 = 3075,
		/// <summary><c>VPDPBUSDS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 51 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpbusds_zmm_k1z_zmm_zmmm512b32 = 3076,
		/// <summary><c>VPDPWSSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpwssd_xmm_k1z_xmm_xmmm128b32 = 3077,
		/// <summary><c>VPDPWSSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpwssd_ymm_k1z_ymm_ymmm256b32 = 3078,
		/// <summary><c>VPDPWSSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpwssd_zmm_k1z_zmm_zmmm512b32 = 3079,
		/// <summary><c>VDPBF16PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32 = 3080,
		/// <summary><c>VDPBF16PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32 = 3081,
		/// <summary><c>VDPBF16PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512F and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32 = 3082,
		/// <summary><c>VP4DPWSSD zmm1 {k1}{z}, zmm2+3, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W0 52 /r</c><br/>
		/// <br/>
		/// <c>AVX512_4VNNIW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp4dpwssd_zmm_k1z_zmmp3_m128 = 3083,
		/// <summary><c>VPDPWSSDS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 53 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpwssds_xmm_k1z_xmm_xmmm128b32 = 3084,
		/// <summary><c>VPDPWSSDS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 53 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpwssds_ymm_k1z_ymm_ymmm256b32 = 3085,
		/// <summary><c>VPDPWSSDS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 53 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VNNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpdpwssds_zmm_k1z_zmm_zmmm512b32 = 3086,
		/// <summary><c>VP4DPWSSDS zmm1 {k1}{z}, zmm2+3, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W0 53 /r</c><br/>
		/// <br/>
		/// <c>AVX512_4VNNIW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp4dpwssds_zmm_k1z_zmmp3_m128 = 3087,
		/// <summary><c>VPOPCNTB xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntb_xmm_k1z_xmmm128 = 3088,
		/// <summary><c>VPOPCNTB ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntb_ymm_k1z_ymmm256 = 3089,
		/// <summary><c>VPOPCNTB zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntb_zmm_k1z_zmmm512 = 3090,
		/// <summary><c>VPOPCNTW xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntw_xmm_k1z_xmmm128 = 3091,
		/// <summary><c>VPOPCNTW ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntw_ymm_k1z_ymmm256 = 3092,
		/// <summary><c>VPOPCNTW zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 54 /r</c><br/>
		/// <br/>
		/// <c>AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntw_zmm_k1z_zmmm512 = 3093,
		/// <summary><c>VPOPCNTD xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VPOPCNTDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntd_xmm_k1z_xmmm128b32 = 3094,
		/// <summary><c>VPOPCNTD ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VPOPCNTDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntd_ymm_k1z_ymmm256b32 = 3095,
		/// <summary><c>VPOPCNTD zmm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VPOPCNTDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntd_zmm_k1z_zmmm512b32 = 3096,
		/// <summary><c>VPOPCNTQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VPOPCNTDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntq_xmm_k1z_xmmm128b64 = 3097,
		/// <summary><c>VPOPCNTQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VPOPCNTDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntq_ymm_k1z_ymmm256b64 = 3098,
		/// <summary><c>VPOPCNTQ zmm1 {k1}{z}, zmm2/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 55 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VPOPCNTDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpopcntq_zmm_k1z_zmmm512b64 = 3099,
		/// <summary><c>VPBROADCASTD xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastd_xmm_xmmm32 = 3100,
		/// <summary><c>VPBROADCASTD ymm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastd_ymm_xmmm32 = 3101,
		/// <summary><c>VPBROADCASTD xmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastd_xmm_k1z_xmmm32 = 3102,
		/// <summary><c>VPBROADCASTD ymm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastd_ymm_k1z_xmmm32 = 3103,
		/// <summary><c>VPBROADCASTD zmm1 {k1}{z}, xmm2/m32</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 58 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastd_zmm_k1z_xmmm32 = 3104,
		/// <summary><c>VPBROADCASTQ xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastq_xmm_xmmm64 = 3105,
		/// <summary><c>VPBROADCASTQ ymm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastq_ymm_xmmm64 = 3106,
		/// <summary><c>VBROADCASTI32X2 xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti32x2_xmm_k1z_xmmm64 = 3107,
		/// <summary><c>VBROADCASTI32X2 ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti32x2_ymm_k1z_xmmm64 = 3108,
		/// <summary><c>VBROADCASTI32X2 zmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti32x2_zmm_k1z_xmmm64 = 3109,
		/// <summary><c>VPBROADCASTQ xmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastq_xmm_k1z_xmmm64 = 3110,
		/// <summary><c>VPBROADCASTQ ymm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastq_ymm_k1z_xmmm64 = 3111,
		/// <summary><c>VPBROADCASTQ zmm1 {k1}{z}, xmm2/m64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 59 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastq_zmm_k1z_xmmm64 = 3112,
		/// <summary><c>VBROADCASTI128 ymm1, m128</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vbroadcasti128_ymm_m128 = 3113,
		/// <summary><c>VBROADCASTI32X4 ymm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti32x4_ymm_k1z_m128 = 3114,
		/// <summary><c>VBROADCASTI32X4 zmm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti32x4_zmm_k1z_m128 = 3115,
		/// <summary><c>VBROADCASTI64X2 ymm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti64x2_ymm_k1z_m128 = 3116,
		/// <summary><c>VBROADCASTI64X2 zmm1 {k1}{z}, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 5A /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti64x2_zmm_k1z_m128 = 3117,
		/// <summary><c>VBROADCASTI32X8 zmm1 {k1}{z}, m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti32x8_zmm_k1z_m256 = 3118,
		/// <summary><c>VBROADCASTI64X4 zmm1 {k1}{z}, m256</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 5B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vbroadcasti64x4_zmm_k1z_m256 = 3119,
		/// <summary><c>VPEXPANDB xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandb_xmm_k1z_xmmm128 = 3120,
		/// <summary><c>VPEXPANDB ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandb_ymm_k1z_ymmm256 = 3121,
		/// <summary><c>VPEXPANDB zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandb_zmm_k1z_zmmm512 = 3122,
		/// <summary><c>VPEXPANDW xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandw_xmm_k1z_xmmm128 = 3123,
		/// <summary><c>VPEXPANDW ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandw_ymm_k1z_ymmm256 = 3124,
		/// <summary><c>VPEXPANDW zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 62 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandw_zmm_k1z_zmmm512 = 3125,
		/// <summary><c>VPCOMPRESSB xmm1/m128 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressb_xmmm128_k1z_xmm = 3126,
		/// <summary><c>VPCOMPRESSB ymm1/m256 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressb_ymmm256_k1z_ymm = 3127,
		/// <summary><c>VPCOMPRESSB zmm1/m512 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressb_zmmm512_k1z_zmm = 3128,
		/// <summary><c>VPCOMPRESSW xmm1/m128 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressw_xmmm128_k1z_xmm = 3129,
		/// <summary><c>VPCOMPRESSW ymm1/m256 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressw_ymmm256_k1z_ymm = 3130,
		/// <summary><c>VPCOMPRESSW zmm1/m512 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 63 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressw_zmmm512_k1z_zmm = 3131,
		/// <summary><c>VPBLENDMD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmd_xmm_k1z_xmm_xmmm128b32 = 3132,
		/// <summary><c>VPBLENDMD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmd_ymm_k1z_ymm_ymmm256b32 = 3133,
		/// <summary><c>VPBLENDMD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmd_zmm_k1z_zmm_zmmm512b32 = 3134,
		/// <summary><c>VPBLENDMQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmq_xmm_k1z_xmm_xmmm128b64 = 3135,
		/// <summary><c>VPBLENDMQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmq_ymm_k1z_ymm_ymmm256b64 = 3136,
		/// <summary><c>VPBLENDMQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 64 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmq_zmm_k1z_zmm_zmmm512b64 = 3137,
		/// <summary><c>VBLENDMPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vblendmps_xmm_k1z_xmm_xmmm128b32 = 3138,
		/// <summary><c>VBLENDMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vblendmps_ymm_k1z_ymm_ymmm256b32 = 3139,
		/// <summary><c>VBLENDMPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vblendmps_zmm_k1z_zmm_zmmm512b32 = 3140,
		/// <summary><c>VBLENDMPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vblendmpd_xmm_k1z_xmm_xmmm128b64 = 3141,
		/// <summary><c>VBLENDMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vblendmpd_ymm_k1z_ymm_ymmm256b64 = 3142,
		/// <summary><c>VBLENDMPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 65 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vblendmpd_zmm_k1z_zmm_zmmm512b64 = 3143,
		/// <summary><c>VPBLENDMB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmb_xmm_k1z_xmm_xmmm128 = 3144,
		/// <summary><c>VPBLENDMB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmb_ymm_k1z_ymm_ymmm256 = 3145,
		/// <summary><c>VPBLENDMB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmb_zmm_k1z_zmm_zmmm512 = 3146,
		/// <summary><c>VPBLENDMW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmw_xmm_k1z_xmm_xmmm128 = 3147,
		/// <summary><c>VPBLENDMW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmw_ymm_k1z_ymm_ymmm256 = 3148,
		/// <summary><c>VPBLENDMW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 66 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpblendmw_zmm_k1z_zmm_zmmm512 = 3149,
		/// <summary><c>VP2INTERSECTD k1+1, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F38.W0 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VP2INTERSECT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp2intersectd_kp1_xmm_xmmm128b32 = 3150,
		/// <summary><c>VP2INTERSECTD k1+1, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F38.W0 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VP2INTERSECT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp2intersectd_kp1_ymm_ymmm256b32 = 3151,
		/// <summary><c>VP2INTERSECTD k1+1, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W0 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512F and AVX512_VP2INTERSECT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp2intersectd_kp1_zmm_zmmm512b32 = 3152,
		/// <summary><c>VP2INTERSECTQ k1+1, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F38.W1 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VP2INTERSECT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp2intersectq_kp1_xmm_xmmm128b64 = 3153,
		/// <summary><c>VP2INTERSECTQ k1+1, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F38.W1 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VP2INTERSECT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp2intersectq_kp1_ymm_ymmm256b64 = 3154,
		/// <summary><c>VP2INTERSECTQ k1+1, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W1 68 /r</c><br/>
		/// <br/>
		/// <c>AVX512F and AVX512_VP2INTERSECT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vp2intersectq_kp1_zmm_zmmm512b64 = 3155,
		/// <summary><c>VPSHLDVW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 70 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvw_xmm_k1z_xmm_xmmm128 = 3156,
		/// <summary><c>VPSHLDVW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 70 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvw_ymm_k1z_ymm_ymmm256 = 3157,
		/// <summary><c>VPSHLDVW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 70 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvw_zmm_k1z_zmm_zmmm512 = 3158,
		/// <summary><c>VPSHLDVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 71 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32 = 3159,
		/// <summary><c>VPSHLDVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 71 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32 = 3160,
		/// <summary><c>VPSHLDVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 71 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32 = 3161,
		/// <summary><c>VPSHLDVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 71 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64 = 3162,
		/// <summary><c>VPSHLDVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 71 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64 = 3163,
		/// <summary><c>VPSHLDVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 71 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64 = 3164,
		/// <summary><c>VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvw_xmm_k1z_xmm_xmmm128 = 3165,
		/// <summary><c>VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvw_ymm_k1z_ymm_ymmm256 = 3166,
		/// <summary><c>VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvw_zmm_k1z_zmm_zmmm512 = 3167,
		/// <summary><c>VCVTNEPS2BF16 xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F3.0F38.W0 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32 = 3168,
		/// <summary><c>VCVTNEPS2BF16 xmm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F3.0F38.W0 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32 = 3169,
		/// <summary><c>VCVTNEPS2BF16 ymm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F3.0F38.W0 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512F and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32 = 3170,
		/// <summary><c>VCVTNE2PS2BF16 xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.F2.0F38.W0 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32 = 3171,
		/// <summary><c>VCVTNE2PS2BF16 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.F2.0F38.W0 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32 = 3172,
		/// <summary><c>VCVTNE2PS2BF16 zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W0 72 /r</c><br/>
		/// <br/>
		/// <c>AVX512F and AVX512_BF16</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32 = 3173,
		/// <summary><c>VPSHRDVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 73 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32 = 3174,
		/// <summary><c>VPSHRDVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 73 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32 = 3175,
		/// <summary><c>VPSHRDVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 73 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32 = 3176,
		/// <summary><c>VPSHRDVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 73 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64 = 3177,
		/// <summary><c>VPSHRDVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 73 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64 = 3178,
		/// <summary><c>VPSHRDVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 73 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64 = 3179,
		/// <summary><c>VPERMI2B xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2b_xmm_k1z_xmm_xmmm128 = 3180,
		/// <summary><c>VPERMI2B ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2b_ymm_k1z_ymm_ymmm256 = 3181,
		/// <summary><c>VPERMI2B zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2b_zmm_k1z_zmm_zmmm512 = 3182,
		/// <summary><c>VPERMI2W xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2w_xmm_k1z_xmm_xmmm128 = 3183,
		/// <summary><c>VPERMI2W ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2w_ymm_k1z_ymm_ymmm256 = 3184,
		/// <summary><c>VPERMI2W zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 75 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2w_zmm_k1z_zmm_zmmm512 = 3185,
		/// <summary><c>VPERMI2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2d_xmm_k1z_xmm_xmmm128b32 = 3186,
		/// <summary><c>VPERMI2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2d_ymm_k1z_ymm_ymmm256b32 = 3187,
		/// <summary><c>VPERMI2D zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2d_zmm_k1z_zmm_zmmm512b32 = 3188,
		/// <summary><c>VPERMI2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2q_xmm_k1z_xmm_xmmm128b64 = 3189,
		/// <summary><c>VPERMI2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2q_ymm_k1z_ymm_ymmm256b64 = 3190,
		/// <summary><c>VPERMI2Q zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 76 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2q_zmm_k1z_zmm_zmmm512b64 = 3191,
		/// <summary><c>VPERMI2PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 77 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2ps_xmm_k1z_xmm_xmmm128b32 = 3192,
		/// <summary><c>VPERMI2PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 77 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2ps_ymm_k1z_ymm_ymmm256b32 = 3193,
		/// <summary><c>VPERMI2PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 77 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2ps_zmm_k1z_zmm_zmmm512b32 = 3194,
		/// <summary><c>VPERMI2PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 77 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2pd_xmm_k1z_xmm_xmmm128b64 = 3195,
		/// <summary><c>VPERMI2PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 77 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2pd_ymm_k1z_ymm_ymmm256b64 = 3196,
		/// <summary><c>VPERMI2PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 77 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermi2pd_zmm_k1z_zmm_zmmm512b64 = 3197,
		/// <summary><c>VPBROADCASTB xmm1, xmm2/m8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastb_xmm_xmmm8 = 3198,
		/// <summary><c>VPBROADCASTB ymm1, xmm2/m8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastb_ymm_xmmm8 = 3199,
		/// <summary><c>VPBROADCASTB xmm1 {k1}{z}, xmm2/m8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastb_xmm_k1z_xmmm8 = 3200,
		/// <summary><c>VPBROADCASTB ymm1 {k1}{z}, xmm2/m8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastb_ymm_k1z_xmmm8 = 3201,
		/// <summary><c>VPBROADCASTB zmm1 {k1}{z}, xmm2/m8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 78 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastb_zmm_k1z_xmmm8 = 3202,
		/// <summary><c>VPBROADCASTW xmm1, xmm2/m16</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastw_xmm_xmmm16 = 3203,
		/// <summary><c>VPBROADCASTW ymm1, xmm2/m16</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpbroadcastw_ymm_xmmm16 = 3204,
		/// <summary><c>VPBROADCASTW xmm1 {k1}{z}, xmm2/m16</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastw_xmm_k1z_xmmm16 = 3205,
		/// <summary><c>VPBROADCASTW ymm1 {k1}{z}, xmm2/m16</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastw_ymm_k1z_xmmm16 = 3206,
		/// <summary><c>VPBROADCASTW zmm1 {k1}{z}, xmm2/m16</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 79 /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastw_zmm_k1z_xmmm16 = 3207,
		/// <summary><c>VPBROADCASTB xmm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastb_xmm_k1z_r32 = 3208,
		/// <summary><c>VPBROADCASTB ymm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastb_ymm_k1z_r32 = 3209,
		/// <summary><c>VPBROADCASTB zmm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 7A /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastb_zmm_k1z_r32 = 3210,
		/// <summary><c>VPBROADCASTW xmm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastw_xmm_k1z_r32 = 3211,
		/// <summary><c>VPBROADCASTW ymm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastw_ymm_k1z_r32 = 3212,
		/// <summary><c>VPBROADCASTW zmm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 7B /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastw_zmm_k1z_r32 = 3213,
		/// <summary><c>VPBROADCASTD xmm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 7C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastd_xmm_k1z_r32 = 3214,
		/// <summary><c>VPBROADCASTD ymm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 7C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastd_ymm_k1z_r32 = 3215,
		/// <summary><c>VPBROADCASTD zmm1 {k1}{z}, r32</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 7C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpbroadcastd_zmm_k1z_r32 = 3216,
		/// <summary><c>VPBROADCASTQ xmm1 {k1}{z}, r64</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 7C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpbroadcastq_xmm_k1z_r64 = 3217,
		/// <summary><c>VPBROADCASTQ ymm1 {k1}{z}, r64</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 7C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpbroadcastq_ymm_k1z_r64 = 3218,
		/// <summary><c>VPBROADCASTQ zmm1 {k1}{z}, r64</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 7C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpbroadcastq_zmm_k1z_r64 = 3219,
		/// <summary><c>VPERMT2B xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 7D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2b_xmm_k1z_xmm_xmmm128 = 3220,
		/// <summary><c>VPERMT2B ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 7D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2b_ymm_k1z_ymm_ymmm256 = 3221,
		/// <summary><c>VPERMT2B zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 7D /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2b_zmm_k1z_zmm_zmmm512 = 3222,
		/// <summary><c>VPERMT2W xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 7D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2w_xmm_k1z_xmm_xmmm128 = 3223,
		/// <summary><c>VPERMT2W ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 7D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2w_ymm_k1z_ymm_ymmm256 = 3224,
		/// <summary><c>VPERMT2W zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 7D /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2w_zmm_k1z_zmm_zmmm512 = 3225,
		/// <summary><c>VPERMT2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2d_xmm_k1z_xmm_xmmm128b32 = 3226,
		/// <summary><c>VPERMT2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2d_ymm_k1z_ymm_ymmm256b32 = 3227,
		/// <summary><c>VPERMT2D zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2d_zmm_k1z_zmm_zmmm512b32 = 3228,
		/// <summary><c>VPERMT2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2q_xmm_k1z_xmm_xmmm128b64 = 3229,
		/// <summary><c>VPERMT2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2q_ymm_k1z_ymm_ymmm256b64 = 3230,
		/// <summary><c>VPERMT2Q zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 7E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2q_zmm_k1z_zmm_zmmm512b64 = 3231,
		/// <summary><c>VPERMT2PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2ps_xmm_k1z_xmm_xmmm128b32 = 3232,
		/// <summary><c>VPERMT2PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2ps_ymm_k1z_ymm_ymmm256b32 = 3233,
		/// <summary><c>VPERMT2PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2ps_zmm_k1z_zmm_zmmm512b32 = 3234,
		/// <summary><c>VPERMT2PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2pd_xmm_k1z_xmm_xmmm128b64 = 3235,
		/// <summary><c>VPERMT2PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2pd_ymm_k1z_ymm_ymmm256b64 = 3236,
		/// <summary><c>VPERMT2PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 7F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermt2pd_zmm_k1z_zmm_zmmm512b64 = 3237,
		/// <summary><c>INVEPT r32, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 80 /r</c><br/>
		/// <br/>
		/// <c>VMX and IA32_VMX_EPT_VPID_CAP[bit 20]</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Invept_r32_m128 = 3238,
		/// <summary><c>INVEPT r64, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 80 /r</c><br/>
		/// <br/>
		/// <c>VMX and IA32_VMX_EPT_VPID_CAP[bit 20]</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Invept_r64_m128 = 3239,
		/// <summary><c>INVVPID r32, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 81 /r</c><br/>
		/// <br/>
		/// <c>VMX and IA32_VMX_EPT_VPID_CAP[bit 32]</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Invvpid_r32_m128 = 3240,
		/// <summary><c>INVVPID r64, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 81 /r</c><br/>
		/// <br/>
		/// <c>VMX and IA32_VMX_EPT_VPID_CAP[bit 32]</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Invvpid_r64_m128 = 3241,
		/// <summary><c>INVPCID r32, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 82 /r</c><br/>
		/// <br/>
		/// <c>INVPCID</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Invpcid_r32_m128 = 3242,
		/// <summary><c>INVPCID r64, m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 82 /r</c><br/>
		/// <br/>
		/// <c>INVPCID</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Invpcid_r64_m128 = 3243,
		/// <summary><c>VPMULTISHIFTQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 83 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmultishiftqb_xmm_k1z_xmm_xmmm128b64 = 3244,
		/// <summary><c>VPMULTISHIFTQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 83 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmultishiftqb_ymm_k1z_ymm_ymmm256b64 = 3245,
		/// <summary><c>VPMULTISHIFTQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 83 /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmultishiftqb_zmm_k1z_zmm_zmmm512b64 = 3246,
		/// <summary><c>VEXPANDPS xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 88 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexpandps_xmm_k1z_xmmm128 = 3247,
		/// <summary><c>VEXPANDPS ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 88 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexpandps_ymm_k1z_ymmm256 = 3248,
		/// <summary><c>VEXPANDPS zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 88 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexpandps_zmm_k1z_zmmm512 = 3249,
		/// <summary><c>VEXPANDPD xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 88 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexpandpd_xmm_k1z_xmmm128 = 3250,
		/// <summary><c>VEXPANDPD ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 88 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexpandpd_ymm_k1z_ymmm256 = 3251,
		/// <summary><c>VEXPANDPD zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 88 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexpandpd_zmm_k1z_zmmm512 = 3252,
		/// <summary><c>VPEXPANDD xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 89 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandd_xmm_k1z_xmmm128 = 3253,
		/// <summary><c>VPEXPANDD ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 89 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandd_ymm_k1z_ymmm256 = 3254,
		/// <summary><c>VPEXPANDD zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 89 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandd_zmm_k1z_zmmm512 = 3255,
		/// <summary><c>VPEXPANDQ xmm1 {k1}{z}, xmm2/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 89 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandq_xmm_k1z_xmmm128 = 3256,
		/// <summary><c>VPEXPANDQ ymm1 {k1}{z}, ymm2/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 89 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandq_ymm_k1z_ymmm256 = 3257,
		/// <summary><c>VPEXPANDQ zmm1 {k1}{z}, zmm2/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 89 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpexpandq_zmm_k1z_zmmm512 = 3258,
		/// <summary><c>VCOMPRESSPS xmm1/m128 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 8A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcompressps_xmmm128_k1z_xmm = 3259,
		/// <summary><c>VCOMPRESSPS ymm1/m256 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 8A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcompressps_ymmm256_k1z_ymm = 3260,
		/// <summary><c>VCOMPRESSPS zmm1/m512 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 8A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcompressps_zmmm512_k1z_zmm = 3261,
		/// <summary><c>VCOMPRESSPD xmm1/m128 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 8A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcompresspd_xmmm128_k1z_xmm = 3262,
		/// <summary><c>VCOMPRESSPD ymm1/m256 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 8A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcompresspd_ymmm256_k1z_ymm = 3263,
		/// <summary><c>VCOMPRESSPD zmm1/m512 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 8A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcompresspd_zmmm512_k1z_zmm = 3264,
		/// <summary><c>VPCOMPRESSD xmm1/m128 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 8B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressd_xmmm128_k1z_xmm = 3265,
		/// <summary><c>VPCOMPRESSD ymm1/m256 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 8B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressd_ymmm256_k1z_ymm = 3266,
		/// <summary><c>VPCOMPRESSD zmm1/m512 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 8B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressd_zmmm512_k1z_zmm = 3267,
		/// <summary><c>VPCOMPRESSQ xmm1/m128 {k1}{z}, xmm2</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 8B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressq_xmmm128_k1z_xmm = 3268,
		/// <summary><c>VPCOMPRESSQ ymm1/m256 {k1}{z}, ymm2</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 8B /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressq_ymmm256_k1z_ymm = 3269,
		/// <summary><c>VPCOMPRESSQ zmm1/m512 {k1}{z}, zmm2</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 8B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcompressq_zmmm512_k1z_zmm = 3270,
		/// <summary><c>VPMASKMOVD xmm1, xmm2, m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 8C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovd_xmm_xmm_m128 = 3271,
		/// <summary><c>VPMASKMOVD ymm1, ymm2, m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 8C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovd_ymm_ymm_m256 = 3272,
		/// <summary><c>VPMASKMOVQ xmm1, xmm2, m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 8C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovq_xmm_xmm_m128 = 3273,
		/// <summary><c>VPMASKMOVQ ymm1, ymm2, m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 8C /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovq_ymm_ymm_m256 = 3274,
		/// <summary><c>VPERMB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 8D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermb_xmm_k1z_xmm_xmmm128 = 3275,
		/// <summary><c>VPERMB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 8D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermb_ymm_k1z_ymm_ymmm256 = 3276,
		/// <summary><c>VPERMB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 8D /r</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermb_zmm_k1z_zmm_zmmm512 = 3277,
		/// <summary><c>VPERMW xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 8D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermw_xmm_k1z_xmm_xmmm128 = 3278,
		/// <summary><c>VPERMW ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 8D /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermw_ymm_k1z_ymm_ymmm256 = 3279,
		/// <summary><c>VPERMW zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 8D /r</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermw_zmm_k1z_zmm_zmmm512 = 3280,
		/// <summary><c>VPMASKMOVD m128, xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 8E /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovd_m128_xmm_xmm = 3281,
		/// <summary><c>VPMASKMOVD m256, ymm1, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 8E /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovd_m256_ymm_ymm = 3282,
		/// <summary><c>VPMASKMOVQ m128, xmm1, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 8E /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovq_m128_xmm_xmm = 3283,
		/// <summary><c>VPMASKMOVQ m256, ymm1, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 8E /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpmaskmovq_m256_ymm_ymm = 3284,
		/// <summary><c>VPSHUFBITQMB k1 {k2}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 8F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufbitqmb_k_k1_xmm_xmmm128 = 3285,
		/// <summary><c>VPSHUFBITQMB k1 {k2}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 8F /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufbitqmb_k_k1_ymm_ymmm256 = 3286,
		/// <summary><c>VPSHUFBITQMB k1 {k2}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 8F /r</c><br/>
		/// <br/>
		/// <c>AVX512_BITALG</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshufbitqmb_k_k1_zmm_zmmm512 = 3287,
		/// <summary><c>VPGATHERDD xmm1, vm32x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 90 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherdd_xmm_vm32x_xmm = 3288,
		/// <summary><c>VPGATHERDD ymm1, vm32y, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 90 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherdd_ymm_vm32y_ymm = 3289,
		/// <summary><c>VPGATHERDQ xmm1, vm32x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 90 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherdq_xmm_vm32x_xmm = 3290,
		/// <summary><c>VPGATHERDQ ymm1, vm32x, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 90 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherdq_ymm_vm32x_ymm = 3291,
		/// <summary><c>VPGATHERDD xmm1 {k1}, vm32x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 90 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherdd_xmm_k1_vm32x = 3292,
		/// <summary><c>VPGATHERDD ymm1 {k1}, vm32y</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 90 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherdd_ymm_k1_vm32y = 3293,
		/// <summary><c>VPGATHERDD zmm1 {k1}, vm32z</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 90 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherdd_zmm_k1_vm32z = 3294,
		/// <summary><c>VPGATHERDQ xmm1 {k1}, vm32x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 90 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherdq_xmm_k1_vm32x = 3295,
		/// <summary><c>VPGATHERDQ ymm1 {k1}, vm32x</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 90 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherdq_ymm_k1_vm32x = 3296,
		/// <summary><c>VPGATHERDQ zmm1 {k1}, vm32y</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 90 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherdq_zmm_k1_vm32y = 3297,
		/// <summary><c>VPGATHERQD xmm1, vm64x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 91 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherqd_xmm_vm64x_xmm = 3298,
		/// <summary><c>VPGATHERQD xmm1, vm64y, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 91 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherqd_xmm_vm64y_xmm = 3299,
		/// <summary><c>VPGATHERQQ xmm1, vm64x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 91 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherqq_xmm_vm64x_xmm = 3300,
		/// <summary><c>VPGATHERQQ ymm1, vm64y, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 91 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpgatherqq_ymm_vm64y_ymm = 3301,
		/// <summary><c>VPGATHERQD xmm1 {k1}, vm64x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 91 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherqd_xmm_k1_vm64x = 3302,
		/// <summary><c>VPGATHERQD xmm1 {k1}, vm64y</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 91 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherqd_xmm_k1_vm64y = 3303,
		/// <summary><c>VPGATHERQD ymm1 {k1}, vm64z</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 91 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherqd_ymm_k1_vm64z = 3304,
		/// <summary><c>VPGATHERQQ xmm1 {k1}, vm64x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 91 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherqq_xmm_k1_vm64x = 3305,
		/// <summary><c>VPGATHERQQ ymm1 {k1}, vm64y</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 91 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherqq_ymm_k1_vm64y = 3306,
		/// <summary><c>VPGATHERQQ zmm1 {k1}, vm64z</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 91 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpgatherqq_zmm_k1_vm64z = 3307,
		/// <summary><c>VGATHERDPS xmm1, vm32x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 92 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherdps_xmm_vm32x_xmm = 3308,
		/// <summary><c>VGATHERDPS ymm1, vm32y, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 92 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherdps_ymm_vm32y_ymm = 3309,
		/// <summary><c>VGATHERDPD xmm1, vm32x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 92 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherdpd_xmm_vm32x_xmm = 3310,
		/// <summary><c>VGATHERDPD ymm1, vm32x, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 92 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherdpd_ymm_vm32x_ymm = 3311,
		/// <summary><c>VGATHERDPS xmm1 {k1}, vm32x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 92 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherdps_xmm_k1_vm32x = 3312,
		/// <summary><c>VGATHERDPS ymm1 {k1}, vm32y</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 92 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherdps_ymm_k1_vm32y = 3313,
		/// <summary><c>VGATHERDPS zmm1 {k1}, vm32z</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 92 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherdps_zmm_k1_vm32z = 3314,
		/// <summary><c>VGATHERDPD xmm1 {k1}, vm32x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 92 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherdpd_xmm_k1_vm32x = 3315,
		/// <summary><c>VGATHERDPD ymm1 {k1}, vm32x</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 92 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherdpd_ymm_k1_vm32x = 3316,
		/// <summary><c>VGATHERDPD zmm1 {k1}, vm32y</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 92 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherdpd_zmm_k1_vm32y = 3317,
		/// <summary><c>VGATHERQPS xmm1, vm64x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 93 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherqps_xmm_vm64x_xmm = 3318,
		/// <summary><c>VGATHERQPS xmm1, vm64y, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 93 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherqps_xmm_vm64y_xmm = 3319,
		/// <summary><c>VGATHERQPD xmm1, vm64x, xmm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 93 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherqpd_xmm_vm64x_xmm = 3320,
		/// <summary><c>VGATHERQPD ymm1, vm64y, ymm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 93 /r</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgatherqpd_ymm_vm64y_ymm = 3321,
		/// <summary><c>VGATHERQPS xmm1 {k1}, vm64x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 93 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherqps_xmm_k1_vm64x = 3322,
		/// <summary><c>VGATHERQPS xmm1 {k1}, vm64y</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 93 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherqps_xmm_k1_vm64y = 3323,
		/// <summary><c>VGATHERQPS ymm1 {k1}, vm64z</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 93 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherqps_ymm_k1_vm64z = 3324,
		/// <summary><c>VGATHERQPD xmm1 {k1}, vm64x</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 93 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherqpd_xmm_k1_vm64x = 3325,
		/// <summary><c>VGATHERQPD ymm1 {k1}, vm64y</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 93 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherqpd_ymm_k1_vm64y = 3326,
		/// <summary><c>VGATHERQPD zmm1 {k1}, vm64z</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 93 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherqpd_zmm_k1_vm64z = 3327,
		/// <summary><c>VFMADDSUB132PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 96 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub132ps_xmm_xmm_xmmm128 = 3328,
		/// <summary><c>VFMADDSUB132PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 96 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub132ps_ymm_ymm_ymmm256 = 3329,
		/// <summary><c>VFMADDSUB132PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 96 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub132pd_xmm_xmm_xmmm128 = 3330,
		/// <summary><c>VFMADDSUB132PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 96 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub132pd_ymm_ymm_ymmm256 = 3331,
		/// <summary><c>VFMADDSUB132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 96 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub132ps_xmm_k1z_xmm_xmmm128b32 = 3332,
		/// <summary><c>VFMADDSUB132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 96 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub132ps_ymm_k1z_ymm_ymmm256b32 = 3333,
		/// <summary><c>VFMADDSUB132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 96 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub132ps_zmm_k1z_zmm_zmmm512b32_er = 3334,
		/// <summary><c>VFMADDSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 96 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub132pd_xmm_k1z_xmm_xmmm128b64 = 3335,
		/// <summary><c>VFMADDSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 96 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub132pd_ymm_k1z_ymm_ymmm256b64 = 3336,
		/// <summary><c>VFMADDSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 96 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub132pd_zmm_k1z_zmm_zmmm512b64_er = 3337,
		/// <summary><c>VFMSUBADD132PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 97 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd132ps_xmm_xmm_xmmm128 = 3338,
		/// <summary><c>VFMSUBADD132PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 97 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd132ps_ymm_ymm_ymmm256 = 3339,
		/// <summary><c>VFMSUBADD132PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 97 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd132pd_xmm_xmm_xmmm128 = 3340,
		/// <summary><c>VFMSUBADD132PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 97 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd132pd_ymm_ymm_ymmm256 = 3341,
		/// <summary><c>VFMSUBADD132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 97 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd132ps_xmm_k1z_xmm_xmmm128b32 = 3342,
		/// <summary><c>VFMSUBADD132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 97 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd132ps_ymm_k1z_ymm_ymmm256b32 = 3343,
		/// <summary><c>VFMSUBADD132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 97 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd132ps_zmm_k1z_zmm_zmmm512b32_er = 3344,
		/// <summary><c>VFMSUBADD132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 97 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd132pd_xmm_k1z_xmm_xmmm128b64 = 3345,
		/// <summary><c>VFMSUBADD132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 97 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd132pd_ymm_k1z_ymm_ymmm256b64 = 3346,
		/// <summary><c>VFMSUBADD132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 97 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd132pd_zmm_k1z_zmm_zmmm512b64_er = 3347,
		/// <summary><c>VFMADD132PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 98 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd132ps_xmm_xmm_xmmm128 = 3348,
		/// <summary><c>VFMADD132PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 98 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd132ps_ymm_ymm_ymmm256 = 3349,
		/// <summary><c>VFMADD132PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 98 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd132pd_xmm_xmm_xmmm128 = 3350,
		/// <summary><c>VFMADD132PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 98 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd132pd_ymm_ymm_ymmm256 = 3351,
		/// <summary><c>VFMADD132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132ps_xmm_k1z_xmm_xmmm128b32 = 3352,
		/// <summary><c>VFMADD132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132ps_ymm_k1z_ymm_ymmm256b32 = 3353,
		/// <summary><c>VFMADD132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132ps_zmm_k1z_zmm_zmmm512b32_er = 3354,
		/// <summary><c>VFMADD132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132pd_xmm_k1z_xmm_xmmm128b64 = 3355,
		/// <summary><c>VFMADD132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132pd_ymm_k1z_ymm_ymmm256b64 = 3356,
		/// <summary><c>VFMADD132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 98 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132pd_zmm_k1z_zmm_zmmm512b64_er = 3357,
		/// <summary><c>VFMADD132SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 99 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd132ss_xmm_xmm_xmmm32 = 3358,
		/// <summary><c>VFMADD132SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 99 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd132sd_xmm_xmm_xmmm64 = 3359,
		/// <summary><c>VFMADD132SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 99 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132ss_xmm_k1z_xmm_xmmm32_er = 3360,
		/// <summary><c>VFMADD132SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 99 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd132sd_xmm_k1z_xmm_xmmm64_er = 3361,
		/// <summary><c>VFMSUB132PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 9A /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub132ps_xmm_xmm_xmmm128 = 3362,
		/// <summary><c>VFMSUB132PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 9A /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub132ps_ymm_ymm_ymmm256 = 3363,
		/// <summary><c>VFMSUB132PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 9A /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub132pd_xmm_xmm_xmmm128 = 3364,
		/// <summary><c>VFMSUB132PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 9A /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub132pd_ymm_ymm_ymmm256 = 3365,
		/// <summary><c>VFMSUB132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132ps_xmm_k1z_xmm_xmmm128b32 = 3366,
		/// <summary><c>VFMSUB132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132ps_ymm_k1z_ymm_ymmm256b32 = 3367,
		/// <summary><c>VFMSUB132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132ps_zmm_k1z_zmm_zmmm512b32_er = 3368,
		/// <summary><c>VFMSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132pd_xmm_k1z_xmm_xmmm128b64 = 3369,
		/// <summary><c>VFMSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132pd_ymm_k1z_ymm_ymmm256b64 = 3370,
		/// <summary><c>VFMSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132pd_zmm_k1z_zmm_zmmm512b64_er = 3371,
		/// <summary><c>V4FMADDPS zmm1 {k1}{z}, zmm2+3, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W0 9A /r</c><br/>
		/// <br/>
		/// <c>AVX512_4FMAPS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_V4fmaddps_zmm_k1z_zmmp3_m128 = 3372,
		/// <summary><c>VFMSUB132SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 9B /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub132ss_xmm_xmm_xmmm32 = 3373,
		/// <summary><c>VFMSUB132SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 9B /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub132sd_xmm_xmm_xmmm64 = 3374,
		/// <summary><c>VFMSUB132SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 9B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132ss_xmm_k1z_xmm_xmmm32_er = 3375,
		/// <summary><c>VFMSUB132SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 9B /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub132sd_xmm_k1z_xmm_xmmm64_er = 3376,
		/// <summary><c>V4FMADDSS xmm1 {k1}{z}, xmm2+3, m128</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F38.W0 9B /r</c><br/>
		/// <br/>
		/// <c>AVX512_4FMAPS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_V4fmaddss_xmm_k1z_xmmp3_m128 = 3377,
		/// <summary><c>VFNMADD132PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 9C /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd132ps_xmm_xmm_xmmm128 = 3378,
		/// <summary><c>VFNMADD132PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 9C /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd132ps_ymm_ymm_ymmm256 = 3379,
		/// <summary><c>VFNMADD132PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 9C /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd132pd_xmm_xmm_xmmm128 = 3380,
		/// <summary><c>VFNMADD132PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 9C /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd132pd_ymm_ymm_ymmm256 = 3381,
		/// <summary><c>VFNMADD132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 9C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132ps_xmm_k1z_xmm_xmmm128b32 = 3382,
		/// <summary><c>VFNMADD132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 9C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132ps_ymm_k1z_ymm_ymmm256b32 = 3383,
		/// <summary><c>VFNMADD132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 9C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132ps_zmm_k1z_zmm_zmmm512b32_er = 3384,
		/// <summary><c>VFNMADD132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 9C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132pd_xmm_k1z_xmm_xmmm128b64 = 3385,
		/// <summary><c>VFNMADD132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 9C /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132pd_ymm_k1z_ymm_ymmm256b64 = 3386,
		/// <summary><c>VFNMADD132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 9C /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132pd_zmm_k1z_zmm_zmmm512b64_er = 3387,
		/// <summary><c>VFNMADD132SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 9D /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd132ss_xmm_xmm_xmmm32 = 3388,
		/// <summary><c>VFNMADD132SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 9D /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd132sd_xmm_xmm_xmmm64 = 3389,
		/// <summary><c>VFNMADD132SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 9D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132ss_xmm_k1z_xmm_xmmm32_er = 3390,
		/// <summary><c>VFNMADD132SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 9D /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd132sd_xmm_k1z_xmm_xmmm64_er = 3391,
		/// <summary><c>VFNMSUB132PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 9E /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub132ps_xmm_xmm_xmmm128 = 3392,
		/// <summary><c>VFNMSUB132PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 9E /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub132ps_ymm_ymm_ymmm256 = 3393,
		/// <summary><c>VFNMSUB132PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 9E /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub132pd_xmm_xmm_xmmm128 = 3394,
		/// <summary><c>VFNMSUB132PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 9E /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub132pd_ymm_ymm_ymmm256 = 3395,
		/// <summary><c>VFNMSUB132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 9E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132ps_xmm_k1z_xmm_xmmm128b32 = 3396,
		/// <summary><c>VFNMSUB132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 9E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132ps_ymm_k1z_ymm_ymmm256b32 = 3397,
		/// <summary><c>VFNMSUB132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 9E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132ps_zmm_k1z_zmm_zmmm512b32_er = 3398,
		/// <summary><c>VFNMSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 9E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132pd_xmm_k1z_xmm_xmmm128b64 = 3399,
		/// <summary><c>VFNMSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 9E /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132pd_ymm_k1z_ymm_ymmm256b64 = 3400,
		/// <summary><c>VFNMSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 9E /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132pd_zmm_k1z_zmm_zmmm512b64_er = 3401,
		/// <summary><c>VFNMSUB132SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 9F /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub132ss_xmm_xmm_xmmm32 = 3402,
		/// <summary><c>VFNMSUB132SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 9F /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub132sd_xmm_xmm_xmmm64 = 3403,
		/// <summary><c>VFNMSUB132SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 9F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132ss_xmm_k1z_xmm_xmmm32_er = 3404,
		/// <summary><c>VFNMSUB132SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 9F /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub132sd_xmm_k1z_xmm_xmmm64_er = 3405,
		/// <summary><c>VPSCATTERDD vm32x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A0 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterdd_vm32x_k1_xmm = 3406,
		/// <summary><c>VPSCATTERDD vm32y {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A0 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterdd_vm32y_k1_ymm = 3407,
		/// <summary><c>VPSCATTERDD vm32z {k1}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A0 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterdd_vm32z_k1_zmm = 3408,
		/// <summary><c>VPSCATTERDQ vm32x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A0 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterdq_vm32x_k1_xmm = 3409,
		/// <summary><c>VPSCATTERDQ vm32x {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A0 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterdq_vm32x_k1_ymm = 3410,
		/// <summary><c>VPSCATTERDQ vm32y {k1}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A0 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterdq_vm32y_k1_zmm = 3411,
		/// <summary><c>VPSCATTERQD vm64x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterqd_vm64x_k1_xmm = 3412,
		/// <summary><c>VPSCATTERQD vm64y {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterqd_vm64y_k1_xmm = 3413,
		/// <summary><c>VPSCATTERQD vm64z {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterqd_vm64z_k1_ymm = 3414,
		/// <summary><c>VPSCATTERQQ vm64x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterqq_vm64x_k1_xmm = 3415,
		/// <summary><c>VPSCATTERQQ vm64y {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterqq_vm64y_k1_ymm = 3416,
		/// <summary><c>VPSCATTERQQ vm64z {k1}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpscatterqq_vm64z_k1_zmm = 3417,
		/// <summary><c>VSCATTERDPS vm32x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterdps_vm32x_k1_xmm = 3418,
		/// <summary><c>VSCATTERDPS vm32y {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterdps_vm32y_k1_ymm = 3419,
		/// <summary><c>VSCATTERDPS vm32z {k1}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterdps_vm32z_k1_zmm = 3420,
		/// <summary><c>VSCATTERDPD vm32x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterdpd_vm32x_k1_xmm = 3421,
		/// <summary><c>VSCATTERDPD vm32x {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterdpd_vm32x_k1_ymm = 3422,
		/// <summary><c>VSCATTERDPD vm32y {k1}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterdpd_vm32y_k1_zmm = 3423,
		/// <summary><c>VSCATTERQPS vm64x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A3 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterqps_vm64x_k1_xmm = 3424,
		/// <summary><c>VSCATTERQPS vm64y {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A3 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterqps_vm64y_k1_xmm = 3425,
		/// <summary><c>VSCATTERQPS vm64z {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A3 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterqps_vm64z_k1_ymm = 3426,
		/// <summary><c>VSCATTERQPD vm64x {k1}, xmm1</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A3 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterqpd_vm64x_k1_xmm = 3427,
		/// <summary><c>VSCATTERQPD vm64y {k1}, ymm1</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A3 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterqpd_vm64y_k1_ymm = 3428,
		/// <summary><c>VSCATTERQPD vm64z {k1}, zmm1</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A3 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterqpd_vm64z_k1_zmm = 3429,
		/// <summary><c>VFMADDSUB213PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 A6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub213ps_xmm_xmm_xmmm128 = 3430,
		/// <summary><c>VFMADDSUB213PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 A6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub213ps_ymm_ymm_ymmm256 = 3431,
		/// <summary><c>VFMADDSUB213PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 A6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub213pd_xmm_xmm_xmmm128 = 3432,
		/// <summary><c>VFMADDSUB213PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 A6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub213pd_ymm_ymm_ymmm256 = 3433,
		/// <summary><c>VFMADDSUB213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32 = 3434,
		/// <summary><c>VFMADDSUB213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32 = 3435,
		/// <summary><c>VFMADDSUB213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er = 3436,
		/// <summary><c>VFMADDSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64 = 3437,
		/// <summary><c>VFMADDSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64 = 3438,
		/// <summary><c>VFMADDSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er = 3439,
		/// <summary><c>VFMSUBADD213PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 A7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd213ps_xmm_xmm_xmmm128 = 3440,
		/// <summary><c>VFMSUBADD213PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 A7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd213ps_ymm_ymm_ymmm256 = 3441,
		/// <summary><c>VFMSUBADD213PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 A7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd213pd_xmm_xmm_xmmm128 = 3442,
		/// <summary><c>VFMSUBADD213PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 A7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd213pd_ymm_ymm_ymmm256 = 3443,
		/// <summary><c>VFMSUBADD213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32 = 3444,
		/// <summary><c>VFMSUBADD213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32 = 3445,
		/// <summary><c>VFMSUBADD213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A7 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er = 3446,
		/// <summary><c>VFMSUBADD213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64 = 3447,
		/// <summary><c>VFMSUBADD213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64 = 3448,
		/// <summary><c>VFMSUBADD213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A7 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er = 3449,
		/// <summary><c>VFMADD213PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 A8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd213ps_xmm_xmm_xmmm128 = 3450,
		/// <summary><c>VFMADD213PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 A8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd213ps_ymm_ymm_ymmm256 = 3451,
		/// <summary><c>VFMADD213PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 A8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd213pd_xmm_xmm_xmmm128 = 3452,
		/// <summary><c>VFMADD213PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 A8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd213pd_ymm_ymm_ymmm256 = 3453,
		/// <summary><c>VFMADD213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 A8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213ps_xmm_k1z_xmm_xmmm128b32 = 3454,
		/// <summary><c>VFMADD213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 A8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213ps_ymm_k1z_ymm_ymmm256b32 = 3455,
		/// <summary><c>VFMADD213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 A8 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213ps_zmm_k1z_zmm_zmmm512b32_er = 3456,
		/// <summary><c>VFMADD213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 A8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213pd_xmm_k1z_xmm_xmmm128b64 = 3457,
		/// <summary><c>VFMADD213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 A8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213pd_ymm_k1z_ymm_ymmm256b64 = 3458,
		/// <summary><c>VFMADD213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 A8 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213pd_zmm_k1z_zmm_zmmm512b64_er = 3459,
		/// <summary><c>VFMADD213SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 A9 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd213ss_xmm_xmm_xmmm32 = 3460,
		/// <summary><c>VFMADD213SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 A9 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd213sd_xmm_xmm_xmmm64 = 3461,
		/// <summary><c>VFMADD213SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 A9 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213ss_xmm_k1z_xmm_xmmm32_er = 3462,
		/// <summary><c>VFMADD213SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 A9 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd213sd_xmm_k1z_xmm_xmmm64_er = 3463,
		/// <summary><c>VFMSUB213PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 AA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub213ps_xmm_xmm_xmmm128 = 3464,
		/// <summary><c>VFMSUB213PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 AA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub213ps_ymm_ymm_ymmm256 = 3465,
		/// <summary><c>VFMSUB213PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 AA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub213pd_xmm_xmm_xmmm128 = 3466,
		/// <summary><c>VFMSUB213PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 AA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub213pd_ymm_ymm_ymmm256 = 3467,
		/// <summary><c>VFMSUB213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213ps_xmm_k1z_xmm_xmmm128b32 = 3468,
		/// <summary><c>VFMSUB213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213ps_ymm_k1z_ymm_ymmm256b32 = 3469,
		/// <summary><c>VFMSUB213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213ps_zmm_k1z_zmm_zmmm512b32_er = 3470,
		/// <summary><c>VFMSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213pd_xmm_k1z_xmm_xmmm128b64 = 3471,
		/// <summary><c>VFMSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213pd_ymm_k1z_ymm_ymmm256b64 = 3472,
		/// <summary><c>VFMSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213pd_zmm_k1z_zmm_zmmm512b64_er = 3473,
		/// <summary><c>V4FNMADDPS zmm1 {k1}{z}, zmm2+3, m128</c><br/>
		/// <br/>
		/// <c>EVEX.512.F2.0F38.W0 AA /r</c><br/>
		/// <br/>
		/// <c>AVX512_4FMAPS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_V4fnmaddps_zmm_k1z_zmmp3_m128 = 3474,
		/// <summary><c>VFMSUB213SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 AB /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub213ss_xmm_xmm_xmmm32 = 3475,
		/// <summary><c>VFMSUB213SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 AB /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub213sd_xmm_xmm_xmmm64 = 3476,
		/// <summary><c>VFMSUB213SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 AB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213ss_xmm_k1z_xmm_xmmm32_er = 3477,
		/// <summary><c>VFMSUB213SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 AB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub213sd_xmm_k1z_xmm_xmmm64_er = 3478,
		/// <summary><c>V4FNMADDSS xmm1 {k1}{z}, xmm2+3, m128</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.F2.0F38.W0 AB /r</c><br/>
		/// <br/>
		/// <c>AVX512_4FMAPS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_V4fnmaddss_xmm_k1z_xmmp3_m128 = 3479,
		/// <summary><c>VFNMADD213PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 AC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd213ps_xmm_xmm_xmmm128 = 3480,
		/// <summary><c>VFNMADD213PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 AC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd213ps_ymm_ymm_ymmm256 = 3481,
		/// <summary><c>VFNMADD213PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 AC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd213pd_xmm_xmm_xmmm128 = 3482,
		/// <summary><c>VFNMADD213PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 AC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd213pd_ymm_ymm_ymmm256 = 3483,
		/// <summary><c>VFNMADD213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 AC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213ps_xmm_k1z_xmm_xmmm128b32 = 3484,
		/// <summary><c>VFNMADD213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 AC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213ps_ymm_k1z_ymm_ymmm256b32 = 3485,
		/// <summary><c>VFNMADD213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 AC /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213ps_zmm_k1z_zmm_zmmm512b32_er = 3486,
		/// <summary><c>VFNMADD213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 AC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213pd_xmm_k1z_xmm_xmmm128b64 = 3487,
		/// <summary><c>VFNMADD213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 AC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213pd_ymm_k1z_ymm_ymmm256b64 = 3488,
		/// <summary><c>VFNMADD213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 AC /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213pd_zmm_k1z_zmm_zmmm512b64_er = 3489,
		/// <summary><c>VFNMADD213SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 AD /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd213ss_xmm_xmm_xmmm32 = 3490,
		/// <summary><c>VFNMADD213SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 AD /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd213sd_xmm_xmm_xmmm64 = 3491,
		/// <summary><c>VFNMADD213SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 AD /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213ss_xmm_k1z_xmm_xmmm32_er = 3492,
		/// <summary><c>VFNMADD213SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 AD /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd213sd_xmm_k1z_xmm_xmmm64_er = 3493,
		/// <summary><c>VFNMSUB213PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 AE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub213ps_xmm_xmm_xmmm128 = 3494,
		/// <summary><c>VFNMSUB213PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 AE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub213ps_ymm_ymm_ymmm256 = 3495,
		/// <summary><c>VFNMSUB213PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 AE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub213pd_xmm_xmm_xmmm128 = 3496,
		/// <summary><c>VFNMSUB213PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 AE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub213pd_ymm_ymm_ymmm256 = 3497,
		/// <summary><c>VFNMSUB213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 AE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213ps_xmm_k1z_xmm_xmmm128b32 = 3498,
		/// <summary><c>VFNMSUB213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 AE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213ps_ymm_k1z_ymm_ymmm256b32 = 3499,
		/// <summary><c>VFNMSUB213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 AE /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213ps_zmm_k1z_zmm_zmmm512b32_er = 3500,
		/// <summary><c>VFNMSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 AE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213pd_xmm_k1z_xmm_xmmm128b64 = 3501,
		/// <summary><c>VFNMSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 AE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213pd_ymm_k1z_ymm_ymmm256b64 = 3502,
		/// <summary><c>VFNMSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 AE /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213pd_zmm_k1z_zmm_zmmm512b64_er = 3503,
		/// <summary><c>VFNMSUB213SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 AF /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub213ss_xmm_xmm_xmmm32 = 3504,
		/// <summary><c>VFNMSUB213SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 AF /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub213sd_xmm_xmm_xmmm64 = 3505,
		/// <summary><c>VFNMSUB213SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 AF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213ss_xmm_k1z_xmm_xmmm32_er = 3506,
		/// <summary><c>VFNMSUB213SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 AF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub213sd_xmm_k1z_xmm_xmmm64_er = 3507,
		/// <summary><c>VPMADD52LUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 B4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_IFMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmadd52luq_xmm_k1z_xmm_xmmm128b64 = 3508,
		/// <summary><c>VPMADD52LUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 B4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_IFMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmadd52luq_ymm_k1z_ymm_ymmm256b64 = 3509,
		/// <summary><c>VPMADD52LUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 B4 /r</c><br/>
		/// <br/>
		/// <c>AVX512_IFMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmadd52luq_zmm_k1z_zmm_zmmm512b64 = 3510,
		/// <summary><c>VPMADD52HUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 B5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_IFMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmadd52huq_xmm_k1z_xmm_xmmm128b64 = 3511,
		/// <summary><c>VPMADD52HUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 B5 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_IFMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmadd52huq_ymm_k1z_ymm_ymmm256b64 = 3512,
		/// <summary><c>VPMADD52HUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 B5 /r</c><br/>
		/// <br/>
		/// <c>AVX512_IFMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpmadd52huq_zmm_k1z_zmm_zmmm512b64 = 3513,
		/// <summary><c>VFMADDSUB231PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 B6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub231ps_xmm_xmm_xmmm128 = 3514,
		/// <summary><c>VFMADDSUB231PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 B6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub231ps_ymm_ymm_ymmm256 = 3515,
		/// <summary><c>VFMADDSUB231PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 B6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub231pd_xmm_xmm_xmmm128 = 3516,
		/// <summary><c>VFMADDSUB231PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 B6 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsub231pd_ymm_ymm_ymmm256 = 3517,
		/// <summary><c>VFMADDSUB231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 B6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub231ps_xmm_k1z_xmm_xmmm128b32 = 3518,
		/// <summary><c>VFMADDSUB231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 B6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub231ps_ymm_k1z_ymm_ymmm256b32 = 3519,
		/// <summary><c>VFMADDSUB231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 B6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub231ps_zmm_k1z_zmm_zmmm512b32_er = 3520,
		/// <summary><c>VFMADDSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 B6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub231pd_xmm_k1z_xmm_xmmm128b64 = 3521,
		/// <summary><c>VFMADDSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 B6 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub231pd_ymm_k1z_ymm_ymmm256b64 = 3522,
		/// <summary><c>VFMADDSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 B6 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmaddsub231pd_zmm_k1z_zmm_zmmm512b64_er = 3523,
		/// <summary><c>VFMSUBADD231PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 B7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd231ps_xmm_xmm_xmmm128 = 3524,
		/// <summary><c>VFMSUBADD231PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 B7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd231ps_ymm_ymm_ymmm256 = 3525,
		/// <summary><c>VFMSUBADD231PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 B7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd231pd_xmm_xmm_xmmm128 = 3526,
		/// <summary><c>VFMSUBADD231PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 B7 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubadd231pd_ymm_ymm_ymmm256 = 3527,
		/// <summary><c>VFMSUBADD231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 B7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd231ps_xmm_k1z_xmm_xmmm128b32 = 3528,
		/// <summary><c>VFMSUBADD231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 B7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd231ps_ymm_k1z_ymm_ymmm256b32 = 3529,
		/// <summary><c>VFMSUBADD231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 B7 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd231ps_zmm_k1z_zmm_zmmm512b32_er = 3530,
		/// <summary><c>VFMSUBADD231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 B7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd231pd_xmm_k1z_xmm_xmmm128b64 = 3531,
		/// <summary><c>VFMSUBADD231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 B7 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd231pd_ymm_k1z_ymm_ymmm256b64 = 3532,
		/// <summary><c>VFMSUBADD231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 B7 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsubadd231pd_zmm_k1z_zmm_zmmm512b64_er = 3533,
		/// <summary><c>VFMADD231PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 B8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd231ps_xmm_xmm_xmmm128 = 3534,
		/// <summary><c>VFMADD231PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 B8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd231ps_ymm_ymm_ymmm256 = 3535,
		/// <summary><c>VFMADD231PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 B8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd231pd_xmm_xmm_xmmm128 = 3536,
		/// <summary><c>VFMADD231PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 B8 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd231pd_ymm_ymm_ymmm256 = 3537,
		/// <summary><c>VFMADD231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 B8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231ps_xmm_k1z_xmm_xmmm128b32 = 3538,
		/// <summary><c>VFMADD231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 B8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231ps_ymm_k1z_ymm_ymmm256b32 = 3539,
		/// <summary><c>VFMADD231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 B8 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231ps_zmm_k1z_zmm_zmmm512b32_er = 3540,
		/// <summary><c>VFMADD231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 B8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231pd_xmm_k1z_xmm_xmmm128b64 = 3541,
		/// <summary><c>VFMADD231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 B8 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231pd_ymm_k1z_ymm_ymmm256b64 = 3542,
		/// <summary><c>VFMADD231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 B8 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231pd_zmm_k1z_zmm_zmmm512b64_er = 3543,
		/// <summary><c>VFMADD231SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 B9 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd231ss_xmm_xmm_xmmm32 = 3544,
		/// <summary><c>VFMADD231SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 B9 /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmadd231sd_xmm_xmm_xmmm64 = 3545,
		/// <summary><c>VFMADD231SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 B9 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231ss_xmm_k1z_xmm_xmmm32_er = 3546,
		/// <summary><c>VFMADD231SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 B9 /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmadd231sd_xmm_k1z_xmm_xmmm64_er = 3547,
		/// <summary><c>VFMSUB231PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 BA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub231ps_xmm_xmm_xmmm128 = 3548,
		/// <summary><c>VFMSUB231PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 BA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub231ps_ymm_ymm_ymmm256 = 3549,
		/// <summary><c>VFMSUB231PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 BA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub231pd_xmm_xmm_xmmm128 = 3550,
		/// <summary><c>VFMSUB231PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 BA /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub231pd_ymm_ymm_ymmm256 = 3551,
		/// <summary><c>VFMSUB231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 BA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231ps_xmm_k1z_xmm_xmmm128b32 = 3552,
		/// <summary><c>VFMSUB231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 BA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231ps_ymm_k1z_ymm_ymmm256b32 = 3553,
		/// <summary><c>VFMSUB231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 BA /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231ps_zmm_k1z_zmm_zmmm512b32_er = 3554,
		/// <summary><c>VFMSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 BA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231pd_xmm_k1z_xmm_xmmm128b64 = 3555,
		/// <summary><c>VFMSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 BA /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231pd_ymm_k1z_ymm_ymmm256b64 = 3556,
		/// <summary><c>VFMSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 BA /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231pd_zmm_k1z_zmm_zmmm512b64_er = 3557,
		/// <summary><c>VFMSUB231SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 BB /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub231ss_xmm_xmm_xmmm32 = 3558,
		/// <summary><c>VFMSUB231SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 BB /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsub231sd_xmm_xmm_xmmm64 = 3559,
		/// <summary><c>VFMSUB231SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 BB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231ss_xmm_k1z_xmm_xmmm32_er = 3560,
		/// <summary><c>VFMSUB231SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 BB /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfmsub231sd_xmm_k1z_xmm_xmmm64_er = 3561,
		/// <summary><c>VFNMADD231PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 BC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd231ps_xmm_xmm_xmmm128 = 3562,
		/// <summary><c>VFNMADD231PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 BC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd231ps_ymm_ymm_ymmm256 = 3563,
		/// <summary><c>VFNMADD231PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 BC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd231pd_xmm_xmm_xmmm128 = 3564,
		/// <summary><c>VFNMADD231PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 BC /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd231pd_ymm_ymm_ymmm256 = 3565,
		/// <summary><c>VFNMADD231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 BC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231ps_xmm_k1z_xmm_xmmm128b32 = 3566,
		/// <summary><c>VFNMADD231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 BC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231ps_ymm_k1z_ymm_ymmm256b32 = 3567,
		/// <summary><c>VFNMADD231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 BC /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231ps_zmm_k1z_zmm_zmmm512b32_er = 3568,
		/// <summary><c>VFNMADD231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 BC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231pd_xmm_k1z_xmm_xmmm128b64 = 3569,
		/// <summary><c>VFNMADD231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 BC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231pd_ymm_k1z_ymm_ymmm256b64 = 3570,
		/// <summary><c>VFNMADD231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 BC /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231pd_zmm_k1z_zmm_zmmm512b64_er = 3571,
		/// <summary><c>VFNMADD231SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 BD /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd231ss_xmm_xmm_xmmm32 = 3572,
		/// <summary><c>VFNMADD231SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 BD /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmadd231sd_xmm_xmm_xmmm64 = 3573,
		/// <summary><c>VFNMADD231SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 BD /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231ss_xmm_k1z_xmm_xmmm32_er = 3574,
		/// <summary><c>VFNMADD231SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 BD /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmadd231sd_xmm_k1z_xmm_xmmm64_er = 3575,
		/// <summary><c>VFNMSUB231PS xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 BE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub231ps_xmm_xmm_xmmm128 = 3576,
		/// <summary><c>VFNMSUB231PS ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 BE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub231ps_ymm_ymm_ymmm256 = 3577,
		/// <summary><c>VFNMSUB231PD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W1 BE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub231pd_xmm_xmm_xmmm128 = 3578,
		/// <summary><c>VFNMSUB231PD ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W1 BE /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub231pd_ymm_ymm_ymmm256 = 3579,
		/// <summary><c>VFNMSUB231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 BE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231ps_xmm_k1z_xmm_xmmm128b32 = 3580,
		/// <summary><c>VFNMSUB231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 BE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231ps_ymm_k1z_ymm_ymmm256b32 = 3581,
		/// <summary><c>VFNMSUB231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 BE /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231ps_zmm_k1z_zmm_zmmm512b32_er = 3582,
		/// <summary><c>VFNMSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 BE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231pd_xmm_k1z_xmm_xmmm128b64 = 3583,
		/// <summary><c>VFNMSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 BE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231pd_ymm_k1z_ymm_ymmm256b64 = 3584,
		/// <summary><c>VFNMSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 BE /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231pd_zmm_k1z_zmm_zmmm512b64_er = 3585,
		/// <summary><c>VFNMSUB231SS xmm1, xmm2, xmm3/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W0 BF /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub231ss_xmm_xmm_xmmm32 = 3586,
		/// <summary><c>VFNMSUB231SD xmm1, xmm2, xmm3/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F38.W1 BF /r</c><br/>
		/// <br/>
		/// <c>FMA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsub231sd_xmm_xmm_xmmm64 = 3587,
		/// <summary><c>VFNMSUB231SS xmm1 {k1}{z}, xmm2, xmm3/m32{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 BF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231ss_xmm_k1z_xmm_xmmm32_er = 3588,
		/// <summary><c>VFNMSUB231SD xmm1 {k1}{z}, xmm2, xmm3/m64{er}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 BF /r</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfnmsub231sd_xmm_k1z_xmm_xmmm64_er = 3589,
		/// <summary><c>VPCONFLICTD xmm1 {k1}{z}, xmm2/m128/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 C4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpconflictd_xmm_k1z_xmmm128b32 = 3590,
		/// <summary><c>VPCONFLICTD ymm1 {k1}{z}, ymm2/m256/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 C4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpconflictd_ymm_k1z_ymmm256b32 = 3591,
		/// <summary><c>VPCONFLICTD zmm1 {k1}{z}, zmm2/m512/m32bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C4 /r</c><br/>
		/// <br/>
		/// <c>AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpconflictd_zmm_k1z_zmmm512b32 = 3592,
		/// <summary><c>VPCONFLICTQ xmm1 {k1}{z}, xmm2/m128/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W1 C4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpconflictq_xmm_k1z_xmmm128b64 = 3593,
		/// <summary><c>VPCONFLICTQ ymm1 {k1}{z}, ymm2/m256/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W1 C4 /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpconflictq_ymm_k1z_ymmm256b64 = 3594,
		/// <summary><c>VPCONFLICTQ zmm1 {k1}{z}, zmm2/m512/m64bcst</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C4 /r</c><br/>
		/// <br/>
		/// <c>AVX512CD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpconflictq_zmm_k1z_zmmm512b64 = 3595,
		/// <summary><c>VGATHERPF0DPS vm32z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C6 /1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf0dps_vm32z_k1 = 3596,
		/// <summary><c>VGATHERPF0DPD vm32y {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C6 /1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf0dpd_vm32y_k1 = 3597,
		/// <summary><c>VGATHERPF1DPS vm32z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C6 /2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf1dps_vm32z_k1 = 3598,
		/// <summary><c>VGATHERPF1DPD vm32y {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C6 /2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf1dpd_vm32y_k1 = 3599,
		/// <summary><c>VSCATTERPF0DPS vm32z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C6 /5 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf0dps_vm32z_k1 = 3600,
		/// <summary><c>VSCATTERPF0DPD vm32y {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C6 /5 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf0dpd_vm32y_k1 = 3601,
		/// <summary><c>VSCATTERPF1DPS vm32z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C6 /6 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf1dps_vm32z_k1 = 3602,
		/// <summary><c>VSCATTERPF1DPD vm32y {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C6 /6 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf1dpd_vm32y_k1 = 3603,
		/// <summary><c>VGATHERPF0QPS vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C7 /1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf0qps_vm64z_k1 = 3604,
		/// <summary><c>VGATHERPF0QPD vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C7 /1 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf0qpd_vm64z_k1 = 3605,
		/// <summary><c>VGATHERPF1QPS vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C7 /2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf1qps_vm64z_k1 = 3606,
		/// <summary><c>VGATHERPF1QPD vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C7 /2 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgatherpf1qpd_vm64z_k1 = 3607,
		/// <summary><c>VSCATTERPF0QPS vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C7 /5 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf0qps_vm64z_k1 = 3608,
		/// <summary><c>VSCATTERPF0QPD vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C7 /5 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf0qpd_vm64z_k1 = 3609,
		/// <summary><c>VSCATTERPF1QPS vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C7 /6 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf1qps_vm64z_k1 = 3610,
		/// <summary><c>VSCATTERPF1QPD vm64z {k1}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C7 /6 /vsib</c><br/>
		/// <br/>
		/// <c>AVX512PF</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vscatterpf1qpd_vm64z_k1 = 3611,
		/// <summary><c>SHA1NEXTE xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 38 C8 /r</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha1nexte_xmm_xmmm128 = 3612,
		/// <summary><c>VEXP2PS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 C8 /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexp2ps_zmm_k1z_zmmm512b32_sae = 3613,
		/// <summary><c>VEXP2PD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 C8 /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vexp2pd_zmm_k1z_zmmm512b64_sae = 3614,
		/// <summary><c>SHA1MSG1 xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 38 C9 /r</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha1msg1_xmm_xmmm128 = 3615,
		/// <summary><c>SHA1MSG2 xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 38 CA /r</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha1msg2_xmm_xmmm128 = 3616,
		/// <summary><c>VRCP28PS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 CA /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp28ps_zmm_k1z_zmmm512b32_sae = 3617,
		/// <summary><c>VRCP28PD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 CA /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp28pd_zmm_k1z_zmmm512b64_sae = 3618,
		/// <summary><c>SHA256RNDS2 xmm1, xmm2/m128, &lt;XMM0&gt;</c><br/>
		/// <br/>
		/// <c>NP 0F 38 CB /r</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha256rnds2_xmm_xmmm128 = 3619,
		/// <summary><c>VRCP28SS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 CB /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp28ss_xmm_k1z_xmm_xmmm32_sae = 3620,
		/// <summary><c>VRCP28SD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 CB /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrcp28sd_xmm_k1z_xmm_xmmm64_sae = 3621,
		/// <summary><c>SHA256MSG1 xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 38 CC /r</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha256msg1_xmm_xmmm128 = 3622,
		/// <summary><c>VRSQRT28PS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 CC /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt28ps_zmm_k1z_zmmm512b32_sae = 3623,
		/// <summary><c>VRSQRT28PD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W1 CC /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt28pd_zmm_k1z_zmmm512b64_sae = 3624,
		/// <summary><c>SHA256MSG2 xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>NP 0F 38 CD /r</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha256msg2_xmm_xmmm128 = 3625,
		/// <summary><c>VRSQRT28SS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W0 CD /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt28ss_xmm_k1z_xmm_xmmm32_sae = 3626,
		/// <summary><c>VRSQRT28SD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F38.W1 CD /r</c><br/>
		/// <br/>
		/// <c>AVX512ER</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrsqrt28sd_xmm_k1z_xmm_xmmm64_sae = 3627,
		/// <summary><c>GF2P8MULB xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 CF /r</c><br/>
		/// <br/>
		/// <c>GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Gf2p8mulb_xmm_xmmm128 = 3628,
		/// <summary><c>VGF2P8MULB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.W0 CF /r</c><br/>
		/// <br/>
		/// <c>AVX and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgf2p8mulb_xmm_xmm_xmmm128 = 3629,
		/// <summary><c>VGF2P8MULB ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.W0 CF /r</c><br/>
		/// <br/>
		/// <c>AVX and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgf2p8mulb_ymm_ymm_ymmm256 = 3630,
		/// <summary><c>VGF2P8MULB xmm1 {k1}{z}, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.W0 CF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8mulb_xmm_k1z_xmm_xmmm128 = 3631,
		/// <summary><c>VGF2P8MULB ymm1 {k1}{z}, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.W0 CF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8mulb_ymm_k1z_ymm_ymmm256 = 3632,
		/// <summary><c>VGF2P8MULB zmm1 {k1}{z}, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.W0 CF /r</c><br/>
		/// <br/>
		/// <c>AVX512F and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8mulb_zmm_k1z_zmm_zmmm512 = 3633,
		/// <summary><c>AESIMC xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 DB /r</c><br/>
		/// <br/>
		/// <c>AES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Aesimc_xmm_xmmm128 = 3634,
		/// <summary><c>VAESIMC xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG DB /r</c><br/>
		/// <br/>
		/// <c>AES and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesimc_xmm_xmmm128 = 3635,
		/// <summary><c>AESENC xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 DC /r</c><br/>
		/// <br/>
		/// <c>AES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Aesenc_xmm_xmmm128 = 3636,
		/// <summary><c>VAESENC xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AES and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesenc_xmm_xmm_xmmm128 = 3637,
		/// <summary><c>VAESENC ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG DC /r</c><br/>
		/// <br/>
		/// <c>VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesenc_ymm_ymm_ymmm256 = 3638,
		/// <summary><c>VAESENC xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesenc_xmm_xmm_xmmm128 = 3639,
		/// <summary><c>VAESENC ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesenc_ymm_ymm_ymmm256 = 3640,
		/// <summary><c>VAESENC zmm1, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG DC /r</c><br/>
		/// <br/>
		/// <c>AVX512F and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesenc_zmm_zmm_zmmm512 = 3641,
		/// <summary><c>AESENCLAST xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 DD /r</c><br/>
		/// <br/>
		/// <c>AES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Aesenclast_xmm_xmmm128 = 3642,
		/// <summary><c>VAESENCLAST xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AES and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesenclast_xmm_xmm_xmmm128 = 3643,
		/// <summary><c>VAESENCLAST ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG DD /r</c><br/>
		/// <br/>
		/// <c>VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesenclast_ymm_ymm_ymmm256 = 3644,
		/// <summary><c>VAESENCLAST xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesenclast_xmm_xmm_xmmm128 = 3645,
		/// <summary><c>VAESENCLAST ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesenclast_ymm_ymm_ymmm256 = 3646,
		/// <summary><c>VAESENCLAST zmm1, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG DD /r</c><br/>
		/// <br/>
		/// <c>AVX512F and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesenclast_zmm_zmm_zmmm512 = 3647,
		/// <summary><c>AESDEC xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 DE /r</c><br/>
		/// <br/>
		/// <c>AES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Aesdec_xmm_xmmm128 = 3648,
		/// <summary><c>VAESDEC xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AES and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesdec_xmm_xmm_xmmm128 = 3649,
		/// <summary><c>VAESDEC ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG DE /r</c><br/>
		/// <br/>
		/// <c>VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesdec_ymm_ymm_ymmm256 = 3650,
		/// <summary><c>VAESDEC xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesdec_xmm_xmm_xmmm128 = 3651,
		/// <summary><c>VAESDEC ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesdec_ymm_ymm_ymmm256 = 3652,
		/// <summary><c>VAESDEC zmm1, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG DE /r</c><br/>
		/// <br/>
		/// <c>AVX512F and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesdec_zmm_zmm_zmmm512 = 3653,
		/// <summary><c>AESDECLAST xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>66 0F 38 DF /r</c><br/>
		/// <br/>
		/// <c>AES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Aesdeclast_xmm_xmmm128 = 3654,
		/// <summary><c>VAESDECLAST xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F38.WIG DF /r</c><br/>
		/// <br/>
		/// <c>AES and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesdeclast_xmm_xmm_xmmm128 = 3655,
		/// <summary><c>VAESDECLAST ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F38.WIG DF /r</c><br/>
		/// <br/>
		/// <c>VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaesdeclast_ymm_ymm_ymmm256 = 3656,
		/// <summary><c>VAESDECLAST xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F38.WIG DF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesdeclast_xmm_xmm_xmmm128 = 3657,
		/// <summary><c>VAESDECLAST ymm1, ymm2, ymm3/m256</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F38.WIG DF /r</c><br/>
		/// <br/>
		/// <c>AVX512VL and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesdeclast_ymm_ymm_ymmm256 = 3658,
		/// <summary><c>VAESDECLAST zmm1, zmm2, zmm3/m512</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F38.WIG DF /r</c><br/>
		/// <br/>
		/// <c>AVX512F and VAES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vaesdeclast_zmm_zmm_zmmm512 = 3659,
		/// <summary><c>MOVBE r16, m16</c><br/>
		/// <br/>
		/// <c>o16 0F 38 F0 /r</c><br/>
		/// <br/>
		/// <c>MOVBE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movbe_r16_m16 = 3660,
		/// <summary><c>MOVBE r32, m32</c><br/>
		/// <br/>
		/// <c>o32 0F 38 F0 /r</c><br/>
		/// <br/>
		/// <c>MOVBE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movbe_r32_m32 = 3661,
		/// <summary><c>MOVBE r64, m64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 38 F0 /r</c><br/>
		/// <br/>
		/// <c>MOVBE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movbe_r64_m64 = 3662,
		/// <summary><c>CRC32 r32, r/m8</c><br/>
		/// <br/>
		/// <c>F2 0F 38 F0 /r</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Crc32_r32_rm8 = 3663,
		/// <summary><c>CRC32 r64, r/m8</c><br/>
		/// <br/>
		/// <c>F2 REX.W 0F 38 F0 /r</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Crc32_r64_rm8 = 3664,
		/// <summary><c>MOVBE m16, r16</c><br/>
		/// <br/>
		/// <c>o16 0F 38 F1 /r</c><br/>
		/// <br/>
		/// <c>MOVBE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movbe_m16_r16 = 3665,
		/// <summary><c>MOVBE m32, r32</c><br/>
		/// <br/>
		/// <c>o32 0F 38 F1 /r</c><br/>
		/// <br/>
		/// <c>MOVBE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movbe_m32_r32 = 3666,
		/// <summary><c>MOVBE m64, r64</c><br/>
		/// <br/>
		/// <c>REX.W 0F 38 F1 /r</c><br/>
		/// <br/>
		/// <c>MOVBE</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movbe_m64_r64 = 3667,
		/// <summary><c>CRC32 r32, r/m16</c><br/>
		/// <br/>
		/// <c>o16 F2 0F 38 F1 /r</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Crc32_r32_rm16 = 3668,
		/// <summary><c>CRC32 r32, r/m32</c><br/>
		/// <br/>
		/// <c>o32 F2 0F 38 F1 /r</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Crc32_r32_rm32 = 3669,
		/// <summary><c>CRC32 r64, r/m64</c><br/>
		/// <br/>
		/// <c>F2 REX.W 0F 38 F1 /r</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Crc32_r64_rm64 = 3670,
		/// <summary><c>ANDN r32a, r32b, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W0 F2 /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Andn_r32_r32_rm32 = 3671,
		/// <summary><c>ANDN r64a, r64b, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W1 F2 /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Andn_r64_r64_rm64 = 3672,
		/// <summary><c>BLSR r32, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W0 F3 /1</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Blsr_r32_rm32 = 3673,
		/// <summary><c>BLSR r64, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W1 F3 /1</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Blsr_r64_rm64 = 3674,
		/// <summary><c>BLSMSK r32, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W0 F3 /2</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Blsmsk_r32_rm32 = 3675,
		/// <summary><c>BLSMSK r64, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W1 F3 /2</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Blsmsk_r64_rm64 = 3676,
		/// <summary><c>BLSI r32, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W0 F3 /3</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Blsi_r32_rm32 = 3677,
		/// <summary><c>BLSI r64, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W1 F3 /3</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Blsi_r64_rm64 = 3678,
		/// <summary><c>BZHI r32a, r/m32, r32b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W0 F5 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Bzhi_r32_rm32_r32 = 3679,
		/// <summary><c>BZHI r64a, r/m64, r64b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W1 F5 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Bzhi_r64_rm64_r64 = 3680,
		/// <summary><c>WRUSSD m32, r32</c><br/>
		/// <br/>
		/// <c>66 0F 38 F5 /r</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wrussd_m32_r32 = 3681,
		/// <summary><c>WRUSSQ m64, r64</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 38 F5 /r</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Wrussq_m64_r64 = 3682,
		/// <summary><c>PEXT r32a, r32b, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F3.0F38.W0 F5 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Pext_r32_r32_rm32 = 3683,
		/// <summary><c>PEXT r64a, r64b, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F3.0F38.W1 F5 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Pext_r64_r64_rm64 = 3684,
		/// <summary><c>PDEP r32a, r32b, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F38.W0 F5 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Pdep_r32_r32_rm32 = 3685,
		/// <summary><c>PDEP r64a, r64b, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F38.W1 F5 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Pdep_r64_r64_rm64 = 3686,
		/// <summary><c>WRSSD m32, r32</c><br/>
		/// <br/>
		/// <c>NP 0F 38 F6 /r</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Wrssd_m32_r32 = 3687,
		/// <summary><c>WRSSQ m64, r64</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F 38 F6 /r</c><br/>
		/// <br/>
		/// <c>CET_SS</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Wrssq_m64_r64 = 3688,
		/// <summary><c>ADCX r32, r/m32</c><br/>
		/// <br/>
		/// <c>66 0F 38 F6 /r</c><br/>
		/// <br/>
		/// <c>ADX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adcx_r32_rm32 = 3689,
		/// <summary><c>ADCX r64, r/m64</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 38 F6 /r</c><br/>
		/// <br/>
		/// <c>ADX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adcx_r64_rm64 = 3690,
		/// <summary><c>ADOX r32, r/m32</c><br/>
		/// <br/>
		/// <c>F3 0F 38 F6 /r</c><br/>
		/// <br/>
		/// <c>ADX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Adox_r32_rm32 = 3691,
		/// <summary><c>ADOX r64, r/m64</c><br/>
		/// <br/>
		/// <c>F3 REX.W 0F 38 F6 /r</c><br/>
		/// <br/>
		/// <c>ADX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Adox_r64_rm64 = 3692,
		/// <summary><c>MULX r32a, r32b, r/m32</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F38.W0 F6 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Mulx_r32_r32_rm32 = 3693,
		/// <summary><c>MULX r64a, r64b, r/m64</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F38.W1 F6 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Mulx_r64_r64_rm64 = 3694,
		/// <summary><c>BEXTR r32a, r/m32, r32b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W0 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Bextr_r32_rm32_r32 = 3695,
		/// <summary><c>BEXTR r64a, r/m64, r64b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.0F38.W1 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Bextr_r64_rm64_r64 = 3696,
		/// <summary><c>SHLX r32a, r/m32, r32b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.66.0F38.W0 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Shlx_r32_rm32_r32 = 3697,
		/// <summary><c>SHLX r64a, r/m64, r64b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.66.0F38.W1 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Shlx_r64_rm64_r64 = 3698,
		/// <summary><c>SARX r32a, r/m32, r32b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F3.0F38.W0 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Sarx_r32_rm32_r32 = 3699,
		/// <summary><c>SARX r64a, r/m64, r64b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F3.0F38.W1 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Sarx_r64_rm64_r64 = 3700,
		/// <summary><c>SHRX r32a, r/m32, r32b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F38.W0 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Shrx_r32_rm32_r32 = 3701,
		/// <summary><c>SHRX r64a, r/m64, r64b</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F38.W1 F7 /r</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Shrx_r64_rm64_r64 = 3702,
		/// <summary><c>MOVDIR64B r16, m512</c><br/>
		/// <br/>
		/// <c>a16 66 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>MOVDIR64B</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Movdir64b_r16_m512 = 3703,
		/// <summary><c>MOVDIR64B r32, m512</c><br/>
		/// <br/>
		/// <c>a32 66 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>MOVDIR64B</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdir64b_r32_m512 = 3704,
		/// <summary><c>MOVDIR64B r64, m512</c><br/>
		/// <br/>
		/// <c>66 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>MOVDIR64B</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movdir64b_r64_m512 = 3705,
		/// <summary><c>ENQCMDS r16, m512</c><br/>
		/// <br/>
		/// <c>a16 F3 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>ENQCMD</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Enqcmds_r16_m512 = 3706,
		/// <summary><c>ENQCMDS r32, m512</c><br/>
		/// <br/>
		/// <c>a32 F3 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>ENQCMD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Enqcmds_r32_m512 = 3707,
		/// <summary><c>ENQCMDS r64, m512</c><br/>
		/// <br/>
		/// <c>F3 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>ENQCMD</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Enqcmds_r64_m512 = 3708,
		/// <summary><c>ENQCMD r16, m512</c><br/>
		/// <br/>
		/// <c>a16 F2 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>ENQCMD</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Enqcmd_r16_m512 = 3709,
		/// <summary><c>ENQCMD r32, m512</c><br/>
		/// <br/>
		/// <c>a32 F2 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>ENQCMD</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Enqcmd_r32_m512 = 3710,
		/// <summary><c>ENQCMD r64, m512</c><br/>
		/// <br/>
		/// <c>F2 0F 38 F8 /r</c><br/>
		/// <br/>
		/// <c>ENQCMD</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Enqcmd_r64_m512 = 3711,
		/// <summary><c>MOVDIRI m32, r32</c><br/>
		/// <br/>
		/// <c>NP 0F 38 F9 /r</c><br/>
		/// <br/>
		/// <c>MOVDIRI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Movdiri_m32_r32 = 3712,
		/// <summary><c>MOVDIRI m64, r64</c><br/>
		/// <br/>
		/// <c>NP REX.W 0F 38 F9 /r</c><br/>
		/// <br/>
		/// <c>MOVDIRI</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Movdiri_m64_r64 = 3713,
		/// <summary><c>VPERMQ ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 00 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermq_ymm_ymmm256_imm8 = 3714,
		/// <summary><c>VPERMQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 00 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermq_ymm_k1z_ymmm256b64_imm8 = 3715,
		/// <summary><c>VPERMQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 00 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermq_zmm_k1z_zmmm512b64_imm8 = 3716,
		/// <summary><c>VPERMPD ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 01 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermpd_ymm_ymmm256_imm8 = 3717,
		/// <summary><c>VPERMPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 01 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermpd_ymm_k1z_ymmm256b64_imm8 = 3718,
		/// <summary><c>VPERMPD zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 01 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermpd_zmm_k1z_zmmm512b64_imm8 = 3719,
		/// <summary><c>VPBLENDD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 02 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpblendd_xmm_xmm_xmmm128_imm8 = 3720,
		/// <summary><c>VPBLENDD ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 02 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpblendd_ymm_ymm_ymmm256_imm8 = 3721,
		/// <summary><c>VALIGND xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 03 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Valignd_xmm_k1z_xmm_xmmm128b32_imm8 = 3722,
		/// <summary><c>VALIGND ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 03 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Valignd_ymm_k1z_ymm_ymmm256b32_imm8 = 3723,
		/// <summary><c>VALIGND zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 03 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Valignd_zmm_k1z_zmm_zmmm512b32_imm8 = 3724,
		/// <summary><c>VALIGNQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 03 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Valignq_xmm_k1z_xmm_xmmm128b64_imm8 = 3725,
		/// <summary><c>VALIGNQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 03 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Valignq_ymm_k1z_ymm_ymmm256b64_imm8 = 3726,
		/// <summary><c>VALIGNQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 03 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Valignq_zmm_k1z_zmm_zmmm512b64_imm8 = 3727,
		/// <summary><c>VPERMILPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 04 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilps_xmm_xmmm128_imm8 = 3728,
		/// <summary><c>VPERMILPS ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 04 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilps_ymm_ymmm256_imm8 = 3729,
		/// <summary><c>VPERMILPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 04 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilps_xmm_k1z_xmmm128b32_imm8 = 3730,
		/// <summary><c>VPERMILPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 04 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilps_ymm_k1z_ymmm256b32_imm8 = 3731,
		/// <summary><c>VPERMILPS zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 04 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilps_zmm_k1z_zmmm512b32_imm8 = 3732,
		/// <summary><c>VPERMILPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 05 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilpd_xmm_xmmm128_imm8 = 3733,
		/// <summary><c>VPERMILPD ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 05 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermilpd_ymm_ymmm256_imm8 = 3734,
		/// <summary><c>VPERMILPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 05 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilpd_xmm_k1z_xmmm128b64_imm8 = 3735,
		/// <summary><c>VPERMILPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 05 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilpd_ymm_k1z_ymmm256b64_imm8 = 3736,
		/// <summary><c>VPERMILPD zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 05 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpermilpd_zmm_k1z_zmmm512b64_imm8 = 3737,
		/// <summary><c>VPERM2F128 ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 06 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vperm2f128_ymm_ymm_ymmm256_imm8 = 3738,
		/// <summary><c>ROUNDPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 08 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Roundps_xmm_xmmm128_imm8 = 3739,
		/// <summary><c>VROUNDPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 08 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vroundps_xmm_xmmm128_imm8 = 3740,
		/// <summary><c>VROUNDPS ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 08 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vroundps_ymm_ymmm256_imm8 = 3741,
		/// <summary><c>VRNDSCALEPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 08 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscaleps_xmm_k1z_xmmm128b32_imm8 = 3742,
		/// <summary><c>VRNDSCALEPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 08 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscaleps_ymm_k1z_ymmm256b32_imm8 = 3743,
		/// <summary><c>VRNDSCALEPS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 08 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscaleps_zmm_k1z_zmmm512b32_imm8_sae = 3744,
		/// <summary><c>ROUNDPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 09 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Roundpd_xmm_xmmm128_imm8 = 3745,
		/// <summary><c>VROUNDPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 09 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vroundpd_xmm_xmmm128_imm8 = 3746,
		/// <summary><c>VROUNDPD ymm1, ymm2/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 09 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vroundpd_ymm_ymmm256_imm8 = 3747,
		/// <summary><c>VRNDSCALEPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 09 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscalepd_xmm_k1z_xmmm128b64_imm8 = 3748,
		/// <summary><c>VRNDSCALEPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 09 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscalepd_ymm_k1z_ymmm256b64_imm8 = 3749,
		/// <summary><c>VRNDSCALEPD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 09 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscalepd_zmm_k1z_zmmm512b64_imm8_sae = 3750,
		/// <summary><c>ROUNDSS xmm1, xmm2/m32, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 0A /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Roundss_xmm_xmmm32_imm8 = 3751,
		/// <summary><c>VROUNDSS xmm1, xmm2, xmm3/m32, imm8</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.WIG 0A /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vroundss_xmm_xmm_xmmm32_imm8 = 3752,
		/// <summary><c>VRNDSCALESS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W0 0A /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscaless_xmm_k1z_xmm_xmmm32_imm8_sae = 3753,
		/// <summary><c>ROUNDSD xmm1, xmm2/m64, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 0B /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Roundsd_xmm_xmmm64_imm8 = 3754,
		/// <summary><c>VROUNDSD xmm1, xmm2, xmm3/m64, imm8</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.WIG 0B /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vroundsd_xmm_xmm_xmmm64_imm8 = 3755,
		/// <summary><c>VRNDSCALESD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W1 0B /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrndscalesd_xmm_k1z_xmm_xmmm64_imm8_sae = 3756,
		/// <summary><c>BLENDPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 0C /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Blendps_xmm_xmmm128_imm8 = 3757,
		/// <summary><c>VBLENDPS xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 0C /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendps_xmm_xmm_xmmm128_imm8 = 3758,
		/// <summary><c>VBLENDPS ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 0C /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendps_ymm_ymm_ymmm256_imm8 = 3759,
		/// <summary><c>BLENDPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 0D /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Blendpd_xmm_xmmm128_imm8 = 3760,
		/// <summary><c>VBLENDPD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 0D /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendpd_xmm_xmm_xmmm128_imm8 = 3761,
		/// <summary><c>VBLENDPD ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 0D /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendpd_ymm_ymm_ymmm256_imm8 = 3762,
		/// <summary><c>PBLENDW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 0E /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pblendw_xmm_xmmm128_imm8 = 3763,
		/// <summary><c>VPBLENDW xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 0E /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpblendw_xmm_xmm_xmmm128_imm8 = 3764,
		/// <summary><c>VPBLENDW ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 0E /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpblendw_ymm_ymm_ymmm256_imm8 = 3765,
		/// <summary><c>PALIGNR mm1, mm2/m64, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 3A 0F /r ib</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Palignr_mm_mmm64_imm8 = 3766,
		/// <summary><c>PALIGNR xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 0F /r ib</c><br/>
		/// <br/>
		/// <c>SSSE3</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Palignr_xmm_xmmm128_imm8 = 3767,
		/// <summary><c>VPALIGNR xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 0F /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpalignr_xmm_xmm_xmmm128_imm8 = 3768,
		/// <summary><c>VPALIGNR ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 0F /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpalignr_ymm_ymm_ymmm256_imm8 = 3769,
		/// <summary><c>VPALIGNR xmm1 {k1}{z}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.WIG 0F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpalignr_xmm_k1z_xmm_xmmm128_imm8 = 3770,
		/// <summary><c>VPALIGNR ymm1 {k1}{z}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.WIG 0F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpalignr_ymm_k1z_ymm_ymmm256_imm8 = 3771,
		/// <summary><c>VPALIGNR zmm1 {k1}{z}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.WIG 0F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpalignr_zmm_k1z_zmm_zmmm512_imm8 = 3772,
		/// <summary><c>PEXTRB r32/m8, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 14 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pextrb_r32m8_xmm_imm8 = 3773,
		/// <summary><c>PEXTRB r64/m8, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 14 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pextrb_r64m8_xmm_imm8 = 3774,
		/// <summary><c>VPEXTRB r32/m8, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 14 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpextrb_r32m8_xmm_imm8 = 3775,
		/// <summary><c>VPEXTRB r64/m8, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 14 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpextrb_r64m8_xmm_imm8 = 3776,
		/// <summary><c>VPEXTRB r32/m8, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 14 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpextrb_r32m8_xmm_imm8 = 3777,
		/// <summary><c>VPEXTRB r64/m8, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 14 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpextrb_r64m8_xmm_imm8 = 3778,
		/// <summary><c>PEXTRW r32/m16, xmm, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 15 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pextrw_r32m16_xmm_imm8 = 3779,
		/// <summary><c>PEXTRW r64/m16, xmm, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 15 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pextrw_r64m16_xmm_imm8 = 3780,
		/// <summary><c>VPEXTRW r32/m16, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 15 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpextrw_r32m16_xmm_imm8 = 3781,
		/// <summary><c>VPEXTRW r64/m16, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 15 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpextrw_r64m16_xmm_imm8 = 3782,
		/// <summary><c>VPEXTRW r32/m16, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 15 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpextrw_r32m16_xmm_imm8 = 3783,
		/// <summary><c>VPEXTRW r64/m16, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 15 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpextrw_r64m16_xmm_imm8 = 3784,
		/// <summary><c>PEXTRD r/m32, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 16 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pextrd_rm32_xmm_imm8 = 3785,
		/// <summary><c>PEXTRQ r/m64, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 16 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pextrq_rm64_xmm_imm8 = 3786,
		/// <summary><c>VPEXTRD r/m32, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 16 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpextrd_rm32_xmm_imm8 = 3787,
		/// <summary><c>VPEXTRQ r/m64, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 16 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpextrq_rm64_xmm_imm8 = 3788,
		/// <summary><c>VPEXTRD r/m32, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 16 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpextrd_rm32_xmm_imm8 = 3789,
		/// <summary><c>VPEXTRQ r/m64, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 16 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpextrq_rm64_xmm_imm8 = 3790,
		/// <summary><c>EXTRACTPS r/m32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 17 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Extractps_rm32_xmm_imm8 = 3791,
		/// <summary><c>EXTRACTPS r64/m32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 17 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Extractps_r64m32_xmm_imm8 = 3792,
		/// <summary><c>VEXTRACTPS r/m32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 17 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vextractps_rm32_xmm_imm8 = 3793,
		/// <summary><c>VEXTRACTPS r64/m32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 17 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vextractps_r64m32_xmm_imm8 = 3794,
		/// <summary><c>VEXTRACTPS r/m32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 17 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractps_rm32_xmm_imm8 = 3795,
		/// <summary><c>VEXTRACTPS r64/m32, xmm1, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 17 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vextractps_r64m32_xmm_imm8 = 3796,
		/// <summary><c>VINSERTF128 ymm1, ymm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 18 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vinsertf128_ymm_ymm_xmmm128_imm8 = 3797,
		/// <summary><c>VINSERTF32X4 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 18 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertf32x4_ymm_k1z_ymm_xmmm128_imm8 = 3798,
		/// <summary><c>VINSERTF32X4 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 18 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertf32x4_zmm_k1z_zmm_xmmm128_imm8 = 3799,
		/// <summary><c>VINSERTF64X2 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 18 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertf64x2_ymm_k1z_ymm_xmmm128_imm8 = 3800,
		/// <summary><c>VINSERTF64X2 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 18 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertf64x2_zmm_k1z_zmm_xmmm128_imm8 = 3801,
		/// <summary><c>VEXTRACTF128 xmm1/m128, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 19 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vextractf128_xmmm128_ymm_imm8 = 3802,
		/// <summary><c>VEXTRACTF32X4 xmm1/m128 {k1}{z}, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 19 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractf32x4_xmmm128_k1z_ymm_imm8 = 3803,
		/// <summary><c>VEXTRACTF32X4 xmm1/m128 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 19 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractf32x4_xmmm128_k1z_zmm_imm8 = 3804,
		/// <summary><c>VEXTRACTF64X2 xmm1/m128 {k1}{z}, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 19 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractf64x2_xmmm128_k1z_ymm_imm8 = 3805,
		/// <summary><c>VEXTRACTF64X2 xmm1/m128 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 19 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractf64x2_xmmm128_k1z_zmm_imm8 = 3806,
		/// <summary><c>VINSERTF32X8 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 1A /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertf32x8_zmm_k1z_zmm_ymmm256_imm8 = 3807,
		/// <summary><c>VINSERTF64X4 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 1A /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertf64x4_zmm_k1z_zmm_ymmm256_imm8 = 3808,
		/// <summary><c>VEXTRACTF32X8 ymm1/m256 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 1B /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractf32x8_ymmm256_k1z_zmm_imm8 = 3809,
		/// <summary><c>VEXTRACTF64X4 ymm1/m256 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 1B /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextractf64x4_ymmm256_k1z_zmm_imm8 = 3810,
		/// <summary><c>VCVTPS2PH xmm1/m64, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 1D /r ib</c><br/>
		/// <br/>
		/// <c>F16C</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtps2ph_xmmm64_xmm_imm8 = 3811,
		/// <summary><c>VCVTPS2PH xmm1/m128, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 1D /r ib</c><br/>
		/// <br/>
		/// <c>F16C</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vcvtps2ph_xmmm128_ymm_imm8 = 3812,
		/// <summary><c>VCVTPS2PH xmm1/m64 {k1}{z}, xmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 1D /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2ph_xmmm64_k1z_xmm_imm8 = 3813,
		/// <summary><c>VCVTPS2PH xmm1/m128 {k1}{z}, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 1D /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2ph_xmmm128_k1z_ymm_imm8 = 3814,
		/// <summary><c>VCVTPS2PH ymm1/m256 {k1}{z}, zmm2{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 1D /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vcvtps2ph_ymmm256_k1z_zmm_imm8_sae = 3815,
		/// <summary><c>VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 1E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpud_k_k1_xmm_xmmm128b32_imm8 = 3816,
		/// <summary><c>VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 1E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpud_k_k1_ymm_ymmm256b32_imm8 = 3817,
		/// <summary><c>VPCMPUD k1 {k2}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 1E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpud_k_k1_zmm_zmmm512b32_imm8 = 3818,
		/// <summary><c>VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 1E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpuq_k_k1_xmm_xmmm128b64_imm8 = 3819,
		/// <summary><c>VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 1E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpuq_k_k1_ymm_ymmm256b64_imm8 = 3820,
		/// <summary><c>VPCMPUQ k1 {k2}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 1E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpuq_k_k1_zmm_zmmm512b64_imm8 = 3821,
		/// <summary><c>VPCMPD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 1F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpd_k_k1_xmm_xmmm128b32_imm8 = 3822,
		/// <summary><c>VPCMPD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 1F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpd_k_k1_ymm_ymmm256b32_imm8 = 3823,
		/// <summary><c>VPCMPD k1 {k2}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 1F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpd_k_k1_zmm_zmmm512b32_imm8 = 3824,
		/// <summary><c>VPCMPQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 1F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpq_k_k1_xmm_xmmm128b64_imm8 = 3825,
		/// <summary><c>VPCMPQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 1F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpq_k_k1_ymm_ymmm256b64_imm8 = 3826,
		/// <summary><c>VPCMPQ k1 {k2}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 1F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpq_k_k1_zmm_zmmm512b64_imm8 = 3827,
		/// <summary><c>PINSRB xmm1, r32/m8, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 20 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pinsrb_xmm_r32m8_imm8 = 3828,
		/// <summary><c>PINSRB xmm1, r64/m8, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 20 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pinsrb_xmm_r64m8_imm8 = 3829,
		/// <summary><c>VPINSRB xmm1, xmm2, r32/m8, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 20 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpinsrb_xmm_xmm_r32m8_imm8 = 3830,
		/// <summary><c>VPINSRB xmm1, xmm2, r64/m8, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 20 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpinsrb_xmm_xmm_r64m8_imm8 = 3831,
		/// <summary><c>VPINSRB xmm1, xmm2, r32/m8, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 20 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpinsrb_xmm_xmm_r32m8_imm8 = 3832,
		/// <summary><c>VPINSRB xmm1, xmm2, r64/m8, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 20 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpinsrb_xmm_xmm_r64m8_imm8 = 3833,
		/// <summary><c>INSERTPS xmm1, xmm2/m32, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 21 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Insertps_xmm_xmmm32_imm8 = 3834,
		/// <summary><c>VINSERTPS xmm1, xmm2, xmm3/m32, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 21 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vinsertps_xmm_xmm_xmmm32_imm8 = 3835,
		/// <summary><c>VINSERTPS xmm1, xmm2, xmm3/m32, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 21 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinsertps_xmm_xmm_xmmm32_imm8 = 3836,
		/// <summary><c>PINSRD xmm1, r/m32, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 22 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pinsrd_xmm_rm32_imm8 = 3837,
		/// <summary><c>PINSRQ xmm1, r/m64, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 22 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pinsrq_xmm_rm64_imm8 = 3838,
		/// <summary><c>VPINSRD xmm1, xmm2, r/m32, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 22 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpinsrd_xmm_xmm_rm32_imm8 = 3839,
		/// <summary><c>VPINSRQ xmm1, xmm2, r/m64, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 22 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpinsrq_xmm_xmm_rm64_imm8 = 3840,
		/// <summary><c>VPINSRD xmm1, xmm2, r/m32, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 22 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpinsrd_xmm_xmm_rm32_imm8 = 3841,
		/// <summary><c>VPINSRQ xmm1, xmm2, r/m64, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 22 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		EVEX_Vpinsrq_xmm_xmm_rm64_imm8 = 3842,
		/// <summary><c>VSHUFF32X4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 23 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshuff32x4_ymm_k1z_ymm_ymmm256b32_imm8 = 3843,
		/// <summary><c>VSHUFF32X4 zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 23 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshuff32x4_zmm_k1z_zmm_zmmm512b32_imm8 = 3844,
		/// <summary><c>VSHUFF64X2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 23 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshuff64x2_ymm_k1z_ymm_ymmm256b64_imm8 = 3845,
		/// <summary><c>VSHUFF64X2 zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 23 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshuff64x2_zmm_k1z_zmm_zmmm512b64_imm8 = 3846,
		/// <summary><c>VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 25 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpternlogd_xmm_k1z_xmm_xmmm128b32_imm8 = 3847,
		/// <summary><c>VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 25 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpternlogd_ymm_k1z_ymm_ymmm256b32_imm8 = 3848,
		/// <summary><c>VPTERNLOGD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 25 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpternlogd_zmm_k1z_zmm_zmmm512b32_imm8 = 3849,
		/// <summary><c>VPTERNLOGQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 25 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpternlogq_xmm_k1z_xmm_xmmm128b64_imm8 = 3850,
		/// <summary><c>VPTERNLOGQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 25 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpternlogq_ymm_k1z_ymm_ymmm256b64_imm8 = 3851,
		/// <summary><c>VPTERNLOGQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 25 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpternlogq_zmm_k1z_zmm_zmmm512b64_imm8 = 3852,
		/// <summary><c>VGETMANTPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 26 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantps_xmm_k1z_xmmm128b32_imm8 = 3853,
		/// <summary><c>VGETMANTPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 26 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantps_ymm_k1z_ymmm256b32_imm8 = 3854,
		/// <summary><c>VGETMANTPS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 26 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantps_zmm_k1z_zmmm512b32_imm8_sae = 3855,
		/// <summary><c>VGETMANTPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 26 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantpd_xmm_k1z_xmmm128b64_imm8 = 3856,
		/// <summary><c>VGETMANTPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 26 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantpd_ymm_k1z_ymmm256b64_imm8 = 3857,
		/// <summary><c>VGETMANTPD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 26 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantpd_zmm_k1z_zmmm512b64_imm8_sae = 3858,
		/// <summary><c>VGETMANTSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W0 27 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantss_xmm_k1z_xmm_xmmm32_imm8_sae = 3859,
		/// <summary><c>VGETMANTSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W1 27 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgetmantsd_xmm_k1z_xmm_xmmm64_imm8_sae = 3860,
		/// <summary><c>KSHIFTRB k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W0 30 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftrb_k_k_imm8 = 3861,
		/// <summary><c>KSHIFTRW k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W1 30 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftrw_k_k_imm8 = 3862,
		/// <summary><c>KSHIFTRD k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W0 31 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftrd_k_k_imm8 = 3863,
		/// <summary><c>KSHIFTRQ k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W1 31 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftrq_k_k_imm8 = 3864,
		/// <summary><c>KSHIFTLB k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W0 32 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftlb_k_k_imm8 = 3865,
		/// <summary><c>KSHIFTLW k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W1 32 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftlw_k_k_imm8 = 3866,
		/// <summary><c>KSHIFTLD k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W0 33 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftld_k_k_imm8 = 3867,
		/// <summary><c>KSHIFTLQ k1, k2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.L0.66.0F3A.W1 33 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Kshiftlq_k_k_imm8 = 3868,
		/// <summary><c>VINSERTI128 ymm1, ymm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 38 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vinserti128_ymm_ymm_xmmm128_imm8 = 3869,
		/// <summary><c>VINSERTI32X4 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 38 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinserti32x4_ymm_k1z_ymm_xmmm128_imm8 = 3870,
		/// <summary><c>VINSERTI32X4 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 38 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinserti32x4_zmm_k1z_zmm_xmmm128_imm8 = 3871,
		/// <summary><c>VINSERTI64X2 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 38 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinserti64x2_ymm_k1z_ymm_xmmm128_imm8 = 3872,
		/// <summary><c>VINSERTI64X2 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 38 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinserti64x2_zmm_k1z_zmm_xmmm128_imm8 = 3873,
		/// <summary><c>VEXTRACTI128 xmm1/m128, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 39 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vextracti128_xmmm128_ymm_imm8 = 3874,
		/// <summary><c>VEXTRACTI32X4 xmm1/m128 {k1}{z}, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 39 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextracti32x4_xmmm128_k1z_ymm_imm8 = 3875,
		/// <summary><c>VEXTRACTI32X4 xmm1/m128 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 39 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextracti32x4_xmmm128_k1z_zmm_imm8 = 3876,
		/// <summary><c>VEXTRACTI64X2 xmm1/m128 {k1}{z}, ymm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 39 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextracti64x2_xmmm128_k1z_ymm_imm8 = 3877,
		/// <summary><c>VEXTRACTI64X2 xmm1/m128 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 39 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextracti64x2_xmmm128_k1z_zmm_imm8 = 3878,
		/// <summary><c>VINSERTI32X8 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 3A /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinserti32x8_zmm_k1z_zmm_ymmm256_imm8 = 3879,
		/// <summary><c>VINSERTI64X4 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 3A /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vinserti64x4_zmm_k1z_zmm_ymmm256_imm8 = 3880,
		/// <summary><c>VEXTRACTI32X8 ymm1/m256 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 3B /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextracti32x8_ymmm256_k1z_zmm_imm8 = 3881,
		/// <summary><c>VEXTRACTI64X4 ymm1/m256 {k1}{z}, zmm2, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 3B /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vextracti64x4_ymmm256_k1z_zmm_imm8 = 3882,
		/// <summary><c>VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 3E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpub_k_k1_xmm_xmmm128_imm8 = 3883,
		/// <summary><c>VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 3E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpub_k_k1_ymm_ymmm256_imm8 = 3884,
		/// <summary><c>VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 3E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpub_k_k1_zmm_zmmm512_imm8 = 3885,
		/// <summary><c>VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 3E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpuw_k_k1_xmm_xmmm128_imm8 = 3886,
		/// <summary><c>VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 3E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpuw_k_k1_ymm_ymmm256_imm8 = 3887,
		/// <summary><c>VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 3E /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpuw_k_k1_zmm_zmmm512_imm8 = 3888,
		/// <summary><c>VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 3F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpb_k_k1_xmm_xmmm128_imm8 = 3889,
		/// <summary><c>VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 3F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpb_k_k1_ymm_ymmm256_imm8 = 3890,
		/// <summary><c>VPCMPB k1 {k2}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 3F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpb_k_k1_zmm_zmmm512_imm8 = 3891,
		/// <summary><c>VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 3F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpw_k_k1_xmm_xmmm128_imm8 = 3892,
		/// <summary><c>VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 3F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpw_k_k1_ymm_ymmm256_imm8 = 3893,
		/// <summary><c>VPCMPW k1 {k2}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 3F /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpcmpw_k_k1_zmm_zmmm512_imm8 = 3894,
		/// <summary><c>DPPS xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 40 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Dpps_xmm_xmmm128_imm8 = 3895,
		/// <summary><c>VDPPS xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 40 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdpps_xmm_xmm_xmmm128_imm8 = 3896,
		/// <summary><c>VDPPS ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 40 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdpps_ymm_ymm_ymmm256_imm8 = 3897,
		/// <summary><c>DPPD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 41 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Dppd_xmm_xmmm128_imm8 = 3898,
		/// <summary><c>VDPPD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 41 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vdppd_xmm_xmm_xmmm128_imm8 = 3899,
		/// <summary><c>MPSADBW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 42 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.1</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Mpsadbw_xmm_xmmm128_imm8 = 3900,
		/// <summary><c>VMPSADBW xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 42 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmpsadbw_xmm_xmm_xmmm128_imm8 = 3901,
		/// <summary><c>VMPSADBW ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 42 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vmpsadbw_ymm_ymm_ymmm256_imm8 = 3902,
		/// <summary><c>VDBPSADBW xmm1 {k1}{z}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 42 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdbpsadbw_xmm_k1z_xmm_xmmm128_imm8 = 3903,
		/// <summary><c>VDBPSADBW ymm1 {k1}{z}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 42 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdbpsadbw_ymm_k1z_ymm_ymmm256_imm8 = 3904,
		/// <summary><c>VDBPSADBW zmm1 {k1}{z}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 42 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512BW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vdbpsadbw_zmm_k1z_zmm_zmmm512_imm8 = 3905,
		/// <summary><c>VSHUFI32X4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 43 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufi32x4_ymm_k1z_ymm_ymmm256b32_imm8 = 3906,
		/// <summary><c>VSHUFI32X4 zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 43 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufi32x4_zmm_k1z_zmm_zmmm512b32_imm8 = 3907,
		/// <summary><c>VSHUFI64X2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 43 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufi64x2_ymm_k1z_ymm_ymmm256b64_imm8 = 3908,
		/// <summary><c>VSHUFI64X2 zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 43 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vshufi64x2_zmm_k1z_zmm_zmmm512b64_imm8 = 3909,
		/// <summary><c>PCLMULQDQ xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 44 /r ib</c><br/>
		/// <br/>
		/// <c>PCLMULQDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pclmulqdq_xmm_xmmm128_imm8 = 3910,
		/// <summary><c>VPCLMULQDQ xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 44 /r ib</c><br/>
		/// <br/>
		/// <c>PCLMULQDQ and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8 = 3911,
		/// <summary><c>VPCLMULQDQ ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.WIG 44 /r ib</c><br/>
		/// <br/>
		/// <c>VPCLMULQDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8 = 3912,
		/// <summary><c>VPCLMULQDQ xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.WIG 44 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and VPCLMULQDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8 = 3913,
		/// <summary><c>VPCLMULQDQ ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.WIG 44 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and VPCLMULQDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8 = 3914,
		/// <summary><c>VPCLMULQDQ zmm1, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.WIG 44 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F and VPCLMULQDQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpclmulqdq_zmm_zmm_zmmm512_imm8 = 3915,
		/// <summary><c>VPERM2I128 ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 46 /r ib</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vperm2i128_ymm_ymm_ymmm256_imm8 = 3916,
		/// <summary><c>VPERMIL2PS xmm1, xmm2, xmm3/m128, xmm4, imm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 48 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2ps_xmm_xmm_xmmm128_xmm_imm2 = 3917,
		/// <summary><c>VPERMIL2PS ymm1, ymm2, ymm3/m256, ymm4, imm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 48 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2ps_ymm_ymm_ymmm256_ymm_imm2 = 3918,
		/// <summary><c>VPERMIL2PS xmm1, xmm2, xmm3, xmm4/m128, imm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 48 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2ps_xmm_xmm_xmm_xmmm128_imm2 = 3919,
		/// <summary><c>VPERMIL2PS ymm1, ymm2, ymm3, ymm4/m256, imm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 48 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2ps_ymm_ymm_ymm_ymmm256_imm2 = 3920,
		/// <summary><c>VPERMIL2PD xmm1, xmm2, xmm3/m128, xmm4, imm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 49 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2pd_xmm_xmm_xmmm128_xmm_imm2 = 3921,
		/// <summary><c>VPERMIL2PD ymm1, ymm2, ymm3/m256, ymm4, imm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 49 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2pd_ymm_ymm_ymmm256_ymm_imm2 = 3922,
		/// <summary><c>VPERMIL2PD xmm1, xmm2, xmm3, xmm4/m128, imm2</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 49 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2pd_xmm_xmm_xmm_xmmm128_imm2 = 3923,
		/// <summary><c>VPERMIL2PD ymm1, ymm2, ymm3, ymm4/m256, imm2</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 49 /r /is5</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpermil2pd_ymm_ymm_ymm_ymmm256_imm2 = 3924,
		/// <summary><c>VBLENDVPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 4A /r /is4</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendvps_xmm_xmm_xmmm128_xmm = 3925,
		/// <summary><c>VBLENDVPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 4A /r /is4</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendvps_ymm_ymm_ymmm256_ymm = 3926,
		/// <summary><c>VBLENDVPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 4B /r /is4</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendvpd_xmm_xmm_xmmm128_xmm = 3927,
		/// <summary><c>VBLENDVPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 4B /r /is4</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vblendvpd_ymm_ymm_ymmm256_ymm = 3928,
		/// <summary><c>VPBLENDVB xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 4C /r /is4</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpblendvb_xmm_xmm_xmmm128_xmm = 3929,
		/// <summary><c>VPBLENDVB ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 4C /r /is4</c><br/>
		/// <br/>
		/// <c>AVX2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpblendvb_ymm_ymm_ymmm256_ymm = 3930,
		/// <summary><c>VRANGEPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 50 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangeps_xmm_k1z_xmm_xmmm128b32_imm8 = 3931,
		/// <summary><c>VRANGEPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 50 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangeps_ymm_k1z_ymm_ymmm256b32_imm8 = 3932,
		/// <summary><c>VRANGEPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 50 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangeps_zmm_k1z_zmm_zmmm512b32_imm8_sae = 3933,
		/// <summary><c>VRANGEPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 50 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangepd_xmm_k1z_xmm_xmmm128b64_imm8 = 3934,
		/// <summary><c>VRANGEPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 50 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangepd_ymm_k1z_ymm_ymmm256b64_imm8 = 3935,
		/// <summary><c>VRANGEPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 50 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangepd_zmm_k1z_zmm_zmmm512b64_imm8_sae = 3936,
		/// <summary><c>VRANGESS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W0 51 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangess_xmm_k1z_xmm_xmmm32_imm8_sae = 3937,
		/// <summary><c>VRANGESD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W1 51 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vrangesd_xmm_k1z_xmm_xmmm64_imm8_sae = 3938,
		/// <summary><c>VFIXUPIMMPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 54 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmps_xmm_k1z_xmm_xmmm128b32_imm8 = 3939,
		/// <summary><c>VFIXUPIMMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 54 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmps_ymm_k1z_ymm_ymmm256b32_imm8 = 3940,
		/// <summary><c>VFIXUPIMMPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 54 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmps_zmm_k1z_zmm_zmmm512b32_imm8_sae = 3941,
		/// <summary><c>VFIXUPIMMPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 54 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmpd_xmm_k1z_xmm_xmmm128b64_imm8 = 3942,
		/// <summary><c>VFIXUPIMMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 54 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmpd_ymm_k1z_ymm_ymmm256b64_imm8 = 3943,
		/// <summary><c>VFIXUPIMMPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 54 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmpd_zmm_k1z_zmm_zmmm512b64_imm8_sae = 3944,
		/// <summary><c>VFIXUPIMMSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W0 55 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmss_xmm_k1z_xmm_xmmm32_imm8_sae = 3945,
		/// <summary><c>VFIXUPIMMSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W1 55 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfixupimmsd_xmm_k1z_xmm_xmmm64_imm8_sae = 3946,
		/// <summary><c>VREDUCEPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 56 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreduceps_xmm_k1z_xmmm128b32_imm8 = 3947,
		/// <summary><c>VREDUCEPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 56 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreduceps_ymm_k1z_ymmm256b32_imm8 = 3948,
		/// <summary><c>VREDUCEPS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 56 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreduceps_zmm_k1z_zmmm512b32_imm8_sae = 3949,
		/// <summary><c>VREDUCEPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 56 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreducepd_xmm_k1z_xmmm128b64_imm8 = 3950,
		/// <summary><c>VREDUCEPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 56 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreducepd_ymm_k1z_ymmm256b64_imm8 = 3951,
		/// <summary><c>VREDUCEPD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 56 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreducepd_zmm_k1z_zmmm512b64_imm8_sae = 3952,
		/// <summary><c>VREDUCESS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W0 57 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreducess_xmm_k1z_xmm_xmmm32_imm8_sae = 3953,
		/// <summary><c>VREDUCESD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W1 57 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vreducesd_xmm_k1z_xmm_xmmm64_imm8_sae = 3954,
		/// <summary><c>VFMADDSUBPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 5C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubps_xmm_xmm_xmmm128_xmm = 3955,
		/// <summary><c>VFMADDSUBPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 5C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubps_ymm_ymm_ymmm256_ymm = 3956,
		/// <summary><c>VFMADDSUBPS xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 5C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubps_xmm_xmm_xmm_xmmm128 = 3957,
		/// <summary><c>VFMADDSUBPS ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 5C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubps_ymm_ymm_ymm_ymmm256 = 3958,
		/// <summary><c>VFMADDSUBPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 5D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubpd_xmm_xmm_xmmm128_xmm = 3959,
		/// <summary><c>VFMADDSUBPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 5D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubpd_ymm_ymm_ymmm256_ymm = 3960,
		/// <summary><c>VFMADDSUBPD xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 5D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubpd_xmm_xmm_xmm_xmmm128 = 3961,
		/// <summary><c>VFMADDSUBPD ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 5D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsubpd_ymm_ymm_ymm_ymmm256 = 3962,
		/// <summary><c>VFMSUBADDPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 5E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddps_xmm_xmm_xmmm128_xmm = 3963,
		/// <summary><c>VFMSUBADDPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 5E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddps_ymm_ymm_ymmm256_ymm = 3964,
		/// <summary><c>VFMSUBADDPS xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 5E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddps_xmm_xmm_xmm_xmmm128 = 3965,
		/// <summary><c>VFMSUBADDPS ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 5E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddps_ymm_ymm_ymm_ymmm256 = 3966,
		/// <summary><c>VFMSUBADDPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 5F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddpd_xmm_xmm_xmmm128_xmm = 3967,
		/// <summary><c>VFMSUBADDPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 5F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddpd_ymm_ymm_ymmm256_ymm = 3968,
		/// <summary><c>VFMSUBADDPD xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 5F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddpd_xmm_xmm_xmm_xmmm128 = 3969,
		/// <summary><c>VFMSUBADDPD ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 5F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubaddpd_ymm_ymm_ymm_ymmm256 = 3970,
		/// <summary><c>PCMPESTRM xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 60 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpestrm_xmm_xmmm128_imm8 = 3971,
		/// <summary><c>PCMPESTRM64 xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 60 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pcmpestrm64_xmm_xmmm128_imm8 = 3972,
		/// <summary><c>VPCMPESTRM xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 60 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpestrm_xmm_xmmm128_imm8 = 3973,
		/// <summary><c>VPCMPESTRM64 xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 60 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpcmpestrm64_xmm_xmmm128_imm8 = 3974,
		/// <summary><c>PCMPESTRI xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 61 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpestri_xmm_xmmm128_imm8 = 3975,
		/// <summary><c>PCMPESTRI64 xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 REX.W 0F 3A 61 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pcmpestri64_xmm_xmmm128_imm8 = 3976,
		/// <summary><c>VPCMPESTRI xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 61 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpestri_xmm_xmmm128_imm8 = 3977,
		/// <summary><c>VPCMPESTRI64 xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 61 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Vpcmpestri64_xmm_xmmm128_imm8 = 3978,
		/// <summary><c>PCMPISTRM xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 62 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpistrm_xmm_xmmm128_imm8 = 3979,
		/// <summary><c>VPCMPISTRM xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 62 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpistrm_xmm_xmmm128_imm8 = 3980,
		/// <summary><c>PCMPISTRI xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A 63 /r ib</c><br/>
		/// <br/>
		/// <c>SSE4.2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pcmpistri_xmm_xmmm128_imm8 = 3981,
		/// <summary><c>VPCMPISTRI xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG 63 /r ib</c><br/>
		/// <br/>
		/// <c>AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vpcmpistri_xmm_xmmm128_imm8 = 3982,
		/// <summary><c>VFPCLASSPS k2 {k1}, xmm2/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 66 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclassps_k_k1_xmmm128b32_imm8 = 3983,
		/// <summary><c>VFPCLASSPS k2 {k1}, ymm2/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 66 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclassps_k_k1_ymmm256b32_imm8 = 3984,
		/// <summary><c>VFPCLASSPS k2 {k1}, zmm2/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 66 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclassps_k_k1_zmmm512b32_imm8 = 3985,
		/// <summary><c>VFPCLASSPD k2 {k1}, xmm2/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 66 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclasspd_k_k1_xmmm128b64_imm8 = 3986,
		/// <summary><c>VFPCLASSPD k2 {k1}, ymm2/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 66 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclasspd_k_k1_ymmm256b64_imm8 = 3987,
		/// <summary><c>VFPCLASSPD k2 {k1}, zmm2/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 66 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclasspd_k_k1_zmmm512b64_imm8 = 3988,
		/// <summary><c>VFPCLASSSS k2 {k1}, xmm2/m32, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W0 67 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclassss_k_k1_xmmm32_imm8 = 3989,
		/// <summary><c>VFPCLASSSD k2 {k1}, xmm2/m64, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.LIG.66.0F3A.W1 67 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512DQ</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vfpclasssd_k_k1_xmmm64_imm8 = 3990,
		/// <summary><c>VFMADDPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 68 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddps_xmm_xmm_xmmm128_xmm = 3991,
		/// <summary><c>VFMADDPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 68 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddps_ymm_ymm_ymmm256_ymm = 3992,
		/// <summary><c>VFMADDPS xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 68 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddps_xmm_xmm_xmm_xmmm128 = 3993,
		/// <summary><c>VFMADDPS ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 68 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddps_ymm_ymm_ymm_ymmm256 = 3994,
		/// <summary><c>VFMADDPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 69 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddpd_xmm_xmm_xmmm128_xmm = 3995,
		/// <summary><c>VFMADDPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 69 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddpd_ymm_ymm_ymmm256_ymm = 3996,
		/// <summary><c>VFMADDPD xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 69 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddpd_xmm_xmm_xmm_xmmm128 = 3997,
		/// <summary><c>VFMADDPD ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 69 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddpd_ymm_ymm_ymm_ymmm256 = 3998,
		/// <summary><c>VFMADDSS xmm1, xmm2, xmm3/m32, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 6A /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddss_xmm_xmm_xmmm32_xmm = 3999,
		/// <summary><c>VFMADDSS xmm1, xmm2, xmm3, xmm4/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 6A /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddss_xmm_xmm_xmm_xmmm32 = 4000,
		/// <summary><c>VFMADDSD xmm1, xmm2, xmm3/m64, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 6B /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsd_xmm_xmm_xmmm64_xmm = 4001,
		/// <summary><c>VFMADDSD xmm1, xmm2, xmm3, xmm4/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 6B /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmaddsd_xmm_xmm_xmm_xmmm64 = 4002,
		/// <summary><c>VFMSUBPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 6C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubps_xmm_xmm_xmmm128_xmm = 4003,
		/// <summary><c>VFMSUBPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 6C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubps_ymm_ymm_ymmm256_ymm = 4004,
		/// <summary><c>VFMSUBPS xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 6C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubps_xmm_xmm_xmm_xmmm128 = 4005,
		/// <summary><c>VFMSUBPS ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 6C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubps_ymm_ymm_ymm_ymmm256 = 4006,
		/// <summary><c>VFMSUBPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 6D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubpd_xmm_xmm_xmmm128_xmm = 4007,
		/// <summary><c>VFMSUBPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 6D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubpd_ymm_ymm_ymmm256_ymm = 4008,
		/// <summary><c>VFMSUBPD xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 6D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubpd_xmm_xmm_xmm_xmmm128 = 4009,
		/// <summary><c>VFMSUBPD ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 6D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubpd_ymm_ymm_ymm_ymmm256 = 4010,
		/// <summary><c>VFMSUBSS xmm1, xmm2, xmm3/m32, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 6E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubss_xmm_xmm_xmmm32_xmm = 4011,
		/// <summary><c>VFMSUBSS xmm1, xmm2, xmm3, xmm4/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 6E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubss_xmm_xmm_xmm_xmmm32 = 4012,
		/// <summary><c>VFMSUBSD xmm1, xmm2, xmm3/m64, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 6F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubsd_xmm_xmm_xmmm64_xmm = 4013,
		/// <summary><c>VFMSUBSD xmm1, xmm2, xmm3, xmm4/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 6F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfmsubsd_xmm_xmm_xmm_xmmm64 = 4014,
		/// <summary><c>VPSHLDW xmm1 {k1}{z}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldw_xmm_k1z_xmm_xmmm128_imm8 = 4015,
		/// <summary><c>VPSHLDW ymm1 {k1}{z}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldw_ymm_k1z_ymm_ymmm256_imm8 = 4016,
		/// <summary><c>VPSHLDW zmm1 {k1}{z}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 70 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldw_zmm_k1z_zmm_zmmm512_imm8 = 4017,
		/// <summary><c>VPSHLDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 71 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8 = 4018,
		/// <summary><c>VPSHLDD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 71 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8 = 4019,
		/// <summary><c>VPSHLDD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 71 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8 = 4020,
		/// <summary><c>VPSHLDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 71 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8 = 4021,
		/// <summary><c>VPSHLDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 71 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8 = 4022,
		/// <summary><c>VPSHLDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 71 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8 = 4023,
		/// <summary><c>VPSHRDW xmm1 {k1}{z}, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 72 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdw_xmm_k1z_xmm_xmmm128_imm8 = 4024,
		/// <summary><c>VPSHRDW ymm1 {k1}{z}, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 72 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdw_ymm_k1z_ymm_ymmm256_imm8 = 4025,
		/// <summary><c>VPSHRDW zmm1 {k1}{z}, zmm2, zmm3/m512, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 72 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdw_zmm_k1z_zmm_zmmm512_imm8 = 4026,
		/// <summary><c>VPSHRDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W0 73 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8 = 4027,
		/// <summary><c>VPSHRDD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W0 73 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8 = 4028,
		/// <summary><c>VPSHRDD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W0 73 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8 = 4029,
		/// <summary><c>VPSHRDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 73 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8 = 4030,
		/// <summary><c>VPSHRDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 73 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8 = 4031,
		/// <summary><c>VPSHRDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 73 /r ib</c><br/>
		/// <br/>
		/// <c>AVX512_VBMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8 = 4032,
		/// <summary><c>VFNMADDPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 78 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddps_xmm_xmm_xmmm128_xmm = 4033,
		/// <summary><c>VFNMADDPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 78 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddps_ymm_ymm_ymmm256_ymm = 4034,
		/// <summary><c>VFNMADDPS xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 78 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddps_xmm_xmm_xmm_xmmm128 = 4035,
		/// <summary><c>VFNMADDPS ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 78 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddps_ymm_ymm_ymm_ymmm256 = 4036,
		/// <summary><c>VFNMADDPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 79 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddpd_xmm_xmm_xmmm128_xmm = 4037,
		/// <summary><c>VFNMADDPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 79 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddpd_ymm_ymm_ymmm256_ymm = 4038,
		/// <summary><c>VFNMADDPD xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 79 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddpd_xmm_xmm_xmm_xmmm128 = 4039,
		/// <summary><c>VFNMADDPD ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 79 /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddpd_ymm_ymm_ymm_ymmm256 = 4040,
		/// <summary><c>VFNMADDSS xmm1, xmm2, xmm3/m32, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 7A /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddss_xmm_xmm_xmmm32_xmm = 4041,
		/// <summary><c>VFNMADDSS xmm1, xmm2, xmm3, xmm4/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 7A /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddss_xmm_xmm_xmm_xmmm32 = 4042,
		/// <summary><c>VFNMADDSD xmm1, xmm2, xmm3/m64, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 7B /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddsd_xmm_xmm_xmmm64_xmm = 4043,
		/// <summary><c>VFNMADDSD xmm1, xmm2, xmm3, xmm4/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 7B /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmaddsd_xmm_xmm_xmm_xmmm64 = 4044,
		/// <summary><c>VFNMSUBPS xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 7C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubps_xmm_xmm_xmmm128_xmm = 4045,
		/// <summary><c>VFNMSUBPS ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 7C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubps_ymm_ymm_ymmm256_ymm = 4046,
		/// <summary><c>VFNMSUBPS xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 7C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubps_xmm_xmm_xmm_xmmm128 = 4047,
		/// <summary><c>VFNMSUBPS ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 7C /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubps_ymm_ymm_ymm_ymmm256 = 4048,
		/// <summary><c>VFNMSUBPD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W0 7D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubpd_xmm_xmm_xmmm128_xmm = 4049,
		/// <summary><c>VFNMSUBPD ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W0 7D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubpd_ymm_ymm_ymmm256_ymm = 4050,
		/// <summary><c>VFNMSUBPD xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 7D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubpd_xmm_xmm_xmm_xmmm128 = 4051,
		/// <summary><c>VFNMSUBPD ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 7D /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubpd_ymm_ymm_ymm_ymmm256 = 4052,
		/// <summary><c>VFNMSUBSS xmm1, xmm2, xmm3/m32, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 7E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubss_xmm_xmm_xmmm32_xmm = 4053,
		/// <summary><c>VFNMSUBSS xmm1, xmm2, xmm3, xmm4/m32</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 7E /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubss_xmm_xmm_xmm_xmmm32 = 4054,
		/// <summary><c>VFNMSUBSD xmm1, xmm2, xmm3/m64, xmm4</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W0 7F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubsd_xmm_xmm_xmmm64_xmm = 4055,
		/// <summary><c>VFNMSUBSD xmm1, xmm2, xmm3, xmm4/m64</c><br/>
		/// <br/>
		/// <c>VEX.LIG.66.0F3A.W1 7F /r /is4</c><br/>
		/// <br/>
		/// <c>FMA4</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vfnmsubsd_xmm_xmm_xmm_xmmm64 = 4056,
		/// <summary><c>SHA1RNDS4 xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>NP 0F 3A CC /r ib</c><br/>
		/// <br/>
		/// <c>SHA</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Sha1rnds4_xmm_xmmm128_imm8 = 4057,
		/// <summary><c>GF2P8AFFINEQB xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A CE /r ib</c><br/>
		/// <br/>
		/// <c>GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Gf2p8affineqb_xmm_xmmm128_imm8 = 4058,
		/// <summary><c>VGF2P8AFFINEQB xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 CE /r ib</c><br/>
		/// <br/>
		/// <c>AVX and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgf2p8affineqb_xmm_xmm_xmmm128_imm8 = 4059,
		/// <summary><c>VGF2P8AFFINEQB ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 CE /r ib</c><br/>
		/// <br/>
		/// <c>AVX and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgf2p8affineqb_ymm_ymm_ymmm256_imm8 = 4060,
		/// <summary><c>VGF2P8AFFINEQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 CE /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8 = 4061,
		/// <summary><c>VGF2P8AFFINEQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 CE /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8 = 4062,
		/// <summary><c>VGF2P8AFFINEQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 CE /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8 = 4063,
		/// <summary><c>GF2P8AFFINEINVQB xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A CF /r ib</c><br/>
		/// <br/>
		/// <c>GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Gf2p8affineinvqb_xmm_xmmm128_imm8 = 4064,
		/// <summary><c>VGF2P8AFFINEINVQB xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.W1 CF /r ib</c><br/>
		/// <br/>
		/// <c>AVX and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgf2p8affineinvqb_xmm_xmm_xmmm128_imm8 = 4065,
		/// <summary><c>VGF2P8AFFINEINVQB ymm1, ymm2, ymm3/m256, imm8</c><br/>
		/// <br/>
		/// <c>VEX.256.66.0F3A.W1 CF /r ib</c><br/>
		/// <br/>
		/// <c>AVX and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vgf2p8affineinvqb_ymm_ymm_ymmm256_imm8 = 4066,
		/// <summary><c>VGF2P8AFFINEINVQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.128.66.0F3A.W1 CF /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8 = 4067,
		/// <summary><c>VGF2P8AFFINEINVQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.256.66.0F3A.W1 CF /r ib</c><br/>
		/// <br/>
		/// <c>AVX512VL and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8 = 4068,
		/// <summary><c>VGF2P8AFFINEINVQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8</c><br/>
		/// <br/>
		/// <c>EVEX.512.66.0F3A.W1 CF /r ib</c><br/>
		/// <br/>
		/// <c>AVX512F and GFNI</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8 = 4069,
		/// <summary><c>AESKEYGENASSIST xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>66 0F 3A DF /r ib</c><br/>
		/// <br/>
		/// <c>AES</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Aeskeygenassist_xmm_xmmm128_imm8 = 4070,
		/// <summary><c>VAESKEYGENASSIST xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>VEX.128.66.0F3A.WIG DF /r ib</c><br/>
		/// <br/>
		/// <c>AES and AVX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Vaeskeygenassist_xmm_xmmm128_imm8 = 4071,
		/// <summary><c>RORX r32, r/m32, imm8</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F3A.W0 F0 /r ib</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		VEX_Rorx_r32_rm32_imm8 = 4072,
		/// <summary><c>RORX r64, r/m64, imm8</c><br/>
		/// <br/>
		/// <c>VEX.LZ.F2.0F3A.W1 F0 /r ib</c><br/>
		/// <br/>
		/// <c>BMI2</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		VEX_Rorx_r64_rm64_imm8 = 4073,
		/// <summary><c>VPMACSSWW xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 85 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacssww_xmm_xmm_xmmm128_xmm = 4074,
		/// <summary><c>VPMACSSWD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 86 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacsswd_xmm_xmm_xmmm128_xmm = 4075,
		/// <summary><c>VPMACSSDQL xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 87 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacssdql_xmm_xmm_xmmm128_xmm = 4076,
		/// <summary><c>VPMACSSDD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 8E /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacssdd_xmm_xmm_xmmm128_xmm = 4077,
		/// <summary><c>VPMACSSDQH xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 8F /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacssdqh_xmm_xmm_xmmm128_xmm = 4078,
		/// <summary><c>VPMACSWW xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 95 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacsww_xmm_xmm_xmmm128_xmm = 4079,
		/// <summary><c>VPMACSWD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 96 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacswd_xmm_xmm_xmmm128_xmm = 4080,
		/// <summary><c>VPMACSDQL xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 97 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacsdql_xmm_xmm_xmmm128_xmm = 4081,
		/// <summary><c>VPMACSDD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 9E /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacsdd_xmm_xmm_xmmm128_xmm = 4082,
		/// <summary><c>VPMACSDQH xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 9F /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmacsdqh_xmm_xmm_xmmm128_xmm = 4083,
		/// <summary><c>VPCMOV xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 A2 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcmov_xmm_xmm_xmmm128_xmm = 4084,
		/// <summary><c>VPCMOV ymm1, ymm2, ymm3/m256, ymm4</c><br/>
		/// <br/>
		/// <c>XOP.256.X8.W0 A2 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcmov_ymm_ymm_ymmm256_ymm = 4085,
		/// <summary><c>VPCMOV xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W1 A2 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcmov_xmm_xmm_xmm_xmmm128 = 4086,
		/// <summary><c>VPCMOV ymm1, ymm2, ymm3, ymm4/m256</c><br/>
		/// <br/>
		/// <c>XOP.256.X8.W1 A2 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcmov_ymm_ymm_ymm_ymmm256 = 4087,
		/// <summary><c>VPPERM xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 A3 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpperm_xmm_xmm_xmmm128_xmm = 4088,
		/// <summary><c>VPPERM xmm1, xmm2, xmm3, xmm4/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W1 A3 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpperm_xmm_xmm_xmm_xmmm128 = 4089,
		/// <summary><c>VPMADCSSWD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 A6 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmadcsswd_xmm_xmm_xmmm128_xmm = 4090,
		/// <summary><c>VPMADCSWD xmm1, xmm2, xmm3/m128, xmm4</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 B6 /r /is4</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpmadcswd_xmm_xmm_xmmm128_xmm = 4091,
		/// <summary><c>VPROTB xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 C0 /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotb_xmm_xmmm128_imm8 = 4092,
		/// <summary><c>VPROTW xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 C1 /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotw_xmm_xmmm128_imm8 = 4093,
		/// <summary><c>VPROTD xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 C2 /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotd_xmm_xmmm128_imm8 = 4094,
		/// <summary><c>VPROTQ xmm1, xmm2/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 C3 /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotq_xmm_xmmm128_imm8 = 4095,
		/// <summary><c>VPCOMB xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 CC /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomb_xmm_xmm_xmmm128_imm8 = 4096,
		/// <summary><c>VPCOMW xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 CD /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomw_xmm_xmm_xmmm128_imm8 = 4097,
		/// <summary><c>VPCOMD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 CE /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomd_xmm_xmm_xmmm128_imm8 = 4098,
		/// <summary><c>VPCOMQ xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 CF /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomq_xmm_xmm_xmmm128_imm8 = 4099,
		/// <summary><c>VPCOMUB xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 EC /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomub_xmm_xmm_xmmm128_imm8 = 4100,
		/// <summary><c>VPCOMUW xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 ED /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomuw_xmm_xmm_xmmm128_imm8 = 4101,
		/// <summary><c>VPCOMUD xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 EE /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomud_xmm_xmm_xmmm128_imm8 = 4102,
		/// <summary><c>VPCOMUQ xmm1, xmm2, xmm3/m128, imm8</c><br/>
		/// <br/>
		/// <c>XOP.128.X8.W0 EF /r ib</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpcomuq_xmm_xmm_xmmm128_imm8 = 4103,
		/// <summary><c>BLCFILL r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /1</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blcfill_r32_rm32 = 4104,
		/// <summary><c>BLCFILL r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /1</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blcfill_r64_rm64 = 4105,
		/// <summary><c>BLSFILL r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /2</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blsfill_r32_rm32 = 4106,
		/// <summary><c>BLSFILL r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /2</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blsfill_r64_rm64 = 4107,
		/// <summary><c>BLCS r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /3</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blcs_r32_rm32 = 4108,
		/// <summary><c>BLCS r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /3</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blcs_r64_rm64 = 4109,
		/// <summary><c>TZMSK r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /4</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Tzmsk_r32_rm32 = 4110,
		/// <summary><c>TZMSK r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /4</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Tzmsk_r64_rm64 = 4111,
		/// <summary><c>BLCIC r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /5</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blcic_r32_rm32 = 4112,
		/// <summary><c>BLCIC r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /5</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blcic_r64_rm64 = 4113,
		/// <summary><c>BLSIC r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /6</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blsic_r32_rm32 = 4114,
		/// <summary><c>BLSIC r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /6</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blsic_r64_rm64 = 4115,
		/// <summary><c>T1MSKC r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 01 /7</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_T1mskc_r32_rm32 = 4116,
		/// <summary><c>T1MSKC r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 01 /7</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_T1mskc_r64_rm64 = 4117,
		/// <summary><c>BLCMSK r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 02 /1</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blcmsk_r32_rm32 = 4118,
		/// <summary><c>BLCMSK r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 02 /1</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blcmsk_r64_rm64 = 4119,
		/// <summary><c>BLCI r32, r/m32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 02 /6</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Blci_r32_rm32 = 4120,
		/// <summary><c>BLCI r64, r/m64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 02 /6</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Blci_r64_rm64 = 4121,
		/// <summary><c>LLWPCB r32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 12 /0</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Llwpcb_r32 = 4122,
		/// <summary><c>LLWPCB r64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 12 /0</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Llwpcb_r64 = 4123,
		/// <summary><c>SLWPCB r32</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W0 12 /1</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Slwpcb_r32 = 4124,
		/// <summary><c>SLWPCB r64</c><br/>
		/// <br/>
		/// <c>XOP.L0.X9.W1 12 /1</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Slwpcb_r64 = 4125,
		/// <summary><c>VFRCZPS xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 80 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vfrczps_xmm_xmmm128 = 4126,
		/// <summary><c>VFRCZPS ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>XOP.256.X9.W0 80 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vfrczps_ymm_ymmm256 = 4127,
		/// <summary><c>VFRCZPD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 81 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vfrczpd_xmm_xmmm128 = 4128,
		/// <summary><c>VFRCZPD ymm1, ymm2/m256</c><br/>
		/// <br/>
		/// <c>XOP.256.X9.W0 81 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vfrczpd_ymm_ymmm256 = 4129,
		/// <summary><c>VFRCZSS xmm1, xmm2/m32</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 82 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vfrczss_xmm_xmmm32 = 4130,
		/// <summary><c>VFRCZSD xmm1, xmm2/m64</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 83 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vfrczsd_xmm_xmmm64 = 4131,
		/// <summary><c>VPROTB xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 90 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotb_xmm_xmmm128_xmm = 4132,
		/// <summary><c>VPROTB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 90 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotb_xmm_xmm_xmmm128 = 4133,
		/// <summary><c>VPROTW xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 91 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotw_xmm_xmmm128_xmm = 4134,
		/// <summary><c>VPROTW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 91 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotw_xmm_xmm_xmmm128 = 4135,
		/// <summary><c>VPROTD xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 92 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotd_xmm_xmmm128_xmm = 4136,
		/// <summary><c>VPROTD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 92 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotd_xmm_xmm_xmmm128 = 4137,
		/// <summary><c>VPROTQ xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 93 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotq_xmm_xmmm128_xmm = 4138,
		/// <summary><c>VPROTQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 93 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vprotq_xmm_xmm_xmmm128 = 4139,
		/// <summary><c>VPSHLB xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 94 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshlb_xmm_xmmm128_xmm = 4140,
		/// <summary><c>VPSHLB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 94 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshlb_xmm_xmm_xmmm128 = 4141,
		/// <summary><c>VPSHLW xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 95 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshlw_xmm_xmmm128_xmm = 4142,
		/// <summary><c>VPSHLW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 95 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshlw_xmm_xmm_xmmm128 = 4143,
		/// <summary><c>VPSHLD xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 96 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshld_xmm_xmmm128_xmm = 4144,
		/// <summary><c>VPSHLD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 96 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshld_xmm_xmm_xmmm128 = 4145,
		/// <summary><c>VPSHLQ xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 97 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshlq_xmm_xmmm128_xmm = 4146,
		/// <summary><c>VPSHLQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 97 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshlq_xmm_xmm_xmmm128 = 4147,
		/// <summary><c>VPSHAB xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 98 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshab_xmm_xmmm128_xmm = 4148,
		/// <summary><c>VPSHAB xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 98 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshab_xmm_xmm_xmmm128 = 4149,
		/// <summary><c>VPSHAW xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 99 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshaw_xmm_xmmm128_xmm = 4150,
		/// <summary><c>VPSHAW xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 99 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshaw_xmm_xmm_xmmm128 = 4151,
		/// <summary><c>VPSHAD xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 9A /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshad_xmm_xmmm128_xmm = 4152,
		/// <summary><c>VPSHAD xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 9A /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshad_xmm_xmm_xmmm128 = 4153,
		/// <summary><c>VPSHAQ xmm1, xmm2/m128, xmm3</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 9B /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshaq_xmm_xmmm128_xmm = 4154,
		/// <summary><c>VPSHAQ xmm1, xmm2, xmm3/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W1 9B /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vpshaq_xmm_xmm_xmmm128 = 4155,
		/// <summary><c>VPHADDBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 C1 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddbw_xmm_xmmm128 = 4156,
		/// <summary><c>VPHADDBD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 C2 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddbd_xmm_xmmm128 = 4157,
		/// <summary><c>VPHADDBQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 C3 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddbq_xmm_xmmm128 = 4158,
		/// <summary><c>VPHADDWD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 C6 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddwd_xmm_xmmm128 = 4159,
		/// <summary><c>VPHADDWQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 C7 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddwq_xmm_xmmm128 = 4160,
		/// <summary><c>VPHADDDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 CB /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphadddq_xmm_xmmm128 = 4161,
		/// <summary><c>VPHADDUBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 D1 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddubw_xmm_xmmm128 = 4162,
		/// <summary><c>VPHADDUBD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 D2 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddubd_xmm_xmmm128 = 4163,
		/// <summary><c>VPHADDUBQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 D3 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddubq_xmm_xmmm128 = 4164,
		/// <summary><c>VPHADDUWD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 D6 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphadduwd_xmm_xmmm128 = 4165,
		/// <summary><c>VPHADDUWQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 D7 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphadduwq_xmm_xmmm128 = 4166,
		/// <summary><c>VPHADDUDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 DB /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphaddudq_xmm_xmmm128 = 4167,
		/// <summary><c>VPHSUBBW xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 E1 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphsubbw_xmm_xmmm128 = 4168,
		/// <summary><c>VPHSUBWD xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 E2 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphsubwd_xmm_xmmm128 = 4169,
		/// <summary><c>VPHSUBDQ xmm1, xmm2/m128</c><br/>
		/// <br/>
		/// <c>XOP.128.X9.W0 E3 /r</c><br/>
		/// <br/>
		/// <c>XOP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Vphsubdq_xmm_xmmm128 = 4170,
		/// <summary><c>BEXTR r32, r/m32, imm32</c><br/>
		/// <br/>
		/// <c>XOP.L0.XA.W0 10 /r id</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Bextr_r32_rm32_imm32 = 4171,
		/// <summary><c>BEXTR r64, r/m64, imm32</c><br/>
		/// <br/>
		/// <c>XOP.L0.XA.W1 10 /r id</c><br/>
		/// <br/>
		/// <c>TBM</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Bextr_r64_rm64_imm32 = 4172,
		/// <summary><c>LWPINS r32, r/m32, imm32</c><br/>
		/// <br/>
		/// <c>XOP.L0.XA.W0 12 /0 id</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Lwpins_r32_rm32_imm32 = 4173,
		/// <summary><c>LWPINS r64, r/m32, imm32</c><br/>
		/// <br/>
		/// <c>XOP.L0.XA.W1 12 /0 id</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Lwpins_r64_rm32_imm32 = 4174,
		/// <summary><c>LWPVAL r32, r/m32, imm32</c><br/>
		/// <br/>
		/// <c>XOP.L0.XA.W0 12 /1 id</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		XOP_Lwpval_r32_rm32_imm32 = 4175,
		/// <summary><c>LWPVAL r64, r/m32, imm32</c><br/>
		/// <br/>
		/// <c>XOP.L0.XA.W1 12 /1 id</c><br/>
		/// <br/>
		/// <c>LWP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		XOP_Lwpval_r64_rm32_imm32 = 4176,
		/// <summary><c>PI2FW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 0C</c><br/>
		/// <br/>
		/// <c>3DNOWEXT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pi2fw_mm_mmm64 = 4177,
		/// <summary><c>PI2FD mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 0D</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pi2fd_mm_mmm64 = 4178,
		/// <summary><c>PF2IW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 1C</c><br/>
		/// <br/>
		/// <c>3DNOWEXT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pf2iw_mm_mmm64 = 4179,
		/// <summary><c>PF2ID mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 1D</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pf2id_mm_mmm64 = 4180,
		/// <summary><c>PFRCPV mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 86</c><br/>
		/// <br/>
		/// <c>AMD Geode LX/GX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrcpv_mm_mmm64 = 4181,
		/// <summary><c>PFRSQRTV mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 87</c><br/>
		/// <br/>
		/// <c>AMD Geode LX/GX</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrsqrtv_mm_mmm64 = 4182,
		/// <summary><c>PFNACC mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 8A</c><br/>
		/// <br/>
		/// <c>3DNOWEXT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfnacc_mm_mmm64 = 4183,
		/// <summary><c>PFPNACC mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 8E</c><br/>
		/// <br/>
		/// <c>3DNOWEXT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfpnacc_mm_mmm64 = 4184,
		/// <summary><c>PFCMPGE mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 90</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfcmpge_mm_mmm64 = 4185,
		/// <summary><c>PFMIN mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 94</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfmin_mm_mmm64 = 4186,
		/// <summary><c>PFRCP mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 96</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrcp_mm_mmm64 = 4187,
		/// <summary><c>PFRSQRT mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 97</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrsqrt_mm_mmm64 = 4188,
		/// <summary><c>PFSUB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 9A</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfsub_mm_mmm64 = 4189,
		/// <summary><c>PFADD mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r 9E</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfadd_mm_mmm64 = 4190,
		/// <summary><c>PFCMPGT mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r A0</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfcmpgt_mm_mmm64 = 4191,
		/// <summary><c>PFMAX mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r A4</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfmax_mm_mmm64 = 4192,
		/// <summary><c>PFRCPIT1 mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r A6</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrcpit1_mm_mmm64 = 4193,
		/// <summary><c>PFRSQIT1 mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r A7</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrsqit1_mm_mmm64 = 4194,
		/// <summary><c>PFSUBR mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r AA</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfsubr_mm_mmm64 = 4195,
		/// <summary><c>PFACC mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r AE</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfacc_mm_mmm64 = 4196,
		/// <summary><c>PFCMPEQ mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r B0</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfcmpeq_mm_mmm64 = 4197,
		/// <summary><c>PFMUL mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r B4</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfmul_mm_mmm64 = 4198,
		/// <summary><c>PFRCPIT2 mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r B6</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pfrcpit2_mm_mmm64 = 4199,
		/// <summary><c>PMULHRW mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r B7</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pmulhrw_mm_mmm64 = 4200,
		/// <summary><c>PSWAPD mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r BB</c><br/>
		/// <br/>
		/// <c>3DNOWEXT</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pswapd_mm_mmm64 = 4201,
		/// <summary><c>PAVGUSB mm1, mm2/m64</c><br/>
		/// <br/>
		/// <c>0F 0F /r BF</c><br/>
		/// <br/>
		/// <c>3DNOW</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		D3NOW_Pavgusb_mm_mmm64 = 4202,
		/// <summary><c>RMPADJUST</c><br/>
		/// <br/>
		/// <c>F3 0F 01 FE</c><br/>
		/// <br/>
		/// <c>SNP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rmpadjust = 4203,
		/// <summary><c>RMPUPDATE</c><br/>
		/// <br/>
		/// <c>F2 0F 01 FE</c><br/>
		/// <br/>
		/// <c>SNP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Rmpupdate = 4204,
		/// <summary><c>PSMASH</c><br/>
		/// <br/>
		/// <c>F3 0F 01 FF</c><br/>
		/// <br/>
		/// <c>SNP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Psmash = 4205,
		/// <summary><c>PVALIDATE</c><br/>
		/// <br/>
		/// <c>a16 F2 0F 01 FF</c><br/>
		/// <br/>
		/// <c>SNP</c><br/>
		/// <br/>
		/// <c>16/32-bit</c></summary>
		Pvalidatew = 4206,
		/// <summary><c>PVALIDATE</c><br/>
		/// <br/>
		/// <c>a32 F2 0F 01 FF</c><br/>
		/// <br/>
		/// <c>SNP</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Pvalidated = 4207,
		/// <summary><c>PVALIDATE</c><br/>
		/// <br/>
		/// <c>F2 0F 01 FF</c><br/>
		/// <br/>
		/// <c>SNP</c><br/>
		/// <br/>
		/// <c>64-bit</c></summary>
		Pvalidateq = 4208,
		/// <summary><c>SERIALIZE</c><br/>
		/// <br/>
		/// <c>NP 0F 01 E8</c><br/>
		/// <br/>
		/// <c>SERIALIZE</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Serialize = 4209,
		/// <summary><c>XSUSLDTRK</c><br/>
		/// <br/>
		/// <c>F2 0F 01 E8</c><br/>
		/// <br/>
		/// <c>TSXLDTRK</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xsusldtrk = 4210,
		/// <summary><c>XRESLDTRK</c><br/>
		/// <br/>
		/// <c>F2 0F 01 E9</c><br/>
		/// <br/>
		/// <c>TSXLDTRK</c><br/>
		/// <br/>
		/// <c>16/32/64-bit</c></summary>
		Xresldtrk = 4211,
	}
}