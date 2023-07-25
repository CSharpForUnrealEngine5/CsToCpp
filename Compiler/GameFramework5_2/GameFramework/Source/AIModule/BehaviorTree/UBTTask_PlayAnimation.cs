#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_PlayAnimation.h")]
///<summary>Play indicated AnimationAsset on Pawn controlled by BT</summary>
public partial class UBTTask_PlayAnimation : UBTTaskNode {
// BTTask_PlayAnimation
	public UAnimationAsset AnimationToPlay;
	public bool bLooping;
	public bool bNonBlocking;
	public UBehaviorTreeComponent MyOwnerComp;
	public USkeletalMeshComponent CachedSkelMesh;
}
