#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MovementComponent is an abstract component class that defines functionality for moving a PrimitiveComponent (our UpdatedComponent) each tick.</summary>
[CppInclude("GameFramework/MovementComponent.h")]
public partial class UMovementComponent : UActorComponent {
	///<summary>The component we move and update.</summary>
	public USceneComponent UpdatedComponent;
	///<summary>UpdatedComponent, cast as a UPrimitiveComponent. May be invalid if UpdatedComponent was null or not a UPrimitiveComponent.</summary>
	public UPrimitiveComponent UpdatedPrimitive;
	///<summary>Current velocity of updated component.</summary>
	public FVector Velocity;
	///<summary>The normal or axis of the plane that constrains movement, if bConstrainToPlane is enabled.</summary>
	public FVector PlaneConstraintNormal;
	///<summary>The origin of the plane that constrains movement, if plane constraint is enabled.</summary>
	public FVector PlaneConstraintOrigin;
	///<summary>If true, skips TickComponent() if UpdatedComponent was not recently rendered.</summary>
	public bool bUpdateOnlyIfRendered;
	///<summary>If true, whenever the updated component is changed, this component will enable or disable its tick dependent on whether it has something to update.</summary>
	public bool bAutoUpdateTickRegistration;
	///<summary>If true, after registration we will add a tick dependency to tick before our owner (if we can both tick).</summary>
	public bool bTickBeforeOwner;
	///<summary>If true, registers the owner&#39;s Root component as the UpdatedComponent if there is not one currently assigned.</summary>
	public bool bAutoRegisterUpdatedComponent;
	///<summary>If true, movement will be constrained to a plane.</summary>
	public bool bConstrainToPlane;
	///<summary>If true and plane constraints are enabled, then the updated component will be snapped to the plane when first attached.</summary>
	public bool bSnapToPlaneAtStart;
	///<summary>If true, then applies the value of bComponentShouldUpdatePhysicsVolume to the UpdatedComponent. If false, will not change bShouldUpdatePhysicsVolume on the UpdatedComponent at all.</summary>
	public bool bAutoRegisterPhysicsVolumeUpdates;
	///<summary>If true, enables bShouldUpdatePhysicsVolume on the UpdatedComponent during initialization from SetUpdatedComponent(), otherwise disables such updates.</summary>
	public bool bComponentShouldUpdatePhysicsVolume;
	///<summary>Setting that controls behavior when movement is restricted to a 2D plane defined by a specific axis/normal,</summary>
	public EPlaneConstraintAxisSetting PlaneConstraintAxisSetting;
	///<summary>Returns gravity that affects this component</summary>
	public  float GetGravityZ() { return default; }
	///<summary>Returns maximum speed of component in current movement mode.</summary>
	public  float GetMaxSpeed() { return default; }
	///<summary>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance.</summary>
	public  bool IsExceedingMaxSpeed(float MaxSpeed) { return default; }
	///<summary>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration).</summary>
	public  void StopMovementImmediately() {}
	///<summary>Returns the PhysicsVolume this MovementComponent is using, or the world&#39;s default physics volume if none. *</summary>
	public  APhysicsVolume GetPhysicsVolume() { return default; }
	///<summary>Delegate when PhysicsVolume of UpdatedComponent has been changed *</summary>
	public  void PhysicsVolumeChanged(APhysicsVolume NewVolume) {}
	///<summary>Assign the component we move and update.</summary>
	public  void SetUpdatedComponent(USceneComponent NewUpdatedComponent) {}
	///<summary>Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation.</summary>
	public  bool K2_MoveUpdatedComponent(FVector Delta,FRotator NewRotation,FHitResult OutHit,bool bSweep/*=true*/,bool bTeleport/*=false*/) { return default; }
	///<summary>Set the plane constraint axis setting.</summary>
	public  void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) {}
	///<summary>Get the plane constraint axis setting.</summary>
	public  EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting() { return default; }
	///<summary>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
	public  void SetPlaneConstraintNormal(FVector PlaneNormal) {}
	///<summary>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
	public  void SetPlaneConstraintFromVectors(FVector Forward,FVector Up) {}
	///<summary>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
	public  void SetPlaneConstraintOrigin(FVector PlaneOrigin) {}
	///<summary>Sets whether or not the plane constraint is enabled.</summary>
	public  void SetPlaneConstraintEnabled(bool bEnabled) {}
	///<summary>Returns the normal of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
	public  FVector GetPlaneConstraintNormal() { return default; }
	///<summary>Get the plane constraint origin. This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().</summary>
	public  FVector GetPlaneConstraintOrigin() { return default; }
	///<summary>Constrain a direction vector to the plane constraint, if enabled.</summary>
	public  FVector ConstrainDirectionToPlane(FVector Direction) { return default; }
	///<summary>Constrain a position vector to the plane constraint, if enabled.</summary>
	public  FVector ConstrainLocationToPlane(FVector Location) { return default; }
	///<summary>Constrain a normal vector (of unit length) to the plane constraint, if enabled.</summary>
	public  FVector ConstrainNormalToPlane(FVector Normal) { return default; }
	///<summary>Snap the updated component to the plane constraint, if enabled.</summary>
	public  void SnapUpdatedComponentToPlane() {}
}
