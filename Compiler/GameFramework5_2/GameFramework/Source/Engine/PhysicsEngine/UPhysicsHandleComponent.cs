namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility object for moving physics objects around.</summary>
[CppInclude("PhysicsEngine/PhysicsHandleComponent.h")]
public partial class UPhysicsHandleComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Component we are currently holding</summary>
	public UPrimitiveComponent GrabbedComponent;
	///<summary>bSoftAngularConstraint</summary>
	public bool bSoftAngularConstraint;
	///<summary>bSoftLinearConstraint</summary>
	public bool bSoftLinearConstraint;
	///<summary>bInterpolateTarget</summary>
	public bool bInterpolateTarget;
	///<summary>Linear damping of the handle spring.</summary>
	public float LinearDamping;
	///<summary>Linear stiffness of the handle spring</summary>
	public float LinearStiffness;
	///<summary>Angular damping of the handle spring</summary>
	public float AngularDamping;
	///<summary>Angular stiffness of the handle spring</summary>
	public float AngularStiffness;
	///<summary>How quickly we interpolate the physics target transform</summary>
	public float InterpolationSpeed;
	///<summary>GrabComponent</summary>
	public virtual void GrabComponent(UPrimitiveComponent Component,string InBoneName,FVector GrabLocation,bool bConstrainRotation) {}
	///<summary>Grab the specified component at a given location. Does NOT constraint rotation which means the handle will pivot about GrabLocation.</summary>
	public void GrabComponentAtLocation(UPrimitiveComponent Component,string InBoneName,FVector GrabLocation) {}
	///<summary>Grab the specified component at a given location and rotation. Constrains rotation.</summary>
	public void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component,string InBoneName,FVector Location,FRotator Rotation) {}
	///<summary>Release the currently held component</summary>
	public virtual void ReleaseComponent() {}
	///<summary>Returns the currently grabbed component, or null if nothing is grabbed.</summary>
	public UPrimitiveComponent GetGrabbedComponent() { return default; }
	///<summary>Set the target location</summary>
	public void SetTargetLocation(FVector NewLocation) {}
	///<summary>Set the target rotation</summary>
	public void SetTargetRotation(FRotator NewRotation) {}
	///<summary>Set target location and rotation</summary>
	public void SetTargetLocationAndRotation(FVector NewLocation,FRotator NewRotation) {}
	///<summary>Get the current location and rotation</summary>
	public void GetTargetLocationAndRotation(FVector TargetLocation,FRotator TargetRotation) {}
	///<summary>Set linear damping</summary>
	public void SetLinearDamping(float NewLinearDamping) {}
	///<summary>Set linear stiffness</summary>
	public void SetLinearStiffness(float NewLinearStiffness) {}
	///<summary>Set angular damping</summary>
	public void SetAngularDamping(float NewAngularDamping) {}
	///<summary>Set angular stiffness</summary>
	public void SetAngularStiffness(float NewAngularStiffness) {}
	///<summary>Set interpolation speed</summary>
	public void SetInterpolationSpeed(float NewInterpolationSpeed) {}
}
