#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility struct to accumulate root motion.</summary>
[CppInclude("Animation/AnimationAsset.h")]
public partial struct FRootMotionMovementParams {
	public bool bHasRootMotion;
	public float BlendWeight;
	public FTransform RootMotionTransform;
}
