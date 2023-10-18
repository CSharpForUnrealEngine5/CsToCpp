namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a single bound for a range of frame numbers.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FFrameNumberRangeBound {
	public ERangeBoundTypes Type;
	public FFrameNumber Value;
}
