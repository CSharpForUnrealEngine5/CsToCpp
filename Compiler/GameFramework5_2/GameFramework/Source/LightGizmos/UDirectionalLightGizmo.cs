#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectionalLightGizmo.h")]
///<summary>UDirectionalLightGizmo provides a gizmo to allow for editing directional light properties in viewport</summary>
public partial class UDirectionalLightGizmo : UInteractiveGizmo {
// DirectionalLightGizmo
	public USubTransformProxy TransformProxy;
	public UWorld World;
	public ADirectionalLightGizmoActor GizmoActor;
	public UGizmoViewContext GizmoViewContext;
	public ADirectionalLight LightActor;
	public bool bIsHovering;
	public bool bIsDragging;
	public FVector DragStartWorldPosition;
	public FVector InteractionStartPoint;
	public float InteractionStartParameter;
	public FVector HitAxis;
	public FVector RotationPlaneX;
	public FVector RotationPlaneZ;
	public UGizmoBaseComponent HitComponent;
	public float ArrowLength;
}
