namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/SkeletalMeshImportTestFunctions.h")]
public partial class USkeletalMeshImportTestFunctions : UImportTestFunctionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the expected number of skeletal meshes are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedSkeletalMeshCount(TArray<USkeletalMesh> Meshes,int ExpectedNumberOfImportedSkeletalMeshes) { return default; }
	///<summary>Check whether the vertex count in the built render data for the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckRenderVertexCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfRenderVertices) { return default; }
	///<summary>Check whether the triangle count in the built render data for the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckRenderTriangleCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfRenderTriangles) { return default; }
	///<summary>Check whether the mesh has the expected number of LODs</summary>
	public static FInterchangeTestFunctionResult CheckLodCount(USkeletalMesh Mesh,int ExpectedNumberOfLods) { return default; }
	///<summary>Check whether the mesh has the expected number of material slots</summary>
	public static FInterchangeTestFunctionResult CheckMaterialSlotCount(USkeletalMesh Mesh,int ExpectedNumberOfMaterialSlots) { return default; }
	///<summary>Check whether the built render data for the given mesh LOD has the expected number of sections</summary>
	public static FInterchangeTestFunctionResult CheckSectionCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfSections) { return default; }
	///<summary>Check whether the given section in the built render data for the given LOD has the expected number of triangles</summary>
	public static FInterchangeTestFunctionResult CheckTriangleCountInSection(USkeletalMesh Mesh,int LodIndex,int SectionIndex,int ExpectedNumberOfTriangles) { return default; }
	///<summary>Check whether the mesh has the expected number of UV channels</summary>
	public static FInterchangeTestFunctionResult CheckUVChannelCount(USkeletalMesh Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	///<summary>Check whether the material name for the given section in the render data for the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckSectionMaterialName(USkeletalMesh Mesh,int LodIndex,int SectionIndex,string ExpectedMaterialName) { return default; }
	///<summary>Check whether the imported material slot name for the given section in the render data for the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(USkeletalMesh Mesh,int LodIndex,int SectionIndex,string ExpectedImportedMaterialSlotName) { return default; }
	///<summary>Check whether the vertex of the given index is at the expected position</summary>
	public static FInterchangeTestFunctionResult CheckVertexIndexPosition(USkeletalMesh Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition) { return default; }
	///<summary>Check whether the vertex of the given index is at the expected normal</summary>
	public static FInterchangeTestFunctionResult CheckVertexIndexNormal(USkeletalMesh Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexNormal) { return default; }
	///<summary>Check whether the mesh has the expected number of bones</summary>
	public static FInterchangeTestFunctionResult CheckBoneCount(USkeletalMesh Mesh,int ExpectedNumberOfBones) { return default; }
	///<summary>Check that the bone of the specified index has the expected position</summary>
	public static FInterchangeTestFunctionResult CheckBonePosition(USkeletalMesh Mesh,int BoneIndex,FVector ExpectedBonePosition) { return default; }
	///<summary>Check that the specified bone name is skinned with the expected number of vertices</summary>
	public static FInterchangeTestFunctionResult CheckSkinnedVertexCountForBone(USkeletalMesh Mesh,string BoneName,bool bTestFirstAlternateProfile,int ExpectedSkinnedVertexCount) { return default; }
}
