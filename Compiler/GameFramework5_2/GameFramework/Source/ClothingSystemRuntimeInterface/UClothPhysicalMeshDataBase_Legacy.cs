#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deprecated, use FClothPhysicalMeshData instead.</summary>
[CppInclude("ClothPhysicalMeshDataBase_Legacy.h")]
public partial class UClothPhysicalMeshDataBase_Legacy : UObject {
	///<summary>Positions of each simulation vertex</summary>
	public TArray<FVector3f> Vertices;
	///<summary>Normal at each vertex</summary>
	public TArray<FVector3f> Normals;
	///<summary>Color at each vertex</summary>
	public TArray<FColor> VertexColors;
	///<summary>Indices of the simulation mesh triangles</summary>
	public TArray<uint> Indices;
	///<summary>Inverse mass for each vertex in the physical mesh</summary>
	public TArray<float> InverseMasses;
	///<summary>Indices and weights for each vertex, used to skin the mesh to create the reference pose</summary>
	public TArray<FClothVertBoneData> BoneData;
	///<summary>Number of fixed verts in the simulation mesh (fixed verts are just skinned and do not simulate)</summary>
	public int NumFixedVerts;
	///<summary>Maximum number of bone weights of any vetex</summary>
	public int MaxBoneWeights;
	///<summary>Valid indices to use for self collisions (reduced set of Indices)</summary>
	public TArray<uint> SelfCollisionIndices;
}
