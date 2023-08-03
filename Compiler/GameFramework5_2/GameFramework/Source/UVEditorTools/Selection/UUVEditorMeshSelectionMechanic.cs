#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mechanic for selecting elements of a dynamic mesh in the UV editor. Interacts</summary>
[CppInclude("Selection/UVEditorMeshSelectionMechanic.h")]
public partial class UUVEditorMeshSelectionMechanic : UInteractionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionAPI</summary>
	public UUVToolSelectionAPI SelectionAPI;
	///<summary>ViewportButtonsAPI</summary>
	public UUVToolViewportButtonsAPI ViewportButtonsAPI;
	///<summary>EmitChangeAPI</summary>
	public UUVToolEmitChangeAPI EmitChangeAPI;
	///<summary>LivePreviewAPI</summary>
	public UUVToolLivePreviewAPI LivePreviewAPI;
	///<summary>UnwrapClickTargetRouter</summary>
	public ULocalSingleClickInputBehavior UnwrapClickTargetRouter;
	///<summary>LivePreviewClickTargetRouter</summary>
	public ULocalSingleClickInputBehavior LivePreviewClickTargetRouter;
	///<summary>UnwrapHoverBehaviorTargetRouter</summary>
	public ULocalMouseHoverBehavior UnwrapHoverBehaviorTargetRouter;
	///<summary>LivePreviewHoverBehaviorTargetRouter</summary>
	public ULocalMouseHoverBehavior LivePreviewHoverBehaviorTargetRouter;
	///<summary>MarqueeMechanic</summary>
	public URectangleMarqueeMechanic MarqueeMechanic;
	///<summary>LivePreviewMarqueeMechanic</summary>
	public URectangleMarqueeMechanic LivePreviewMarqueeMechanic;
	///<summary>HoverTriangleSetMaterial</summary>
	public UMaterialInstanceDynamic HoverTriangleSetMaterial;
	///<summary>HoverGeometryActor</summary>
	public APreviewGeometryActor HoverGeometryActor;
	///<summary>LivePreviewBehaviorSet</summary>
	public UInputBehaviorSet LivePreviewBehaviorSet;
	///<summary>LivePreviewBehaviorSource</summary>
	public ULocalInputBehaviorSource LivePreviewBehaviorSource;
	///<summary>LivePreviewHoverGeometryActor</summary>
	public APreviewGeometryActor LivePreviewHoverGeometryActor;
}
