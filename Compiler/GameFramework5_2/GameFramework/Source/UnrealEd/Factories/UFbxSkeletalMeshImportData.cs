#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSkeletalMeshImportData.h")]
///<summary>Import data and options used when importing a static mesh from fbx</summary>
public partial class UFbxSkeletalMeshImportData : UFbxMeshImportData {
// FbxSkeletalMeshImportData
	public byte ImportContentType;
	public byte LastImportContentType;
	public byte VertexColorImportOption;
	public FColor VertexOverrideColor;
	public bool bUpdateSkeletonReferencePose;
	public bool bUseT0AsRefPose;
	public bool bPreserveSmoothingGroups;
	public bool bImportMeshesInBoneHierarchy;
	public bool bImportMorphTargets;
	public float ThresholdPosition;
	public float ThresholdTangentNormal;
	public float ThresholdUV;
	public float MorphThresholdPosition;
}
