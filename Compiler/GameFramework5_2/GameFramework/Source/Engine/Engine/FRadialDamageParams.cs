#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DamageEvents.h")]
///<summary>Parameters used to compute radial damage</summary>
public partial struct FRadialDamageParams {
// RadialDamageParams
	public float BaseDamage;
	public float MinimumDamage;
	public float InnerRadius;
	public float OuterRadius;
	public float DamageFalloff;
}
