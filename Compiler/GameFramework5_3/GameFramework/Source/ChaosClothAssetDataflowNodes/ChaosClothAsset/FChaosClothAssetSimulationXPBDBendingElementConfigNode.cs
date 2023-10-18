namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>XPBD bending element constraint property configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationXPBDBendingElementConfigNode.h")]
public partial struct FChaosClothAssetSimulationXPBDBendingElementConfigNode {
	public EChaosClothAssetRestAngleConstructionType XPBDRestAngleType;
	public FChaosClothAssetWeightedValueNonAnimatable XPBDFlatnessRatio;
	public FChaosClothAssetWeightedValueNonAnimatable XPBDRestAngle;
	public FChaosClothAssetWeightedValue XPBDBendingElementStiffness;
	public FChaosClothAssetWeightedValue XPBDBendingElementDamping;
	public float XPBDBucklingRatio;
	public FChaosClothAssetWeightedValue XPBDBucklingStiffness;
}
