#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The source data for runtime resources.</summary>
[CppInclude("Particles/TypeData/ParticleModuleTypeDataGpu.h")]
public partial struct FGPUSpriteResourceData {
	public TArray<FColor> QuantizedColorSamples;
	public TArray<FColor> QuantizedMiscSamples;
	public TArray<FColor> QuantizedSimulationAttrSamples;
	public FVector4 ColorScale;
	public FVector4 ColorBias;
	public FVector4 MiscScale;
	public FVector4 MiscBias;
	public FVector4 SimulationAttrCurveScale;
	public FVector4 SimulationAttrCurveBias;
	public FVector4 SubImageSize;
	public FVector4 SizeBySpeed;
	public FVector ConstantAcceleration;
	public FVector OrbitOffsetBase;
	public FVector OrbitOffsetRange;
	public FVector OrbitFrequencyBase;
	public FVector OrbitFrequencyRange;
	public FVector OrbitPhaseBase;
	public FVector OrbitPhaseRange;
	public float GlobalVectorFieldScale;
	public float GlobalVectorFieldTightness;
	public float PerParticleVectorFieldScale;
	public float PerParticleVectorFieldBias;
	public float DragCoefficientScale;
	public float DragCoefficientBias;
	public float ResilienceScale;
	public float ResilienceBias;
	public float CollisionRadiusScale;
	public float CollisionRadiusBias;
	public float CollisionTimeBias;
	public float CollisionRandomSpread;
	public float CollisionRandomDistribution;
	public float OneMinusFriction;
	public float RotationRateScale;
	public float CameraMotionBlurAmount;
	public EParticleScreenAlignment ScreenAlignment;
	public EParticleAxisLock LockAxisFlag;
	public FVector2D PivotOffset;
	public bool bRemoveHMDRoll;
	public float MinFacingCameraBlendDistance;
	public float MaxFacingCameraBlendDistance;
}
