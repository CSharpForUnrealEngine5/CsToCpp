#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothSimulationModel.h")]
///<summary>Cloth simulation model.</summary>
public partial struct FChaosClothSimulationModel {
// ChaosClothSimulationModel
	public TArray<FChaosClothSimulationLodModel> ClothSimulationLodModels;
	public TArray<string> UsedBoneNames;
	public TArray<int> UsedBoneIndices;
	public int ReferenceBoneIndex;
}
