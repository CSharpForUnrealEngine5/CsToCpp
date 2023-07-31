#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USpotLightGizmo provides a gizmo to allow for editing spot light properties in viewport</summary>
[CppInclude("SpotLightGizmo.h")]
public partial class USpotLightGizmo : UInteractiveGizmo {
	///<summary>The current target light the gizmo is attached to</summary>
	public ASpotLight LightActor;
	///<summary>World</summary>
	public UWorld World;
	///<summary>A transform proxy to use with other gizmos</summary>
	public USubTransformProxy TransformProxy;
	///<summary>The gizmo to change the outer angle of the spotlight</summary>
	public UScalableConeGizmo OuterAngleGizmo;
	///<summary>The gizmo to change the inner angle of the spotlight</summary>
	public UScalableConeGizmo InnerAngleGizmo;
	///<summary>The internal gizmo actor that is used by the gizmo</summary>
	public ASpotLightGizmoActor GizmoActor;
	///<summary>Used to properly render the handle gizmo.</summary>
	public UGizmoViewContext GizmoViewContext;
	///<summary>DragStartWorldPosition</summary>
	public FVector DragStartWorldPosition;
	///<summary>InteractionStartParameter</summary>
	public float InteractionStartParameter;
	///<summary>bIsHovering</summary>
	public bool bIsHovering;
	///<summary>bIsDragging</summary>
	public bool bIsDragging;
}
