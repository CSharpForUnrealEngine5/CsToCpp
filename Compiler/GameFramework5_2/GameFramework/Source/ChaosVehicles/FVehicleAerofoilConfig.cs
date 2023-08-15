namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleAerofoilConfig {
	public EVehicleAerofoilType AerofoilType;
	public FName BoneName;
	public FVector Offset;
	public FVector UpAxis;
	public float Area;
	public float Camber;
	public float MaxControlAngle;
	public float StallAngle;
	public float LiftMultiplier;
	public float DragMultiplier;
}
