namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimManager.h")]
public partial class UContextualAnimManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TryStopSceneWithActor</summary>
	public bool TryStopSceneWithActor(AActor Actor) { return default; }
	///<summary>IsActorInAnyScene</summary>
	public bool IsActorInAnyScene(AActor Actor) { return default; }
	///<summary>GetSceneWithActor</summary>
	public UContextualAnimSceneInstance GetSceneWithActor(AActor Actor) { return default; }
	///<summary>GetContextualAnimManager</summary>
	public static UContextualAnimManager GetContextualAnimManager(UObject WorldContextObject) { return default; }
	///<summary>Attempts to start an scene instance with the supplied actors using the first valid set based on selection criteria</summary>
	public UContextualAnimSceneInstance BP_TryStartScene(UContextualAnimSceneAsset SceneAsset,FContextualAnimStartSceneParams Params) { return default; }
	///<summary>Container for all SceneActorComps in the world</summary>
	public TSet<UContextualAnimSceneActorComponent> SceneActorCompContainer;
	///<summary>Instances</summary>
	public TArray<UContextualAnimSceneInstance> Instances;
	///<summary>OnSceneInstanceEnded</summary>
	public void OnSceneInstanceEnded(UContextualAnimSceneInstance SceneInstance) {}
}
