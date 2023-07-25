#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DamageEvents.h")]
///<summary>Damage subclass that handles damage with a single impact location and source direction</summary>
public partial struct FPointDamageEvent {
// PointDamageEvent
	public float Damage;
	public FVector_NetQuantizeNormal ShotDirection;
	public FHitResult HitInfo;
}
