namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The cloth editor mode is the mode used in the cloth asset editor. It holds most of the inter-tool state.</summary>
[CppInclude("ChaosClothAsset/ClothEditorMode.h")]
public partial class UChaosClothAssetEditorMode : UBaseCharacterFXEditorMode {
	public static UClass StaticClass() {return default;}
	///<summary>Rest space wireframes. They have to get ticked to be able to respond to setting changes.</summary>
	public TArray<UMeshElementsVisualizer> WireframesToTick;
	///<summary>Mode-level property objects (visible or not) that get ticked.</summary>
	public TArray<UInteractiveToolPropertySet> PropertyObjectsToTick;
	///<summary>Rest space editable meshes</summary>
	public TArray<UDynamicMeshComponent> DynamicMeshComponents;
	///<summary>Actors required for hit testing DynamicMeshComponents</summary>
	public TArray<AActor> DynamicMeshComponentParentActors;
	///<summary>DataflowComponent</summary>
	public UDataflowComponent DataflowComponent;
}
