namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters used to compute radial damage</summary>
[CppInclude("Engine/DamageEvents.h")]
public partial struct FRadialDamageParams {
	public float BaseDamage;
	public float MinimumDamage;
	public float InnerRadius;
	public float OuterRadius;
	public float DamageFalloff;
}
