#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInterface.h")]
public partial class UMaterialInterface : UObject {
// MaterialInterface
	public UMaterialInterfaceEditorOnlyData EditorOnlyData;
	public USubsurfaceProfile SubsurfaceProfile;
	public FLightmassMaterialInterfaceSettings LightmassSettings;
	public bool bTextureStreamingDataSorted;
	public int TextureStreamingDataVersion;
	public TArray<FMaterialTextureInfo> TextureStreamingData;
	public TArray<UAssetUserData> AssetUserData;
	public TArray<FMaterialTextureInfo> TextureStreamingDataMissingEntries;
	public FSoftObjectPath PreviewMesh;
	public UThumbnailInfo ThumbnailInfo;
	public TMap<string,bool> LayerParameterExpansion;
	public TMap<string,bool> ParameterOverviewExpansion;
	public UAssetImportData AssetImportData;
	public FGuid LightingGuid;
	public  UMaterial GetBaseMaterial() { return default; }
	public  UPhysicalMaterial GetPhysicalMaterial() { return default; }
	public  UPhysicalMaterialMask GetPhysicalMaterialMask() { return default; }
	public  UPhysicalMaterial GetPhysicalMaterialFromMap(int Index) { return default; }
	public  FMaterialParameterInfo GetParameterInfo(EMaterialParameterAssociation Association,string ParameterName,UMaterialFunctionInterface LayerFunction) { return default; }
	public  EBlendMode GetBlendMode() { return default; }
	public  void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident,bool bForceMiplevelsToBeResidentValue,float ForceDuration,int CinematicTextureGroups/*=0*/,bool bFastResponse/*=false*/) {}
}
