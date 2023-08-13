namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial struct FVehicleSteeringConfig {
	public ESteeringType SteeringType;
	public float AngleRatio;
	public FRuntimeFloatCurve SteeringCurve;
}
