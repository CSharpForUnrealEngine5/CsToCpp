namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial struct FVehicleEngineConfig {
	public FRuntimeFloatCurve TorqueCurve;
	public float MaxTorque;
	public float MaxRPM;
	public float EngineIdleRPM;
	public float EngineBrakeEffect;
	public float EngineRevUpMOI;
	public float EngineRevDownRate;
}
