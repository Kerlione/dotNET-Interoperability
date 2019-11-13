#pragma once

using namespace System;

namespace CPPFirstNumber {
	public ref class CPPFirstNumber
	{
		// TODO: Add your methods for this class here.
		public: static Int32 GetInt() {
			int value = 0;
			Console::Write("Please, enter the first number: ");

			value = Convert::ToInt32(Console::ReadLine());

			return value;
		}
	};
}
