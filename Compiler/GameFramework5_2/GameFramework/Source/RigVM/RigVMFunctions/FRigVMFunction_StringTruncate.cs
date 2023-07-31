#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the left or right most characters from the string chopping the given number of characters from the start or the end</summary>
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
public partial struct FRigVMFunction_StringTruncate {
	public string Name;
	public int Count;
	public bool FromEnd;
	public string Remainder;
	public string Chopped;
}
