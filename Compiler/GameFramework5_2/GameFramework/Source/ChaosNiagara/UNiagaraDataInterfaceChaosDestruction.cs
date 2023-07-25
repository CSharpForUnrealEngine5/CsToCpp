#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceChaosDestruction.h")]
///<summary>Data Interface allowing sampling of Chaos Destruction data.</summary>
public partial class UNiagaraDataInterfaceChaosDestruction : UNiagaraDataInterface {
// NiagaraDataInterfaceChaosDestruction
	public TSet<AChaosSolverActor> ChaosSolverActorSet;
	public EDataSourceTypeEnum DataSourceType;
	public int DataProcessFrequency;
	public int MaxNumberOfDataEntriesToSpawn;
	public bool DoSpawn;
	public FVector2D SpawnMultiplierMinMax;
	public float SpawnChance;
	public FVector2D ImpulseToSpawnMinMax;
	public FVector2D SpeedToSpawnMinMax;
	public FVector2D MassToSpawnMinMax;
	public FVector2D ExtentMinToSpawnMinMax;
	public FVector2D ExtentMaxToSpawnMinMax;
	public FVector2D VolumeToSpawnMinMax;
	public FVector2D SolverTimeToSpawnMinMax;
	public int SurfaceTypeToSpawn;
	public ELocationFilteringModeEnum LocationFilteringMode;
	public ELocationXToSpawnEnum LocationXToSpawn;
	public FVector2D LocationXToSpawnMinMax;
	public ELocationYToSpawnEnum LocationYToSpawn;
	public FVector2D LocationYToSpawnMinMax;
	public ELocationZToSpawnEnum LocationZToSpawn;
	public FVector2D LocationZToSpawnMinMax;
	public float TrailMinSpeedToSpawn;
	public EDataSortTypeEnum DataSortingType;
	public bool bGetExternalCollisionData;
	public bool DoSpatialHash;
	public FVector SpatialHashVolumeMin;
	public FVector SpatialHashVolumeMax;
	public FVector SpatialHashVolumeCellSize;
	public int MaxDataPerCell;
	public bool bApplyMaterialsFilter;
	public TSet<UPhysicalMaterial> ChaosBreakingMaterialSet;
	public bool bGetExternalBreakingData;
	public bool bGetExternalTrailingData;
	public FVector2D RandomPositionMagnitudeMinMax;
	public float InheritedVelocityMultiplier;
	public ERandomVelocityGenerationTypeEnum RandomVelocityGenerationType;
	public FVector2D RandomVelocityMagnitudeMinMax;
	public float SpreadAngleMax;
	public FVector VelocityOffsetMin;
	public FVector VelocityOffsetMax;
	public FVector2D FinalVelocityMagnitudeMinMax;
	public float MaxLatency;
	public EDebugTypeEnum DebugType;
	public int LastSpawnedPointID;
	public float LastSpawnTime;
	public float SolverTime;
	public float TimeStampOfLastProcessedData;
}
