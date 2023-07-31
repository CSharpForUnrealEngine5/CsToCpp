#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
