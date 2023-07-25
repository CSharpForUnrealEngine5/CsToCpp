#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/AxisAngleGizmo.h")]
public partial class UAxisAngleGizmo : UInteractiveGizmo {
// AxisAngleGizmo
	public object /*AxisSource*/ AxisSource;
	public object /*AngleSource*/ AngleSource;
	public object /*HitTarget*/ HitTarget;
	public object /*StateTarget*/ StateTarget;
	public UClickDragInputBehavior MouseBehavior;
	public bool bInInteraction;
	public FVector RotationOrigin;
	public FVector RotationAxis;
	public FVector RotationPlaneX;
	public FVector RotationPlaneY;
	public FVector InteractionStartPoint;
	public FVector InteractionCurPoint;
	public float InteractionStartAngle;
	public float InteractionCurAngle;
}
