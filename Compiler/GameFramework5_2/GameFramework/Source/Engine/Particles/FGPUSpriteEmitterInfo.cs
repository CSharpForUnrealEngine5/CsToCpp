#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
///<summary>The data needed by the runtime to simulate sprites.</summary>
public partial struct FGPUSpriteEmitterInfo {
// GPUSpriteEmitterInfo
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
	public byte ScreenAlignment;
	public byte LockAxisFlag;
	public bool bEnableCollision;
	public byte CollisionMode;
	public bool bRemoveHMDRoll;
	public float MinFacingCameraBlendDistance;
	public float MaxFacingCameraBlendDistance;
	public FRawDistributionVector DynamicColor;
	public FRawDistributionFloat DynamicAlpha;
	public FRawDistributionVector DynamicColorScale;
	public FRawDistributionFloat DynamicAlphaScale;
}
