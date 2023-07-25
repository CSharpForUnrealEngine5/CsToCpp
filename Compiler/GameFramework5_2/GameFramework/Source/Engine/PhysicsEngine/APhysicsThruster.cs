#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsThruster.h")]
///<summary>Attach one of these on an object using physics simulation and it will apply a force down the negative-X direction</summary>
public partial class APhysicsThruster : ARigidBodyBase {
// PhysicsThruster
	public UPhysicsThrusterComponent ThrusterComponent;
	public UArrowComponent ArrowComponent;
}
