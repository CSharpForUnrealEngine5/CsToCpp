#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AIController is the base class of controllers for AI-controlled Pawns.</summary>
[CppInclude("AIController.h")]
public partial class AAIController : AController {
	public static UClass StaticClass() {return default;}
	///<summary>By default AI&#39;s logic does not start when controlled Pawn is possessed. Setting this flag to true</summary>
	public bool bStartAILogicOnPossess;
	///<summary>By default AI&#39;s logic gets stopped when controlled Pawn is unpossessed. Setting this flag to false</summary>
	public bool bStopAILogicOnUnposses;
	///<summary>used for alternating LineOfSight traces</summary>
	public bool bLOSflag;
	///<summary>Skip extra line of sight traces to extremities of target being checked.</summary>
	public bool bSkipExtraLOSChecks;
	///<summary>Is strafing allowed during movement?</summary>
	public bool bAllowStrafe;
	///<summary>Specifies if this AI wants its own PlayerState.</summary>
	public bool bWantsPlayerState;
	///<summary>Copy Pawn rotation to ControlRotation, if there is no focus point.</summary>
	public bool bSetControlRotationFromPawnOrientation;
	///<summary>Component used for moving along a path.</summary>
	public UPathFollowingComponent PathFollowingComponent;
	///<summary>Component responsible for behaviors.</summary>
	public UBrainComponent BrainComponent;
	///<summary>PerceptionComponent</summary>
	public UAIPerceptionComponent PerceptionComponent;
	///<summary>ActionsComp_DEPRECATED</summary>
	public UDEPRECATED_PawnActionsComponent ActionsComp_DEPRECATED;
	///<summary>blackboard</summary>
	public UBlackboardComponent Blackboard;
	///<summary>CachedGameplayTasksComponent</summary>
	public UGameplayTasksComponent CachedGameplayTasksComponent;
	///<summary>DefaultNavigationFilterClass</summary>
	public UClass DefaultNavigationFilterClass;
	///<summary>Makes AI go toward specified Goal actor (destination will be continuously updated), aborts any active path following</summary>
	public  EPathFollowingRequestResult MoveToActor(AActor Goal,float AcceptanceRadius/*=-1f*/,bool bStopOnOverlap/*=true*/,bool bUsePathfinding/*=true*/,bool bCanStrafe/*=true*/,UClass FilterClass/*=NULL*/,bool bAllowPartialPath/*=true*/) { return default; }
	///<summary>Makes AI go toward specified Dest location, aborts any active path following</summary>
	public  EPathFollowingRequestResult MoveToLocation(FVector Dest,float AcceptanceRadius/*=-1f*/,bool bStopOnOverlap/*=true*/,bool bUsePathfinding/*=true*/,bool bProjectDestinationToNavigation/*=false*/,bool bCanStrafe/*=true*/,UClass FilterClass/*=NULL*/,bool bAllowPartialPath/*=true*/) { return default; }
	///<summary>Blueprint notification that we&#39;ve completed the current movement request</summary>
	public FAIMoveCompletedSignature ReceiveMoveCompleted;
	///<summary>Returns status of path following</summary>
	public  EPathFollowingStatus GetMoveStatus() { return default; }
	///<summary>Returns true if the current PathFollowingComponent&#39;s path is partial (does not reach desired destination).</summary>
	public  bool HasPartialPath() { return default; }
	///<summary>Returns position of current path segment&#39;s end.</summary>
	public  FVector GetImmediateMoveDestination() { return default; }
	///<summary>Updates state of movement block detection.</summary>
	public  void SetMoveBlockDetection(bool bEnable) {}
	///<summary>Starts executing behavior tree.</summary>
	public  bool RunBehaviorTree(UBehaviorTree BTAsset) { return default; }
	///<summary>Makes AI use the specified Blackboard asset &amp; creates a Blackboard Component if one does not already exist.</summary>
	public  bool UseBlackboard(UBlackboardData BlackboardAsset,UBlackboardComponent BlackboardComponent) { return default; }
	///<summary>ClaimTaskResource</summary>
	public  void ClaimTaskResource(UClass ResourceClass) {}
	///<summary>UnclaimTaskResource</summary>
	public  void UnclaimTaskResource(UClass ResourceClass) {}
	///<summary>OnUsingBlackBoard</summary>
	public  void OnUsingBlackBoard(UBlackboardComponent BlackboardComp,UBlackboardData BlackboardAsset) {}
	///<summary>Retrieve the final position that controller should be looking at.</summary>
	public  FVector GetFocalPoint() { return default; }
	///<summary>Retrieve the focal point this controller should focus to on given actor.</summary>
	public  FVector GetFocalPointOnActor(AActor Actor) { return default; }
	///<summary>Set the position that controller should be looking at.</summary>
	public  void K2_SetFocalPoint(FVector FP) {}
	///<summary>Set Focus for actor, will set FocalPoint as a result.</summary>
	public  void K2_SetFocus(AActor NewFocus) {}
	///<summary>Get the focused actor.</summary>
	public  AActor GetFocusActor() { return default; }
	///<summary>Clears Focus, will also clear FocalPoint as a result</summary>
	public  void K2_ClearFocus() {}
	///<summary>OnGameplayTaskResourcesClaimed</summary>
	public  void OnGameplayTaskResourcesClaimed(FGameplayResourceSet NewlyClaimed,FGameplayResourceSet FreshlyReleased) {}
	///<summary>Returns PathFollowingComponent subobject *</summary>
	public  UPathFollowingComponent GetPathFollowingComponent() { return default; }
	///<summary>GetAIPerceptionComponent</summary>
	public  UAIPerceptionComponent GetAIPerceptionComponent() { return default; }
	///<summary>Note that this function does not do any pathfollowing state transfer.</summary>
	public  void SetPathFollowingComponent(UPathFollowingComponent NewPFComponent) {}
	///<summary>GetDeprecatedActionsComponent</summary>
	public  UDEPRECATED_PawnActionsComponent GetDeprecatedActionsComponent() { return default; }
}
