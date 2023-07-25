#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationAsset.h")]
///<summary>Transform definition</summary>
public partial struct FBlendSampleData {
// BlendSampleData
	public int SampleDataIndex;
	public UAnimSequence Animation;
	public float TotalWeight;
	public float WeightRate;
	public float Time;
	public float PreviousTime;
	public float SamplePlayRate;
}
