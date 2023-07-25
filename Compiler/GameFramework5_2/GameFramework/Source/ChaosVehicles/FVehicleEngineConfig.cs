#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial struct FVehicleEngineConfig {
// VehicleEngineConfig
	public FRuntimeFloatCurve TorqueCurve;
	public float MaxTorque;
	public float MaxRPM;
	public float EngineIdleRPM;
	public float EngineBrakeEffect;
	public float EngineRevUpMOI;
	public float EngineRevDownRate;
}
