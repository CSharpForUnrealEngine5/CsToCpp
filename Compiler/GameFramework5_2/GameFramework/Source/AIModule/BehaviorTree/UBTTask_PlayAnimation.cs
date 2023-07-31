#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Play indicated AnimationAsset on Pawn controlled by BT</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_PlayAnimation.h")]
public partial class UBTTask_PlayAnimation : UBTTaskNode {
	///<summary>Animation asset to play. Note that it needs to match the skeleton of pawn this BT is controlling</summary>
	public UAnimationAsset AnimationToPlay;
	///<summary>bLooping</summary>
	public bool bLooping;
	///<summary>if true the task will just trigger the animation and instantly finish. Fire and Forget.</summary>
	public bool bNonBlocking;
	///<summary>MyOwnerComp</summary>
	public UBehaviorTreeComponent MyOwnerComp;
	///<summary>CachedSkelMesh</summary>
	public USkeletalMeshComponent CachedSkelMesh;
}
