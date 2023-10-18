namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bending element constraint property configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationPBDBendingElementConfigNode.h")]
public partial struct FChaosClothAssetSimulationPBDBendingElementConfigNode {
	public EChaosClothAssetRestAngleConstructionType RestAngleType;
	public FChaosClothAssetWeightedValueNonAnimatable FlatnessRatio;
	public FChaosClothAssetWeightedValueNonAnimatable RestAngle;
	public FChaosClothAssetWeightedValue BendingElementStiffness;
	public float BucklingRatio;
	public FChaosClothAssetWeightedValue BucklingStiffness;
}
