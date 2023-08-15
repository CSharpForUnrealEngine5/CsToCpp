namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleModuleRequired.h")]
public partial class UParticleModuleRequired : UParticleModule {
	public static UClass StaticClass() {return default;}
	///<summary>The material to utilize for the emitter at this LOD level.</summary>
	public UMaterialInterface Material;
	///<summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
	public float MinFacingCameraBlendDistance;
	///<summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
	public float MaxFacingCameraBlendDistance;
	///<summary>EmitterOrigin</summary>
	public FVector EmitterOrigin;
	///<summary>EmitterRotation</summary>
	public FRotator EmitterRotation;
	///<summary>The screen alignment to utilize for the emitter at this LOD level.</summary>
	public EParticleScreenAlignment ScreenAlignment;
	///<summary>If true, update the emitter in local space</summary>
	public bool bUseLocalSpace;
	///<summary>If true, kill the emitter when the particle system is deactivated</summary>
	public bool bKillOnDeactivate;
	///<summary>If true, kill the emitter when it completes</summary>
	public bool bKillOnCompleted;
	///<summary>The sorting mode to use for this emitter.</summary>
	public EParticleSortMode SortMode;
	///<summary>If true, the EmitterTime for the emitter will be calculated by</summary>
	public bool bUseLegacyEmitterTime;
	///<summary>If true, removes the HMD view roll (e.g. in VR)</summary>
	public bool bRemoveHMDRoll;
	///<summary>If true, gpu simulation positions are offset to support double precision vectors. Cpu sims always support large world coordinates.</summary>
	public bool bSupportLargeWorldCoordinates;
	///<summary>If true, select the emitter duration from the range</summary>
	public bool bEmitterDurationUseRange;
	///<summary>How long, in seconds, the emitter will run before looping.</summary>
	public float EmitterDuration;
	///<summary>The rate at which to spawn particles</summary>
	public FRawDistributionFloat SpawnRate;
	///<summary>The array of burst entries.</summary>
	public TArray<FParticleBurst> BurstList;
	///<summary>Indicates the time (in seconds) that this emitter should be delayed in the particle system.</summary>
	public float EmitterDelay;
	///<summary>The low end of the emitter delay if using a range.</summary>
	public float EmitterDelayLow;
	///<summary>If true, the emitter will be delayed only on the first loop.</summary>
	public bool bDelayFirstLoopOnly;
	///<summary>The interpolation method to used for the SubUV image selection.</summary>
	public EParticleSubUVInterpMethod InterpolationMethod;
	///<summary>Whether to scale the UV or not - ie, the model wasn&#39;t setup with sub uvs</summary>
	public bool bScaleUV;
	///<summary>If true, select the emitter delay from the range</summary>
	public bool bEmitterDelayUseRange;
	///<summary>The method to utilize when burst-emitting particles</summary>
	public EParticleBurstMethod ParticleBurstMethod;
	///<summary>Override the system MacroUV settings</summary>
	public bool bOverrideSystemMacroUV;
	///<summary>If true, use the MaxDrawCount to limit the number of particles rendered.</summary>
	public bool bUseMaxDrawCount;
	///<summary>OpacitySourceMode</summary>
	public EOpacitySourceMode OpacitySourceMode;
	///<summary>Normal generation mode for this emitter LOD.</summary>
	public EEmitterNormalsMode EmitterNormalsMode;
	///<summary>Ensures that movement generated from the orbit module is applied to velocity-aligned particles</summary>
	public bool bOrbitModuleAffectsVelocityAlignment;
	///<summary>The number of sub-images horizontally in the texture</summary>
	public int SubImages_Horizontal;
	///<summary>The number of sub-images vertically in the texture</summary>
	public int SubImages_Vertical;
	///<summary>The amount of time (particle-relative, 0.0 to 1.0) to &#39;lock&#39; on a random sub image</summary>
	public float RandomImageTime;
	///<summary>The number of times to change a random image over the life of the particle.</summary>
	public int RandomImageChanges;
	///<summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
	public FVector MacroUVPosition;
	///<summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
	public float MacroUVRadius;
	///<summary>Controls UV Flipping for this emitter.</summary>
	public EParticleUVFlipMode UVFlippingMode;
	///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
	public ESubUVBoundingVertexCount BoundingMode;
	///<summary>If true, recalculate the emitter duration on each loop.</summary>
	public bool bDurationRecalcEachLoop;
	///<summary>When EmitterNormalsMode is ENM_Spherical, particle normals are created to face away from NormalsSphereCenter.</summary>
	public FVector NormalsSphereCenter;
	///<summary>Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.</summary>
	public float AlphaThreshold;
	///<summary>The number of times to loop the emitter.</summary>
	public int EmitterLoops;
	///<summary>Texture to generate bounding geometry from.</summary>
	public UTexture2D CutoutTexture;
	///<summary>The maximum number of particles to DRAW for this emitter.</summary>
	public int MaxDrawCount;
	///<summary>The low end of the emitter duration if using a range.</summary>
	public float EmitterDurationLow;
	///<summary>When EmitterNormalsMode is ENM_Cylindrical,</summary>
	public FVector NormalsCylinderDirection;
	///<summary>Named material overrides for this emitter.</summary>
	public TArray<FName> NamedMaterialOverrides;
}
