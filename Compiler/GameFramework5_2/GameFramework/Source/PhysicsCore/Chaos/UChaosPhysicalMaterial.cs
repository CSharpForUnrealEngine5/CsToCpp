#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosPhysicalMaterial.h")]
///<summary>Physical materials are used to define the response of a physical object when</summary>
public partial class UChaosPhysicalMaterial : UObject {
// ChaosPhysicalMaterial
	public float Friction;
	public float StaticFriction;
	public float Restitution;
	public float LinearEtherDrag;
	public float AngularEtherDrag;
	public float SleepingLinearVelocityThreshold;
	public float SleepingAngularVelocityThreshold;
}
