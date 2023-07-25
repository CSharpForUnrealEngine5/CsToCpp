#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorMode.h")]
///<summary>The UV editor mode is the mode used in the UV asset editor. It holds most of the inter-tool state.</summary>
public partial class UUVEditorMode : UEdMode {
// UVEditorMode
	public UUVEditorBackgroundPreview BackgroundVisualization;
	public UUVEditorGridProperties UVEditorGridProperties;
	public UUVEditorUDIMProperties UVEditorUDIMProperties;
	public TArray<UUVToolAction> RegisteredActions;
	public TArray<UObject> OriginalObjectsToEdit;
	public TArray<UToolTarget> ToolTargets;
	public TArray<UUVEditorToolMeshInput> ToolInputObjects;
	public UWorld LivePreviewWorld;
	public UUVToolSelectionAPI SelectionAPI;
	public TArray<UInteractiveToolPropertySet> PropertyObjectsToTick;
}
