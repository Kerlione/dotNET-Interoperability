#pragma once

using namespace System;

namespace CPPLibrary {
	public ref class HelloCPP
	{
		public: virtual void Hello() {
			Console::WriteLine("Hello from C++");
		}
 	};
}
