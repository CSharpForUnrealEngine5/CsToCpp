namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Follows a path long the current lane to a specified point.</summary>
[CppInclude("Tasks/MassZoneGraphPathFollowTask.h")]
public partial struct FMassZoneGraphPathFollowTaskInstanceData {
	public FStateTreeStructRef TargetLocation;
	public FMassMovementStyleRef MovementStyle;
	public float SpeedScale;
}
