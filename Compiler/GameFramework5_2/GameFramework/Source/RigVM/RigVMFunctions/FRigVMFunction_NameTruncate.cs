namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the left or right most characters from the string chopping the given number of characters from the start or the end</summary>
[CppInclude("RigVMFunctions/RigVMFunction_Name.h")]
public partial struct FRigVMFunction_NameTruncate {
	public FName Name;
	public int Count;
	public bool FromEnd;
	public FName Remainder;
	public FName Chopped;
}
