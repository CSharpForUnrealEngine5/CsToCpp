namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleThrustConfig {
	public EVehicleThrustType ThrustType;
	public FName BoneName;
	public FVector Offset;
	public FVector ThrustAxis;
	public float MaxThrustForce;
	public float MaxControlAngle;
}
