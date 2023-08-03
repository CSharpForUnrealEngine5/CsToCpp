#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ParticleSystem is a complete particle effect that contains any number of ParticleEmitters. By allowing multiple emitters</summary>
[CppInclude("Particles/ParticleSystem.h")]
public partial class UParticleSystem : UFXSystemAsset {
	public static UClass StaticClass() {return default;}
	///<summary>UpdateTime_FPS - the frame per second to update at in FixedTime mode</summary>
	public float UpdateTime_FPS;
	///<summary>UpdateTime_Delta       - internal</summary>
	public float UpdateTime_Delta;
	///<summary>WarmupTime - the time to warm-up the particle system when first rendered</summary>
	public float WarmupTime;
	///<summary>WarmupTickRate - the time step for each tick during warm up.</summary>
	public float WarmupTickRate;
	///<summary>Emitters       - internal - the array of emitters in the system</summary>
	public TArray<UParticleEmitter> Emitters;
	///<summary>The component used to preview the particle system in Cascade</summary>
	public UParticleSystemComponent PreviewComponent;
	///<summary>The angle to use when rendering the thumbnail image</summary>
	public FRotator ThumbnailAngle;
	///<summary>The distance to place the system when rendering the thumbnail image</summary>
	public float ThumbnailDistance;
	///<summary>The time to warm-up the system for the thumbnail image</summary>
	public float ThumbnailWarmup;
	///<summary>Used for curve editor to remember curve-editing setup.</summary>
	public UInterpCurveEdSetup CurveEdSetup;
	///<summary>How often (in seconds) the system should perform the LOD distance check.</summary>
	public float LODDistanceCheckTime;
	///<summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
	public float MacroUVRadius;
	///<summary>The array of distances for each LOD level in the system.</summary>
	public TArray<float> LODDistances;
	///<summary>LOD setting for intepolation (set by Cascade) Range [0..100]</summary>
	public int EditorLODSetting;
	///<summary>LODSettings</summary>
	public TArray<FParticleSystemLOD> LODSettings;
	///<summary>Fixed relative bounding box for particle system.</summary>
	public FBox FixedRelativeBoundingBox;
	///<summary>Number of seconds of emitter not being rendered that need to pass before it</summary>
	public float SecondsBeforeInactive;
	///<summary>Cascade &#39;floor&#39; mesh information.</summary>
	public string FloorMesh;
	///<summary>FloorPosition</summary>
	public FVector FloorPosition;
	///<summary>FloorRotation</summary>
	public FRotator FloorRotation;
	///<summary>FloorScale</summary>
	public float FloorScale;
	///<summary>FloorScale3D</summary>
	public FVector FloorScale3D;
	///<summary>The background color to display in Cascade</summary>
	public FColor BackgroundColor;
	///<summary>How long this Particle system should delay when ActivateSystem is called on it.</summary>
	public float Delay;
	///<summary>The low end of the emitter delay if using a range.</summary>
	public float DelayLow;
	///<summary>If true, the system&#39;s Z axis will be oriented toward the camera</summary>
	public bool bOrientZAxisTowardCamera;
	///<summary>Whether to use the fixed relative bounding box or calculate it every frame.</summary>
	public bool bUseFixedRelativeBoundingBox;
	///<summary>EDITOR ONLY: Indicates that Cascade would like to have the PeakActiveParticles count reset</summary>
	public bool bShouldResetPeakCounts;
	///<summary>Set during load time to indicate that physics is used...</summary>
	public bool bHasPhysics;
	///<summary>Inidicates the old &#39;real-time&#39; thumbnail rendering should be used</summary>
	public bool bUseRealtimeThumbnail;
	///<summary>Internal: Indicates the PSys thumbnail image is out of date</summary>
	public bool ThumbnailImageOutOfDate;
	///<summary>Internal: The PSys thumbnail image</summary>
	public UTexture2D ThumbnailImage;
	///<summary>If true, select the emitter delay from the range</summary>
	public bool bUseDelayRange;
	///<summary>Whether or not to allow instances of this system to have their ticks managed.</summary>
	public bool bAllowManagedTicking;
	///<summary>Auto-deactivate system if all emitters are determined to not spawn particles again, regardless of lifetime.</summary>
	public bool bAutoDeactivate;
	///<summary>Internal value that tracks the regenerate LOD levels preference.</summary>
	public bool bRegenerateLODDuplicate;
	///<summary>SystemUpdateMode</summary>
	public EParticleSystemUpdateMode SystemUpdateMode;
	///<summary>The method of LOD level determination to utilize for this particle system</summary>
	public ParticleSystemLODMethod LODMethod;
	///<summary>The reaction this system takes when all emitters are insignificant.</summary>
	public EParticleSystemInsignificanceReaction InsignificantReaction;
	///<summary>Which occlusion bounds method to use for this particle system.</summary>
	public EParticleSystemOcclusionBoundsMethod OcclusionBoundsMethod;
	///<summary>The maximum level of significance for emitters in this system. Any emitters with a higher significance will be capped at this significance level.</summary>
	public EParticleSignificanceLevel MaxSignificanceLevel;
	///<summary>Minimum duration between ticks; 33=tick at max. 30FPS, 16=60FPS, 8=120FPS</summary>
	public uint MinTimeBetweenTicks;
	///<summary>Time delay between all emitters becoming insignificant and the systems insignificant reaction.</summary>
	public float InsignificanceDelay;
	///<summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
	public FVector MacroUVPosition;
	///<summary>The occlusion bounds to use if OcclusionBoundsMethod is set to EPSOBM_CustomBounds</summary>
	public FBox CustomOcclusionBounds;
	///<summary>SoloTracking</summary>
	public TArray<FLODSoloTrack> SoloTracking;
	///<summary>Array of named material slots for use by emitters of this system.</summary>
	public TArray<FNamedEmitterMaterial> NamedMaterialSlots;
	///<summary>Returns true if this system contains an emitter of the pasesd type.</summary>
	public  bool ContainsEmitterType(UClass TypeData) { return default; }
}
