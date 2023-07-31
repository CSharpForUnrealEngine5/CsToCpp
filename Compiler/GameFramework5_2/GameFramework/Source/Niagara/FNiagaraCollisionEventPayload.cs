#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Type struct for collision event payloads; collision event data set is based on this</summary>
[CppInclude("NiagaraEvents.h")]
public partial struct FNiagaraCollisionEventPayload {
	public FVector CollisionPos;
	public FVector CollisionNormal;
	public FVector CollisionVelocity;
	public int ParticleIndex;
	public int PhysicalMaterialIndex;
}
