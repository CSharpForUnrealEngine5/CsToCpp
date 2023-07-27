#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARGeoAnchorComponent : UARComponent {
// ARGeoAnchorComponent
	public static void SetGeoAnchorComponentDebugMode(EGeoAnchorComponentDebugMode NewDebugMode) {}
	public  void ReceiveAdd(FARGeoAnchorUpdatePayload Payload) {}
	public  void ReceiveUpdate(FARGeoAnchorUpdatePayload Payload) {}
	public  void ServerUpdatePayload(FARGeoAnchorUpdatePayload NewPayload) {}
	public FARGeoAnchorUpdatePayload ReplicatedPayload;
}
