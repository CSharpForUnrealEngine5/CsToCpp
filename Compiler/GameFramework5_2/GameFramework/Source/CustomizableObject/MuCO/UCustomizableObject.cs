#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial class UCustomizableObject : UObject {
// CustomizableObject
	public USkeletalMesh ReferenceSkeletalMesh_DEPRECATED;
	public TArray<USkeletalMesh> ReferenceSkeletalMeshes;
	public TArray<FMutableRefSkeletalMeshData> ReferenceSkeletalMeshesData;
	public UStaticMesh ReferenceStaticMesh;
	public TArray<TSoftObjectPtr<UMaterialInterface>> ReferencedMaterials;
	public TArray<string> ReferencedMaterialSlotNames;
	public TArray<TSoftObjectPtr<USkeleton>> ReferencedSkeletons;
	public FMutableLODSettings LODSettings;
	public TArray<FMutableModelImageProperties> ImageProperties;
	public TArray<FMorphTargetInfo> ContributingMorphTargetsInfo;
	public TArray<FMorphTargetVertexData> MorphTargetReconstructionData;
	public TArray<FCustomizableObjectClothConfigData> ClothSharedConfigsData;
	public TArray<FCustomizableObjectClothingAssetData> ContributingClothingAssetsData;
	public TArray<FCustomizableObjectMeshToMeshVertData> ClothMeshToMeshVertData;
	public TArray<FMutableSkinWeightProfileInfo> SkinWeightProfilesInfo;
	public ECustomizableObjectRelevancy Relevancy;
	public FCompilationOptions CompileOptions;
	public bool bDisableTextureLayoutManagement;
	public bool bEnableRealTimeMorphTargets;
	public bool bEnableClothing;
	public bool bEnable16BitBoneWeights;
	public bool bEnableAltSkinWeightProfiles;
	public bool bEnablePhysicsAssetMerge;
	public EMutableCompileMeshType MeshCompileType;
	public TArray<TSoftObjectPtr<UCustomizableObject>> WorkingSet;
	public UEdGraph Source;
	public FGuid VersionId;
	public TSet<FGuid> CustomizableObjectGuidsInCompilation;
	public TMap<string,string> CustomizableObjectPathMap;
	public TMap<string,FCustomizableObjectIdPair> GroupNodeMap;
	public TArray<FProfileParameterDat> InstancePropertiesProfiles;
	public int NumMeshComponentsInRoot;
	public  int GetComponentCount() { return default; }
	public  int GetParameterCount() { return default; }
	public  int FindParameter(string Name) { return default; }
	public  EMutableParameterType GetParameterType(int ParamIndex) { return default; }
	public  EMutableParameterType GetParameterTypeByName(string Name) { return default; }
	public  string GetParameterName(int ParamIndex) { return default; }
	public  int GetParameterDescriptionCount(string ParamName) { return default; }
	public  int GetIntParameterNumOptions(int ParamIndex) { return default; }
	public  string GetIntParameterAvailableOption(int ParamIndex,int K) { return default; }
	public  void LoadMaskOutCache() {}
	public  void UnloadMaskOutCache() {}
	public TArray<FMutableModelParameterProperties> ParameterProperties;
	public  int GetStateCount() { return default; }
	public  string GetStateName(int StateIndex) { return default; }
	public  int GetStateParameterCount(string StateName) { return default; }
	public  string GetStateParameterName(string StateName,int ParameterIndex) { return default; }
	public  FParameterUIData GetStateUIMetadata(string StateName) { return default; }
	public  FParameterUIData GetStateUIMetadataFromIndex(int StateIndex) { return default; }
	public  FParameterUIData GetParameterUIMetadata(string ParamName) { return default; }
	public  FParameterUIData GetParameterUIMetadataFromIndex(int ParamIndex) { return default; }
	public TMap<string,FParameterUIData> ParameterUIDataMap;
	public TMap<string,FParameterUIData> StateUIDataMap;
	public TMap<string,TSoftObjectPtr<UPhysicsAsset>> PhysicsAssetsMap;
	public TMap<string,TSoftObjectPtr<UClass>> AnimBPAssetsMap;
	public TArray<FMutableRefSocket> SocketArray;
	public TSoftObjectPtr<UMutableMaskOutCache> MaskOutCache;
	public TMap<ulong,FMutableStreamableBlock> HashToStreamableBlock;
	public TArray<string> CustomizableObjectClassTags;
	public TArray<string> PopulationClassTags;
	public TMap<string,FParameterTags> CustomizableObjectParametersTags;
	public bool bIsChildObject;
	public  UCustomizableObjectInstance CreateInstance() { return default; }
	public  bool IsCompiled() { return default; }
	public UMutableMaskOutCache MaskOutCache_HardRef;
	public FGuid Identifier;
	public FGuid CompilationGuid;
	public UCustomizableObjectBulk BulkData;
}
