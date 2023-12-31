namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true or false if a given name exists in another given name</summary>
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
public partial struct FRigVMFunction_StringContains {
	public string Name;
	public string Search;
	public bool Result;
}
