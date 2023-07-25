#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpotLightGizmo.h")]
///<summary>USpotLightGizmo provides a gizmo to allow for editing spot light properties in viewport</summary>
public partial class USpotLightGizmo : UInteractiveGizmo {
// SpotLightGizmo
	public ASpotLight LightActor;
	public UWorld World;
	public USubTransformProxy TransformProxy;
	public UScalableConeGizmo OuterAngleGizmo;
	public UScalableConeGizmo InnerAngleGizmo;
	public ASpotLightGizmoActor GizmoActor;
	public UGizmoViewContext GizmoViewContext;
	public FVector DragStartWorldPosition;
	public float InteractionStartParameter;
	public bool bIsHovering;
	public bool bIsDragging;
}
