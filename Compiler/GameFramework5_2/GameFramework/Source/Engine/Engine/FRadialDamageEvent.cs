#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DamageEvents.h")]
///<summary>Damage subclass that handles damage with a source location and falloff radius</summary>
public partial struct FRadialDamageEvent {
// RadialDamageEvent
	public FRadialDamageParams Params;
	public FVector Origin;
	public TArray<FHitResult> ComponentHits;
}
