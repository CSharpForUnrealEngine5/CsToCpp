namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/MaterialEditorInstanceConstant.h")]
public partial class UMaterialEditorInstanceConstant : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
	public UPhysicalMaterial PhysMaterial;
	///<summary>since the Parent may point across levels and the property editor needs to import this text, it must be marked lazy so it doesn&#39;t set itself to NULL in FindImportedObject</summary>
	public UMaterialInterface Parent;
	///<summary>ParameterGroups</summary>
	public TArray<FEditorParameterGroup> ParameterGroups;
	///<summary>This is the refraction depth bias, larger values offset distortion to prevent closer objects from rendering into the distorted surface at acute viewing angles but increases the disconnect between surface and where the refraction starts.</summary>
	public float RefractionDepthBias;
	///<summary>SubsurfaceProfile, for Screen Space Subsurface Scattering</summary>
	public USubsurfaceProfile SubsurfaceProfile;
	///<summary>Defines if SubsurfaceProfile from tis instance is used or it uses the parent one.</summary>
	public bool bOverrideSubsurfaceProfile;
	///<summary>bOverrideBaseProperties_DEPRECATED</summary>
	public bool bOverrideBaseProperties_DEPRECATED;
	///<summary>bIsFunctionPreviewMaterial</summary>
	public bool bIsFunctionPreviewMaterial;
	///<summary>bIsFunctionInstanceDirty</summary>
	public bool bIsFunctionInstanceDirty;
	///<summary>BasePropertyOverrides</summary>
	public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
	///<summary>SourceInstance</summary>
	public UMaterialInstanceConstant SourceInstance;
	///<summary>SourceFunction</summary>
	public UMaterialFunctionInstance SourceFunction;
	///<summary>VisibleExpressions</summary>
	public TArray<FMaterialParameterInfo> VisibleExpressions;
	///<summary>The Lightmass override settings for this object.</summary>
	public FLightmassParameterizedMaterialSettings LightmassSettings;
	///<summary>Should we use old style typed arrays for unassigned parameters instead of a None group (new style)?</summary>
	public bool bUseOldStyleMICEditorGroups;
	///<summary>When set we will use the override from NaniteOverrideMaterial. Otherwise we inherit any override on the parent.</summary>
	public bool bNaniteOverride;
	///<summary>An override material which will be used instead of this one when rendering with nanite.</summary>
	public UMaterialInterface NaniteOverrideMaterial;
	///<summary>StoredLayerPreviews</summary>
	public TArray<UMaterialInstanceConstant> StoredLayerPreviews;
	///<summary>StoredBlendPreviews</summary>
	public TArray<UMaterialInstanceConstant> StoredBlendPreviews;
}
