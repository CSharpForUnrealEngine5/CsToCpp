#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneActorComponent.h")]
public partial class UContextualAnimSceneActorComponent : UPrimitiveComponent {
// ContextualAnimSceneActorComponent
	public FContextualAnimSceneActorCompDelegate OnJoinedSceneDelegate;
	public FContextualAnimSceneActorCompDelegate OnLeftSceneDelegate;
	public UContextualAnimSceneAsset SceneAsset;
	public bool bEnableDebug;
	public void OnJoinedScene(FContextualAnimSceneBindings InBindings) {}
	public void OnLeftScene() {}
	public TArray<FContextualAnimIKTarget> GetIKTargets() { return default; }
	public FContextualAnimIKTarget GetIKTargetByGoalName(string GoalName) { return default; }
	public bool StartContextualAnimScene(FContextualAnimSceneBindings InBindings) { return default; }
	public FContextualAnimSceneBindings RepBindings;
	public FContextualAnimSceneBindings Bindings;
	public TArray<FContextualAnimIKTarget> IKTargets;
	public void OnTickPose(UObject SkinnedMeshComponent,float DeltaTime,bool bNeedsValidRootMotion) {}
	public void OnRep_Bindings(FContextualAnimSceneBindings LastRepBindings) {}
	public void OnMontageBlendingOut(UObject Montage,bool bInterrupted) {}
	public void ServerStartContextualAnimScene(FContextualAnimSceneBindings InBindings) {}
	public void ServerEarlyOutContextualAnimScene() {}
}
