namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARImageComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public void ReceiveAdd(FARImageUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public void ReceiveUpdate(FARImageUpdatePayload Payload) {}
	///<summary>SetImageComponentDebugMode</summary>
	public static void SetImageComponentDebugMode(EImageComponentDebugMode NewDebugMode) {}
	///<summary>ServerUpdatePayload</summary>
	public void ServerUpdatePayload(FARImageUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARImageUpdatePayload ReplicatedPayload;
}
