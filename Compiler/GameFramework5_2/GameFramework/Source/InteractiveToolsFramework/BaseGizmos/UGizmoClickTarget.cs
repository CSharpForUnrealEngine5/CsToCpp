namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoClickTarget : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>* Updates the hover state indicating whether the input device is currently hovering over the Standard gizmo.</summary>
	public virtual void UpdateHoverState(bool bHovering) {}
	///<summary>* Updates the interacting state indicating when interaction with the Standard gizmo is actively occurring,</summary>
	public virtual void UpdateInteractingState(bool bInteracting) {}
}
