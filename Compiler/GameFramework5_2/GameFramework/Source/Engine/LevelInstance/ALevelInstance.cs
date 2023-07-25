#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceActor.h")]
public partial class ALevelInstance : AActor {
// LevelInstance
	public TSoftObjectPtr<UWorld> WorldAsset;
	public TSoftObjectPtr<UWorld> CookedWorldAsset;
	public FGuid LevelInstanceSpawnGuid;
	public ELevelInstanceRuntimeBehavior DesiredRuntimeBehavior;
	public void OnRep_LevelInstanceSpawnGuid() {}
}
