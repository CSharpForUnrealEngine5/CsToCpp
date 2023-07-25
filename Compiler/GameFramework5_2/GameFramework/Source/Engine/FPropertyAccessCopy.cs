#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>A property copy, represents a one-to-many copy operation</summary>
public partial struct FPropertyAccessCopy {
// PropertyAccessCopy
	public int AccessIndex;
	public int DestAccessStartIndex;
	public int DestAccessEndIndex;
	public EPropertyAccessCopyType Type;
}
