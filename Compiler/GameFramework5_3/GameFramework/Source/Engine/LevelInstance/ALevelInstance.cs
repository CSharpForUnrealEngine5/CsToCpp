namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceActor.h")]
public partial class ALevelInstance : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Level LevelInstance</summary>
	public TSoftObjectPtr<UWorld> WorldAsset;
	///<summary>LevelInstanceComponent</summary>
	public ULevelInstanceComponent LevelInstanceComponent;
	///<summary>CookedWorldAsset</summary>
	public TSoftObjectPtr<UWorld> CookedWorldAsset;
	///<summary>LevelInstanceSpawnGuid</summary>
	public FGuid LevelInstanceSpawnGuid;
	///<summary>DesiredRuntimeBehavior</summary>
	public ELevelInstanceRuntimeBehavior DesiredRuntimeBehavior;
	///<summary>OnRep_LevelInstanceSpawnGuid</summary>
	public void OnRep_LevelInstanceSpawnGuid() {}
}
