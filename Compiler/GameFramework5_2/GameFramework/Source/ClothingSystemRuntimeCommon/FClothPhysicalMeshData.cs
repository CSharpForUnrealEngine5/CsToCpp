#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothPhysicalMeshData.h")]
///<summary>Spatial simulation data for a mesh.</summary>
public partial struct FClothPhysicalMeshData {
// ClothPhysicalMeshData
	public TArray<FVector3f> Vertices;
	public TArray<FVector3f> Normals;
	public TArray<FColor> VertexColors;
	public TArray<uint> Indices;
	public TMap<uint,FPointWeightMap> WeightMaps;
	public TArray<float> InverseMasses;
	public TArray<FClothVertBoneData> BoneData;
	public TArray<uint> SelfCollisionIndices;
	public FClothTetherData EuclideanTethers;
	public FClothTetherData GeodesicTethers;
	public int MaxBoneWeights;
	public int NumFixedVerts;
	public TArray<float> MaxDistances_DEPRECATED;
	public TArray<float> BackstopDistances_DEPRECATED;
	public TArray<float> BackstopRadiuses_DEPRECATED;
	public TArray<float> AnimDriveMultipliers_DEPRECATED;
}
