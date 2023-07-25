#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSpawner.h")]
///<summary>A spawner you can put on a map and configure it to spawn different things</summary>
public partial class AMassSpawner : AActor {
// MassSpawner
	public void DEBUG_Spawn() {}
	public void DEBUG_Clear() {}
	public void DoSpawning() {}
	public void DoDespawning() {}
	public void ClearTemplates() {}
	public void UnloadConfig() {}
	public void ScaleSpawningCount(float Scale) {}
	public int GetCount() { return default; }
	public float GetSpawningCountScale() { return default; }
	public FMassSpawnerOnSpawningFinishedEvent OnSpawningFinishedEvent;
	public FMassSpawnerOnDespawningFinishedEvent OnDespawningFinishedEvent;
	public int Count;
	public TArray<FMassSpawnedEntityType> EntityTypes;
	public TArray<FMassSpawnDataGenerator> SpawnDataGenerators;
	public bool bAutoSpawnOnBeginPlay;
	public bool bOverrideSchematics;
	public TArray<UMassProcessor> PostSpawnProcessors;
	public float SpawningCountScale;
	public UBillboardComponent SpriteComponent;
}
