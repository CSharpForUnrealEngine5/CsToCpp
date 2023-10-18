namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/VectorField/ParticleModuleVectorFieldScale.h")]
public partial class UParticleModuleVectorFieldScale : UParticleModuleVectorFieldBase {
	public static UClass StaticClass() {return default;}
	///<summary>Per-particle vector field scale. Evaluated using emitter time.</summary>
	public UDistributionFloat VectorFieldScale_DEPRECATED;
	///<summary>Per-particle vector field scale. Evaluated using emitter time.</summary>
	public FRawDistributionFloat VectorFieldScaleRaw;
}
