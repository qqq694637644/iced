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

use super::super::super::ConditionCode;
#[cfg(not(feature = "std"))]
use hashbrown::HashMap;
#[cfg(feature = "std")]
use std::collections::HashMap;

lazy_static! {
	pub(super) static ref TO_CONDITION_CODE_HASH: HashMap<&'static str, ConditionCode> = {
		// GENERATOR-BEGIN: ConditionCodeHash
		// ⚠️This was generated by GENERATOR!🦹‍♂️
		let mut h = HashMap::with_capacity(17);
		let _ = h.insert("None", ConditionCode::None);
		let _ = h.insert("o", ConditionCode::o);
		let _ = h.insert("no", ConditionCode::no);
		let _ = h.insert("b", ConditionCode::b);
		let _ = h.insert("ae", ConditionCode::ae);
		let _ = h.insert("e", ConditionCode::e);
		let _ = h.insert("ne", ConditionCode::ne);
		let _ = h.insert("be", ConditionCode::be);
		let _ = h.insert("a", ConditionCode::a);
		let _ = h.insert("s", ConditionCode::s);
		let _ = h.insert("ns", ConditionCode::ns);
		let _ = h.insert("p", ConditionCode::p);
		let _ = h.insert("np", ConditionCode::np);
		let _ = h.insert("l", ConditionCode::l);
		let _ = h.insert("ge", ConditionCode::ge);
		let _ = h.insert("le", ConditionCode::le);
		let _ = h.insert("g", ConditionCode::g);
		// GENERATOR-END: ConditionCodeHash
		h
	};
}
