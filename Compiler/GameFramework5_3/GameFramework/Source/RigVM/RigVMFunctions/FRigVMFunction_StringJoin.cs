namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Joins a string into multiple sections given a separator</summary>
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
public partial struct FRigVMFunction_StringJoin {
	public TArray<string> Values;
	public string Separator;
	public string Result;
}
