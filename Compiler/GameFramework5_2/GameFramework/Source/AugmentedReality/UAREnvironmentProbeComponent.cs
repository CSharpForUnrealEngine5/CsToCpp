#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UAREnvironmentProbeComponent : UARComponent {
// AREnvironmentProbeComponent
	public void ReceiveAdd(FAREnvironmentProbeUpdatePayload Payload) {}
	public void ReceiveUpdate(FAREnvironmentProbeUpdatePayload Payload) {}
	public void ServerUpdatePayload(FAREnvironmentProbeUpdatePayload NewPayload) {}
	public FAREnvironmentProbeUpdatePayload ReplicatedPayload;
}
