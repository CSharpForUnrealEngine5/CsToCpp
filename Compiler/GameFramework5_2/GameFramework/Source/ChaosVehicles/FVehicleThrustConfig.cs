#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleThrustConfig {
// VehicleThrustConfig
	public EVehicleThrustType ThrustType;
	public string BoneName;
	public FVector Offset;
	public FVector ThrustAxis;
	public float MaxThrustForce;
	public float MaxControlAngle;
}
