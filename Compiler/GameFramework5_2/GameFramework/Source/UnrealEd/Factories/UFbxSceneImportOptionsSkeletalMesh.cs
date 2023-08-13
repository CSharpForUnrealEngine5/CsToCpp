namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportOptionsSkeletalMesh.h")]
public partial class UFbxSceneImportOptionsSkeletalMesh : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, update the Skeleton (of the mesh being imported)&#39;s reference pose.</summary>
	public bool bUpdateSkeletonReferencePose;
	///<summary>If checked, create new PhysicsAsset if it doesn&#39;t have it</summary>
	public bool bCreatePhysicsAsset;
	///<summary>TODO support T0AsRefPose Enable this option to use frame 0 as reference pose</summary>
	public bool bUseT0AsRefPose;
	///<summary>If checked, triangles with non-matching smoothing groups will be physically split.</summary>
	public bool bPreserveSmoothingGroups;
	///<summary>If checked, meshes nested in bone hierarchies will be imported instead of being converted to bones.</summary>
	public bool bImportMeshesInBoneHierarchy;
	///<summary>If enabled, creates Unreal morph objects for the imported meshes</summary>
	public bool bImportMorphTargets;
	///<summary>Threshold to compare vertex position equality.</summary>
	public float ThresholdPosition;
	///<summary>Threshold to compare normal, tangent or bi-normal equality.</summary>
	public float ThresholdTangentNormal;
	///<summary>Threshold to compare UV equality.</summary>
	public float ThresholdUV;
	///<summary>Threshold to compare vertex position equality when computing morph target deltas.</summary>
	public float MorphThresholdPosition;
	///<summary>True to import animations from the FBX File</summary>
	public bool bImportAnimations;
	///<summary>Type of asset to import from the FBX file</summary>
	public EFBXAnimationLengthImportType AnimationLength;
	///<summary>Frame range used when Set Range is used in Animation Length</summary>
	public FInt32Interval FrameImportRange;
	///<summary>If enabled, samples all animation curves to 30 FPS</summary>
	public bool bUseDefaultSampleRate;
	///<summary>Sample fbx animation data at the specified sample rate, 0 find automaticaly the best sample rate</summary>
	public int CustomSampleRate;
	///<summary>If enabled, snaps the animation to the closest frame boundary using the import sampling rate</summary>
	public bool bSnapToClosestFrameBoundary;
	///<summary>If true, import node attributes as either Animation Curves or Animation Attributes</summary>
	public bool bImportCustomAttribute;
	///<summary>If true, all previous node attributes imported as Animation Curves will be deleted when doing a re-import.</summary>
	public bool bDeleteExistingCustomAttributeCurves;
	///<summary>If true, all previous node attributes imported as Animation Attributes will be deleted when doing a re-import.</summary>
	public bool bDeleteExistingNonCurveCustomAttributes;
	///<summary>Type of asset to import from the FBX file</summary>
	public bool bPreserveLocalTransform;
	///<summary>Type of asset to import from the FBX file</summary>
	public bool bDeleteExistingMorphTargetCurves;
}
