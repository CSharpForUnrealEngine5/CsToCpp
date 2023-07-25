#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/PlanePositionGizmo.h")]
///<summary>UPlanePositionGizmo implements a gizmo interaction where 2D parameter value is manipulated</summary>
public partial class UPlanePositionGizmo : UInteractiveGizmo {
// PlanePositionGizmo
	public object /*AxisSource*/ AxisSource;
	public object /*ParameterSource*/ ParameterSource;
	public object /*HitTarget*/ HitTarget;
	public object /*StateTarget*/ StateTarget;
	public UClickDragInputBehavior MouseBehavior;
	public bool bEnableSignedAxis;
	public bool bFlipX;
	public bool bFlipY;
	public bool bInInteraction;
	public FVector InteractionOrigin;
	public FVector InteractionNormal;
	public FVector InteractionAxisX;
	public FVector InteractionAxisY;
	public FVector InteractionStartPoint;
	public FVector InteractionCurPoint;
	public FVector2D InteractionStartParameter;
	public FVector2D InteractionCurParameter;
	public FVector2D ParameterSigns;
}
