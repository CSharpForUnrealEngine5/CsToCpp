namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility struct to accumulate root motion.</summary>
[CppInclude("Animation/AnimationAsset.h")]
public partial struct FRootMotionMovementParams {
	public bool bHasRootMotion;
	public float BlendWeight;
	public FTransform RootMotionTransform;
}
