#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hide drop down will make sure the class is not showing in the class picker</summary>
[CppInclude("InterchangeGenericMeshPipeline.h")]
public partial class UInterchangeGenericMeshPipeline : UInterchangePipelineBase {
	///<summary>Common Meshes Properties Settings Pointer</summary>
	public TWeakObjectPtr<UInterchangeGenericCommonMeshesProperties> CommonMeshesProperties;
	///<summary>Common SkeletalMeshes And Animations Properties Settings Pointer</summary>
	public TWeakObjectPtr<UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties> CommonSkeletalMeshesAndAnimationsProperties;
	///<summary>If enabled, import the static mesh asset found in the sources.</summary>
	public bool bImportStaticMeshes;
	///<summary>If enabled, all translated static mesh nodes will be imported as a single static mesh.</summary>
	public bool bCombineStaticMeshes;
	///<summary>If enabled, meshes with certain prefixes will be imported as collision primitives for the mesh with the corresponding unprefixed name.</summary>
	public bool bImportCollisionAccordingToMeshName;
	///<summary>If enabled, each UCX collision mesh will be imported as a single convex hull. If disabled, a UCX mesh will be decomposed into its separate pieces and a convex hull generated for each.</summary>
	public bool bOneConvexHullPerUCX;
	///<summary>If enabled this option will allow you to use Nanite rendering at runtime. Can only be used with simple opaque materials.</summary>
	public bool bBuildNanite;
	///<summary>If enabled this option will make sure the staticmesh build a reverse index buffer.</summary>
	public bool bBuildReversedIndexBuffer;
	///<summary>If enabled this option will generate lightmap for this staticmesh.</summary>
	public bool bGenerateLightmapUVs;
	///<summary>Whether to generate the distance field treating every triangle hit as a front face.</summary>
	public bool bGenerateDistanceFieldAsIfTwoSided;
	///<summary>bSupportFaceRemap</summary>
	public bool bSupportFaceRemap;
	///<summary>MinLightmapResolution</summary>
	public int MinLightmapResolution;
	///<summary>SrcLightmapIndex</summary>
	public int SrcLightmapIndex;
	///<summary>DstLightmapIndex</summary>
	public int DstLightmapIndex;
	///<summary>The local scale applied when building the mesh</summary>
	public FVector BuildScale3D;
	///<summary>Scale to apply to the mesh when allocating the distance field volume texture.</summary>
	public float DistanceFieldResolutionScale;
	///<summary>DistanceFieldReplacementMesh</summary>
	public TWeakObjectPtr<UStaticMesh> DistanceFieldReplacementMesh;
	///<summary>Max Lumen mesh cards to generate for this mesh.</summary>
	public int MaxLumenMeshCards;
	///<summary>If enable, import the animation asset find in the sources.</summary>
	public bool bImportSkeletalMeshes;
	///<summary>Re-import partially or totally a skeletal mesh. You can choose betwwen geometry, skinning or everything.</summary>
	public EInterchangeSkeletalMeshContentType SkeletalMeshImportContentType;
	///<summary>The value of the content type during the last import. This cannot be edited and is set only on successful import or re-import</summary>
	public EInterchangeSkeletalMeshContentType LastSkeletalMeshImportContentType;
	///<summary>If enable all translated skinned mesh node will be imported has a one skeletal mesh, note that it can still create several skeletal mesh for each different skeleton root joint.</summary>
	public bool bCombineSkeletalMeshes;
	///<summary>If enable any morph target shape will be imported.</summary>
	public bool bImportMorphTargets;
	///<summary>Enable this option to update Skeleton (of the mesh)&#39;s reference pose. Mesh&#39;s reference pose is always updated.</summary>
	public bool bUpdateSkeletonReferencePose;
	///<summary>If checked, create new PhysicsAsset if it doesn&#39;t have it</summary>
	public bool bCreatePhysicsAsset;
	///<summary>If this is set, use this specified PhysicsAsset. If its not set and bCreatePhysicsAsset is false, the importer will not generate or set any physic asset.</summary>
	public TWeakObjectPtr<UPhysicsAsset> PhysicsAsset;
	///<summary>If Checked, use 16 bits for skin weights instead of 8 bits.</summary>
	public bool bUseHighPrecisionSkinWeights;
	///<summary>Threshold use to decide if two vertex position are equal.</summary>
	public float ThresholdPosition;
	///<summary>Threshold use to decide if two normal, tangents or bi-normals are equal.</summary>
	public float ThresholdTangentNormal;
	///<summary>Threshold use to decide if two UVs are equal.</summary>
	public float ThresholdUV;
	///<summary>Threshold to compare vertex position equality when computing morph target deltas.</summary>
	public float MorphThresholdPosition;
	///<summary>The maximum number of bone influences to allow each vertex in this mesh to use.</summary>
	public int BoneInfluenceLimit;
}
