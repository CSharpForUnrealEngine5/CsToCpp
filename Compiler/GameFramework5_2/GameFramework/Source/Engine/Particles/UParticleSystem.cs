#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystem.h")]
///<summary>A ParticleSystem is a complete particle effect that contains any number of ParticleEmitters. By allowing multiple emitters</summary>
public partial class UParticleSystem : UFXSystemAsset {
// ParticleSystem
	public float UpdateTime_FPS;
	public float UpdateTime_Delta;
	public float WarmupTime;
	public float WarmupTickRate;
	public TArray<UParticleEmitter> Emitters;
	public UParticleSystemComponent PreviewComponent;
	public FRotator ThumbnailAngle;
	public float ThumbnailDistance;
	public float ThumbnailWarmup;
	public UInterpCurveEdSetup CurveEdSetup;
	public float LODDistanceCheckTime;
	public float MacroUVRadius;
	public TArray<float> LODDistances;
	public int EditorLODSetting;
	public TArray<FParticleSystemLOD> LODSettings;
	public FBox FixedRelativeBoundingBox;
	public float SecondsBeforeInactive;
	public string FloorMesh;
	public FVector FloorPosition;
	public FRotator FloorRotation;
	public float FloorScale;
	public FVector FloorScale3D;
	public FColor BackgroundColor;
	public float Delay;
	public float DelayLow;
	public bool bOrientZAxisTowardCamera;
	public bool bUseFixedRelativeBoundingBox;
	public bool bShouldResetPeakCounts;
	public bool bHasPhysics;
	public bool bUseRealtimeThumbnail;
	public bool ThumbnailImageOutOfDate;
	public UTexture2D ThumbnailImage;
	public bool bUseDelayRange;
	public bool bAllowManagedTicking;
	public bool bAutoDeactivate;
	public bool bRegenerateLODDuplicate;
	public byte SystemUpdateMode;
	public byte LODMethod;
	public EParticleSystemInsignificanceReaction InsignificantReaction;
	public byte OcclusionBoundsMethod;
	public EParticleSignificanceLevel MaxSignificanceLevel;
	public uint MinTimeBetweenTicks;
	public float InsignificanceDelay;
	public FVector MacroUVPosition;
	public FBox CustomOcclusionBounds;
	public TArray<FLODSoloTrack> SoloTracking;
	public TArray<FNamedEmitterMaterial> NamedMaterialSlots;
	public  bool ContainsEmitterType(UClass TypeData) { return default; }
}
