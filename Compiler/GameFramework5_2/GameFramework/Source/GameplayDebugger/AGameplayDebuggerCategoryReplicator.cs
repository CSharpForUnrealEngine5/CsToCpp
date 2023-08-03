#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerCategoryReplicator.h")]
public partial class AGameplayDebuggerCategoryReplicator : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>OnRep_ReplicatedData</summary>
	public  void OnRep_ReplicatedData() {}
	///<summary>OwnerPC</summary>
	public APlayerController OwnerPC;
	///<summary>bIsEnabled</summary>
	public bool bIsEnabled;
	///<summary>ReplicatedData</summary>
	public FGameplayDebuggerNetPack ReplicatedData;
	///<summary>DebugActor</summary>
	public FGameplayDebuggerDebugActor DebugActor;
	///<summary>VisLogSync</summary>
	public FGameplayDebuggerVisLogSync VisLogSync;
	///<summary>rendering component needs to attached to some actor, and this is as good as any</summary>
	public UGameplayDebuggerRenderingComponent RenderingComp;
	///<summary>ServerSetEnabled</summary>
	public  void ServerSetEnabled(bool bEnable) {}
	///<summary>ServerSetDebugActor</summary>
	public  void ServerSetDebugActor(AActor Actor,bool bSelectInEditor) {}
	///<summary>ServerSetViewPoint</summary>
	public  void ServerSetViewPoint(FVector InViewLocation,FVector InViewDirection) {}
	///<summary>ServerResetViewPoint</summary>
	public  void ServerResetViewPoint() {}
	///<summary>ServerSetCategoryEnabled</summary>
	public  void ServerSetCategoryEnabled(int CategoryId,bool bEnable) {}
	///<summary>helper function for replicating input for category handlers</summary>
	public  void ServerSendCategoryInputEvent(int CategoryId,int HandlerId) {}
	///<summary>helper function for replicating input for extension handlers</summary>
	public  void ServerSendExtensionInputEvent(int ExtensionId,int HandlerId) {}
	///<summary>helper function for optionally sending DataPackPackets as RPC&#39;s</summary>
	public  void ClientDataPackPacket(FGameplayDebuggerDataPackRPCParams Params) {}
}
