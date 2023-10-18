namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothMeshSelectionTool.h")]
public partial class UClothMeshSelectionTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>ToolProperties</summary>
	public UClothMeshSelectionToolProperties ToolProperties;
	///<summary>PreviewMesh</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>SelectionMechanic</summary>
	public UPolygonSelectionMechanic SelectionMechanic;
	///<summary>ClothEditorContextObject</summary>
	public UClothEditorContextObject ClothEditorContextObject;
}
