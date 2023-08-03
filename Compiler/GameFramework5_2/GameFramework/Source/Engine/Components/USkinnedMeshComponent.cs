#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Skinned mesh component that supports bone skinned mesh rendering.</summary>
[CppInclude("Components/SkinnedMeshComponent.h")]
public partial class USkinnedMeshComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletalMesh</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>SkinnedAsset</summary>
	public USkinnedAsset SkinnedAsset;
	///<summary>If set, this SkeletalMeshComponent will not use its SpaceBase for bone transform, but will</summary>
	public TWeakObjectPtr<USkinnedMeshComponent> LeaderPoseComponent;
	///<summary>How this Component&#39;s LOD uses the skin cache feature. Auto will defer to the asset&#39;s (SkeletalMesh) option. If Ray Tracing is enabled, will imply Enabled</summary>
	public TArray<ESkinCacheUsage> SkinCacheUsage;
	///<summary>If true, MeshDeformer will be used. If false, use the default mesh deformer on the SkeletalMesh.</summary>
	public bool bSetMeshDeformer;
	///<summary>The mesh deformer to use. If no mesh deformer is set from here or the SkeletalMesh, then we fall back to the fixed function deformation.</summary>
	public UMeshDeformer MeshDeformer;
	///<summary>Object containing instance settings for the bound MeshDeformer.</summary>
	public UMeshDeformerInstanceSettings MeshDeformerInstanceSettings;
	///<summary>Object containing state for the bound MeshDeformer.</summary>
	public UMeshDeformerInstance MeshDeformerInstance;
	///<summary>GetMeshDeformerInstance</summary>
	public  UMeshDeformerInstance GetMeshDeformerInstance() { return default; }
	///<summary>Wireframe color</summary>
	public FColor WireframeColor_DEPRECATED;
	///<summary>PhysicsAsset is set in SkeletalMesh by default, but you can override with this value</summary>
	public UPhysicsAsset PhysicsAssetOverride;
	///<summary>ForcedLodModel</summary>
	public int ForcedLodModel;
	///<summary>This is the min LOD that this component will use.  (e.g. if set to 2 then only 2+ LOD Models will be used.) This is useful to set on</summary>
	public int MinLodModel;
	///<summary>Allows adjusting the desired streaming distance of streaming textures that uses UV 0.</summary>
	public float StreamingDistanceMultiplier;
	///<summary>LOD array info. Each index will correspond to the LOD index *</summary>
	public TArray<FSkelMeshComponentLODInfo> LODInfo;
	///<summary>* This is tick animation frequency option based on this component rendered or not or using montage</summary>
	public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption;
	///<summary>Whether we should use the min lod specified in MinLodModel for this component instead of the min lod in the mesh</summary>
	public bool bOverrideMinLod;
	///<summary>When true, we will just using the bounds from our LeaderPoseComponent.  This is useful for when we have a Mesh Parented</summary>
	public bool bUseBoundsFromLeaderPoseComponent;
	///<summary>Forces the mesh to draw in wireframe mode.</summary>
	public bool bForceWireframe;
	///<summary>Draw the skeleton hierarchy for this skel mesh.</summary>
	public bool bDisplayBones_DEPRECATED;
	///<summary>Disable Morphtarget for this component.</summary>
	public bool bDisableMorphTarget;
	///<summary>Don&#39;t bother rendering the skin.</summary>
	public bool bHideSkin;
	///<summary>If true, use per-bone motion blur on this skeletal mesh (requires additional rendering, can be disabled to save performance).</summary>
	public bool bPerBoneMotionBlur;
	///<summary>When true, skip using the physics asset etc. and always use the fixed bounds defined in the SkeletalMesh.</summary>
	public bool bComponentUseFixedSkelBounds;
	///<summary>If true, when updating bounds from a PhysicsAsset, consider _all_ BodySetups, not just those flagged with bConsiderForBounds.</summary>
	public bool bConsiderAllBodiesForBounds;
	///<summary>If true, this component uses its parents LOD when attached if available</summary>
	public bool bSyncAttachParentLOD;
	///<summary>Whether or not we can highlight selected sections - this should really only be done in the editor</summary>
	public bool bCanHighlightSelectedSections;
	///<summary>true if mesh has been recently rendered, false otherwise</summary>
	public bool bRecentlyRendered;
	///<summary>Whether to use the capsule representation (when present) from a skeletal mesh&#39;s ShadowPhysicsAsset for direct shadowing from lights.</summary>
	public bool bCastCapsuleDirectShadow;
	///<summary>Whether to use the capsule representation (when present) from a skeletal mesh&#39;s ShadowPhysicsAsset for shadowing indirect lighting (from lightmaps or skylight).</summary>
	public bool bCastCapsuleIndirectShadow;
	///<summary>bCPUSkinning</summary>
	public bool bCPUSkinning;
	///<summary>if TRUE, Owner will determine how often animation will be updated and evaluated. See AnimUpdateRateTick()</summary>
	public bool bEnableUpdateRateOptimizations;
	///<summary>Enable on screen debugging of update rate optimization.</summary>
	public bool bDisplayDebugUpdateRateOptimizations;
	///<summary>If true, render as static in reference pose.</summary>
	public bool bRenderStatic;
	///<summary>Flag that when set will ensure UpdateLODStatus will not take the LeaderPoseComponent&#39;s current LOD in consideration when determining the correct LOD level (this requires LeaderPoseComponent&#39;s LOD to always be &gt;= determined LOD otherwise bone transforms could be missing</summary>
	public bool bIgnoreLeaderPoseComponentLOD;
	///<summary>true when CachedLocalBounds is up to date.</summary>
	public bool bCachedLocalBoundsUpToDate;
	///<summary>bCachedWorldSpaceBoundsUpToDate</summary>
	public bool bCachedWorldSpaceBoundsUpToDate;
	///<summary>If true, UpdateTransform will always result in a call to MeshObject-&gt;Update.</summary>
	public bool bForceMeshObjectUpdate;
	///<summary>Whether to update dynamic bone &amp; cloth sim data immediately, not to wait until GDME or defer update to RHIThread.</summary>
	public bool bForceUpdateDynamicDataImmediately;
	///<summary>If false, Follower components ShouldTickPose function will return false (default)</summary>
	public bool bFollowerShouldTickPose;
	///<summary>Controls how dark the capsule indirect shadow can be.</summary>
	public float CapsuleIndirectShadowMinVisibility;
	///<summary>Override the Physics Asset of the mesh. It uses SkeletalMesh.PhysicsAsset, but if you&#39;d like to override use this function</summary>
	public  void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset,bool bForceReInit/*=false*/) {}
	///<summary>Get the number of LODs on this component</summary>
	public  int GetNumLODs() { return default; }
	///<summary>Set MinLodModel of the mesh component</summary>
	public  void SetMinLOD(int InNewMinLOD) {}
	///<summary>Set ForcedLodModel of the mesh component</summary>
	public  void SetForcedLOD(int InNewForcedLOD) {}
	///<summary>Get ForcedLodModel of the mesh component. Note that the actual forced LOD level is the return value minus one and zero means no forced LOD</summary>
	public  int GetForcedLOD() { return default; }
	///<summary>SetCastCapsuleDirectShadow</summary>
	public  void SetCastCapsuleDirectShadow(bool bNewValue) {}
	///<summary>SetCastCapsuleIndirectShadow</summary>
	public  void SetCastCapsuleIndirectShadow(bool bNewValue) {}
	///<summary>SetCapsuleIndirectShadowMinVisibility</summary>
	public  void SetCapsuleIndirectShadowMinVisibility(float NewValue) {}
	///<summary>Returns the number of bones in the skeleton.</summary>
	public  int GetNumBones() { return default; }
	///<summary>Find the index of bone by name. Looks in the current SkeletalMesh being used by this SkeletalMeshComponent.</summary>
	public  int GetBoneIndex(string BoneName) { return default; }
	///<summary>Get Bone Name from index</summary>
	public  string GetBoneName(int BoneIndex) { return default; }
	///<summary>Returns bone name linked to a given named socket on the skeletal mesh component.</summary>
	public  string GetSocketBoneName(string InSocketName) { return default; }
	///<summary>GetSkeletalMesh_DEPRECATED</summary>
	public  USkeletalMesh GetSkeletalMesh_DEPRECATED() { return default; }
	///<summary>Change the SkinnedAsset that is rendered for this Component. Will re-initialize the animation tree etc.</summary>
	public  void SetSkinnedAssetAndUpdate(USkinnedAsset NewMesh,bool bReinitPose/*=true*/) {}
	///<summary>Get the SkinnedAsset rendered for this mesh.</summary>
	public  USkinnedAsset GetSkinnedAsset() { return default; }
	///<summary>Change the MeshDeformer that is used for this Component.</summary>
	public  void SetMeshDeformer(UMeshDeformer InMeshDeformer) {}
	///<summary>Unset any MeshDeformer applied to this Component.</summary>
	public  void UnsetMeshDeformer() {}
	///<summary>Get Parent Bone of the input bone</summary>
	public  string GetParentBone(string BoneName) { return default; }
	///<summary>Get delta transform from reference pose based on BaseNode.</summary>
	public  FTransform GetDeltaTransformFromRefPose(string BoneName,string BaseName/*=NAME_None*/) { return default; }
	///<summary>Get Twist and Swing Angle in Degree of Delta Rotation from Reference Pose in Local space</summary>
	public  bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose(string BoneName,float OutTwistAngle,float OutSwingAngle) { return default; }
	///<summary>Allow override of vertex colors on a per-component basis, taking array of Blueprint-friendly LinearColors.</summary>
	public  void SetVertexColorOverride_LinearColor(int LODIndex,TArray<FLinearColor> VertexColors) {}
	///<summary>Clear any applied vertex color override</summary>
	public  void ClearVertexColorOverride(int LODIndex) {}
	///<summary>Allow override of skin weights on a per-component basis.</summary>
	public  void SetSkinWeightOverride(int LODIndex,TArray<FSkelMeshSkinWeightInfo> SkinWeights) {}
	///<summary>Clear any applied skin weight override</summary>
	public  void ClearSkinWeightOverride(int LODIndex) {}
	///<summary>Setup an override Skin Weight Profile for this component</summary>
	public  bool SetSkinWeightProfile(string InProfileName) { return default; }
	///<summary>Clear the Skin Weight Profile from this component, in case it is set</summary>
	public  void ClearSkinWeightProfile() {}
	///<summary>Unload a Skin Weight Profile&#39;s skin weight buffer (if created)</summary>
	public  void UnloadSkinWeightProfile(string InProfileName) {}
	///<summary>Return the name of the Skin Weight Profile that is currently set otherwise returns &#39;None&#39;</summary>
	public  string GetCurrentSkinWeightProfileName() { return default; }
	///<summary>Check whether or not a Skin Weight Profile is currently set</summary>
	public  bool IsUsingSkinWeightProfile() { return default; }
	///<summary>GetVertexOffsetUsage</summary>
	public  int GetVertexOffsetUsage(int LODIndex) { return default; }
	///<summary>SetVertexOffsetUsage</summary>
	public  void SetVertexOffsetUsage(int LODIndex,int Usage) {}
	///<summary>SetPreSkinningOffsets</summary>
	public  void SetPreSkinningOffsets(int LODIndex,TArray<FVector> Offsets) {}
	///<summary>SetPostSkinningOffsets</summary>
	public  void SetPostSkinningOffsets(int LODIndex,TArray<FVector> Offsets) {}
	///<summary>Get predicted LOD level. This value is usually calculated in UpdateLODStatus, but can be modified by skeletal mesh streaming.</summary>
	public  int GetPredictedLODLevel() { return default; }
	///<summary>Bounds cached, so they&#39;re computed just once, either in local or worldspace depending on cvar &#39;a.CacheLocalSpaceBounds&#39;.</summary>
	public FBoxSphereBounds CachedWorldOrLocalSpaceBounds;
	///<summary>CachedWorldToLocalTransform</summary>
	public FMatrix CachedWorldToLocalTransform;
	///<summary>Set LeaderPoseComponent for this component</summary>
	public  void SetLeaderPoseComponent(USkinnedMeshComponent NewLeaderBoneComponent,bool bForceUpdate/*=false*/,bool bInFollowerShouldTickPose/*=false*/) {}
	///<summary>Tests if BoneName is child of (or equal to) ParentBoneName.</summary>
	public  bool BoneIsChildOf(string BoneName,string ParentBoneName) { return default; }
	///<summary>Gets the local-space position of a bone in the reference pose.</summary>
	public  FVector GetRefPosePosition(int BoneIndex) { return default; }
	///<summary>Gets the local-space transform of a bone in the reference pose.</summary>
	public  FTransform GetRefPoseTransform(int BoneIndex) { return default; }
	///<summary>Transform a location/rotation from world space to bone relative space.</summary>
	public  void TransformToBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,FVector OutPosition,FRotator OutRotation) {}
	///<summary>Transform a location/rotation in bone relative space to world space.</summary>
	public  void TransformFromBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,FVector OutPosition,FRotator OutRotation) {}
	///<summary>finds the closest bone to the given location</summary>
	public  string FindClosestBone_K2(FVector TestLocation,FVector BoneLocation,float IgnoreScale/*=0.0f*/,bool bRequirePhysicsAsset/*=false*/) { return default; }
	///<summary>Hides the specified bone with name.  Currently this just enforces a scale of 0 for the hidden bones.</summary>
	public  void HideBoneByName(string BoneName,EPhysBodyOp PhysBodyOption) {}
	///<summary>UnHide the specified bone with name.  Currently this just enforces a scale of 0 for the hidden bones.</summary>
	public  void UnHideBoneByName(string BoneName) {}
	///<summary>Determines if the specified bone is hidden.</summary>
	public  bool IsBoneHiddenByName(string BoneName) { return default; }
	///<summary>Allows hiding of a particular material (by ID) on this instance of a SkeletalMesh.</summary>
	public  void ShowMaterialSection(int MaterialID,int SectionIndex,bool bShow,int LODIndex) {}
	///<summary>Clear any material visibility modifications made by ShowMaterialSection</summary>
	public  void ShowAllMaterialSections(int LODIndex) {}
	///<summary>Returns whether a specific material section is currently hidden on this component (by using ShowMaterialSection)</summary>
	public  bool IsMaterialSectionShown(int MaterialID,int LODIndex) { return default; }
	///<summary>Set whether this skinned mesh should be rendered as static mesh in a reference pose</summary>
	public  void SetRenderStatic(bool bNewValue) {}
}
