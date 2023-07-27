#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARQRCodeComponent : UARComponent {
// ARQRCodeComponent
	public  void ReceiveAdd(FARQRCodeUpdatePayload Payload) {}
	public  void ReceiveUpdate(FARQRCodeUpdatePayload Payload) {}
	public static void SetQRCodeComponentDebugMode(EQRCodeComponentDebugMode NewDebugMode) {}
	public  void ServerUpdatePayload(FARQRCodeUpdatePayload NewPayload) {}
	public FARQRCodeUpdatePayload ReplicatedPayload;
}
