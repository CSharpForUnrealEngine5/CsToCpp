#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A spawner you can put on a map and configure it to spawn different things</summary>
[CppInclude("MassSpawner.h")]
public partial class AMassSpawner : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>DEBUG_Spawn</summary>
	public  void DEBUG_Spawn() {}
	///<summary>Remove all the entities</summary>
	public  void DEBUG_Clear() {}
	///<summary>Starts the spawning of all the agent types of this spawner</summary>
	public  void DoSpawning() {}
	///<summary>Despawn all mass agent that was spawned by this spawner</summary>
	public  void DoDespawning() {}
	///<summary>ClearTemplates</summary>
	public  void ClearTemplates() {}
	///<summary>UnloadConfig</summary>
	public  void UnloadConfig() {}
	///<summary>Scales the spawning counts</summary>
	public  void ScaleSpawningCount(float Scale) {}
	///<summary>GetCount</summary>
	public  int GetCount() { return default; }
	///<summary>GetSpawningCountScale</summary>
	public  float GetSpawningCountScale() { return default; }
	///<summary>Called once DoSpawning completes and all entities have been spawned.</summary>
	public FMassSpawnerOnSpawningFinishedEvent OnSpawningFinishedEvent;
	///<summary>Called once DoDespawning completes and all mass agents spawned by this spawner have been despawned.</summary>
	public FMassSpawnerOnDespawningFinishedEvent OnDespawningFinishedEvent;
	///<summary>Count</summary>
	public int Count;
	///<summary>Array of entity types to spawn. These define which entities to spawn.</summary>
	public TArray<FMassSpawnedEntityType> EntityTypes;
	///<summary>Array of entity spawn generators. These define where to spawn entities.</summary>
	public TArray<FMassSpawnDataGenerator> SpawnDataGenerators;
	///<summary>bAutoSpawnOnBeginPlay</summary>
	public bool bAutoSpawnOnBeginPlay;
	///<summary>By default TickSchematics will be appended to the simulation&#39;s schematics. If this property is set to true the</summary>
	public bool bOverrideSchematics;
	///<summary>PostSpawnProcessors</summary>
	public TArray<UMassProcessor> PostSpawnProcessors;
	///<summary>Scale of the spawning count</summary>
	public float SpawningCountScale;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
}
