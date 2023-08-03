#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleComponent.h")]
public partial class UDestructibleComponent : USkinnedMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If set, use this actor&#39;s fracture effects instead of the asset&#39;s fracture effects.</summary>
	public bool bFractureEffectOverride;
	///<summary>Fracture effects for each fracture level. Used only if Fracture Effect Override is set.</summary>
	public TArray<FFractureEffect> FractureEffects;
	///<summary>Enable &quot;hard sleeping&quot; for destruction-generated PxActors.  This means that they turn kinematic</summary>
	public bool bEnableHardSleeping;
	///<summary>The minimum size required to treat chunks as Large.</summary>
	public float LargeChunkThreshold;
	///<summary>Provide a blueprint interface for setting the destructible mesh</summary>
	public UDestructibleMesh DestructibleMesh_DEPRECATED;
	///<summary>Take damage</summary>
	public  void ApplyDamage(float DamageAmount,FVector HitLocation,FVector ImpulseDir,float ImpulseStrength) {}
	///<summary>Take radius damage</summary>
	public  void ApplyRadiusDamage(float BaseDamage,FVector HurtOrigin,float DamageRadius,float ImpulseStrength,bool bFullDamage) {}
	///<summary>SetDestructibleMesh</summary>
	public  void SetDestructibleMesh(UDestructibleMesh NewMesh) {}
	///<summary>GetDestructibleMesh</summary>
	public  UDestructibleMesh GetDestructibleMesh() { return default; }
	///<summary>Called when a component is touched</summary>
	public FComponentFractureSignature OnComponentFracture;
}
