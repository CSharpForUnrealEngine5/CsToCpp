namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Instance of a contextual animation scene</summary>
[CppInclude("ContextualAnimSceneInstance.h")]
public partial class UContextualAnimSceneInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Delegate to notify once the scene play time reaches the duration defined by the longest played montage of the selected section.</summary>
	public FOnContextualAnimSceneEnded OnSectionEndTimeReached;
	///<summary>Delegate to notify external objects when this is scene is completed after all montages played by the scene section blended out.</summary>
	public FOnContextualAnimSceneEnded OnSceneEnded;
	///<summary>Delegate to notify external objects when an actor join</summary>
	public FOnContextualAnimSceneActorJoined OnActorJoined;
	///<summary>Delegate to notify external objects when an actor leave</summary>
	public FOnContextualAnimSceneActorLeft OnActorLeft;
	///<summary>Delegate to notify external objects when an animation hits a &#39;PlayMontageNotify&#39; or &#39;PlayMontageNotifyWindow&#39; begin</summary>
	public FOnContextualAnimSceneNotify OnNotifyBegin;
	///<summary>Delegate to notify external objects when an animation hits a &#39;PlayMontageNotify&#39; or &#39;PlayMontageNotifyWindow&#39; end</summary>
	public FOnContextualAnimSceneNotify OnNotifyEnd;
	///<summary>GetActorByRole</summary>
	public AActor GetActorByRole(FName Role) { return default; }
	///<summary>OnMontageBlendingOut</summary>
	public void OnMontageBlendingOut(UAnimMontage Montage,bool bInterrupted) {}
	///<summary>OnNotifyBeginReceived</summary>
	public void OnNotifyBeginReceived(FName NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	///<summary>OnNotifyEndReceived</summary>
	public void OnNotifyEndReceived(FName NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	///<summary>Scene asset this instance was created from</summary>
	public UContextualAnimSceneAsset SceneAsset;
	///<summary>Bindings</summary>
	public FContextualAnimSceneBindings Bindings;
}
