#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkinnedMeshComponent.h")]
///<summary>Skinned Mesh Animation Tick option based on rendered or not. This dictates "TickPose and RefreshBoneTransforms"</summary>
public enum EVisibilityBasedAnimTickOption {
	AlwaysTickPoseAndRefreshBones=0,
	AlwaysTickPose=1,
	OnlyTickMontagesWhenNotRendered=2,
	OnlyTickPoseWhenRendered=3,
}
