#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeMapsToolBase.h")]
///<summary>Base Bake Maps tool</summary>
public partial class UBakeMeshAttributeMapsToolBase : UBakeMeshAttributeTool {
// BakeMeshAttributeMapsToolBase
	public UBakeVisualizationProperties VisualizationProps;
	public UPreviewMesh PreviewMesh;
	public UMaterialInstanceDynamic PreviewMaterial;
	public UMaterialInstanceDynamic BentNormalPreviewMaterial;
	public TMap<EBakeMapType,UTexture2D> CachedMaps;
	public UTexture2D EmptyNormalMap;
	public UTexture2D EmptyColorMapBlack;
	public UTexture2D EmptyColorMapWhite;
}
