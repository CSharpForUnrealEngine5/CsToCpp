#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMesh.h")]
///<summary>SkeletalMesh is geometry bound to a hierarchical skeleton of bones which can be animated for the purpose of deforming the mesh.</summary>
public partial class USkeletalMesh : USkinnedAsset {
// SkeletalMesh
	public USkeletalMeshEditorData MeshEditorDataObject;
	public USkeleton Skeleton;
	public  USkeleton GetSkeleton() { return default; }
	public  void SetSkeleton(USkeleton InSkeleton) {}
	public FBoxSphereBounds ImportedBounds;
	public FBoxSphereBounds ExtendedBounds;
	public FVector PositiveBoundsExtension;
	public FVector NegativeBoundsExtension;
	public  FBoxSphereBounds GetBounds() { return default; }
	public  FBoxSphereBounds GetImportedBounds() { return default; }
	public TArray<FSkeletalMaterial> Materials;
	public  TArray<FSkeletalMaterial> GetMaterials() { return default; }
	public  void SetMaterials(TArray<FSkeletalMaterial> InMaterials) {}
	public TArray<FBoneMirrorInfo> SkelMirrorTable;
	public TArray<FSkeletalMeshLODInfo> LODInfo;
	public FPerQualityLevelInt MinQualityLevelLOD;
	public  void SetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default/*=-1*/) {}
	public  void GetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default) {}
	public FPerPlatformInt MinLod;
	public FPerPlatformBool DisableBelowMinLodStripping;
	public bool bOverrideLODStreamingSettings;
	public FPerPlatformBool bSupportLODStreaming;
	public FPerPlatformInt MaxNumStreamedLODs;
	public FPerPlatformInt MaxNumOptionalLODs;
	public USkeletalMeshLODSettings LODSettings;
	public TSoftObjectPtr<UObject> DefaultAnimatingRig;
	public  USkeletalMeshLODSettings GetLODSettings() { return default; }
	public  void SetLODSettings(USkeletalMeshLODSettings InLODSettings) {}
	public  void SetDefaultAnimatingRig(TSoftObjectPtr<UObject> InAnimatingRig) {}
	public  TSoftObjectPtr<UObject> GetDefaultAnimatingRig() { return default; }
	public byte SkelMirrorAxis;
	public byte SkelMirrorFlipAxis;
	public bool bUseFullPrecisionUVs_DEPRECATED;
	public bool bUseHighPrecisionTangentBasis_DEPRECATED;
	public bool bHasBeenSimplified;
	public bool bHasVertexColors;
	public bool bEnablePerPolyCollision;
	public FGuid VertexColorGuid;
	public UBodySetup BodySetup;
	public UPhysicsAsset PhysicsAsset;
	public  UPhysicsAsset GetPhysicsAsset() { return default; }
	public UPhysicsAsset ShadowPhysicsAsset;
	public  UPhysicsAsset GetShadowPhysicsAsset() { return default; }
	public TArray<UNodeMappingContainer> NodeMappingData;
	public  TArray<UNodeMappingContainer> GetNodeMappingData() { return default; }
	public  UNodeMappingContainer GetNodeMappingContainer(UBlueprint SourceAsset) { return default; }
	public UAssetImportData AssetImportData;
	public string SourceFilePath_DEPRECATED;
	public string SourceFileTimestamp_DEPRECATED;
	public UThumbnailInfo ThumbnailInfo;
	public bool bHasCustomDefaultEditorCamera;
	public FVector DefaultEditorCameraLocation;
	public FRotator DefaultEditorCameraRotation;
	public FVector DefaultEditorCameraLookAt;
	public float DefaultEditorCameraOrthoZoom;
	public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
	public bool bSupportRayTracing;
	public int RayTracingMinLOD;
	public EClothLODBiasMode ClothLODBiasMode;
	public TArray<UMorphTarget> MorphTargets;
	public  TArray<UMorphTarget> GetMorphTargetsPtrConv() { return default; }
	public  void SetMorphTargets(TArray<UMorphTarget> InMorphTargets) {}
	public  TArray<string> K2_GetAllMorphTargetNames() { return default; }
	public float FloorOffset;
	public TArray<FTransform> RetargetBasePose;
	public TArray<FClothingAssetData_Legacy> ClothingAssets_DEPRECATED;
	public UClass PostProcessAnimBlueprint;
	public TArray<UClothingAssetBase> MeshClothingAssets;
	public  TArray<UClothingAssetBase> GetMeshClothingAssets() { return default; }
	public  void SetMeshClothingAssets(TArray<UClothingAssetBase> InMeshClothingAssets) {}
	public FSkeletalMeshSamplingInfo SamplingInfo;
	public TArray<UAssetUserData> AssetUserData;
	public TArray<USkeletalMeshSocket> Sockets;
	public  void AddSocket(USkeletalMeshSocket InSocket,bool bAddToSkeleton/*=false*/) {}
	public  USkeletalMeshSocket FindSocketAndIndex(string InSocketName,int OutIndex) { return default; }
	public  int NumSockets() { return default; }
	public  USkeletalMeshSocket GetSocketByIndex(int Index) { return default; }
	public  bool IsSectionUsingCloth(int InSectionIndex,bool bCheckCorrespondingSections/*=true*/) { return default; }
	public TArray<FSkinWeightProfileInfo> SkinWeightProfiles;
	public UMeshDeformer DefaultMeshDeformer;
}
