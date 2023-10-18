namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import data and options used when importing a static mesh from fbx</summary>
[CppInclude("Factories/FbxSkeletalMeshImportData.h")]
public partial class UFbxSkeletalMeshImportData : UFbxMeshImportData {
	public static UClass StaticClass() {return default;}
	///<summary>Filter the content we want to import from the incoming FBX skeletal mesh.</summary>
	public EFBXImportContentType ImportContentType;
	///<summary>The value of the content type during the last import. This cannot be edited and is set only on successful import or re-import</summary>
	public EFBXImportContentType LastImportContentType;
	///<summary>Specify how vertex colors should be imported</summary>
	public EVertexColorImportOption VertexColorImportOption;
	///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
	public FColor VertexOverrideColor;
	///<summary>If enabled, update the Skeleton (of the mesh being imported)&#39;s reference pose.</summary>
	public bool bUpdateSkeletonReferencePose;
	///<summary>Enable this option to use frame 0 as reference pose</summary>
	public bool bUseT0AsRefPose;
	///<summary>If checked, triangles with non-matching smoothing groups will be physically split.</summary>
	public bool bPreserveSmoothingGroups;
	///<summary>If checked, sections with matching materials are kept separate and will not get combined.</summary>
	public bool bKeepSectionsSeparate;
	///<summary>If checked, meshes nested in bone hierarchies will be imported instead of being converted to bones.</summary>
	public bool bImportMeshesInBoneHierarchy;
	///<summary>If enabled, creates Unreal morph objects for the imported meshes</summary>
	public bool bImportMorphTargets;
	///<summary>If enabled, creates a named vertex attribute for each single-channel weight map of the imported mesh.</summary>
	public bool bImportVertexAttributes;
	///<summary>Threshold to compare vertex position equality.</summary>
	public float ThresholdPosition;
	///<summary>Threshold to compare normal, tangent or bi-normal equality.</summary>
	public float ThresholdTangentNormal;
	///<summary>Threshold to compare UV equality.</summary>
	public float ThresholdUV;
	///<summary>Threshold to compare vertex position equality when computing morph target deltas.</summary>
	public float MorphThresholdPosition;
}
