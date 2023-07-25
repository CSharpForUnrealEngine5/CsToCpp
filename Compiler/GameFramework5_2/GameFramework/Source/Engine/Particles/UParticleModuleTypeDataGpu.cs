#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
public partial class UParticleModuleTypeDataGpu : UParticleModuleTypeDataBase {
// ParticleModuleTypeDataGpu
	public FGPUSpriteEmitterInfo EmitterInfo;
	public FGPUSpriteResourceData ResourceData;
	public float CameraMotionBlurAmount;
	public bool bClearExistingParticlesOnInit;
}
