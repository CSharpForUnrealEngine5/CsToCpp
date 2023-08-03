#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Bake Maps tool</summary>
[CppInclude("BakeMeshAttributeMapsToolBase.h")]
public partial class UBakeMeshAttributeMapsToolBase : UBakeMeshAttributeTool {
	public static UClass StaticClass() {return default;}
	///<summary>Tool property sets</summary>
	public UBakeVisualizationProperties VisualizationProps;
	///<summary>Preview mesh and materials</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>PreviewMaterial</summary>
	public UMaterialInstanceDynamic PreviewMaterial;
	///<summary>BentNormalPreviewMaterial</summary>
	public UMaterialInstanceDynamic BentNormalPreviewMaterial;
	///<summary>Internal cache of bake texture results.</summary>
	public TMap<EBakeMapType,UTexture2D> CachedMaps;
	///<summary>empty maps are shown when nothing is computed</summary>
	public UTexture2D EmptyNormalMap;
	///<summary>EmptyColorMapBlack</summary>
	public UTexture2D EmptyColorMapBlack;
	///<summary>EmptyColorMapWhite</summary>
	public UTexture2D EmptyColorMapWhite;
}
