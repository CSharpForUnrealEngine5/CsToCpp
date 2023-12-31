namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Size/ParticleModuleSize.h")]
public partial class UParticleModuleSize : UParticleModuleSizeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The initial size that should be used for a particle.</summary>
	public FRawDistributionVector StartSize;
}
