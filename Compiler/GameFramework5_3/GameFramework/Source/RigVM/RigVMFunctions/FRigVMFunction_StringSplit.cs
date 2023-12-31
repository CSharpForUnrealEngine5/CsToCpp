namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Splits a string into multiple sections given a separator</summary>
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
public partial struct FRigVMFunction_StringSplit {
	public string Value;
	public string Separator;
	public TArray<string> Result;
}
