#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleComponent.h")]
public partial class UDestructibleComponent : USkinnedMeshComponent {
// DestructibleComponent
	public bool bFractureEffectOverride;
	public TArray<FFractureEffect> FractureEffects;
	public bool bEnableHardSleeping;
	public float LargeChunkThreshold;
	public UDestructibleMesh DestructibleMesh_DEPRECATED;
	public  void ApplyDamage(float DamageAmount,FVector HitLocation,FVector ImpulseDir,float ImpulseStrength) {}
	public  void ApplyRadiusDamage(float BaseDamage,FVector HurtOrigin,float DamageRadius,float ImpulseStrength,bool bFullDamage) {}
	public  void SetDestructibleMesh(UDestructibleMesh NewMesh) {}
	public  UDestructibleMesh GetDestructibleMesh() { return default; }
	public FComponentFractureSignature OnComponentFracture;
}
