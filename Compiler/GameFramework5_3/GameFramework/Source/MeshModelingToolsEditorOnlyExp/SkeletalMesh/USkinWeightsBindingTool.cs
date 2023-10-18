namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMesh/SkinWeightsBindingTool.h")]
public partial class USkinWeightsBindingTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties</summary>
	public USkinWeightsBindingToolProperties Properties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>EditorContext</summary>
	public TWeakObjectPtr<USkeletalMeshEditorContextObjectBase> EditorContext;
}
