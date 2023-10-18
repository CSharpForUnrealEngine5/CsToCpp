namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DamageType is intended to define and describe a particular form of damage and to provide an avenue</summary>
[CppInclude("GameFramework/DamageType.h")]
public partial class UDamageType : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>True if this damagetype is caused by the world (falling off level, into lava, etc).</summary>
	public bool bCausedByWorld;
	///<summary>True to scale imparted momentum by the receiving pawn&#39;s mass for pawns using character movement</summary>
	public bool bScaleMomentumByMass;
	///<summary>When applying radial impulses, whether to treat as impulse or velocity change.</summary>
	public bool bRadialDamageVelChange;
	///<summary>The magnitude of impulse to apply to the Actors damaged by this type.</summary>
	public float DamageImpulse;
	///<summary>How large the impulse should be applied to destructible meshes</summary>
	public float DestructibleImpulse;
	///<summary>How much the damage spreads on a destructible mesh</summary>
	public float DestructibleDamageSpreadScale;
	///<summary>Damage fall-off for radius damage (exponent).  Default 1.0=linear, 2.0=square of distance, etc.</summary>
	public float DamageFalloff;
}
