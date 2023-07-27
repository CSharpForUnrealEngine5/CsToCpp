#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneInstance.h")]
///<summary>Instance of a contextual animation scene</summary>
public partial class UContextualAnimSceneInstance : UObject {
// ContextualAnimSceneInstance
	public FOnContextualAnimSceneEnded OnSectionEndTimeReached;
	public FOnContextualAnimSceneEnded OnSceneEnded;
	public FOnContextualAnimSceneActorJoined OnActorJoined;
	public FOnContextualAnimSceneActorLeft OnActorLeft;
	public FOnContextualAnimSceneNotify OnNotifyBegin;
	public FOnContextualAnimSceneNotify OnNotifyEnd;
	public  AActor GetActorByRole(string Role) { return default; }
	public  void OnMontageBlendingOut(UAnimMontage Montage,bool bInterrupted) {}
	public  void OnNotifyBeginReceived(string NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	public  void OnNotifyEndReceived(string NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	public UContextualAnimSceneAsset SceneAsset;
	public FContextualAnimSceneBindings Bindings;
}
