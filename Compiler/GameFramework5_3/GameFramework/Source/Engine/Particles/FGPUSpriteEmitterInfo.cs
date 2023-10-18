namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The data needed by the runtime to simulate sprites.</summary>
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
public partial struct FGPUSpriteEmitterInfo {
	public UParticleModuleRequired RequiredModule;
	public UParticleModuleSpawn SpawnModule;
	public UParticleModuleSpawnPerUnit SpawnPerUnitModule;
	public TArray<UParticleModule> SpawnModules;
	public FGPUSpriteLocalVectorFieldInfo LocalVectorField;
	public FFloatDistribution VectorFieldScale;
	public FFloatDistribution DragCoefficient;
	public FFloatDistribution PointAttractorStrength;
	public FFloatDistribution Resilience;
	public FVector ConstantAcceleration;
	public FVector PointAttractorPosition;
	public float PointAttractorRadiusSq;
	public FVector OrbitOffsetBase;
	public FVector OrbitOffsetRange;
	public FVector2D InvMaxSize;
	public float InvRotationRateScale;
	public float MaxLifetime;
	public int MaxParticleCount;
	public EParticleScreenAlignment ScreenAlignment;
	public EParticleAxisLock LockAxisFlag;
	public bool bEnableCollision;
	public EParticleCollisionMode CollisionMode;
	public bool bUseVelocityForMotionBlur;
	public bool bRemoveHMDRoll;
	public float MinFacingCameraBlendDistance;
	public float MaxFacingCameraBlendDistance;
	public FRawDistributionVector DynamicColor;
	public FRawDistributionFloat DynamicAlpha;
	public FRawDistributionVector DynamicColorScale;
	public FRawDistributionFloat DynamicAlphaScale;
}
