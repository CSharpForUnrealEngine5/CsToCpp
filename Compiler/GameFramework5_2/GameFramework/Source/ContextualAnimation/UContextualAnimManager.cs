#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimManager.h")]
public partial class UContextualAnimManager : UObject {
// ContextualAnimManager
	public bool TryStopSceneWithActor(UObject Actor) { return default; }
	public bool IsActorInAnyScene(UObject Actor) { return default; }
	public UObject GetSceneWithActor(UObject Actor) { return default; }
	public UObject GetContextualAnimManager(UObject WorldContextObject) { return default; }
	public UObject BP_TryStartScene(UObject SceneAsset,FContextualAnimStartSceneParams Params) { return default; }
	public TSet<UContextualAnimSceneActorComponent> SceneActorCompContainer;
	public TArray<UContextualAnimSceneInstance> Instances;
	public void OnSceneInstanceEnded(UObject SceneInstance) {}
}
