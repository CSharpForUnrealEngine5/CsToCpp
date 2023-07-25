#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/AxisPositionGizmo.h")]
///<summary>UAxisPositionGizmo implements a gizmo interaction where 1D parameter value is manipulated</summary>
public partial class UAxisPositionGizmo : UInteractiveGizmo {
// AxisPositionGizmo
	public object /*AxisSource*/ AxisSource;
	public object /*ParameterSource*/ ParameterSource;
	public UGizmoViewContext GizmoViewContext;
	public object /*HitTarget*/ HitTarget;
	public object /*StateTarget*/ StateTarget;
	public UClickDragInputBehavior MouseBehavior;
	public bool bEnableSignedAxis;
	public bool bInInteraction;
	public FVector InteractionOrigin;
	public FVector InteractionAxis;
	public FVector InteractionStartPoint;
	public FVector InteractionCurPoint;
	public float InteractionStartParameter;
	public float InteractionCurParameter;
	public float ParameterSign;
}
