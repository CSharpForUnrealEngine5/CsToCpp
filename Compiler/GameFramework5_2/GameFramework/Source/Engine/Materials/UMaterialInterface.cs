namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInterface.h")]
public partial class UMaterialInterface : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EditorOnlyData</summary>
	public UMaterialInterfaceEditorOnlyData EditorOnlyData;
	///<summary>SubsurfaceProfile, for Screen Space Subsurface Scattering</summary>
	public USubsurfaceProfile SubsurfaceProfile;
	///<summary>The Lightmass settings for this object.</summary>
	public FLightmassMaterialInterfaceSettings LightmassSettings;
	///<summary>Because of redirector, the texture names need to be resorted at each load in case they changed.</summary>
	public bool bTextureStreamingDataSorted;
	///<summary>TextureStreamingDataVersion</summary>
	public int TextureStreamingDataVersion;
	///<summary>Data used by the texture streaming to know how each texture is sampled by the material. Sorted by names for quick access.</summary>
	public TArray<FMaterialTextureInfo> TextureStreamingData;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>List of all used but missing texture indices in TextureStreamingData. Used for visualization / debugging only.</summary>
	public TArray<FMaterialTextureInfo> TextureStreamingDataMissingEntries;
	///<summary>The mesh used by the material editor to preview the material.</summary>
	public FSoftObjectPath PreviewMesh;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>LayerParameterExpansion</summary>
	public TMap<string,bool> LayerParameterExpansion;
	///<summary>ParameterOverviewExpansion</summary>
	public TMap<string,bool> ParameterOverviewExpansion;
	///<summary>Importing data and options used for this material</summary>
	public UAssetImportData AssetImportData;
	///<summary>Unique ID for this material, used for caching during distributed lighting</summary>
	public FGuid LightingGuid;
	///<summary>Walks up parent chain and finds the base Material that this is an instance of. Just calls the virtual GetMaterial()</summary>
	public UMaterial GetBaseMaterial() { return default; }
	///<summary>Return a pointer to the physical material used by this material instance.</summary>
	public virtual UPhysicalMaterial GetPhysicalMaterial() { return default; }
	///<summary>Return a pointer to the physical material mask used by this material instance.</summary>
	public virtual UPhysicalMaterialMask GetPhysicalMaterialMask() { return default; }
	///<summary>Return a pointer to the physical material from mask map at given index.</summary>
	public virtual UPhysicalMaterial GetPhysicalMaterialFromMap(int Index) { return default; }
	///<summary>GetParameterInfo</summary>
	public FMaterialParameterInfo GetParameterInfo(EMaterialParameterAssociation Association,FName ParameterName,UMaterialFunctionInterface LayerFunction) { return default; }
	///<summary>GetBlendMode</summary>
	public virtual EBlendMode GetBlendMode() { return default; }
	///<summary>Force the streaming system to disregard the normal logic for the specified duration and</summary>
	public virtual void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident,bool bForceMiplevelsToBeResidentValue,float ForceDuration,int CinematicTextureGroups/*=0*/,bool bFastResponse/*=false*/) {}
}
