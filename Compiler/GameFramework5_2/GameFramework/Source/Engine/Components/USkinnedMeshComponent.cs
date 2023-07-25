#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkinnedMeshComponent.h")]
///<summary>Skinned mesh component that supports bone skinned mesh rendering.</summary>
public partial class USkinnedMeshComponent : UMeshComponent {
// SkinnedMeshComponent
	public USkeletalMesh SkeletalMesh;
	public USkinnedAsset SkinnedAsset;
	public TWeakObjectPtr<USkinnedMeshComponent> LeaderPoseComponent;
	public TArray<ESkinCacheUsage> SkinCacheUsage;
	public bool bSetMeshDeformer;
	public UMeshDeformer MeshDeformer;
	public UMeshDeformerInstanceSettings MeshDeformerInstanceSettings;
	public UMeshDeformerInstance MeshDeformerInstance;
	public UObject GetMeshDeformerInstance() { return default; }
	public FColor WireframeColor_DEPRECATED;
	public UPhysicsAsset PhysicsAssetOverride;
	public int ForcedLodModel;
	public int MinLodModel;
	public float StreamingDistanceMultiplier;
	public TArray<FSkelMeshComponentLODInfo> LODInfo;
	public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption;
	public bool bOverrideMinLod;
	public bool bUseBoundsFromLeaderPoseComponent;
	public bool bForceWireframe;
	public bool bDisplayBones_DEPRECATED;
	public bool bDisableMorphTarget;
	public bool bHideSkin;
	public bool bPerBoneMotionBlur;
	public bool bComponentUseFixedSkelBounds;
	public bool bConsiderAllBodiesForBounds;
	public bool bSyncAttachParentLOD;
	public bool bCanHighlightSelectedSections;
	public bool bRecentlyRendered;
	public bool bCastCapsuleDirectShadow;
	public bool bCastCapsuleIndirectShadow;
	public bool bCPUSkinning;
	public bool bEnableUpdateRateOptimizations;
	public bool bDisplayDebugUpdateRateOptimizations;
	public bool bRenderStatic;
	public bool bIgnoreLeaderPoseComponentLOD;
	public bool bCachedLocalBoundsUpToDate;
	public bool bCachedWorldSpaceBoundsUpToDate;
	public bool bForceMeshObjectUpdate;
	public bool bForceUpdateDynamicDataImmediately;
	public bool bFollowerShouldTickPose;
	public float CapsuleIndirectShadowMinVisibility;
	public void SetPhysicsAsset(UObject NewPhysicsAsset,bool bForceReInit/*=false*/) {}
	public int GetNumLODs() { return default; }
	public void SetMinLOD(int InNewMinLOD) {}
	public void SetForcedLOD(int InNewForcedLOD) {}
	public int GetForcedLOD() { return default; }
	public void SetCastCapsuleDirectShadow(bool bNewValue) {}
	public void SetCastCapsuleIndirectShadow(bool bNewValue) {}
	public void SetCapsuleIndirectShadowMinVisibility(float NewValue) {}
	public int GetNumBones() { return default; }
	public int GetBoneIndex(string BoneName) { return default; }
	public string GetBoneName(int BoneIndex) { return default; }
	public string GetSocketBoneName(string InSocketName) { return default; }
	public UObject GetSkeletalMesh_DEPRECATED() { return default; }
	public void SetSkinnedAssetAndUpdate(UObject NewMesh,bool bReinitPose/*=true*/) {}
	public UObject GetSkinnedAsset() { return default; }
	public void SetMeshDeformer(UObject InMeshDeformer) {}
	public void UnsetMeshDeformer() {}
	public string GetParentBone(string BoneName) { return default; }
	public FTransform GetDeltaTransformFromRefPose(string BoneName,string BaseName/*=NAME_None*/) { return default; }
	public bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose(string BoneName,float OutTwistAngle,float OutSwingAngle) { return default; }
	public void SetVertexColorOverride_LinearColor(int LODIndex,TArray<FLinearColor> VertexColors) {}
	public void ClearVertexColorOverride(int LODIndex) {}
	public void SetSkinWeightOverride(int LODIndex,TArray<FSkelMeshSkinWeightInfo> SkinWeights) {}
	public void ClearSkinWeightOverride(int LODIndex) {}
	public bool SetSkinWeightProfile(string InProfileName) { return default; }
	public void ClearSkinWeightProfile() {}
	public void UnloadSkinWeightProfile(string InProfileName) {}
	public string GetCurrentSkinWeightProfileName() { return default; }
	public bool IsUsingSkinWeightProfile() { return default; }
	public int GetVertexOffsetUsage(int LODIndex) { return default; }
	public void SetVertexOffsetUsage(int LODIndex,int Usage) {}
	public void SetPreSkinningOffsets(int LODIndex,TArray<FVector> Offsets) {}
	public void SetPostSkinningOffsets(int LODIndex,TArray<FVector> Offsets) {}
	public int GetPredictedLODLevel() { return default; }
	public FBoxSphereBounds CachedWorldOrLocalSpaceBounds;
	public FMatrix CachedWorldToLocalTransform;
	public void SetLeaderPoseComponent(UObject NewLeaderBoneComponent,bool bForceUpdate/*=false*/,bool bInFollowerShouldTickPose/*=false*/) {}
	public bool BoneIsChildOf(string BoneName,string ParentBoneName) { return default; }
	public FVector GetRefPosePosition(int BoneIndex) { return default; }
	public FTransform GetRefPoseTransform(int BoneIndex) { return default; }
	public void TransformToBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,FVector OutPosition,FRotator OutRotation) {}
	public void TransformFromBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,FVector OutPosition,FRotator OutRotation) {}
	public string FindClosestBone_K2(FVector TestLocation,FVector BoneLocation,float IgnoreScale/*=0.0f*/,bool bRequirePhysicsAsset/*=false*/) { return default; }
	public void HideBoneByName(string BoneName,EPhysBodyOp PhysBodyOption) {}
	public void UnHideBoneByName(string BoneName) {}
	public bool IsBoneHiddenByName(string BoneName) { return default; }
	public void ShowMaterialSection(int MaterialID,int SectionIndex,bool bShow,int LODIndex) {}
	public void ShowAllMaterialSections(int LODIndex) {}
	public bool IsMaterialSectionShown(int MaterialID,int LODIndex) { return default; }
	public void SetRenderStatic(bool bNewValue) {}
}
