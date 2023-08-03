#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARQRCodeComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public  void ReceiveAdd(FARQRCodeUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public  void ReceiveUpdate(FARQRCodeUpdatePayload Payload) {}
	///<summary>SetQRCodeComponentDebugMode</summary>
	public static void SetQRCodeComponentDebugMode(EQRCodeComponentDebugMode NewDebugMode) {}
	///<summary>ServerUpdatePayload</summary>
	public  void ServerUpdatePayload(FARQRCodeUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARQRCodeUpdatePayload ReplicatedPayload;
}
