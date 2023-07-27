#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AIController.h")]
///<summary>AIController is the base class of controllers for AI-controlled Pawns.</summary>
public partial class AAIController : AController {
// AIController
	public bool bStartAILogicOnPossess;
	public bool bStopAILogicOnUnposses;
	public bool bLOSflag;
	public bool bSkipExtraLOSChecks;
	public bool bAllowStrafe;
	public bool bWantsPlayerState;
	public bool bSetControlRotationFromPawnOrientation;
	public UPathFollowingComponent PathFollowingComponent;
	public UBrainComponent BrainComponent;
	public UAIPerceptionComponent PerceptionComponent;
	public UDEPRECATED_PawnActionsComponent ActionsComp_DEPRECATED;
	public UBlackboardComponent Blackboard;
	public UGameplayTasksComponent CachedGameplayTasksComponent;
	public UClass DefaultNavigationFilterClass;
	public  EPathFollowingRequestResult MoveToActor(AActor Goal,float AcceptanceRadius/*=-1f*/,bool bStopOnOverlap/*=true*/,bool bUsePathfinding/*=true*/,bool bCanStrafe/*=true*/,UClass FilterClass/*=NULL*/,bool bAllowPartialPath/*=true*/) { return default; }
	public  EPathFollowingRequestResult MoveToLocation(FVector Dest,float AcceptanceRadius/*=-1f*/,bool bStopOnOverlap/*=true*/,bool bUsePathfinding/*=true*/,bool bProjectDestinationToNavigation/*=false*/,bool bCanStrafe/*=true*/,UClass FilterClass/*=NULL*/,bool bAllowPartialPath/*=true*/) { return default; }
	public FAIMoveCompletedSignature ReceiveMoveCompleted;
	public  EPathFollowingStatus GetMoveStatus() { return default; }
	public  bool HasPartialPath() { return default; }
	public  FVector GetImmediateMoveDestination() { return default; }
	public  void SetMoveBlockDetection(bool bEnable) {}
	public  bool RunBehaviorTree(UBehaviorTree BTAsset) { return default; }
	public  bool UseBlackboard(UBlackboardData BlackboardAsset,UBlackboardComponent BlackboardComponent) { return default; }
	public  void ClaimTaskResource(UClass ResourceClass) {}
	public  void UnclaimTaskResource(UClass ResourceClass) {}
	public  void OnUsingBlackBoard(UBlackboardComponent BlackboardComp,UBlackboardData BlackboardAsset) {}
	public  FVector GetFocalPoint() { return default; }
	public  FVector GetFocalPointOnActor(AActor Actor) { return default; }
	public  void K2_SetFocalPoint(FVector FP) {}
	public  void K2_SetFocus(AActor NewFocus) {}
	public  AActor GetFocusActor() { return default; }
	public  void K2_ClearFocus() {}
	public  void OnGameplayTaskResourcesClaimed(FGameplayResourceSet NewlyClaimed,FGameplayResourceSet FreshlyReleased) {}
	public  UPathFollowingComponent GetPathFollowingComponent() { return default; }
	public  UAIPerceptionComponent GetAIPerceptionComponent() { return default; }
	public  void SetPathFollowingComponent(UPathFollowingComponent NewPFComponent) {}
	public  UDEPRECATED_PawnActionsComponent GetDeprecatedActionsComponent() { return default; }
}
