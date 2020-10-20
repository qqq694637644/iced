/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

use wasm_bindgen::prelude::*;

// GENERATOR-BEGIN: Enum
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// Control flow
#[wasm_bindgen]
#[derive(Copy, Clone)]
pub enum FlowControl {
	/// The next instruction that will be executed is the next instruction in the instruction stream
	Next = 0,
	/// It's an unconditional branch instruction: `JMP NEAR`, `JMP FAR`
	UnconditionalBranch = 1,
	/// It's an unconditional indirect branch: `JMP NEAR reg`, `JMP NEAR [mem]`, `JMP FAR [mem]`
	IndirectBranch = 2,
	/// It's a conditional branch instruction: `Jcc SHORT`, `Jcc NEAR`, `LOOP`, `LOOPcc`, `JRCXZ`
	ConditionalBranch = 3,
	/// It's a return instruction: `RET NEAR`, `RET FAR`, `IRET`, `SYSRET`, `SYSEXIT`, `RSM`, `VMLAUNCH`, `VMRESUME`, `VMRUN`, `SKINIT`, `RDM`, `SEAMRET`, `UIRET`
	Return = 4,
	/// It's a call instruction: `CALL NEAR`, `CALL FAR`, `SYSCALL`, `SYSENTER`, `VMCALL`, `VMMCALL`, `VMGEXIT`, `TDCALL`, `SEAMCALL`
	Call = 5,
	/// It's an indirect call instruction: `CALL NEAR reg`, `CALL NEAR [mem]`, `CALL FAR [mem]`
	IndirectCall = 6,
	/// It's an interrupt instruction: `INT n`, `INT3`, `INT1`, `INTO`, `SMINT`, `DMINT`
	Interrupt = 7,
	/// It's `XBEGIN`, `XABORT`, `XEND`, `XSUSLDTRK`, `XRESLDTRK`
	XbeginXabortXend = 8,
	/// It's an invalid instruction, eg. [`Code.INVALID`], `UD0`, `UD1`, `UD2`
	///
	/// [`Code.INVALID`]: enum.Code.html#variant.INVALID
	Exception = 9,
}
// GENERATOR-END: Enum

#[allow(dead_code)]
pub(crate) fn iced_to_flow_control(value: iced_x86_rust::FlowControl) -> FlowControl {
	// Safe, the enums are exactly identical
	unsafe { std::mem::transmute(value as u8) }
}
