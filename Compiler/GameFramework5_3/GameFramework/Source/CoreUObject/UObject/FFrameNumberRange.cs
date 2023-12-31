namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A contiguous set of frame numbers described by lower and upper bound values.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FFrameNumberRange {
	public FFrameNumberRangeBound LowerBound;
	public FFrameNumberRangeBound UpperBound;
}
