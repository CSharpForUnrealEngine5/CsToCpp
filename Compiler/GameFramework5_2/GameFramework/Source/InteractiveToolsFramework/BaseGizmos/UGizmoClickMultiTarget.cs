#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoClickMultiTarget : UInterface {
	///<summary>* Updates the hover state of the specified gizmo part, indicating whether the input device is currently hovering</summary>
	public  void UpdateHoverState(bool bHovering,uint InPartIdentifier) {}
	///<summary>* Updates the interacting state of the specified gizmo part, indicating when interaction with the</summary>
	public  void UpdateInteractingState(bool bInteracting,uint InPartIdentifier) {}
	///<summary>* Updates the hittable state of the specified gizmo part.</summary>
	public  void UpdateHittableState(bool bHittable,uint InPartIdentifier) {}
}
