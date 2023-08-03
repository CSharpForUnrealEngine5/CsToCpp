#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoClickTarget : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>* Updates the hover state indicating whether the input device is currently hovering over the Standard gizmo.</summary>
	public  void UpdateHoverState(bool bHovering) {}
	///<summary>* Updates the interacting state indicating when interaction with the Standard gizmo is actively occurring,</summary>
	public  void UpdateInteractingState(bool bInteracting) {}
}
