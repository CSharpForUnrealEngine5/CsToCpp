#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstance.h")]
public partial class UMaterialInstance : UMaterialInterface {
// MaterialInstance
	public UPhysicalMaterial PhysMaterial;
	public UPhysicalMaterial PhysicalMaterialMap;
	public UMaterialInterface Parent;
	public FMaterialOverrideNanite NaniteOverrideMaterial;
	public bool bHasStaticPermutationResource;
	public bool bOverrideSubsurfaceProfile;
	public TArray<FScalarParameterValue> ScalarParameterValues;
	public TArray<FVectorParameterValue> VectorParameterValues;
	public TArray<FDoubleVectorParameterValue> DoubleVectorParameterValues;
	public TArray<FTextureParameterValue> TextureParameterValues;
	public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues;
	public TArray<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues;
	public TArray<FFontParameterValue> FontParameterValues;
	public bool bOverrideBaseProperties_DEPRECATED;
	public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
	public FStaticParameterSetRuntimeData StaticParametersRuntime;
	public TArray<FGuid> ReferencedTextureGuids;
	public FStaticParameterSet StaticParameters_DEPRECATED;
	public bool bSavedCachedData_DEPRECATED;
}
