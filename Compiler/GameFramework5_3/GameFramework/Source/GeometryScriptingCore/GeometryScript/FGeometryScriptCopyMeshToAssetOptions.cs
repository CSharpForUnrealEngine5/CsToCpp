namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
public partial struct FGeometryScriptCopyMeshToAssetOptions {
	public bool bEnableRecomputeNormals;
	public bool bEnableRecomputeTangents;
	public bool bEnableRemoveDegenerates;
	public bool bReplaceMaterials;
	public TArray<UMaterialInterface> NewMaterials;
	public TArray<FName> NewMaterialSlotNames;
	public bool bApplyNaniteSettings;
	public FGeometryScriptNaniteOptions NaniteSettings;
	public FMeshNaniteSettings NewNaniteSettings;
	public bool bEmitTransaction;
	public bool bDeferMeshPostEditChange;
}
