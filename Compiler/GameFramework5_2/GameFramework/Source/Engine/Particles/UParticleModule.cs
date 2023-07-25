#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleModule.h")]
public partial class UParticleModule : UObject {
// ParticleModule
	public bool bSpawnModule;
	public bool bUpdateModule;
	public bool bFinalUpdateModule;
	public bool bUpdateForGPUEmitter;
	public bool bCurvesAsColor;
	public bool b3DDrawMode;
	public bool bSupported3DDrawMode;
	public bool bEnabled;
	public bool bEditable;
	public bool LODDuplicate;
	public bool bSupportsRandomSeed;
	public bool bRequiresLoopingNotification;
	public byte LODValidity;
	public FColor ModuleEditorColor;
}
