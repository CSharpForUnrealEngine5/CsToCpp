#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/MaterialEditorPreviewParameters.h")]
public partial class UMaterialEditorPreviewParameters : UObject {
// MaterialEditorPreviewParameters
	public TArray<FEditorParameterGroup> ParameterGroups;
	public UMaterial PreviewMaterial;
	public UMaterialFunction OriginalFunction;
	public UMaterial OriginalMaterial;
	public TArray<UMaterialInstanceConstant> StoredLayerPreviews;
	public TArray<UMaterialInstanceConstant> StoredBlendPreviews;
}
