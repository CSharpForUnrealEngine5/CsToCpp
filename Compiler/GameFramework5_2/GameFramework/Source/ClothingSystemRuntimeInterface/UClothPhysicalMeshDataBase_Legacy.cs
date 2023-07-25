#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothPhysicalMeshDataBase_Legacy.h")]
///<summary>Deprecated, use FClothPhysicalMeshData instead.</summary>
public partial class UClothPhysicalMeshDataBase_Legacy : UObject {
// ClothPhysicalMeshDataBase_Legacy
	public TArray<FVector3f> Vertices;
	public TArray<FVector3f> Normals;
	public TArray<FColor> VertexColors;
	public TArray<uint> Indices;
	public TArray<float> InverseMasses;
	public TArray<FClothVertBoneData> BoneData;
	public int NumFixedVerts;
	public int MaxBoneWeights;
	public TArray<uint> SelfCollisionIndices;
}
