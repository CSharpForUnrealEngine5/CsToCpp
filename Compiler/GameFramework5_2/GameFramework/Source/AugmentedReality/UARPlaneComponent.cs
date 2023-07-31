#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARPlaneComponent : UARComponent {
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public  void ReceiveAdd(FARPlaneUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public  void ReceiveUpdate(FARPlaneUpdatePayload Payload) {}
	///<summary>SetPlaneComponentDebugMode</summary>
	public static void SetPlaneComponentDebugMode(EPlaneComponentDebugMode NewDebugMode) {}
	///<summary>SetObjectClassificationDebugColors</summary>
	public static void SetObjectClassificationDebugColors(TMap<EARObjectClassification,FLinearColor> InColors) {}
	///<summary>GetObjectClassificationDebugColors</summary>
	public static TMap<EARObjectClassification,FLinearColor> GetObjectClassificationDebugColors() { return default; }
	///<summary>ServerUpdatePayload</summary>
	public  void ServerUpdatePayload(FARPlaneUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARPlaneUpdatePayload ReplicatedPayload;
}
