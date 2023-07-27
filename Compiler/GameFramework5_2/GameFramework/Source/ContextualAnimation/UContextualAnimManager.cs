#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimManager.h")]
public partial class UContextualAnimManager : UObject {
// ContextualAnimManager
	public  bool TryStopSceneWithActor(AActor Actor) { return default; }
	public  bool IsActorInAnyScene(AActor Actor) { return default; }
	public  UContextualAnimSceneInstance GetSceneWithActor(AActor Actor) { return default; }
	public static UContextualAnimManager GetContextualAnimManager(UObject WorldContextObject) { return default; }
	public  UContextualAnimSceneInstance BP_TryStartScene(UContextualAnimSceneAsset SceneAsset,FContextualAnimStartSceneParams Params) { return default; }
	public TSet<UContextualAnimSceneActorComponent> SceneActorCompContainer;
	public TArray<UContextualAnimSceneInstance> Instances;
	public  void OnSceneInstanceEnded(UContextualAnimSceneInstance SceneInstance) {}
}
