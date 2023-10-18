namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true or false if a given name exists in another given name</summary>
[CppInclude("RigVMFunctions/RigVMFunction_Name.h")]
public partial struct FRigVMFunction_Contains {
	public FName Name;
	public FName Search;
	public bool Result;
}
