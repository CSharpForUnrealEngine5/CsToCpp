#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cloth simulation model.</summary>
[CppInclude("ChaosClothAsset/ClothSimulationModel.h")]
public partial struct FChaosClothSimulationModel {
	public TArray<FChaosClothSimulationLodModel> ClothSimulationLodModels;
	public TArray<string> UsedBoneNames;
	public TArray<int> UsedBoneIndices;
	public int ReferenceBoneIndex;
}
