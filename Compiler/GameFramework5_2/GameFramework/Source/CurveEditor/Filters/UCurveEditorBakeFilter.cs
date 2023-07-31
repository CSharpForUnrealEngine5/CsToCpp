#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/CurveEditorBakeFilter.h")]
public partial class UCurveEditorBakeFilter : UCurveEditorFilterBase {
	///<summary>If true we will use frame interval to bake, else will use seconds interval</summary>
	public bool bUseFrameBake;
	///<summary>The interval (in display rate frames) between baked keys. Only used if bUseFrameBake is true.</summary>
	public FFrameNumber BakeIntervalInFrames;
	///<summary>The interval (in seconds) between baked keys. Only used if bUseSnapRateForInterval is false.</summary>
	public float BakeIntervalInSeconds;
}
