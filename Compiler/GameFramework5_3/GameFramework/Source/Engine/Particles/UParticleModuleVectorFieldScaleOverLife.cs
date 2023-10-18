namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/VectorField/ParticleModuleVectorFieldScaleOverLife.h")]
public partial class UParticleModuleVectorFieldScaleOverLife : UParticleModuleVectorFieldBase {
	public static UClass StaticClass() {return default;}
	///<summary>Per-particle vector field scale. Evaluated using particle relative time.</summary>
	public UDistributionFloat VectorFieldScaleOverLife_DEPRECATED;
	///<summary>Per-particle vector field scale. Evaluated using particle relative time.</summary>
	public FRawDistributionFloat VectorFieldScaleOverLifeRaw;
}
