#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVSelectTool.h")]
///<summary>The tool in the UV editor that secretly runs when other tools are not running. It uses the</summary>
public partial class UUVSelectTool : UInteractiveTool {
// UVSelectTool
	public TArray<UUVEditorToolMeshInput> Targets;
	public UUVToolViewportButtonsAPI ViewportButtonsAPI;
	public UUVToolEmitChangeAPI EmitChangeAPI;
	public UUVToolSelectionAPI SelectionAPI;
	public UUVEditorMeshSelectionMechanic SelectionMechanic;
	public UCombinedTransformGizmo TransformGizmo;
}
