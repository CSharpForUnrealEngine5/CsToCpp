#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsHandleComponent.h")]
///<summary>Utility object for moving physics objects around.</summary>
public partial class UPhysicsHandleComponent : UActorComponent {
// PhysicsHandleComponent
	public UPrimitiveComponent GrabbedComponent;
	public bool bSoftAngularConstraint;
	public bool bSoftLinearConstraint;
	public bool bInterpolateTarget;
	public float LinearDamping;
	public float LinearStiffness;
	public float AngularDamping;
	public float AngularStiffness;
	public float InterpolationSpeed;
	public void GrabComponent(UObject Component,string InBoneName,FVector GrabLocation,bool bConstrainRotation) {}
	public void GrabComponentAtLocation(UObject Component,string InBoneName,FVector GrabLocation) {}
	public void GrabComponentAtLocationWithRotation(UObject Component,string InBoneName,FVector Location,FRotator Rotation) {}
	public void ReleaseComponent() {}
	public UObject GetGrabbedComponent() { return default; }
	public void SetTargetLocation(FVector NewLocation) {}
	public void SetTargetRotation(FRotator NewRotation) {}
	public void SetTargetLocationAndRotation(FVector NewLocation,FRotator NewRotation) {}
	public void GetTargetLocationAndRotation(FVector TargetLocation,FRotator TargetRotation) {}
	public void SetLinearDamping(float NewLinearDamping) {}
	public void SetLinearStiffness(float NewLinearStiffness) {}
	public void SetAngularDamping(float NewAngularDamping) {}
	public void SetAngularStiffness(float NewAngularStiffness) {}
	public void SetInterpolationSpeed(float NewInterpolationSpeed) {}
}
