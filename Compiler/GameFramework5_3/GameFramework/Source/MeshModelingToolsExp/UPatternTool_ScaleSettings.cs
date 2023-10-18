namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Per Element Scale in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_ScaleSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>If true, changes to Start Scale, End Scale, and Jitter are proportional along all the axes</summary>
	public bool bProportional;
	///<summary>If true, Scale is linearly interpolated between StartScale and Scale values</summary>
	public bool bInterpolate;
	///<summary>If true, Scale at each Pattern Element is offset by a uniformly chosen random value in the range of [-ScaleJitterRange, ScaleJitterRange]</summary>
	public bool bJitter;
	///<summary>Scale applied to all Pattern Elements, or to first Pattern Element for Interpolated scale</summary>
	public FVector StartScale;
	///<summary>Scale applied to last Pattern Element for Interpolated scale</summary>
	public FVector EndScale;
	///<summary>Upper bound of the range which is sampled to randomly scale each Pattern Element if Jitter is true</summary>
	public FVector Jitter;
}
