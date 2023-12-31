namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerLocalController.h")]
public partial class UGameplayDebuggerLocalController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CachedReplicator</summary>
	public AGameplayDebuggerCategoryReplicator CachedReplicator;
	///<summary>CachedPlayerManager</summary>
	public AGameplayDebuggerPlayerManager CachedPlayerManager;
	///<summary>DebugActorCandidate</summary>
	public AActor DebugActorCandidate;
	///<summary>HUDFont</summary>
	public UFont HUDFont;
}
