#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds cheat manager extensions to the cheat manager for each player</summary>
[CppInclude("GameFeatureAction_AddCheats.h")]
public partial class UGameFeatureAction_AddCheats : UGameFeatureAction {
	///<summary>Cheat managers to setup for the game feature plugin</summary>
	public TArray<TSoftObjectPtr<UClass>> CheatManagers;
	///<summary>bLoadCheatManagersAsync</summary>
	public bool bLoadCheatManagersAsync;
	///<summary>SpawnedCheatManagers</summary>
	public TArray<TWeakObjectPtr<UCheatManagerExtension>> SpawnedCheatManagers;
}
