namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The cloth editor mode is the mode used in the cloth asset editor. It holds most of the inter-tool state.</summary>
[CppInclude("ChaosClothAsset/ClothEditorMode.h")]
public partial class UChaosClothAssetEditorMode : UBaseCharacterFXEditorMode {
	public static UClass StaticClass() {return default;}
	///<summary>Rest space wireframe. They have to get ticked to be able to respond to setting changes.</summary>
	public UMeshElementsVisualizer WireframeToTick;
	///<summary>Mode-level property objects (visible or not) that get ticked.</summary>
	public TArray<UInteractiveToolPropertySet> PropertyObjectsToTick;
	///<summary>Rest space editable mesh</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>Actor required for hit testing DynamicMeshComponent</summary>
	public AActor DynamicMeshComponentParentActor;
	///<summary>DataflowComponent</summary>
	public UDataflowComponent DataflowComponent;
	///<summary>DataflowGraph</summary>
	public UDataflow DataflowGraph;
	///<summary>ActiveToolsContext</summary>
	public UEditorInteractiveToolsContext ActiveToolsContext;
}
