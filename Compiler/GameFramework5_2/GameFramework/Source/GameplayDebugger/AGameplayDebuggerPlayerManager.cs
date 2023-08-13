namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerPlayerManager.h")]
public partial class AGameplayDebuggerPlayerManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PlayerData</summary>
	public TArray<FGameplayDebuggerPlayerData> PlayerData;
	///<summary>PendingRegistrations</summary>
	public TArray<AGameplayDebuggerCategoryReplicator> PendingRegistrations;
	///<summary>EditorWorldData</summary>
	public FGameplayDebuggerPlayerData EditorWorldData;
}
