#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters that pertain to chunk damage.</summary>
[CppInclude("DestructibleMesh.h")]
public partial struct FDestructibleDamageParameters {
	public float DamageThreshold;
	public float DamageSpread;
	public bool bEnableImpactDamage;
	public float ImpactDamage;
	public int DefaultImpactDamageDepth;
	public bool bCustomImpactResistance;
	public float ImpactResistance;
}
