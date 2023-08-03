#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
public partial class UParticleModuleTypeDataGpu : UParticleModuleTypeDataBase {
	public static UClass StaticClass() {return default;}
	///<summary>Information for runtime simulation.</summary>
	public FGPUSpriteEmitterInfo EmitterInfo;
	///<summary>Data used to initialize runtime resources.</summary>
	public FGPUSpriteResourceData ResourceData;
	///<summary>TEMP: How much to stretch sprites based on camera motion blur.</summary>
	public float CameraMotionBlurAmount;
	///<summary>When true, all existing partilces are cleared when the emitter is initialized.</summary>
	public bool bClearExistingParticlesOnInit;
}
