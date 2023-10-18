namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/CurveEditorBakeFilter.h")]
public partial class UCurveEditorBakeFilter : UCurveEditorFilterBase {
	public static UClass StaticClass() {return default;}
	///<summary>The interval between baked keys when there is no valid Display Rate and Tick Resolution.</summary>
	public float BakeIntervalInSeconds;
	///<summary>The interval between baked keys.</summary>
	public FFrameNumber BakeInterval;
	///<summary>When enabled, CustomRange will be used for the bake region. Otherwise the selected keys will be used.</summary>
	public bool bCustomRangeOverride;
	///<summary>Specifies a custom range to use for baking when there is no valid Display Rate and Tick Resolution.</summary>
	public float CustomRangeMinInSeconds;
	///<summary>Specifies a custom range to use for baking when there is no valid Display Rate and Tick Resolution.</summary>
	public float CustomRangeMaxInSeconds;
	///<summary>Specifies a custom range to use for baking</summary>
	public FCurveEditorBakeFilterRange CustomRange;
	///<summary>When enabled, will use BakeIntervalInSeconds and CustomRangeInSeconds. Otherwise, use BakeInterval and CustomRange which are defined by the Display Rate and Tick Resolution.</summary>
	public bool bUseSeconds;
}
