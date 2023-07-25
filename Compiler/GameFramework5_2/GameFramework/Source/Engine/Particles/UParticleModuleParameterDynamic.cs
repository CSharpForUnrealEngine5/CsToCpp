#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Parameter/ParticleModuleParameterDynamic.h")]
public partial class UParticleModuleParameterDynamic : UParticleModuleParameterBase {
// ParticleModuleParameterDynamic
	public TArray<FEmitterDynamicParameter> DynamicParams;
	public int UpdateFlags;
	public bool bUsesVelocity;
}
