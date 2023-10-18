namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPointComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public void ReceiveAdd(FARPointUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public void ReceiveUpdate(FARPointUpdatePayload Payload) {}
	///<summary>ServerUpdatePayload</summary>
	public void ServerUpdatePayload(FARPointUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARPointUpdatePayload ReplicatedPayload;
}
