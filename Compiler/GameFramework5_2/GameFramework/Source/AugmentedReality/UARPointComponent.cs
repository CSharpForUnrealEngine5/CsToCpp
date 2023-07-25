#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPointComponent : UARComponent {
// ARPointComponent
	public void ReceiveAdd(FARPointUpdatePayload Payload) {}
	public void ReceiveUpdate(FARPointUpdatePayload Payload) {}
	public void ServerUpdatePayload(FARPointUpdatePayload NewPayload) {}
	public FARPointUpdatePayload ReplicatedPayload;
}
