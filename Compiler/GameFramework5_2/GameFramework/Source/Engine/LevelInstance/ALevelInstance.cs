#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceActor.h")]
public partial class ALevelInstance : AActor {
	///<summary>Level LevelInstance</summary>
	public TSoftObjectPtr<UWorld> WorldAsset;
	///<summary>CookedWorldAsset</summary>
	public TSoftObjectPtr<UWorld> CookedWorldAsset;
	///<summary>LevelInstanceSpawnGuid</summary>
	public FGuid LevelInstanceSpawnGuid;
	///<summary>DesiredRuntimeBehavior</summary>
	public ELevelInstanceRuntimeBehavior DesiredRuntimeBehavior;
	///<summary>OnRep_LevelInstanceSpawnGuid</summary>
	public  void OnRep_LevelInstanceSpawnGuid() {}
}
