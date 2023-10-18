namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The tool in the UV editor that secretly runs when other tools are not running. It uses the</summary>
[CppInclude("UVSelectTool.h")]
public partial class UUVSelectTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>ViewportButtonsAPI</summary>
	public UUVToolViewportButtonsAPI ViewportButtonsAPI;
	///<summary>EmitChangeAPI</summary>
	public UUVToolEmitChangeAPI EmitChangeAPI;
	///<summary>SelectionAPI</summary>
	public UUVToolSelectionAPI SelectionAPI;
	///<summary>SelectionMechanic</summary>
	public UUVEditorMeshSelectionMechanic SelectionMechanic;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
}
