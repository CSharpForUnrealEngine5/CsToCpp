#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleMesh.h")]
///<summary>Parameters that pertain to chunk damage.</summary>
public partial struct FDestructibleDamageParameters {
// DestructibleDamageParameters
	public float DamageThreshold;
	public float DamageSpread;
	public bool bEnableImpactDamage;
	public float ImpactDamage;
	public int DefaultImpactDamageDepth;
	public bool bCustomImpactResistance;
	public float ImpactResistance;
}
