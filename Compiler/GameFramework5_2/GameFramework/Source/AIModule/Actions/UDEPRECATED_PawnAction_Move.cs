#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction_Move.h")]
public partial class UDEPRECATED_PawnAction_Move : UDEPRECATED_PawnAction {
	public static UClass StaticClass() {return default;}
	///<summary>GoalActor</summary>
	public AActor GoalActor;
	///<summary>GoalLocation</summary>
	public FVector GoalLocation;
	///<summary>AcceptableRadius</summary>
	public float AcceptableRadius;
	///<summary>&quot;None&quot; will result in default filter being used</summary>
	public UClass FilterClass;
	///<summary>bAllowStrafe</summary>
	public bool bAllowStrafe;
	///<summary>if set to true (default) will make action succeed when the pawn&#39;s collision component overlaps with goal&#39;s collision component</summary>
	public bool bFinishOnOverlap;
	///<summary>if set, movement will use path finding</summary>
	public bool bUsePathfinding;
	///<summary>if set, use incomplete path when goal can&#39;t be reached</summary>
	public bool bAllowPartialPath;
	///<summary>if set, GoalLocation will be projected on navigation before using</summary>
	public bool bProjectGoalToNavigation;
	///<summary>if set, path to GoalActor will be updated with goal&#39;s movement</summary>
	public bool bUpdatePathToGoal;
	///<summary>if set, other actions with the same priority will be aborted when path is changed</summary>
	public bool bAbortSubActionOnPathChange;
}
