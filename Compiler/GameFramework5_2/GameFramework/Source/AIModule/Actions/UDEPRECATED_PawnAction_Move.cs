#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction_Move.h")]
public partial class UDEPRECATED_PawnAction_Move : UDEPRECATED_PawnAction {
// PawnAction_Move
	public AActor GoalActor;
	public FVector GoalLocation;
	public float AcceptableRadius;
	public UClass FilterClass;
	public bool bAllowStrafe;
	public bool bFinishOnOverlap;
	public bool bUsePathfinding;
	public bool bAllowPartialPath;
	public bool bProjectGoalToNavigation;
	public bool bUpdatePathToGoal;
	public bool bAbortSubActionOnPathChange;
}
