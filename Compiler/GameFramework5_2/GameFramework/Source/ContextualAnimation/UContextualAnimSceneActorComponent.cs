namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneActorComponent.h")]
public partial class UContextualAnimSceneActorComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event that happens when the actor owner of this component joins an scene</summary>
	public FContextualAnimSceneActorCompDelegate OnJoinedSceneDelegate;
	///<summary>Event that happens when the actor owner of this component leave an scene</summary>
	public FContextualAnimSceneActorCompDelegate OnLeftSceneDelegate;
	///<summary>SceneAsset</summary>
	public UContextualAnimSceneAsset SceneAsset;
	///<summary>bEnableDebug</summary>
	public bool bEnableDebug;
	///<summary>Called when the actor owner of this component joins an scene</summary>
	public void OnJoinedScene(FContextualAnimSceneBindings InBindings) {}
	///<summary>Called from the scene instance when the actor owner of this component leave an scene</summary>
	public void OnLeftScene() {}
	///<summary>GetIKTargets</summary>
	public TArray<FContextualAnimIKTarget> GetIKTargets() { return default; }
	///<summary>GetIKTargetByGoalName</summary>
	public FContextualAnimIKTarget GetIKTargetByGoalName(string GoalName) { return default; }
	///<summary>StartContextualAnimScene</summary>
	public bool StartContextualAnimScene(FContextualAnimSceneBindings InBindings) { return default; }
	///<summary>Replicated copy of the bindings so we can start the action on simulated proxies</summary>
	public FContextualAnimSceneBindings RepBindings;
	///<summary>Bindings for the interaction we are currently playing.</summary>
	public FContextualAnimSceneBindings Bindings;
	///<summary>List of IKTarget for this frame</summary>
	public TArray<FContextualAnimIKTarget> IKTargets;
	///<summary>Event called right before owner&#39;s mesh ticks the pose when we are in a scene instance and IK Targets are required.</summary>
	public void OnTickPose(USkinnedMeshComponent SkinnedMeshComponent,float DeltaTime,bool bNeedsValidRootMotion) {}
	///<summary>OnRep_Bindings</summary>
	public void OnRep_Bindings(FContextualAnimSceneBindings LastRepBindings) {}
	///<summary>OnMontageBlendingOut</summary>
	public void OnMontageBlendingOut(UAnimMontage Montage,bool bInterrupted) {}
	///<summary>ServerStartContextualAnimScene</summary>
	public void ServerStartContextualAnimScene(FContextualAnimSceneBindings InBindings) {}
	///<summary>ServerEarlyOutContextualAnimScene</summary>
	public void ServerEarlyOutContextualAnimScene() {}
}
