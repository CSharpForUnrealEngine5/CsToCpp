namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sample data</summary>
[CppInclude("Animation/BlendSpace.h")]
public partial struct FBlendSample {
	public UAnimSequence Animation;
	public FVector SampleValue;
	public float RateScale;
	public bool bIsValid;
}
