#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	public  void FireImpulse() {}
	///<summary>EnableForce</summary>
	public  void EnableForce() {}
	///<summary>DisableForce</summary>
	public  void DisableForce() {}
	///<summary>ToggleForce</summary>
	public  void ToggleForce() {}
}
