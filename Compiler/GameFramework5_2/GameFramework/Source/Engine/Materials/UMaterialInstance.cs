#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstance.h")]
public partial class UMaterialInstance : UMaterialInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
	public UPhysicalMaterial PhysMaterial;
	///<summary>Physical material map used with physical material mask, when it exists.</summary>
	public UPhysicalMaterial PhysicalMaterialMap;
	///<summary>Parent material.</summary>
	public UMaterialInterface Parent;
	///<summary>An override material which will be used instead of this one when rendering with nanite.</summary>
	public FMaterialOverrideNanite NaniteOverrideMaterial;
	///<summary>Indicates whether the instance has static permutation resources (which are required when static parameters are present)</summary>
	public bool bHasStaticPermutationResource;
	///<summary>Defines if SubsurfaceProfile from this instance is used or it uses the parent one.</summary>
	public bool bOverrideSubsurfaceProfile;
	///<summary>Scalar parameters.</summary>
	public TArray<FScalarParameterValue> ScalarParameterValues;
	///<summary>Vector parameters.</summary>
	public TArray<FVectorParameterValue> VectorParameterValues;
	///<summary>DoubleVector parameters.</summary>
	public TArray<FDoubleVectorParameterValue> DoubleVectorParameterValues;
	///<summary>Texture parameters.</summary>
	public TArray<FTextureParameterValue> TextureParameterValues;
	///<summary>RuntimeVirtualTexture parameters.</summary>
	public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues;
	///<summary>Sparse Volume Texture parameters.</summary>
	public TArray<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues;
	///<summary>Font parameters.</summary>
	public TArray<FFontParameterValue> FontParameterValues;
	///<summary>bOverrideBaseProperties_DEPRECATED</summary>
	public bool bOverrideBaseProperties_DEPRECATED;
	///<summary>BasePropertyOverrides</summary>
	public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
	///<summary>Static parameter values that are overridden in this instance.</summary>
	public FStaticParameterSetRuntimeData StaticParametersRuntime;
	///<summary>ReferencedTextureGuids</summary>
	public TArray<FGuid> ReferencedTextureGuids;
	///<summary>StaticParameters_DEPRECATED</summary>
	public FStaticParameterSet StaticParameters_DEPRECATED;
	///<summary>bSavedCachedData_DEPRECATED</summary>
	public bool bSavedCachedData_DEPRECATED;
}
