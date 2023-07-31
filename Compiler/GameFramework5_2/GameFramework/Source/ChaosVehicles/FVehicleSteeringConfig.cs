#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial struct FVehicleSteeringConfig {
	public ESteeringType SteeringType;
	public float AngleRatio;
	public FRuntimeFloatCurve SteeringCurve;
}
