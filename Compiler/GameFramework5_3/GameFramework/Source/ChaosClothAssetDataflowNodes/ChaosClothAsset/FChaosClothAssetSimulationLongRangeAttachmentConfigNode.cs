namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Long range attachment constraint property configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationLongRangeAttachmentConfigNode.h")]
public partial struct FChaosClothAssetSimulationLongRangeAttachmentConfigNode {
	public FChaosClothAssetWeightedValue TetherStiffness;
	public FChaosClothAssetWeightedValue TetherScale;
	public bool bUseGeodesicTethers;
	public string FixedEndWeightMap;
}
