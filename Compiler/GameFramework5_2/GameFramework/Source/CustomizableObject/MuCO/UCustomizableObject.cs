namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial class UCustomizableObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>All the SkeletalMeshes generated for this CustomizableObject instances will use the Reference Skeletal Mesh</summary>
	public USkeletalMesh ReferenceSkeletalMesh_DEPRECATED;
	///<summary>All the SkeletalMeshes generated for this CustomizableObject instances will use the Reference Skeletal Mesh</summary>
	public TArray<USkeletalMesh> ReferenceSkeletalMeshes;
	///<summary>All the SkeletalMeshes generated for this CustomizableObject instances will use the Reference Skeletal Mesh</summary>
	public TArray<FMutableRefSkeletalMeshData> ReferenceSkeletalMeshesData;
	///<summary>Hide for now, since it is not supported yet</summary>
	public UStaticMesh ReferenceStaticMesh;
	///<summary>List of Materials referenced by this or any child customizable object.</summary>
	public TArray<TSoftObjectPtr<UMaterialInterface>> ReferencedMaterials;
	///<summary>List of Material slot names for the materials referenced by this or any child customizable object.</summary>
	public TArray<FName> ReferencedMaterialSlotNames;
	///<summary>List of skeletons referenced by any of the parts of this customizable object.</summary>
	public TArray<TSoftObjectPtr<USkeleton>> ReferencedSkeletons;
	///<summary>LODSettings</summary>
	public FMutableLODSettings LODSettings;
	///<summary>ImageProperties</summary>
	public TArray<FMutableModelImageProperties> ImageProperties;
	///<summary>ContributingMorphTargetsInfo</summary>
	public TArray<FMorphTargetInfo> ContributingMorphTargetsInfo;
	///<summary>MorphTargetReconstructionData</summary>
	public TArray<FMorphTargetVertexData> MorphTargetReconstructionData;
	///<summary>ClothSharedConfigsData</summary>
	public TArray<FCustomizableObjectClothConfigData> ClothSharedConfigsData;
	///<summary>ContributingClothingAssetsData</summary>
	public TArray<FCustomizableObjectClothingAssetData> ContributingClothingAssetsData;
	///<summary>ClothMeshToMeshVertData</summary>
	public TArray<FCustomizableObjectMeshToMeshVertData> ClothMeshToMeshVertData;
	///<summary>SkinWeightProfilesInfo</summary>
	public TArray<FMutableSkinWeightProfileInfo> SkinWeightProfilesInfo;
	///<summary>Hide this property because it is not used yet.</summary>
	public ECustomizableObjectRelevancy Relevancy;
	///<summary>Compilation options to use in editor and for packaging for this object.</summary>
	public FCompilationOptions CompileOptions;
	///<summary>bDisableTextureLayoutManagement</summary>
	public bool bDisableTextureLayoutManagement;
	///<summary>bEnableRealTimeMorphTargets</summary>
	public bool bEnableRealTimeMorphTargets;
	///<summary>bEnableClothing</summary>
	public bool bEnableClothing;
	///<summary>TODO: Enable 16 bit weights</summary>
	public bool bEnable16BitBoneWeights;
	///<summary>bEnableAltSkinWeightProfiles</summary>
	public bool bEnableAltSkinWeightProfiles;
	///<summary>bEnablePhysicsAssetMerge</summary>
	public bool bEnablePhysicsAssetMerge;
	///<summary>Options when compiling this customizable object (see EMutableCompileMeshType declaration for info)</summary>
	public EMutableCompileMeshType MeshCompileType;
	///<summary>Array of elements to use with compile option CompileType = WorkingSet</summary>
	public TArray<TSoftObjectPtr<UCustomizableObject>> WorkingSet;
	///<summary>Editor graph</summary>
	public UEdGraph Source;
	///<summary>Used to verify the derived data matches this version of the Customizable Object.</summary>
	public FGuid VersionId;
	///<summary>Set of all the guids of all the CustomizableObjects in the compilation</summary>
	public TSet<FGuid> CustomizableObjectGuidsInCompilation;
	///<summary>Map to identify what CustomizableObject owns a parameter. Used to display a tooltip when hovering a parameter</summary>
	public TMap<string,string> CustomizableObjectPathMap;
	///<summary>GroupNodeMap</summary>
	public TMap<string,FCustomizableObjectIdPair> GroupNodeMap;
	///<summary>InstancePropertiesProfiles</summary>
	public TArray<FProfileParameterDat> InstancePropertiesProfiles;
	///<summary>Amount of components in this CO. Set at the end of the model compilation process.</summary>
	public int NumMeshComponentsInRoot;
	///<summary>Method to query the amount of components this Customizable Object has.</summary>
	public int GetComponentCount() { return default; }
	///<summary>Get the number of parameters available in any instance.</summary>
	public int GetParameterCount() { return default; }
	///<summary>Get the index of a parameter</summary>
	public int FindParameter(string Name) { return default; }
	///<summary>Get the type of a parameter</summary>
	public EMutableParameterType GetParameterType(int ParamIndex) { return default; }
	///<summary>GetParameterTypeByName</summary>
	public EMutableParameterType GetParameterTypeByName(string Name) { return default; }
	///<summary>Get the name of a parameter</summary>
	public string GetParameterName(int ParamIndex) { return default; }
	///<summary>Get the number of description images available for a parameter</summary>
	public int GetParameterDescriptionCount(string ParamName) { return default; }
	///<summary>Returns how many possible options an int parameter has</summary>
	public int GetIntParameterNumOptions(int ParamIndex) { return default; }
	///<summary>Gets the Name of the option at position K in the list of available options for the int parameter.</summary>
	public string GetIntParameterAvailableOption(int ParamIndex,int K) { return default; }
	///<summary>Call before using Mutable&#39;s Projector testing with mask out features. It should only be loaded when needed because it can spend quite a lot of memory</summary>
	public void LoadMaskOutCache() {}
	///<summary>Call after having used Mutable&#39;s Projector testing with mask out features. It should be unloaded because it can spend quite a lot of memory</summary>
	public void UnloadMaskOutCache() {}
	///<summary>This is information about the parameters in the model that is generated at model compile time.</summary>
	public TArray<FMutableModelParameterProperties> ParameterProperties;
	///<summary>GetStateCount</summary>
	public int GetStateCount() { return default; }
	///<summary>GetStateName</summary>
	public string GetStateName(int StateIndex) { return default; }
	///<summary>GetStateParameterCount</summary>
	public int GetStateParameterCount(string StateName) { return default; }
	///<summary>GetStateParameterName</summary>
	public string GetStateParameterName(string StateName,int ParameterIndex) { return default; }
	///<summary>GetStateUIMetadata</summary>
	public FParameterUIData GetStateUIMetadata(string StateName) { return default; }
	///<summary>GetStateUIMetadataFromIndex</summary>
	public FParameterUIData GetStateUIMetadataFromIndex(int StateIndex) { return default; }
	///<summary>GetParameterUIMetadata</summary>
	public FParameterUIData GetParameterUIMetadata(string ParamName) { return default; }
	///<summary>GetParameterUIMetadataFromIndex</summary>
	public FParameterUIData GetParameterUIMetadataFromIndex(int ParamIndex) { return default; }
	///<summary>Stores all the parameter UI metadata information for all the dependencies of this Customizable Object</summary>
	public TMap<string,FParameterUIData> ParameterUIDataMap;
	///<summary>Stores all the state UI metadata information for all the dependencies of this Customizable Object</summary>
	public TMap<string,FParameterUIData> StateUIDataMap;
	///<summary>Stores the physics assets gathered from the SkeletalMesh nodes during compilation, to be used in mesh generation in-game</summary>
	public TMap<string,TSoftObjectPtr<UPhysicsAsset>> PhysicsAssetsMap;
	///<summary>Stores the UAnimBlueprint assets gathered from the SkeletalMesh nodes during compilation, to be used in mesh generation in-game</summary>
	public TMap<string,TSoftObjectPtr<UClass>> AnimBPAssetsMap;
	///<summary>Stores the sockets provided by the part skeletal meshes, to be merged in the generated meshes</summary>
	public TArray<FMutableRefSocket> SocketArray;
	///<summary>Stores the textures that will be used to mask-out areas in projectors. The cache isn&#39;t used for rendering, but for coverage testing</summary>
	public TSoftObjectPtr<UMutableMaskOutCache> MaskOutCache;
	///<summary>Map of Hash to Streaming blocks, used to stream a block of data representing a resource from the BulkData</summary>
	public TMap<ulong,FMutableStreamableBlock> HashToStreamableBlock;
	///<summary>Array to store the selected Population Class tags for this Customizable Object</summary>
	public TArray<string> CustomizableObjectClassTags;
	///<summary>Array to strore all the Population Class tags</summary>
	public TArray<string> PopulationClassTags;
	///<summary>Map of parameters available for the Customizable Object and their tags</summary>
	public TMap<string,FParameterTags> CustomizableObjectParametersTags;
	///<summary>True if this object references a parent object. This is used basically to exclude this object</summary>
	public bool bIsChildObject;
	///<summary>CreateInstance</summary>
	public UCustomizableObjectInstance CreateInstance() { return default; }
	///<summary>This will always return true in a packaged game</summary>
	public bool IsCompiled() { return default; }
	///<summary>Used to prevent GC of MaskOutCache and keep it in memory while it&#39;s needed</summary>
	public UMutableMaskOutCache MaskOutCache_HardRef;
	///<summary>Unique Identifier - used to locate Model and Streamable data on disk. Should not be modified.</summary>
	public FGuid Identifier;
	///<summary>Unique identifier. Regenerated each time the object is compiled.</summary>
	public FGuid CompilationGuid;
	///<summary>BulkData that stores all in-game resources used by Mutable when generating instances.</summary>
	public UCustomizableObjectBulk BulkData;
}
