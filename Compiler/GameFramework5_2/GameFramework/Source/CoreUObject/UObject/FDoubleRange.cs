namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A contiguous set of doubles described by lower and upper bound values.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FDoubleRange {
	public FDoubleRangeBound LowerBound;
	public FDoubleRangeBound UpperBound;
}
