namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transform definition</summary>
[CppInclude("Animation/AnimationAsset.h")]
public partial struct FBlendSampleData {
	public int SampleDataIndex;
	public UAnimSequence Animation;
	public float TotalWeight;
	public float WeightRate;
	public float Time;
	public float PreviousTime;
	public float SamplePlayRate;
}
