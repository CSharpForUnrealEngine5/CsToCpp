#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSimulationSettings.h")]
///<summary>Implements the settings for MassSimulation</summary>
public partial class UMassSimulationSettings : UMassModuleSettings {
// MassSimulationSettings
	public double DesiredActorSpawningTimeSlicePerTick;
	public double DesiredActorDestructionTimeSlicePerTick;
	public double DesiredEntityCompactionTimeSlicePerTick;
	public float DesiredActorFailedSpawningRetryTimeInterval;
	public float DesiredActorFailedSpawningRetryMoveDistance;
}
