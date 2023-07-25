#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARFaceComponent : UARComponent {
// ARFaceComponent
	public void ReceiveAdd(FARFaceUpdatePayload Payload) {}
	public void ReceiveUpdate(FARFaceUpdatePayload Payload) {}
	public void SetFaceComponentDebugMode(EFaceComponentDebugMode NewDebugMode) {}
	public EARFaceTransformMixing TransformSetting;
	public bool bUpdateVertexNormal;
	public bool bFaceOutOfScreen;
	public void ServerUpdatePayload(FARFaceUpdatePayload NewPayload) {}
	public FARFaceUpdatePayload ReplicatedPayload;
}
