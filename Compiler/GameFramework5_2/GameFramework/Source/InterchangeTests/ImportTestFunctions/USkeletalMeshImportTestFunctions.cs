#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/SkeletalMeshImportTestFunctions.h")]
public partial class USkeletalMeshImportTestFunctions : UImportTestFunctionsBase {
// SkeletalMeshImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedSkeletalMeshCount(TArray<USkeletalMesh> Meshes,int ExpectedNumberOfImportedSkeletalMeshes) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderVertexCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfRenderVertices) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderTriangleCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfRenderTriangles) { return default; }
	public static FInterchangeTestFunctionResult CheckLodCount(USkeletalMesh Mesh,int ExpectedNumberOfLods) { return default; }
	public static FInterchangeTestFunctionResult CheckMaterialSlotCount(USkeletalMesh Mesh,int ExpectedNumberOfMaterialSlots) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfSections) { return default; }
	public static FInterchangeTestFunctionResult CheckTriangleCountInSection(USkeletalMesh Mesh,int LodIndex,int SectionIndex,int ExpectedNumberOfTriangles) { return default; }
	public static FInterchangeTestFunctionResult CheckUVChannelCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionMaterialName(USkeletalMesh Mesh,int LodIndex,int SectionIndex,string ExpectedMaterialName) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(USkeletalMesh Mesh,int LodIndex,int SectionIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public static FInterchangeTestFunctionResult CheckVertexIndexPosition(USkeletalMesh Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition) { return default; }
	public static FInterchangeTestFunctionResult CheckVertexIndexNormal(USkeletalMesh Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexNormal) { return default; }
	public static FInterchangeTestFunctionResult CheckBoneCount(USkeletalMesh Mesh,int ExpectedNumberOfBones) { return default; }
	public static FInterchangeTestFunctionResult CheckBonePosition(USkeletalMesh Mesh,int BoneIndex,FVector ExpectedBonePosition) { return default; }
	public static FInterchangeTestFunctionResult CheckSkinnedVertexCountForBone(USkeletalMesh Mesh,string BoneName,bool bTestFirstAlternateProfile,int ExpectedSkinnedVertexCount) { return default; }
}
