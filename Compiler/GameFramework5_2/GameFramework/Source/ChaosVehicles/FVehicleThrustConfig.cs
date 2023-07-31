#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleThrustConfig {
	public EVehicleThrustType ThrustType;
	public string BoneName;
	public FVector Offset;
	public FVector ThrustAxis;
	public float MaxThrustForce;
	public float MaxControlAngle;
}
