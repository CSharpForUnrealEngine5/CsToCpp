#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARGeoAnchorComponent : UARComponent {
	///<summary>SetGeoAnchorComponentDebugMode</summary>
	public static void SetGeoAnchorComponentDebugMode(EGeoAnchorComponentDebugMode NewDebugMode) {}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public  void ReceiveAdd(FARGeoAnchorUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public  void ReceiveUpdate(FARGeoAnchorUpdatePayload Payload) {}
	///<summary>ServerUpdatePayload</summary>
	public  void ServerUpdatePayload(FARGeoAnchorUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARGeoAnchorUpdatePayload ReplicatedPayload;
}
