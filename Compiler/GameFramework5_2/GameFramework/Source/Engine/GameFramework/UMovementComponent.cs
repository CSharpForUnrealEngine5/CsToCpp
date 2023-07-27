#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/MovementComponent.h")]
///<summary>MovementComponent is an abstract component class that defines functionality for moving a PrimitiveComponent (our UpdatedComponent) each tick.</summary>
public partial class UMovementComponent : UActorComponent {
// MovementComponent
	public USceneComponent UpdatedComponent;
	public UPrimitiveComponent UpdatedPrimitive;
	public FVector Velocity;
	public FVector PlaneConstraintNormal;
	public FVector PlaneConstraintOrigin;
	public bool bUpdateOnlyIfRendered;
	public bool bAutoUpdateTickRegistration;
	public bool bTickBeforeOwner;
	public bool bAutoRegisterUpdatedComponent;
	public bool bConstrainToPlane;
	public bool bSnapToPlaneAtStart;
	public bool bAutoRegisterPhysicsVolumeUpdates;
	public bool bComponentShouldUpdatePhysicsVolume;
	public EPlaneConstraintAxisSetting PlaneConstraintAxisSetting;
	public  float GetGravityZ() { return default; }
	public  float GetMaxSpeed() { return default; }
	public  bool IsExceedingMaxSpeed(float MaxSpeed) { return default; }
	public  void StopMovementImmediately() {}
	public  APhysicsVolume GetPhysicsVolume() { return default; }
	public  void PhysicsVolumeChanged(APhysicsVolume NewVolume) {}
	public  void SetUpdatedComponent(USceneComponent NewUpdatedComponent) {}
	public  bool K2_MoveUpdatedComponent(FVector Delta,FRotator NewRotation,FHitResult OutHit,bool bSweep/*=true*/,bool bTeleport/*=false*/) { return default; }
	public  void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) {}
	public  EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting() { return default; }
	public  void SetPlaneConstraintNormal(FVector PlaneNormal) {}
	public  void SetPlaneConstraintFromVectors(FVector Forward,FVector Up) {}
	public  void SetPlaneConstraintOrigin(FVector PlaneOrigin) {}
	public  void SetPlaneConstraintEnabled(bool bEnabled) {}
	public  FVector GetPlaneConstraintNormal() { return default; }
	public  FVector GetPlaneConstraintOrigin() { return default; }
	public  FVector ConstrainDirectionToPlane(FVector Direction) { return default; }
	public  FVector ConstrainLocationToPlane(FVector Location) { return default; }
	public  FVector ConstrainNormalToPlane(FVector Normal) { return default; }
	public  void SnapUpdatedComponentToPlane() {}
}
