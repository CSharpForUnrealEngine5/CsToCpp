namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoClickMultiTarget : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>* Updates the hover state of the specified gizmo part, indicating whether the input device is currently hovering</summary>
	public virtual void UpdateHoverState(bool bHovering,uint InPartIdentifier) {}
	///<summary>* Updates the interacting state of the specified gizmo part, indicating when interaction with the</summary>
	public virtual void UpdateInteractingState(bool bInteracting,uint InPartIdentifier) {}
	///<summary>* Updates the hittable state of the specified gizmo part.</summary>
	public virtual void UpdateHittableState(bool bHittable,uint InPartIdentifier) {}
}
