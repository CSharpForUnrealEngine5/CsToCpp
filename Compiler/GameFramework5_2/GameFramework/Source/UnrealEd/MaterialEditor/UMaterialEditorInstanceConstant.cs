#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/MaterialEditorInstanceConstant.h")]
public partial class UMaterialEditorInstanceConstant : UObject {
// MaterialEditorInstanceConstant
	public UPhysicalMaterial PhysMaterial;
	public UMaterialInterface Parent;
	public TArray<FEditorParameterGroup> ParameterGroups;
	public float RefractionDepthBias;
	public USubsurfaceProfile SubsurfaceProfile;
	public bool bOverrideSubsurfaceProfile;
	public bool bOverrideBaseProperties_DEPRECATED;
	public bool bIsFunctionPreviewMaterial;
	public bool bIsFunctionInstanceDirty;
	public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
	public UMaterialInstanceConstant SourceInstance;
	public UMaterialFunctionInstance SourceFunction;
	public TArray<FMaterialParameterInfo> VisibleExpressions;
	public FLightmassParameterizedMaterialSettings LightmassSettings;
	public bool bUseOldStyleMICEditorGroups;
	public bool bNaniteOverride;
	public TSoftObjectPtr<UMaterialInterface> NaniteOverrideMaterial;
	public TArray<UMaterialInstanceConstant> StoredLayerPreviews;
	public TArray<UMaterialInstanceConstant> StoredBlendPreviews;
}
