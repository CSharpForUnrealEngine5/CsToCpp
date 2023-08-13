namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocation.h")]
public partial class UParticleModuleLocation : UParticleModuleLocationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The location the particle should be emitted.</summary>
	public FRawDistributionVector StartLocation;
	///<summary>When set to a non-zero value this will force the particles to only spawn on evenly distributed</summary>
	public float DistributeOverNPoints;
	///<summary>When DistributeOverNPoints is set to a non-zero value, this specifies the ratio of particles spawned</summary>
	public float DistributeThreshold;
}
