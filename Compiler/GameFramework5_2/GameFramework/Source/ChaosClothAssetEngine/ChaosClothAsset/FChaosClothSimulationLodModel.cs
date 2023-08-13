namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cloth simulation LOD model.</summary>
[CppInclude("ChaosClothAsset/ClothSimulationModel.h")]
public partial struct FChaosClothSimulationLodModel {
	public TArray<FVector3f> Positions;
	public TArray<FVector3f> Normals;
	public TArray<uint> Indices;
	public TArray<FClothVertBoneData> BoneData;
	public TArray<float> MaxDistance;
}
