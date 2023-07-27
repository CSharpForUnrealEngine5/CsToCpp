#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleEmitter.h")]
public partial class UParticleEmitter : UObject {
// ParticleEmitter
	public string EmitterName;
	public int SubUVDataOffset;
	public EEmitterRenderMode EmitterRenderMode;
	public EParticleSignificanceLevel SignificanceLevel;
	public bool bUseLegacySpawningBehavior;
	public bool ConvertedModules;
	public bool bIsSoloing;
	public bool bCookedOut;
	public bool bDisabledLODsKeepEmitterAlive;
	public bool bDisableWhenInsignficant;
	public bool bCollapsed;
	public EDetailMode DetailMode_DEPRECATED;
	public FColor EmitterEditorColor;
	public TArray<UParticleLODLevel> LODLevels;
	public int PeakActiveParticles;
	public int InitialAllocationCount;
	public float QualityLevelSpawnRateScale;
	public uint DetailModeBitmask;
	public string DetailModeDisplay;
}
