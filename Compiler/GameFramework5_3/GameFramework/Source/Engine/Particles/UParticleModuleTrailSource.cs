namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Trail/ParticleModuleTrailSource.h")]
public partial class UParticleModuleTrailSource : UParticleModuleTrailBase {
	public static UClass StaticClass() {return default;}
	///<summary>The source method for the trail.</summary>
	public ETrail2SourceMethod SourceMethod;
	///<summary>The name of the source - either the emitter or Actor.</summary>
	public FName SourceName;
	///<summary>The strength of the tangent from the source point for each Trail.</summary>
	public FRawDistributionFloat SourceStrength;
	///<summary>Whether to lock the source to the life of the particle.</summary>
	public bool bLockSourceStength;
	///<summary>SourceOffsetCount</summary>
	public int SourceOffsetCount;
	///<summary>Default offsets from the source(s).</summary>
	public TArray<FVector> SourceOffsetDefaults;
	///<summary>Particle selection method, when using the SourceMethod of Particle.</summary>
	public EParticleSourceSelectionMethod SelectionMethod;
	///<summary>Interhit particle rotation - only valid for SourceMethod of PET2SRCM_Particle.</summary>
	public bool bInheritRotation;
}
