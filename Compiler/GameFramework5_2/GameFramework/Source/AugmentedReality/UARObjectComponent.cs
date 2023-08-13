namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARObjectComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public void ReceiveAdd(FARObjectUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public void ReceiveUpdate(FARObjectUpdatePayload Payload) {}
	///<summary>ServerUpdatePayload</summary>
	public void ServerUpdatePayload(FARObjectUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARObjectUpdatePayload ReplicatedPayload;
}
