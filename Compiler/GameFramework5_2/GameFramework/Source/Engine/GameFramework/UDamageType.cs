#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/DamageType.h")]
///<summary>A DamageType is intended to define and describe a particular form of damage and to provide an avenue</summary>
public partial class UDamageType : UObject {
// DamageType
	public bool bCausedByWorld;
	public bool bScaleMomentumByMass;
	public bool bRadialDamageVelChange;
	public float DamageImpulse;
	public float DestructibleImpulse;
	public float DestructibleDamageSpreadScale;
	public float DamageFalloff;
}
