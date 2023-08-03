#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPoseComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public  void ReceiveAdd(FARPoseUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public  void ReceiveUpdate(FARPoseUpdatePayload Payload) {}
	///<summary>SetPoseComponentDebugMode</summary>
	public static void SetPoseComponentDebugMode(EPoseComponentDebugMode NewDebugMode) {}
	///<summary>ServerUpdatePayload</summary>
	public  void ServerUpdatePayload(FARPoseUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARPoseUpdatePayload ReplicatedPayload;
}
