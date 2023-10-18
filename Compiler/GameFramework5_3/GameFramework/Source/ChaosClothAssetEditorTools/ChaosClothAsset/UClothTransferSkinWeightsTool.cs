namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothTransferSkinWeightsTool.h")]
public partial class UClothTransferSkinWeightsTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>ToolProperties</summary>
	public UClothTransferSkinWeightsToolProperties ToolProperties;
	///<summary>ClothEditorContextObject</summary>
	public UClothEditorContextObject ClothEditorContextObject;
	///<summary>TargetClothPreview</summary>
	public UMeshOpPreviewWithBackgroundCompute TargetClothPreview;
	///<summary>SourceMeshParentActor</summary>
	public AInternalToolFrameworkActor SourceMeshParentActor;
	///<summary>SourceMeshComponent</summary>
	public USkeletalMeshComponent SourceMeshComponent;
	///<summary>Source mesh transform gizmo support</summary>
	public UTransformProxy SourceMeshTransformProxy;
	///<summary>SourceMeshTransformGizmo</summary>
	public UCombinedTransformGizmo SourceMeshTransformGizmo;
}
