#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleModuleRequired.h")]
public partial class UParticleModuleRequired : UParticleModule {
// ParticleModuleRequired
	public UMaterialInterface Material;
	public float MinFacingCameraBlendDistance;
	public float MaxFacingCameraBlendDistance;
	public FVector EmitterOrigin;
	public FRotator EmitterRotation;
	public byte ScreenAlignment;
	public bool bUseLocalSpace;
	public bool bKillOnDeactivate;
	public bool bKillOnCompleted;
	public byte SortMode;
	public bool bUseLegacyEmitterTime;
	public bool bRemoveHMDRoll;
	public bool bSupportLargeWorldCoordinates;
	public bool bEmitterDurationUseRange;
	public float EmitterDuration;
	public FRawDistributionFloat SpawnRate;
	public TArray<FParticleBurst> BurstList;
	public float EmitterDelay;
	public float EmitterDelayLow;
	public bool bDelayFirstLoopOnly;
	public byte InterpolationMethod;
	public bool bScaleUV;
	public bool bEmitterDelayUseRange;
	public byte ParticleBurstMethod;
	public bool bOverrideSystemMacroUV;
	public bool bUseMaxDrawCount;
	public byte OpacitySourceMode;
	public byte EmitterNormalsMode;
	public bool bOrbitModuleAffectsVelocityAlignment;
	public int SubImages_Horizontal;
	public int SubImages_Vertical;
	public float RandomImageTime;
	public int RandomImageChanges;
	public FVector MacroUVPosition;
	public float MacroUVRadius;
	public EParticleUVFlipMode UVFlippingMode;
	public byte BoundingMode;
	public bool bDurationRecalcEachLoop;
	public FVector NormalsSphereCenter;
	public float AlphaThreshold;
	public int EmitterLoops;
	public UTexture2D CutoutTexture;
	public int MaxDrawCount;
	public float EmitterDurationLow;
	public FVector NormalsCylinderDirection;
	public TArray<string> NamedMaterialOverrides;
}
