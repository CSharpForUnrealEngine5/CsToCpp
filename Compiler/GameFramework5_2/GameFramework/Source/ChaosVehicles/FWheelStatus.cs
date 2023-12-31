namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing information about the status of a single wheel of the vehicle.</summary>
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial struct FWheelStatus {
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
