namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SkeletalMesh is geometry bound to a hierarchical skeleton of bones which can be animated for the purpose of deforming the mesh.</summary>
[CppInclude("Engine/SkeletalMesh.h")]
public partial class USkeletalMesh : USkinnedAsset {
	public static UClass StaticClass() {return default;}
	///<summary>MeshEditorDataObject</summary>
	public USkeletalMeshEditorData MeshEditorDataObject;
	///<summary>Skeleton</summary>
	public USkeleton Skeleton;
	///<summary>USkinnedAsset interface.</summary>
	public virtual USkeleton GetSkeleton() { return default; }
	///<summary>SetSkeleton</summary>
	public void SetSkeleton(USkeleton InSkeleton) {}
	///<summary>ImportedBounds</summary>
	public FBoxSphereBounds ImportedBounds;
	///<summary>ExtendedBounds</summary>
	public FBoxSphereBounds ExtendedBounds;
	///<summary>PositiveBoundsExtension</summary>
	public FVector PositiveBoundsExtension;
	///<summary>NegativeBoundsExtension</summary>
	public FVector NegativeBoundsExtension;
	///<summary>Get the extended bounds of this mesh (imported bounds plus bounds extension). USkinnedAsset interface.</summary>
	public virtual FBoxSphereBounds GetBounds() { return default; }
	///<summary>Get the original imported bounds of the skel mesh</summary>
	public FBoxSphereBounds GetImportedBounds() { return default; }
	///<summary>Materials</summary>
	public TArray<FSkeletalMaterial> Materials;
	///<summary>USkinnedAsset interface.</summary>
	public virtual TArray<FSkeletalMaterial> GetMaterials() { return default; }
	///<summary>SetMaterials</summary>
	public void SetMaterials(TArray<FSkeletalMaterial> InMaterials) {}
	///<summary>SkelMirrorTable</summary>
	public TArray<FBoneMirrorInfo> SkelMirrorTable;
	///<summary>LODInfo</summary>
	public TArray<FSkeletalMeshLODInfo> LODInfo;
	///<summary>MinQualityLevelLOD</summary>
	public FPerQualityLevelInt MinQualityLevelLOD;
	///<summary>Allow to override min lod quality levels on a skeletalMesh and it Default value (-1 value for Default dont override its value).</summary>
	public void SetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default/*=-1*/) {}
	///<summary>GetMinLODForQualityLevels</summary>
	public void GetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default) {}
	///<summary>MinLod</summary>
	public FPerPlatformInt MinLod;
	///<summary>DisableBelowMinLodStripping</summary>
	public FPerPlatformBool DisableBelowMinLodStripping;
	///<summary>bOverrideLODStreamingSettings</summary>
	public bool bOverrideLODStreamingSettings;
	///<summary>bSupportLODStreaming</summary>
	public FPerPlatformBool bSupportLODStreaming;
	///<summary>MaxNumStreamedLODs</summary>
	public FPerPlatformInt MaxNumStreamedLODs;
	///<summary>MaxNumOptionalLODs</summary>
	public FPerPlatformInt MaxNumOptionalLODs;
	///<summary>LODSettings</summary>
	public USkeletalMeshLODSettings LODSettings;
	///<summary>DefaultAnimatingRig</summary>
	public TSoftObjectPtr<UObject> DefaultAnimatingRig;
	///<summary>GetLODSettings</summary>
	public USkeletalMeshLODSettings GetLODSettings() { return default; }
	///<summary>SetLODSettings</summary>
	public void SetLODSettings(USkeletalMeshLODSettings InLODSettings) {}
	///<summary>SetDefaultAnimatingRig</summary>
	public void SetDefaultAnimatingRig(TSoftObjectPtr<UObject> InAnimatingRig) {}
	///<summary>GetDefaultAnimatingRig</summary>
	public TSoftObjectPtr<UObject> GetDefaultAnimatingRig() { return default; }
	///<summary>SkelMirrorAxis</summary>
	public EAxis SkelMirrorAxis;
	///<summary>SkelMirrorFlipAxis</summary>
	public EAxis SkelMirrorFlipAxis;
	///<summary>If true, use 32 bit UVs. If false, use 16 bit UVs to save memory</summary>
	public bool bUseFullPrecisionUVs_DEPRECATED;
	///<summary>If true, tangents will be stored at 16 bit vs 8 bit precision</summary>
	public bool bUseHighPrecisionTangentBasis_DEPRECATED;
	///<summary>bHasBeenSimplified</summary>
	public bool bHasBeenSimplified;
	///<summary>bHasVertexColors</summary>
	public bool bHasVertexColors;
	///<summary>bEnablePerPolyCollision</summary>
	public bool bEnablePerPolyCollision;
	///<summary>VertexColorGuid</summary>
	public FGuid VertexColorGuid;
	///<summary>BodySetup</summary>
	public UBodySetup BodySetup;
	///<summary>PhysicsAsset</summary>
	public UPhysicsAsset PhysicsAsset;
	///<summary>USkinnedAsset interface.</summary>
	public virtual UPhysicsAsset GetPhysicsAsset() { return default; }
	///<summary>ShadowPhysicsAsset</summary>
	public UPhysicsAsset ShadowPhysicsAsset;
	///<summary>USkinnedAsset interface.</summary>
	public virtual UPhysicsAsset GetShadowPhysicsAsset() { return default; }
	///<summary>NodeMappingData</summary>
	public TArray<UNodeMappingContainer> NodeMappingData;
	///<summary>GetNodeMappingData</summary>
	public TArray<UNodeMappingContainer> GetNodeMappingData() { return default; }
	///<summary>GetNodeMappingContainer</summary>
	public UNodeMappingContainer GetNodeMappingContainer(UBlueprint SourceAsset) { return default; }
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>Path to the resource used to construct this skeletal mesh</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>Date/Time-stamp of the file from the last import</summary>
	public string SourceFileTimestamp_DEPRECATED;
	///<summary>ThumbnailInfo</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>bHasCustomDefaultEditorCamera</summary>
	public bool bHasCustomDefaultEditorCamera;
	///<summary>DefaultEditorCameraLocation</summary>
	public FVector DefaultEditorCameraLocation;
	///<summary>DefaultEditorCameraRotation</summary>
	public FRotator DefaultEditorCameraRotation;
	///<summary>DefaultEditorCameraLookAt</summary>
	public FVector DefaultEditorCameraLookAt;
	///<summary>DefaultEditorCameraOrthoZoom</summary>
	public float DefaultEditorCameraOrthoZoom;
	///<summary>PreviewAttachedAssetContainer</summary>
	public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
	///<summary>bSupportRayTracing</summary>
	public bool bSupportRayTracing;
	///<summary>RayTracingMinLOD</summary>
	public int RayTracingMinLOD;
	///<summary>ClothLODBiasMode</summary>
	public EClothLODBiasMode ClothLODBiasMode;
	///<summary>MorphTargets</summary>
	public TArray<UMorphTarget> MorphTargets;
	///<summary>NOTE: BP compiler doesn&#39;t support TObjectPtr as an argument type for UFUNCTION so this converting call is</summary>
	public TArray<UMorphTarget> GetMorphTargetsPtrConv() { return default; }
	///<summary>SetMorphTargets</summary>
	public void SetMorphTargets(TArray<UMorphTarget> InMorphTargets) {}
	///<summary>Returns the list of all morph targets of this skeletal mesh</summary>
	public TArray<string> K2_GetAllMorphTargetNames() { return default; }
	///<summary>FloorOffset</summary>
	public float FloorOffset;
	///<summary>RetargetBasePose</summary>
	public TArray<FTransform> RetargetBasePose;
	///<summary>Legacy clothing asset data, will be converted to new assets after loading</summary>
	public TArray<FClothingAssetData_Legacy> ClothingAssets_DEPRECATED;
	///<summary>PostProcessAnimBlueprint</summary>
	public UClass PostProcessAnimBlueprint;
	///<summary>* Max LOD level that post-process AnimBPs are evaluated.</summary>
	public int PostProcessAnimBPLODThreshold;
	///<summary>MeshClothingAssets</summary>
	public TArray<UClothingAssetBase> MeshClothingAssets;
	///<summary>GetMeshClothingAssets</summary>
	public TArray<UClothingAssetBase> GetMeshClothingAssets() { return default; }
	///<summary>SetMeshClothingAssets</summary>
	public void SetMeshClothingAssets(TArray<UClothingAssetBase> InMeshClothingAssets) {}
	///<summary>SamplingInfo</summary>
	public FSkeletalMeshSamplingInfo SamplingInfo;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>Array of named socket locations, set up in editor and used as a shortcut instead of specifying</summary>
	public TArray<USkeletalMeshSocket> Sockets;
	///<summary>Add a skeletal socket object to this SkeletalMesh, and optionally promotes it to USkeleton socket.</summary>
	public void AddSocket(USkeletalMeshSocket InSocket,bool bAddToSkeleton/*=false*/) {}
	///<summary>Find a socket object in this SkeletalMesh by name.</summary>
	public USkeletalMeshSocket FindSocketAndIndex(FName InSocketName,int OutIndex) { return default; }
	///<summary>Returns the number of sockets available. Both on this mesh and it&#39;s skeleton.</summary>
	public int NumSockets() { return default; }
	///<summary>Returns a socket by index. Max index is NumSockets(). The meshes sockets are accessed first, then the skeletons.</summary>
	public USkeletalMeshSocket GetSocketByIndex(int Index) { return default; }
	///<summary>Checks whether the provided section is using APEX cloth. if bCheckCorrespondingSections is true</summary>
	public bool IsSectionUsingCloth(int InSectionIndex,bool bCheckCorrespondingSections/*=true*/) { return default; }
	///<summary>SkinWeightProfiles</summary>
	public TArray<FSkinWeightProfileInfo> SkinWeightProfiles;
	///<summary>DefaultMeshDeformer</summary>
	public UMeshDeformer DefaultMeshDeformer;
	///<summary>OverlayMaterial</summary>
	public UMaterialInterface OverlayMaterial;
	///<summary>OverlayMaterialMaxDrawDistance</summary>
	public float OverlayMaterialMaxDrawDistance;
	///<summary>Get the default overlay material used by this mesh</summary>
	public virtual UMaterialInterface GetOverlayMaterial() { return default; }
	///<summary>Change the default overlay material used by this mesh</summary>
	public void SetOverlayMaterial(UMaterialInterface NewOverlayMaterial) {}
	///<summary>Get the default overlay material max draw distance used by this mesh</summary>
	public virtual float GetOverlayMaterialMaxDrawDistance() { return default; }
	///<summary>Change the default overlay material max draw distance used by this mesh</summary>
	public void SetOverlayMaterialMaxDrawDistance(float InMaxDrawDistance) {}
}
