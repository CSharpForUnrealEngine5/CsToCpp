namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UV editor mode is the mode used in the UV asset editor. It holds most of the inter-tool state.</summary>
[CppInclude("UVEditorMode.h")]
public partial class UUVEditorMode : UEdMode {
	public static UClass StaticClass() {return default;}
	///<summary>We don&#39;t actually override MouseEnter, etc, because things get forwarded to the input</summary>
	public UUVEditorBackgroundPreview BackgroundVisualization;
	///<summary>DistortionVisualization</summary>
	public UUVEditorDistortionVisualization DistortionVisualization;
	///<summary>Hold a settings object to configure the grid</summary>
	public UUVEditorGridProperties UVEditorGridProperties;
	///<summary>Hold a settings object to configure the UDIMs</summary>
	public UUVEditorUDIMProperties UVEditorUDIMProperties;
	///<summary>RegisteredActions</summary>
	public TArray<UUVToolAction> RegisteredActions;
	///<summary>Stores original input objects, for instance UStaticMesh pointers. AssetIDs on tool input</summary>
	public TArray<UObject> OriginalObjectsToEdit;
	///<summary>Tool targets created from OriginalObjectsToEdit (and 1:1 with that array) that provide</summary>
	public TArray<UToolTarget> ToolTargets;
	///<summary>Input objects we give to the tools, one per displayed UV layer. This includes pointers</summary>
	public TArray<UUVEditorToolMeshInput> ToolInputObjects;
	///<summary>Here largely for convenience to avoid having to pass it around functions.</summary>
	public UWorld LivePreviewWorld;
	///<summary>SelectionAPI</summary>
	public UUVToolSelectionAPI SelectionAPI;
	///<summary>Mode-level property objects (visible or not) that get ticked.</summary>
	public TArray<UInteractiveToolPropertySet> PropertyObjectsToTick;
}
