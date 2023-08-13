namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/RadialForceActor.h")]
public partial class ARadialForceActor : ARigidBodyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Force component</summary>
	public URadialForceComponent ForceComponent;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public virtual void FireImpulse() {}
	///<summary>EnableForce</summary>
	public virtual void EnableForce() {}
	///<summary>DisableForce</summary>
	public virtual void DisableForce() {}
	///<summary>ToggleForce</summary>
	public virtual void ToggleForce() {}
}
