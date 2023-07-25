#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothEditorMode.h")]
///<summary>The cloth editor mode is the mode used in the cloth asset editor. It holds most of the inter-tool state.</summary>
public partial class UChaosClothAssetEditorMode : UBaseCharacterFXEditorMode {
// ChaosClothAssetEditorMode
	public TArray<UMeshElementsVisualizer> WireframesToTick;
	public TArray<UInteractiveToolPropertySet> PropertyObjectsToTick;
	public TArray<UDynamicMeshComponent> DynamicMeshComponents;
	public TArray<AActor> DynamicMeshComponentParentActors;
	public UDataflowComponent DataflowComponent;
}
