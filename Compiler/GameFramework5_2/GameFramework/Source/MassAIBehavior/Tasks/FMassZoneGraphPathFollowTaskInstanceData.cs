#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassZoneGraphPathFollowTask.h")]
///<summary>Follows a path long the current lane to a specified point.</summary>
public partial struct FMassZoneGraphPathFollowTaskInstanceData {
// MassZoneGraphPathFollowTaskInstanceData
	public FStateTreeStructRef TargetLocation;
	public FMassMovementStyleRef MovementStyle;
	public float SpeedScale;
}
