#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Options/GLTFExportOptions.h")]
public partial class UGLTFExportOptions : UObject {
// GLTFExportOptions
	public float ExportUniformScale;
	public bool bExportPreviewMesh;
	public bool bSkipNearDefaultValues;
	public bool bExportProxyMaterials;
	public bool bExportUnlitMaterials;
	public bool bExportClearCoatMaterials;
	public EGLTFMaterialBakeMode BakeMaterialInputs;
	public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize;
	public byte DefaultMaterialBakeFilter;
	public byte DefaultMaterialBakeTiling;
	public TMap<EGLTFMaterialPropertyGroup,FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings;
	public int DefaultLevelOfDetail;
	public bool bExportVertexColors;
	public bool bExportVertexSkinWeights;
	public bool bUseMeshQuantization;
	public bool bExportLevelSequences;
	public bool bExportAnimationSequences;
	public EGLTFTextureImageFormat TextureImageFormat;
	public int TextureImageQuality;
	public bool bExportTextureTransforms;
	public bool bAdjustNormalmaps;
	public bool bExportHiddenInGame;
	public bool bExportLights;
	public bool bExportCameras;
	public EGLTFMaterialVariantMode ExportMaterialVariants;
	public  void ResetToDefault() {}
}
