#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for gizmo handles</summary>
[CppInclude("VIGizmoHandle.h")]
public partial class UGizmoHandleGroup : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Gizmo material (opaque)</summary>
	public UMaterialInterface GizmoMaterial;
	///<summary>Gizmo material (translucent)</summary>
	public UMaterialInterface TranslucentGizmoMaterial;
	///<summary>All the StaticMeshes for this handle type</summary>
	public TArray<FGizmoHandle> Handles;
	///<summary>The actor transform gizmo owning this handlegroup</summary>
	public ABaseTransformGizmo OwningTransformGizmoActor;
	///<summary>DragOperationComponent</summary>
	public UViewportDragOperationComponent DragOperationComponent;
}
