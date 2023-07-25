#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeatureAction_AddCheats.h")]
///<summary>Adds cheat manager extensions to the cheat manager for each player</summary>
public partial class UGameFeatureAction_AddCheats : UGameFeatureAction {
// GameFeatureAction_AddCheats
	public TArray<TSoftObjectPtr<UClass>> CheatManagers;
	public bool bLoadCheatManagersAsync;
	public TArray<TWeakObjectPtr<UCheatManagerExtension>> SpawnedCheatManagers;
}
