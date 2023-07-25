#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Selection/UVEditorMeshSelectionMechanic.h")]
///<summary>Mechanic for selecting elements of a dynamic mesh in the UV editor. Interacts</summary>
public partial class UUVEditorMeshSelectionMechanic : UInteractionMechanic {
// UVEditorMeshSelectionMechanic
	public UUVToolSelectionAPI SelectionAPI;
	public UUVToolViewportButtonsAPI ViewportButtonsAPI;
	public UUVToolEmitChangeAPI EmitChangeAPI;
	public UUVToolLivePreviewAPI LivePreviewAPI;
	public ULocalSingleClickInputBehavior UnwrapClickTargetRouter;
	public ULocalSingleClickInputBehavior LivePreviewClickTargetRouter;
	public ULocalMouseHoverBehavior UnwrapHoverBehaviorTargetRouter;
	public ULocalMouseHoverBehavior LivePreviewHoverBehaviorTargetRouter;
	public URectangleMarqueeMechanic MarqueeMechanic;
	public URectangleMarqueeMechanic LivePreviewMarqueeMechanic;
	public UMaterialInstanceDynamic HoverTriangleSetMaterial;
	public APreviewGeometryActor HoverGeometryActor;
	public UInputBehaviorSet LivePreviewBehaviorSet;
	public ULocalInputBehaviorSource LivePreviewBehaviorSource;
	public APreviewGeometryActor LivePreviewHoverGeometryActor;
}
