namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkinnedMeshComponent.h")]
///<summary>Skinned Mesh Animation Tick option based on rendered or not. This dictates &quot;TickPose and RefreshBoneTransforms&quot;</summary>
public enum EVisibilityBasedAnimTickOption {
	AlwaysTickPoseAndRefreshBones=0,
	AlwaysTickPose=1,
	OnlyTickMontagesWhenNotRendered=2,
	OnlyTickPoseWhenRendered=3,
}
