namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A property access path. References a string of property access segments.</summary>
[CppInclude("PropertyAccess.h")]
public partial struct FPropertyAccessPath {
	public int PathSegmentStartIndex;
	public int PathSegmentCount;
}
