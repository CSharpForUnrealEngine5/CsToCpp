#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARObjectComponent : UARComponent {
// ARObjectComponent
	public void ReceiveAdd(FARObjectUpdatePayload Payload) {}
	public void ReceiveUpdate(FARObjectUpdatePayload Payload) {}
	public void ServerUpdatePayload(FARObjectUpdatePayload NewPayload) {}
	public FARObjectUpdatePayload ReplicatedPayload;
}
