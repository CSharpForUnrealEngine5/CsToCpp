#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Damage subclass that handles damage with a source location and falloff radius</summary>
[CppInclude("Engine/DamageEvents.h")]
public partial struct FRadialDamageEvent {
	public FRadialDamageParams Params;
	public FVector Origin;
	public TArray<FHitResult> ComponentHits;
}
