#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/SkeletalMeshImportTestFunctions.h")]
public partial class USkeletalMeshImportTestFunctions : UImportTestFunctionsBase {
// SkeletalMeshImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedSkeletalMeshCount(TArray<UObject> Meshes,int ExpectedNumberOfImportedSkeletalMeshes) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexCount(UObject Mesh,int LodIndex,int ExpectedNumberOfRenderVertices) { return default; }
	public FInterchangeTestFunctionResult CheckRenderTriangleCount(UObject Mesh,int LodIndex,int ExpectedNumberOfRenderTriangles) { return default; }
	public FInterchangeTestFunctionResult CheckLodCount(UObject Mesh,int ExpectedNumberOfLods) { return default; }
	public FInterchangeTestFunctionResult CheckMaterialSlotCount(UObject Mesh,int ExpectedNumberOfMaterialSlots) { return default; }
	public FInterchangeTestFunctionResult CheckSectionCount(UObject Mesh,int LodIndex,int ExpectedNumberOfSections) { return default; }
	public FInterchangeTestFunctionResult CheckTriangleCountInSection(UObject Mesh,int LodIndex,int SectionIndex,int ExpectedNumberOfTriangles) { return default; }
	public FInterchangeTestFunctionResult CheckUVChannelCount(UObject Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	public FInterchangeTestFunctionResult CheckSectionMaterialName(UObject Mesh,int LodIndex,int SectionIndex,string ExpectedMaterialName) { return default; }
	public FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UObject Mesh,int LodIndex,int SectionIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public FInterchangeTestFunctionResult CheckVertexIndexPosition(UObject Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition) { return default; }
	public FInterchangeTestFunctionResult CheckVertexIndexNormal(UObject Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexNormal) { return default; }
	public FInterchangeTestFunctionResult CheckBoneCount(UObject Mesh,int ExpectedNumberOfBones) { return default; }
	public FInterchangeTestFunctionResult CheckBonePosition(UObject Mesh,int BoneIndex,FVector ExpectedBonePosition) { return default; }
	public FInterchangeTestFunctionResult CheckSkinnedVertexCountForBone(UObject Mesh,string BoneName,bool bTestFirstAlternateProfile,int ExpectedSkinnedVertexCount) { return default; }
}
