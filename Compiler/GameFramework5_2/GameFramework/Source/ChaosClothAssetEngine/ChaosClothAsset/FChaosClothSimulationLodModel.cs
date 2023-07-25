#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothSimulationModel.h")]
///<summary>Cloth simulation LOD model.</summary>
public partial struct FChaosClothSimulationLodModel {
// ChaosClothSimulationLodModel
	public TArray<FVector3f> Positions;
	public TArray<FVector3f> Normals;
	public TArray<uint> Indices;
	public TArray<FClothVertBoneData> BoneData;
	public TArray<float> MaxDistance;
}
