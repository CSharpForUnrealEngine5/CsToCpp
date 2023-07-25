#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScalableConeGizmo.h")]
///<summary>UScalableConeGizmo provides a cone that can be scaled (changing its angle)</summary>
public partial class UScalableConeGizmo : UInteractiveGizmo {
// ScalableConeGizmo
	public float MaxAngle;
	public float MinAngle;
	public FColor ConeColor;
	public float HitErrorThreshold;
	public string TransactionDescription;
	public float Length;
	public float Angle;
	public bool bIsHovering;
	public bool bIsDragging;
	public UTransformProxy ActiveTarget;
	public FVector DragStartWorldPosition;
	public FVector DragCurrentPositionProjected;
	public FVector InteractionStartPoint;
	public float InteractionStartParameter;
	public FVector HitAxis;
	public FVector RotationPlaneX;
	public FVector RotationPlaneY;
}
