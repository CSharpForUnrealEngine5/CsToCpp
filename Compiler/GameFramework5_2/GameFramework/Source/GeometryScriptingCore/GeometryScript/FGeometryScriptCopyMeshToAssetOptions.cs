#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
public partial struct FGeometryScriptCopyMeshToAssetOptions {
// GeometryScriptCopyMeshToAssetOptions
	public bool bEnableRecomputeNormals;
	public bool bEnableRecomputeTangents;
	public bool bEnableRemoveDegenerates;
	public bool bReplaceMaterials;
	public TArray<UMaterialInterface> NewMaterials;
	public TArray<string> NewMaterialSlotNames;
	public bool bApplyNaniteSettings;
	public FGeometryScriptNaniteOptions NaniteSettings;
	public FMeshNaniteSettings NewNaniteSettings;
	public bool bEmitTransaction;
	public bool bDeferMeshPostEditChange;
}
