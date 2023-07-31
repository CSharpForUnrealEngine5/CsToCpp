#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of Chaos Destruction data.</summary>
[CppInclude("NiagaraDataInterfaceChaosDestruction.h")]
public partial class UNiagaraDataInterfaceChaosDestruction : UNiagaraDataInterface {
	///<summary>Chaos Solver</summary>
	public TSet<AChaosSolverActor> ChaosSolverActorSet;
	///<summary>DataSourceType</summary>
	public EDataSourceTypeEnum DataSourceType;
	///<summary>Number of times the RBD collision data gets processed every second</summary>
	public int DataProcessFrequency;
	///<summary>Maximum number of collision/breaking/trailing entry used for spawning particles every time data from the physics solver gets processed</summary>
	public int MaxNumberOfDataEntriesToSpawn;
	///<summary>Turn on/off particle spawning</summary>
	public bool DoSpawn;
	///<summary>For every collision random number of particles will be spawned in the range of [SpawnMultiplierMin, SpawnMultiplierMax]</summary>
	public FVector2D SpawnMultiplierMinMax;
	///<summary>For every collision random number of particles will be spawned in the range of [SpawnMultiplierMin, SpawnMultiplierMax]</summary>
	public float SpawnChance;
	///<summary>Min/Max collision accumulated impulse to spawn particles</summary>
	public FVector2D ImpulseToSpawnMinMax;
	///<summary>Min/Max speed to spawn particles</summary>
	public FVector2D SpeedToSpawnMinMax;
	///<summary>Min/Max mass to spawn particles</summary>
	public FVector2D MassToSpawnMinMax;
	///<summary>Min/Max ExtentMin to spawn particles</summary>
	public FVector2D ExtentMinToSpawnMinMax;
	///<summary>Min/Max ExtentMax to spawn particles</summary>
	public FVector2D ExtentMaxToSpawnMinMax;
	///<summary>Min/Max volume to spawn particles</summary>
	public FVector2D VolumeToSpawnMinMax;
	///<summary>Min/Max solver time mass to spawn particles</summary>
	public FVector2D SolverTimeToSpawnMinMax;
	///<summary>SurfaceType to spawn particles</summary>
	public int SurfaceTypeToSpawn;
	///<summary>Location Filtering Mode</summary>
	public ELocationFilteringModeEnum LocationFilteringMode;
	///<summary>How to use LocationX to filter</summary>
	public ELocationXToSpawnEnum LocationXToSpawn;
	///<summary>Min/Max LocationX to spawn particles</summary>
	public FVector2D LocationXToSpawnMinMax;
	///<summary>How to use LocationY to filter</summary>
	public ELocationYToSpawnEnum LocationYToSpawn;
	///<summary>Min/Max LocationY to spawn particles</summary>
	public FVector2D LocationYToSpawnMinMax;
	///<summary>How to use LocationZ to filter</summary>
	public ELocationZToSpawnEnum LocationZToSpawn;
	///<summary>Min/Max LocationX to spawn particles</summary>
	public FVector2D LocationZToSpawnMinMax;
	///<summary>Min Linear Speed to generate trailing particles</summary>
	public float TrailMinSpeedToSpawn;
	///<summary>Sorting method to sort the collision data</summary>
	public EDataSortTypeEnum DataSortingType;
	///<summary>TODO: Explanatory comment</summary>
	public bool bGetExternalCollisionData;
	///<summary>DoSpatialHash</summary>
	public bool DoSpatialHash;
	///<summary>SpatialHash volume min</summary>
	public FVector SpatialHashVolumeMin;
	///<summary>SpatialHash volume max</summary>
	public FVector SpatialHashVolumeMax;
	///<summary>SpatialHash volume resolution</summary>
	public FVector SpatialHashVolumeCellSize;
	///<summary>MaxDataPerCell</summary>
	public int MaxDataPerCell;
	///<summary>Materials Filter</summary>
	public bool bApplyMaterialsFilter;
	///<summary>TODO: Explanatory comment</summary>
	public TSet<UPhysicalMaterial> ChaosBreakingMaterialSet;
	///<summary>TODO: Explanatory comment</summary>
	public bool bGetExternalBreakingData;
	///<summary>TODO: Explanatory comment</summary>
	public bool bGetExternalTrailingData;
	///<summary>Random displacement value for the particle spawn position</summary>
	public FVector2D RandomPositionMagnitudeMinMax;
	///<summary>How much of the collision velocity gets inherited</summary>
	public float InheritedVelocityMultiplier;
	///<summary>The method used to create the random velocities for the newly spawned particles</summary>
	public ERandomVelocityGenerationTypeEnum RandomVelocityGenerationType;
	///<summary>Every particles will be spawned with random velocity with magnitude in the range of [RandomVelocityMagnitudeMin, RandomVelocityMagnitudeMax]</summary>
	public FVector2D RandomVelocityMagnitudeMinMax;
	///<summary>SpreadAngleMax</summary>
	public float SpreadAngleMax;
	///<summary>Min Offset value added to spawned particles velocity</summary>
	public FVector VelocityOffsetMin;
	///<summary>Max Offset value added to spawned particles velocity</summary>
	public FVector VelocityOffsetMax;
	///<summary>Clamp particles velocity</summary>
	public FVector2D FinalVelocityMagnitudeMinMax;
	///<summary>MaxLatency</summary>
	public float MaxLatency;
	///<summary>Debug visualization method</summary>
	public EDebugTypeEnum DebugType;
	///<summary>LastSpawnedPointID</summary>
	public int LastSpawnedPointID;
	///<summary>LastSpawnTime</summary>
	public float LastSpawnTime;
	///<summary>SolverTime</summary>
	public float SolverTime;
	///<summary>TimeStampOfLastProcessedData</summary>
	public float TimeStampOfLastProcessedData;
}
