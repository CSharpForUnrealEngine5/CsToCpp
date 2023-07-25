#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPlaneComponent : UARComponent {
// ARPlaneComponent
	public void ReceiveAdd(FARPlaneUpdatePayload Payload) {}
	public void ReceiveUpdate(FARPlaneUpdatePayload Payload) {}
	public void SetPlaneComponentDebugMode(EPlaneComponentDebugMode NewDebugMode) {}
	public void SetObjectClassificationDebugColors(TMap<EARObjectClassification,FLinearColor> InColors) {}
	public TMap<EARObjectClassification,FLinearColor> GetObjectClassificationDebugColors() { return default; }
	public void ServerUpdatePayload(FARPlaneUpdatePayload NewPayload) {}
	public FARPlaneUpdatePayload ReplicatedPayload;
}
