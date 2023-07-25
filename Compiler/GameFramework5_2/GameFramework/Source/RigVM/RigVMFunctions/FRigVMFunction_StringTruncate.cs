#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/RigVMFunction_String.h")]
///<summary>Returns the left or right most characters from the string chopping the given number of characters from the start or the end</summary>
public partial struct FRigVMFunction_StringTruncate {
// RigVMFunction_StringTruncate
	public string Name;
	public int Count;
	public bool FromEnd;
	public string Remainder;
	public string Chopped;
}
