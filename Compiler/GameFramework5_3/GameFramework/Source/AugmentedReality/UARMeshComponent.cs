namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARMeshComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public void ReceiveAdd(FARMeshUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public void ReceiveUpdate(FARMeshUpdatePayload Payload) {}
	///<summary>ServerUpdatePayload</summary>
	public void ServerUpdatePayload(FARMeshUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARMeshUpdatePayload ReplicatedPayload;
}
