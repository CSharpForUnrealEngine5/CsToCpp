#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPlaneComponent : UARComponent {
// ARPlaneComponent
	public  void ReceiveAdd(FARPlaneUpdatePayload Payload) {}
	public  void ReceiveUpdate(FARPlaneUpdatePayload Payload) {}
	public static void SetPlaneComponentDebugMode(EPlaneComponentDebugMode NewDebugMode) {}
	public static void SetObjectClassificationDebugColors(TMap<EARObjectClassification,FLinearColor> InColors) {}
	public static TMap<EARObjectClassification,FLinearColor> GetObjectClassificationDebugColors() { return default; }
	public  void ServerUpdatePayload(FARPlaneUpdatePayload NewPayload) {}
	public FARPlaneUpdatePayload ReplicatedPayload;
}
