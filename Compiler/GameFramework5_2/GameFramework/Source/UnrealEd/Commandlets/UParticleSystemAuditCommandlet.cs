#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/ParticleSystemAuditCommandlet.h")]
public partial class UParticleSystemAuditCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>If a particle system has a spawn rate or burst count greater than this value, it will be reported</summary>
	public float HighSpawnRateOrBurstThreshold;
	///<summary>If a particle system has an LODDistance larger than this value, it will be reported</summary>
	public float FarLODDistanceTheshold;
}
