#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEvents.h")]
///<summary>Type struct for collision event payloads; collision event data set is based on this</summary>
public partial struct FNiagaraCollisionEventPayload {
// NiagaraCollisionEventPayload
	public FVector CollisionPos;
	public FVector CollisionNormal;
	public FVector CollisionVelocity;
	public int ParticleIndex;
	public int PhysicalMaterialIndex;
}
