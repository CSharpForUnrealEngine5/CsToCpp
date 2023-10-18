namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for MassSimulation</summary>
[CppInclude("MassSimulationSettings.h")]
public partial class UMassSimulationSettings : UMassModuleSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The desired budget in seconds allowed to do actor spawning per frame</summary>
	public double DesiredActorSpawningTimeSlicePerTick;
	///<summary>The desired budget in seconds allowed to do actor destruction per frame</summary>
	public double DesiredActorDestructionTimeSlicePerTick;
	///<summary>The desired budget in seconds allowed to do entity compaction per frame</summary>
	public double DesiredEntityCompactionTimeSlicePerTick;
	///<summary>The time to wait before retrying to spawn an actor that previously failed, default 10 seconds</summary>
	public float DesiredActorFailedSpawningRetryTimeInterval;
	///<summary>The distance a failed spawned actor needs to move before we retry, default 10 meters</summary>
	public float DesiredActorFailedSpawningRetryMoveDistance;
}
