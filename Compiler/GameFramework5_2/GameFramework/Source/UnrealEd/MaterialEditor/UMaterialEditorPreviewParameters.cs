#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/MaterialEditorPreviewParameters.h")]
public partial class UMaterialEditorPreviewParameters : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ParameterGroups</summary>
	public TArray<FEditorParameterGroup> ParameterGroups;
	///<summary>PreviewMaterial</summary>
	public UMaterial PreviewMaterial;
	///<summary>OriginalFunction</summary>
	public UMaterialFunction OriginalFunction;
	///<summary>OriginalMaterial</summary>
	public UMaterial OriginalMaterial;
	///<summary>StoredLayerPreviews</summary>
	public TArray<UMaterialInstanceConstant> StoredLayerPreviews;
	///<summary>StoredBlendPreviews</summary>
	public TArray<UMaterialInstanceConstant> StoredBlendPreviews;
}
