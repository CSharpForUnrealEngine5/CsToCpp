#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerCategoryReplicator.h")]
public partial class AGameplayDebuggerCategoryReplicator : AActor {
// GameplayDebuggerCategoryReplicator
	public void OnRep_ReplicatedData() {}
	public APlayerController OwnerPC;
	public bool bIsEnabled;
	public FGameplayDebuggerNetPack ReplicatedData;
	public FGameplayDebuggerDebugActor DebugActor;
	public FGameplayDebuggerVisLogSync VisLogSync;
	public UGameplayDebuggerRenderingComponent RenderingComp;
	public void ServerSetEnabled(bool bEnable) {}
	public void ServerSetDebugActor(UObject Actor,bool bSelectInEditor) {}
	public void ServerSetViewPoint(FVector InViewLocation,FVector InViewDirection) {}
	public void ServerResetViewPoint() {}
	public void ServerSetCategoryEnabled(int CategoryId,bool bEnable) {}
	public void ServerSendCategoryInputEvent(int CategoryId,int HandlerId) {}
	public void ServerSendExtensionInputEvent(int ExtensionId,int HandlerId) {}
	public void ClientDataPackPacket(FGameplayDebuggerDataPackRPCParams Params) {}
}
