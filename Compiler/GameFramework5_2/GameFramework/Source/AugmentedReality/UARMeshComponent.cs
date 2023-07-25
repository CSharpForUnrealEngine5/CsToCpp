#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARMeshComponent : UARComponent {
// ARMeshComponent
	public void ReceiveAdd(FARMeshUpdatePayload Payload) {}
	public void ReceiveUpdate(FARMeshUpdatePayload Payload) {}
	public void ServerUpdatePayload(FARMeshUpdatePayload NewPayload) {}
	public FARMeshUpdatePayload ReplicatedPayload;
}
