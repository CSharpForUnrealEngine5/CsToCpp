#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A property copy, represents a one-to-many copy operation</summary>
[CppInclude("PropertyAccess.h")]
public partial struct FPropertyAccessCopy {
	public int AccessIndex;
	public int DestAccessStartIndex;
	public int DestAccessEndIndex;
	public EPropertyAccessCopyType Type;
}
