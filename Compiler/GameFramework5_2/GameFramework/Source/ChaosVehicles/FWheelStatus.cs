#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
///<summary>Structure containing information about the status of a single wheel of the vehicle.</summary>
public partial struct FWheelStatus {
// WheelStatus
	public bool bInContact;
	public FVector ContactPoint;
	public FVector HitLocation;
	public TWeakObjectPtr<UPhysicalMaterial> PhysMaterial;
	public float NormalizedSuspensionLength;
	public float SpringForce;
	public float SlipAngle;
	public bool bIsSlipping;
	public float SlipMagnitude;
	public bool bIsSkidding;
	public float SkidMagnitude;
	public FVector SkidNormal;
	public float DriveTorque;
	public float BrakeTorque;
	public bool bABSActivated;
}
