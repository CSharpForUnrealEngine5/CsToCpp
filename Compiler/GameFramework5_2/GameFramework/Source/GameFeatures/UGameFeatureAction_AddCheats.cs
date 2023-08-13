namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds cheat manager extensions to the cheat manager for each player</summary>
[CppInclude("GameFeatureAction_AddCheats.h")]
public partial class UGameFeatureAction_AddCheats : UGameFeatureAction {
	public static UClass StaticClass() {return default;}
	///<summary>Cheat managers to setup for the game feature plugin</summary>
	public TArray<TSoftObjectPtr<UClass>> CheatManagers;
	///<summary>bLoadCheatManagersAsync</summary>
	public bool bLoadCheatManagersAsync;
	///<summary>SpawnedCheatManagers</summary>
	public TArray<TWeakObjectPtr<UCheatManagerExtension>> SpawnedCheatManagers;
}
