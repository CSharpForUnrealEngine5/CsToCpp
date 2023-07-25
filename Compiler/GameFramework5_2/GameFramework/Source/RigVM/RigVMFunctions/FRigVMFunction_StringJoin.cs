#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
///<summary>Joins a string into multiple sections given a separator</summary>
public partial struct FRigVMFunction_StringJoin {
// RigVMFunction_StringJoin
	public TArray<string> Values;
	public string Separator;
	public string Result;
}
