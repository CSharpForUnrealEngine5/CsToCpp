#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Damage subclass that handles damage with a single impact location and source direction</summary>
[CppInclude("Engine/DamageEvents.h")]
public partial struct FPointDamageEvent {
	public float Damage;
	public FVector_NetQuantizeNormal ShotDirection;
	public FHitResult HitInfo;
}
