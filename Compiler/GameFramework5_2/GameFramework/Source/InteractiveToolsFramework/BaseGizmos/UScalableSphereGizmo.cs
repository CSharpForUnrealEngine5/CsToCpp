namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScalableSphereGizmo provides a sphere that can be scaled in all directions by dragging</summary>
[CppInclude("BaseGizmos/ScalableSphereGizmo.h")]
public partial class UScalableSphereGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>The error threshold for hit detection with the sphere</summary>
	public float HitErrorThreshold;
	///<summary>The text that will be used as the transaction description for undo/redo</summary>
	public FText TransactionDescription;
	///<summary>The radius of the sphere</summary>
	public float Radius;
	///<summary>Whether the sphere is currently being hovered over</summary>
	public bool bIsHovering;
	///<summary>Whether the sphere is currently being dragged</summary>
	public bool bIsDragging;
	///<summary>ActiveTarget</summary>
	public UTransformProxy ActiveTarget;
	///<summary>The current axis that is being dragged along</summary>
	public FVector ActiveAxis;
	///<summary>The position the drag was started on</summary>
	public FVector DragStartWorldPosition;
	///<summary>The position the drag is on currently (projected onto the line it is being dragged along)</summary>
	public FVector DragCurrentPositionProjected;
	///<summary>The initial parameter along the drag axist</summary>
	public float InteractionStartParameter;
}
