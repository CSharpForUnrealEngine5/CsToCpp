#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_MoveTo.h")]
///<summary>Move To task node.</summary>
public partial class UBTTask_MoveTo : UBTTask_BlackboardBase {
// BTTask_MoveTo
	public float AcceptableRadius;
	public UClass FilterClass;
	public float ObservedBlackboardValueTolerance;
	public bool bObserveBlackboardValue;
	public bool bAllowStrafe;
	public bool bAllowPartialPath;
	public bool bTrackMovingGoal;
	public bool bProjectGoalLocation;
	public bool bReachTestIncludesAgentRadius;
	public bool bReachTestIncludesGoalRadius;
	public bool bStopOnOverlap;
	public bool bStopOnOverlapNeedsUpdate;
}
