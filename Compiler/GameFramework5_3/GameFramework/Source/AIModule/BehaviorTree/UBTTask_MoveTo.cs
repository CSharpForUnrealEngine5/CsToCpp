namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Move To task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_MoveTo.h")]
public partial class UBTTask_MoveTo : UBTTask_BlackboardBase {
	public static UClass StaticClass() {return default;}
	///<summary>fixed distance added to threshold between AI and goal location in destination reach test</summary>
	public float AcceptableRadius;
	///<summary>&quot;None&quot; will result in default filter being used</summary>
	public UClass FilterClass;
	///<summary>if task is expected to react to changes to location represented by BB key</summary>
	public float ObservedBlackboardValueTolerance;
	///<summary>if move goal in BB changes the move will be redirected to new location</summary>
	public bool bObserveBlackboardValue;
	///<summary>bAllowStrafe</summary>
	public bool bAllowStrafe;
	///<summary>if set, use incomplete path when goal can&#39;t be reached</summary>
	public bool bAllowPartialPath;
	///<summary>if set, path to goal actor will update itself when actor moves</summary>
	public bool bTrackMovingGoal;
	///<summary>if set, the goal location will need to be navigable</summary>
	public bool bRequireNavigableEndLocation;
	///<summary>if set, goal location will be projected on navigation data (navmesh) before using</summary>
	public bool bProjectGoalLocation;
	///<summary>if set, radius of AI&#39;s capsule will be added to threshold between AI and goal location in destination reach test</summary>
	public bool bReachTestIncludesAgentRadius;
	///<summary>if set, radius of goal&#39;s capsule will be added to threshold between AI and goal location in destination reach test</summary>
	public bool bReachTestIncludesGoalRadius;
	///<summary>DEPRECATED, please use combination of bReachTestIncludes*Radius instead</summary>
	public bool bStopOnOverlap;
	///<summary>bStopOnOverlapNeedsUpdate</summary>
	public bool bStopOnOverlapNeedsUpdate;
}
