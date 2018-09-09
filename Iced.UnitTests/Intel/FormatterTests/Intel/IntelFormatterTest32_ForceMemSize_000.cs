﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_INTEL_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Intel {
	public sealed class IntelFormatterTest32_ForceMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, IntelFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos32_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos32_000.AllInfos_Length] {
			"data16 push es",
			"push es",
			"data16 pop es",
			"pop es",
			"data16 push cs",
			"push cs",
			"data16 push ss",
			"push ss",
			"data16 pop ss",
			"pop ss",
			"data16 push ds",
			"push ds",
			"data16 pop ds",
			"pop ds",
			"daa",
			"das",
			"aaa",
			"aas",
			"inc ax",
			"inc eax",
			"inc cx",
			"inc ecx",
			"inc dx",
			"inc edx",
			"inc bx",
			"inc ebx",
			"inc sp",
			"inc esp",
			"inc bp",
			"inc ebp",
			"inc si",
			"inc esi",
			"inc di",
			"inc edi",
			"dec ax",
			"dec eax",
			"dec cx",
			"dec ecx",
			"dec dx",
			"dec edx",
			"dec bx",
			"dec ebx",
			"dec sp",
			"dec esp",
			"dec bp",
			"dec ebp",
			"dec si",
			"dec esi",
			"dec di",
			"dec edi",
			"push eax",
			"push ecx",
			"push edx",
			"push ebx",
			"push esp",
			"push ebp",
			"push esi",
			"push edi",
			"pop eax",
			"pop ecx",
			"pop edx",
			"pop ebx",
			"pop esp",
			"pop ebp",
			"pop esi",
			"pop edi",
			"pusha",
			"pushad",
			"popa",
			"popad",
			"bound bx, dword ptr [eax]",
			"bound ebx, qword ptr [eax]",
			"arpl dx, si",
			"arpl word ptr [eax], bx",
			"push 0x3412a55a",
			"push -0x5b",
			"data16 jo short 0x004d",
			"jo short 0x8000004c",
			"data16 jno short 0x004d",
			"jno short 0x8000004c",
			"data16 jb short 0x004d",
			"jb short 0x8000004c",
			"data16 jae short 0x004d",
			"jae short 0x8000004c",
			"data16 je short 0x004d",
			"je short 0x8000004c",
			"data16 jne short 0x004d",
			"jne short 0x8000004c",
			"data16 jbe short 0x004d",
			"jbe short 0x8000004c",
			"data16 ja short 0x004d",
			"ja short 0x8000004c",
			"data16 js short 0x004d",
			"js short 0x8000004c",
			"data16 jns short 0x004d",
			"jns short 0x8000004c",
			"data16 jp short 0x004d",
			"jp short 0x8000004c",
			"data16 jnp short 0x004d",
			"jnp short 0x8000004c",
			"data16 jl short 0x004d",
			"jl short 0x8000004c",
			"data16 jge short 0x004d",
			"jge short 0x8000004c",
			"data16 jle short 0x004d",
			"jle short 0x8000004c",
			"data16 jg short 0x004d",
			"jg short 0x8000004c",
			"pop esi",
			"pop dword ptr [eax]",
			"data16 call far 0x3412, 0x7856",
			"call far 0x78563412, 0xbc9a",
			"pushfd",
			"popfd",
			"data16 ret -0x5aa6",
			"ret -0x5aa6",
			"data16 ret",
			"ret",
			"les bx, dword ptr [eax]",
			"les ebx, fword ptr [eax]",
			"lds bx, dword ptr [eax]",
			"lds ebx, fword ptr [eax]",
			"enter -0x5aa6, -0x5a",
			"leave",
			"into",
			"aam 0xa",
			"aad 0xa",
			"data16 addr16 loopne 0x004e",
			"addr16 loopne 0x8000004d",
			"data16 loopne 0x004d",
			"loopne 0x8000004c",
			"data16 addr16 loope 0x004e",
			"addr16 loope 0x8000004d",
			"data16 loope 0x004d",
			"loope 0x8000004c",
			"data16 addr16 loop 0x004e",
			"addr16 loop 0x8000004d",
			"data16 loop 0x004d",
			"loop 0x8000004c",
			"data16 jcxz 0x004e",
			"jcxz 0x8000004d",
			"data16 jecxz 0x004d",
			"jecxz 0x8000004c",
			"data16 call 0xa54e",
			"call 0x255a3407",
			"data16 jmp 0xa54e",
			"jmp 0x255a3407",
			"data16 jmp far 0x3412, 0x7856",
			"jmp far 0x78563412, 0xbcea",
			"data16 jmp short 0x004d",
			"jmp short 0x8000004c",
			"call cx",
			"call word ptr [eax]",
			"call ecx",
			"call dword ptr [eax]",
			"jmp dx",
			"jmp word ptr [eax]",
			"jmp edx",
			"jmp dword ptr [eax]",
			"push esi",
			"push dword ptr [eax]",
			"bndmov bnd1, bnd2",
			"bndmov bnd1, qword ptr [eax]",
			"bndcl bnd1, edx",
			"bndcl bnd1, dword ptr [eax]",
			"bndcu bnd1, edx",
			"bndcu bnd1, dword ptr [eax]",
			"bndmov bnd2, bnd1",
			"bndmov qword ptr [eax], bnd1",
			"bndmk bnd1, dword ptr [eax]",
			"bndcn bnd1, edx",
			"bndcn bnd1, dword ptr [eax]",
			"mov esi, cr3",
			"mov esi, dr3",
			"mov cr3, esi",
			"mov dr3, esi",
			"vmread esi, ecx",
			"vmread dword ptr [eax], ebx",
			"vmwrite ecx, esi",
			"vmwrite ebx, dword ptr [eax]",
			"data16 jo 0xa54f",
			"jo 0xb412a550",
			"data16 jno 0xa54f",
			"jno 0xb412a550",
			"data16 jb 0xa54f",
			"jb 0xb412a550",
			"data16 jae 0xa54f",
			"jae 0xb412a550",
			"data16 je 0xa54f",
			"je 0xb412a550",
			"data16 jne 0xa54f",
			"jne 0xb412a550",
			"data16 jbe 0xa54f",
			"jbe 0xb412a550",
			"data16 ja 0xa54f",
			"ja 0xb412a550",
			"data16 js 0xa54f",
			"js 0xb412a550",
			"data16 jns 0xa54f",
			"jns 0xb412a550",
			"data16 jp 0xa54f",
			"jp 0xb412a550",
			"data16 jnp 0xa54f",
			"jnp 0xb412a550",
			"data16 jl 0xa54f",
			"jl 0xb412a550",
			"data16 jge 0xa54f",
			"jge 0xb412a550",
			"data16 jle 0xa54f",
			"jle 0xb412a550",
			"data16 jg 0xa54f",
			"jg 0xb412a550",
			"push fs",
			"pop fs",
			"push gs",
			"pop gs",
			"rdpid edx",
			"invept edx, xmmword ptr [eax]",
			"invvpid edx, xmmword ptr [eax]",
			"invpcid edx, xmmword ptr [eax]",
			"salc",
			"data16 push -0x5aa6",
			"data16 push -0x5b",
			"insb byte ptr [di], dx",
			"insb byte ptr [edi], dx",
			"insw word ptr [di], dx",
			"insw word ptr [edi], dx",
			"insd dword ptr [di], dx",
			"insd dword ptr [edi], dx",
			"outsb dx, byte ptr [si]",
			"outsb dx, byte ptr [esi]",
			"outsw dx, word ptr [si]",
			"outsw dx, word ptr [esi]",
			"outsd dx, dword ptr [si]",
			"outsd dx, dword ptr [esi]",
			"mov fs, si",
			"data16 mov ds, word ptr [eax]",
			"mov fs, esi",
			"mov ds, word ptr [eax]",
			"pop si",
			"pop word ptr [eax]",
			"xchg ax, ax",
			"nop",
			"pushf",
			"popf",
			"mov al, byte ptr [0xf0debc9a]",
			"addr16 mov al, byte ptr [0xf0de]",
			"mov ax, word ptr [0xf0debc9a]",
			"addr16 mov ax, word ptr [0xf0de]",
			"mov eax, dword ptr [0xf0debc9a]",
			"addr16 mov eax, dword ptr [0xf0de]",
			"mov byte ptr [0xf0debc9a], al",
			"addr16 mov byte ptr [0xf0de], al",
			"mov word ptr [0xf0debc9a], ax",
			"addr16 mov word ptr [0xf0de], ax",
			"mov dword ptr [0xf0debc9a], eax",
			"addr16 mov dword ptr [0xf0de], eax",
			"movsb byte ptr [di], byte ptr [si]",
			"movsb byte ptr [edi], byte ptr [esi]",
			"movsw word ptr [di], word ptr [si]",
			"movsw word ptr [edi], word ptr [esi]",
			"movsd dword ptr [di], dword ptr [si]",
			"movsd dword ptr [edi], dword ptr [esi]",
			"cmpsb byte ptr [si], byte ptr [di]",
			"cmpsb byte ptr [esi], byte ptr [edi]",
			"cmpsw word ptr [si], word ptr [di]",
			"cmpsw word ptr [esi], word ptr [edi]",
			"cmpsd dword ptr [si], dword ptr [di]",
			"cmpsd dword ptr [esi], dword ptr [edi]",
			"stosb byte ptr [di]",
			"stosb byte ptr [edi]",
			"stosw word ptr [di]",
			"stosw word ptr [edi]",
			"stosd dword ptr [di]",
			"stosd dword ptr [edi]",
			"lodsb byte ptr [si]",
			"lodsb byte ptr [esi]",
			"lodsw word ptr [si]",
			"lodsw word ptr [esi]",
			"lodsd dword ptr [si]",
			"lodsd dword ptr [esi]",
			"scasb byte ptr [di]",
			"scasb byte ptr [edi]",
			"scasw word ptr [di]",
			"scasw word ptr [edi]",
			"scasd dword ptr [di]",
			"scasd dword ptr [edi]",
			"data16 xbegin 0x7fffa54f",
			"xbegin 0xb412a550",
			"data16 enter -0x5aa6, -0x5a",
			"data16 leave",
			"data16 ret far -0x5aa6",
			"ret far -0x5aa6",
			"data16 ret far",
			"ret far",
			"iret",
			"iretd",
			"rol cl, cl",
			"rol byte ptr [eax], cl",
			"ror dl, cl",
			"ror byte ptr [eax], cl",
			"rcl bl, cl",
			"rcl byte ptr [eax], cl",
			"rcr ah, cl",
			"rcr byte ptr [eax], cl",
			"shl ch, cl",
			"shl byte ptr [eax], cl",
			"shr dh, cl",
			"shr byte ptr [eax], cl",
			"sar al, cl",
			"sar byte ptr [eax], cl",
			"rol cx, cl",
			"rol word ptr [eax], cl",
			"rol ecx, cl",
			"rol dword ptr [eax], cl",
			"ror dx, cl",
			"ror word ptr [eax], cl",
			"ror edx, cl",
			"ror dword ptr [eax], cl",
			"rcl bx, cl",
			"rcl word ptr [eax], cl",
			"rcl ebx, cl",
			"rcl dword ptr [eax], cl",
			"rcr sp, cl",
			"rcr word ptr [eax], cl",
			"rcr esp, cl",
			"rcr dword ptr [eax], cl",
			"shl bp, cl",
			"shl word ptr [eax], cl",
			"shl ebp, cl",
			"shl dword ptr [eax], cl",
			"shr si, cl",
			"shr word ptr [eax], cl",
			"shr esi, cl",
			"shr dword ptr [eax], cl",
			"sar ax, cl",
			"sar word ptr [eax], cl",
			"sar eax, cl",
			"sar dword ptr [eax], cl",
			"fldcw word ptr [eax]",
			"fnstcw word ptr [eax]",
			"fnstsw word ptr [eax]",
			"call far dword ptr [eax]",
			"call far fword ptr [eax]",
			"jmp far dword ptr [eax]",
			"jmp far fword ptr [eax]",
			"push si",
			"push word ptr [eax]",
			"sgdt fword ptr [eax]",
			"sgdt fword ptr [eax]",
			"sidt fword ptr [eax]",
			"sidt fword ptr [eax]",
			"lgdt fword ptr [eax]",
			"lgdt fword ptr [eax]",
			"lidt fword ptr [eax]",
			"lidt fword ptr [eax]",
			"lar cx, si",
			"lar bx, word ptr [eax]",
			"lar ecx, esi",
			"lar ebx, word ptr [eax]",
			"lsl cx, si",
			"lsl bx, word ptr [eax]",
			"lsl ecx, esi",
			"lsl ebx, word ptr [eax]",
			"bndldx bnd1, dword ptr [eax]",
			"bndstx dword ptr [eax], bnd1",
			"kmovw k2, k3",
			"kmovw k1, word ptr [eax]",
			"kmovb k2, k3",
			"kmovb k1, byte ptr [eax]",
			"kmovd k2, k3",
			"kmovd k1, dword ptr [eax]",
			"kmovw word ptr [eax], k1",
			"kmovb byte ptr [eax], k1",
			"kmovd dword ptr [eax], k1",
			"kmovw k2, ebx",
			"kmovb k2, ebx",
			"kmovd k2, ebx",
			"kmovw edx, k3",
			"kmovb edx, k3",
			"kmovd edx, k3",
			"kortestw k2, k3",
			"kortestq k2, k3",
			"kortestb k2, k3",
			"kortestd k2, k3",
			"ktestw k2, k3",
			"ktestq k2, k3",
			"ktestb k2, k3",
			"ktestd k2, k3",
			"data16 push fs",
			"data16 pop fs",
			"shld si, cx, cl",
			"shld word ptr [eax], bx, cl",
			"shld esi, ecx, cl",
			"shld dword ptr [eax], ebx, cl",
			"data16 push gs",
			"data16 pop gs",
			"shrd si, cx, cl",
			"shrd word ptr [eax], bx, cl",
			"shrd esi, ecx, cl",
			"shrd dword ptr [eax], ebx, cl",
			"lss bx, dword ptr [eax]",
			"lss ebx, fword ptr [eax]",
			"lfs bx, dword ptr [eax]",
			"lfs ebx, fword ptr [eax]",
			"lgs bx, dword ptr [eax]",
			"lgs ebx, fword ptr [eax]",
			"movzx cx, dh",
			"movzx bx, byte ptr [eax]",
			"movzx ecx, dh",
			"movzx ebx, byte ptr [eax]",
			"movzx cx, si",
			"movzx bx, word ptr [eax]",
			"movzx ecx, si",
			"movzx ebx, word ptr [eax]",
			"movsx cx, dh",
			"movsx bx, byte ptr [eax]",
			"movsx ecx, dh",
			"movsx ebx, byte ptr [eax]",
			"movsx cx, si",
			"movsx bx, word ptr [eax]",
			"movsx ecx, si",
			"movsx ebx, word ptr [eax]",
			"cmpxchg8b qword ptr [eax]",
			"crc32 ecx, dh",
			"crc32 ebx, byte ptr [eax]",
			"crc32 ecx, si",
			"crc32 ebx, word ptr [eax]",
			"crc32 ecx, esi",
			"crc32 ebx, dword ptr [eax]",
			"addr16 maskmovq mmx2, mmx3",
			"maskmovq mmx2, mmx3",
			"addr16 maskmovdqu xmm2, xmm3",
			"maskmovdqu xmm2, xmm3",
			"addr16 vmaskmovdqu xmm2, xmm3",
			"vmaskmovdqu xmm2, xmm3",
			"outsb dx, byte ptr fs:[esi]",
			"outsw dx, word ptr fs:[esi]",
			"outsd dx, dword ptr fs:[esi]",
			"movsb byte ptr es:[edi], byte ptr fs:[esi]",
			"movsw word ptr es:[edi], word ptr fs:[esi]",
			"movsd dword ptr es:[edi], dword ptr fs:[esi]",
			"cmpsb byte ptr fs:[esi], byte ptr es:[edi]",
			"cmpsw word ptr fs:[esi], word ptr es:[edi]",
			"cmpsd dword ptr fs:[esi], dword ptr es:[edi]",
			"lodsb byte ptr fs:[esi]",
			"lodsw word ptr fs:[esi]",
			"lodsd dword ptr fs:[esi]",
			"xlat byte ptr [bx]",
			"xlat byte ptr fs:[ebx]",
			"maskmovq mmx2, mmx3, fs",
			"maskmovdqu xmm2, xmm3, fs",
			"vmaskmovdqu xmm2, xmm3, fs",
			"xlat byte ptr [ebx]",
			"aam -6",
			"aad -6",
			"fldenv fpuenv14 ptr [eax]",
			"fldenv [eax]",
			"fnstenv fpuenv14 ptr [eax]",
			"fnstenv [eax]",
			"frstor fpustate98 ptr [eax]",
			"frstor [eax]",
			"fnsave fpustate98 ptr [eax]",
			"fnsave [eax]",
			"addr16 monitor",
			"monitor",
			"mwait",
			"mov al, byte ptr fs:[0xf0debc9a]",
			"addr16 mov al, byte ptr fs:[0xf0de]",
			"mov ax, word ptr fs:[0xf0debc9a]",
			"addr16 mov ax, word ptr fs:[0xf0de]",
			"mov eax, dword ptr fs:[0xf0debc9a]",
			"addr16 mov eax, dword ptr fs:[0xf0de]",
			"mov byte ptr fs:[0xf0debc9a], al",
			"addr16 mov byte ptr fs:[0xf0de], al",
			"mov word ptr fs:[0xf0debc9a], ax",
			"addr16 mov word ptr fs:[0xf0de], ax",
			"mov dword ptr fs:[0xf0debc9a], eax",
			"addr16 mov dword ptr fs:[0xf0de], eax",
			"mov cl, byte ptr [eax]",
			"mov cl, byte ptr [eax-0x12]",
			"mov cl, byte ptr [eax-0x12345678]",
			"mov cl, byte ptr [0xedcba988]",
			"mov cl, byte ptr [eax+0x12]",
			"mov cl, byte ptr [eax+0x12345678]",
			"mov cl, byte ptr [0x12345678]",
			"mov cl, byte ptr [eax+ecx]",
			"mov cl, byte ptr [eax+ecx*2]",
			"mov cl, byte ptr [eax+ecx*4]",
			"mov cl, byte ptr [eax+ecx*8]",
			"mov cl, byte ptr [eax+ecx-0x12]",
			"mov cl, byte ptr [eax+ecx*2-0x12]",
			"mov cl, byte ptr [eax+ecx*4-0x12]",
			"mov cl, byte ptr [eax+ecx*8-0x12]",
			"mov cl, byte ptr [eax+ecx+0x12]",
			"mov cl, byte ptr [eax+ecx*2+0x12]",
			"mov cl, byte ptr [eax+ecx*4+0x12]",
			"mov cl, byte ptr [eax+ecx*8+0x12]",
			"mov cl, byte ptr [eax+ecx-0x12345678]",
			"mov cl, byte ptr [eax+ecx*2-0x12345678]",
			"mov cl, byte ptr [eax+ecx*4-0x12345678]",
			"mov cl, byte ptr [eax+ecx*8-0x12345678]",
			"mov cl, byte ptr [eax+ecx+0x12345678]",
			"mov cl, byte ptr [eax+ecx*2+0x12345678]",
			"mov cl, byte ptr [eax+ecx*4+0x12345678]",
			"mov cl, byte ptr [eax+ecx*8+0x12345678]",
			"mov cl, byte ptr [ecx*1-0x12345678]",
			"mov cl, byte ptr [ebp+ecx*2-0x12]",
			"mov cl, byte ptr [ebp+ecx*4-0x12345678]",
			"mov cl, byte ptr [ecx*8-0x12345678]",
			"mov cl, byte ptr [ecx*1+0x12345678]",
			"mov cl, byte ptr [ebp+ecx*2+0x12]",
			"mov cl, byte ptr [ebp+ecx*4+0x12345678]",
			"mov cl, byte ptr [ecx*8+0x12345678]",
			"mov cl, byte ptr fs:[eax]",
			"mov cl, byte ptr fs:[eax-0x12]",
			"mov cl, byte ptr fs:[eax-0x12345678]",
			"mov cl, byte ptr fs:[0xedcba988]",
			"mov cl, byte ptr fs:[eax+0x12]",
			"mov cl, byte ptr fs:[eax+0x12345678]",
			"mov cl, byte ptr fs:[0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx]",
			"mov cl, byte ptr fs:[eax+ecx*2]",
			"mov cl, byte ptr fs:[eax+ecx*4]",
			"mov cl, byte ptr fs:[eax+ecx*8]",
			"mov cl, byte ptr fs:[eax+ecx-0x12]",
			"mov cl, byte ptr fs:[eax+ecx*2-0x12]",
			"mov cl, byte ptr fs:[eax+ecx*4-0x12]",
			"mov cl, byte ptr fs:[eax+ecx*8-0x12]",
			"mov cl, byte ptr fs:[eax+ecx+0x12]",
			"mov cl, byte ptr fs:[eax+ecx*2+0x12]",
			"mov cl, byte ptr fs:[eax+ecx*4+0x12]",
			"mov cl, byte ptr fs:[eax+ecx*8+0x12]",
			"mov cl, byte ptr fs:[eax+ecx-0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx*2-0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx*4-0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx*8-0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx+0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx*2+0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx*4+0x12345678]",
			"mov cl, byte ptr fs:[eax+ecx*8+0x12345678]",
			"mov cl, byte ptr fs:[ecx*1-0x12345678]",
			"mov cl, byte ptr fs:[ebp+ecx*2-0x12]",
			"mov cl, byte ptr fs:[ebp+ecx*4-0x12345678]",
			"mov cl, byte ptr fs:[ecx*8-0x12345678]",
			"mov cl, byte ptr fs:[ecx*1+0x12345678]",
			"mov cl, byte ptr fs:[ebp+ecx*2+0x12]",
			"mov cl, byte ptr fs:[ebp+ecx*4+0x12345678]",
			"mov cl, byte ptr fs:[ecx*8+0x12345678]",
		};
	}
}
#endif
