#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/ScalableSphereGizmo.h")]
///<summary>UScalableSphereGizmo provides a sphere that can be scaled in all directions by dragging</summary>
public partial class UScalableSphereGizmo : UInteractiveGizmo {
// ScalableSphereGizmo
	public float HitErrorThreshold;
	public string TransactionDescription;
	public float Radius;
	public bool bIsHovering;
	public bool bIsDragging;
	public UTransformProxy ActiveTarget;
	public FVector ActiveAxis;
	public FVector DragStartWorldPosition;
	public FVector DragCurrentPositionProjected;
	public float InteractionStartParameter;
}
