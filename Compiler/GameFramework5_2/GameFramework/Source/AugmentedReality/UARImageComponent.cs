#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARImageComponent : UARComponent {
// ARImageComponent
	public void ReceiveAdd(FARImageUpdatePayload Payload) {}
	public void ReceiveUpdate(FARImageUpdatePayload Payload) {}
	public void SetImageComponentDebugMode(EImageComponentDebugMode NewDebugMode) {}
	public void ServerUpdatePayload(FARImageUpdatePayload NewPayload) {}
	public FARImageUpdatePayload ReplicatedPayload;
}
