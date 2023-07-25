#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerPlayerManager.h")]
public partial class AGameplayDebuggerPlayerManager : AActor {
// GameplayDebuggerPlayerManager
	public TArray<FGameplayDebuggerPlayerData> PlayerData;
	public TArray<AGameplayDebuggerCategoryReplicator> PendingRegistrations;
	public FGameplayDebuggerPlayerData EditorWorldData;
}
