namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/CurveEditorBakeFilter.h")]
public partial class UCurveEditorBakeFilter : UCurveEditorFilterBase {
	public static UClass StaticClass() {return default;}
	///<summary>If true we will use frame interval to bake, else will use seconds interval</summary>
	public bool bUseFrameBake;
	///<summary>The interval (in display rate frames) between baked keys. Only used if bUseFrameBake is true.</summary>
	public FFrameNumber BakeIntervalInFrames;
	///<summary>The interval (in seconds) between baked keys. Only used if bUseSnapRateForInterval is false.</summary>
	public float BakeIntervalInSeconds;
}
