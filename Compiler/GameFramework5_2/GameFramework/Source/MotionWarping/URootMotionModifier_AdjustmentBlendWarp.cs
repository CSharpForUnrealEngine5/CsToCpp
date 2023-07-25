#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier_AdjustmentBlendWarp.h")]
///<summary>EXPERIMENTAL: Marked with 'hidedropdown' to prevent it from showing up in the UI since it is not ready for production.</summary>
public partial class URootMotionModifier_AdjustmentBlendWarp : URootMotionModifier_Warp {
// RootMotionModifier_AdjustmentBlendWarp
	public bool bWarpIKBones;
	public TArray<string> IKBones;
	public FTransform CachedMeshTransform;
	public FTransform CachedMeshRelativeTransform;
	public FTransform CachedRootMotion;
	public FAnimSequenceTrackContainer Result;
}
