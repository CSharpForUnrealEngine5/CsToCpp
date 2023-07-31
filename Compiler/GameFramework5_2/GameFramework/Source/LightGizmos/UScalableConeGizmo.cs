#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScalableConeGizmo provides a cone that can be scaled (changing its angle)</summary>
[CppInclude("ScalableConeGizmo.h")]
public partial class UScalableConeGizmo : UInteractiveGizmo {
	///<summary>The maximum angle the cone can be stretched to</summary>
	public float MaxAngle;
	///<summary>The minimum angle the cone can be stretched to</summary>
	public float MinAngle;
	///<summary>The color of the cone</summary>
	public FColor ConeColor;
	///<summary>The error threshold for hit detection with the cone</summary>
	public float HitErrorThreshold;
	///<summary>The text that will be used as the transaction description for undo/redo</summary>
	public string TransactionDescription;
	///<summary>The ConeLength</summary>
	public float Length;
	///<summary>Angle</summary>
	public float Angle;
	///<summary>Whether the gizmo is being hovered over</summary>
	public bool bIsHovering;
	///<summary>Whether the gizmo is being dragged</summary>
	public bool bIsDragging;
	///<summary>ActiveTarget</summary>
	public UTransformProxy ActiveTarget;
	///<summary>Used for calculations when moving the handles</summary>
	public FVector DragStartWorldPosition;
	///<summary>The position the drag is on currently (projected onto the line it is being dragged along)</summary>
	public FVector DragCurrentPositionProjected;
	///<summary>InteractionStartPoint</summary>
	public FVector InteractionStartPoint;
	///<summary>InteractionStartParameter</summary>
	public float InteractionStartParameter;
	///<summary>HitAxis</summary>
	public FVector HitAxis;
	///<summary>RotationPlaneX</summary>
	public FVector RotationPlaneX;
	///<summary>RotationPlaneY</summary>
	public FVector RotationPlaneY;
}
