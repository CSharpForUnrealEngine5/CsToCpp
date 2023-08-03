#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Attach one of these on an object using physics simulation and it will apply a force down the negative-X direction</summary>
[CppInclude("PhysicsEngine/PhysicsThruster.h")]
public partial class APhysicsThruster : ARigidBodyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Thruster component</summary>
	public UPhysicsThrusterComponent ThrusterComponent;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
}
