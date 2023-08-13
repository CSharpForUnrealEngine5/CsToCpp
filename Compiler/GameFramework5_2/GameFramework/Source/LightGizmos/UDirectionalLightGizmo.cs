namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDirectionalLightGizmo provides a gizmo to allow for editing directional light properties in viewport</summary>
[CppInclude("DirectionalLightGizmo.h")]
public partial class UDirectionalLightGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>A transform proxy of the LightActor</summary>
	public USubTransformProxy TransformProxy;
	///<summary>World</summary>
	public UWorld World;
	///<summary>The internal actor used by the light gizmo</summary>
	public ADirectionalLightGizmoActor GizmoActor;
	///<summary>Used to properly render the handle gizmo.</summary>
	public UGizmoViewContext GizmoViewContext;
	///<summary>The current target of the gizmo</summary>
	public ADirectionalLight LightActor;
	///<summary>bIsHovering</summary>
	public bool bIsHovering;
	///<summary>bIsDragging</summary>
	public bool bIsDragging;
	///<summary>Parameters used during hit testing</summary>
	public FVector DragStartWorldPosition;
	///<summary>InteractionStartPoint</summary>
	public FVector InteractionStartPoint;
	///<summary>InteractionStartParameter</summary>
	public float InteractionStartParameter;
	///<summary>HitAxis</summary>
	public FVector HitAxis;
	///<summary>RotationPlaneX</summary>
	public FVector RotationPlaneX;
	///<summary>RotationPlaneZ</summary>
	public FVector RotationPlaneZ;
	///<summary>HitComponent</summary>
	public UGizmoBaseComponent HitComponent;
	///<summary>ArrowLength</summary>
	public float ArrowLength;
}
