#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VIGizmoHandle.h")]
///<summary>Base class for gizmo handles</summary>
public partial class UGizmoHandleGroup : USceneComponent {
// GizmoHandleGroup
	public UMaterialInterface GizmoMaterial;
	public UMaterialInterface TranslucentGizmoMaterial;
	public TArray<FGizmoHandle> Handles;
	public ABaseTransformGizmo OwningTransformGizmoActor;
	public UViewportDragOperationComponent DragOperationComponent;
}
