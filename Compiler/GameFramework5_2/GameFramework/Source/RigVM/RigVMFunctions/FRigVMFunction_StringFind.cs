namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Finds a string within another string</summary>
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
public partial struct FRigVMFunction_StringFind {
	public string Value;
	public string Search;
	public bool Found;
	public int Index;
}
