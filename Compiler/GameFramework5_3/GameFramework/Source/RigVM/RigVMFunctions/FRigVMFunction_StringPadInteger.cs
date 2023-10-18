namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts an integer number to a string with padding</summary>
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
public partial struct FRigVMFunction_StringPadInteger {
	public int Value;
	public int Digits;
	public string Result;
}
