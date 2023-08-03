#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAxisPositionGizmo implements a gizmo interaction where 1D parameter value is manipulated</summary>
[CppInclude("BaseGizmos/AxisPositionGizmo.h")]
public partial class UAxisPositionGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>AxisSource provides the 3D line on which the interaction happens</summary>
	public object /*AxisSource*/ AxisSource;
	///<summary>The 3D line-nearest-point is converted to a 1D coordinate along the line, and the change in value is sent to this ParameterSource</summary>
	public object /*ParameterSource*/ ParameterSource;
	///<summary>GizmoViewContext</summary>
	public UGizmoViewContext GizmoViewContext;
	///<summary>The HitTarget provides a hit-test against some 3D element (presumably a visual widget) that controls when interaction can start</summary>
	public object /*HitTarget*/ HitTarget;
	///<summary>StateTarget is notified when interaction starts and ends, so that things like undo/redo can be handled externally.</summary>
	public object /*StateTarget*/ StateTarget;
	///<summary>The mouse click behavior of the gizmo is accessible so that it can be modified to use different mouse keys.</summary>
	public UClickDragInputBehavior MouseBehavior;
	///<summary>If enabled, then the sign on the parameter delta is always &quot;increasing&quot; when moving away from the origin point, rather than just being a projection onto the axis</summary>
	public bool bEnableSignedAxis;
	///<summary>If true, we are in an active click+drag interaction, otherwise we are not</summary>
	public bool bInInteraction;
	///<summary>The values below are used in the context of a single click-drag interaction, ie if bInInteraction = true</summary>
	public FVector InteractionOrigin;
	///<summary>InteractionAxis</summary>
	public FVector InteractionAxis;
	///<summary>InteractionStartPoint</summary>
	public FVector InteractionStartPoint;
	///<summary>InteractionCurPoint</summary>
	public FVector InteractionCurPoint;
	///<summary>InteractionStartParameter</summary>
	public float InteractionStartParameter;
	///<summary>InteractionCurParameter</summary>
	public float InteractionCurParameter;
	///<summary>ParameterSign</summary>
	public float ParameterSign;
}
