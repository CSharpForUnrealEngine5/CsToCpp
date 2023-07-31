#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UARFaceComponent : UARComponent {
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public  void ReceiveAdd(FARFaceUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public  void ReceiveUpdate(FARFaceUpdatePayload Payload) {}
	///<summary>SetFaceComponentDebugMode</summary>
	public static void SetFaceComponentDebugMode(EFaceComponentDebugMode NewDebugMode) {}
	///<summary>Determines how the transform from tracking data and the component&#39;s transform are mixed together.</summary>
	public EARFaceTransformMixing TransformSetting;
	///<summary>Whether to automatically update the vertex normal when the mesh is updated.</summary>
	public bool bUpdateVertexNormal;
	///<summary>Whether the mesh should be rotated so that it&#39;s facing out of the screen.</summary>
	public bool bFaceOutOfScreen;
	///<summary>ServerUpdatePayload</summary>
	public  void ServerUpdatePayload(FARFaceUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FARFaceUpdatePayload ReplicatedPayload;
}
