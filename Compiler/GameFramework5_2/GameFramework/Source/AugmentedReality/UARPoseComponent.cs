#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPoseComponent : UARComponent {
// ARPoseComponent
	public  void ReceiveAdd(FARPoseUpdatePayload Payload) {}
	public  void ReceiveUpdate(FARPoseUpdatePayload Payload) {}
	public static void SetPoseComponentDebugMode(EPoseComponentDebugMode NewDebugMode) {}
	public  void ServerUpdatePayload(FARPoseUpdatePayload NewPayload) {}
	public FARPoseUpdatePayload ReplicatedPayload;
}
