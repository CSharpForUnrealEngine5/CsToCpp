namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>XPBD anisotropic bending constraint property configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationXPBDAnisoBendingConfigNode.h")]
public partial struct FChaosClothAssetSimulationXPBDAnisoBendingConfigNode {
	public EChaosClothAssetRestAngleConstructionType XPBDAnisoRestAngleType;
	public FChaosClothAssetWeightedValueNonAnimatable XPBDAnisoFlatnessRatio;
	public FChaosClothAssetWeightedValueNonAnimatable XPBDAnisoRestAngle;
	public FChaosClothAssetWeightedValue XPBDAnisoBendingStiffnessWarp;
	public FChaosClothAssetWeightedValue XPBDAnisoBendingStiffnessWeft;
	public FChaosClothAssetWeightedValue XPBDAnisoBendingStiffnessBias;
	public FChaosClothAssetWeightedValue XPBDAnisoBendingDamping;
	public float XPBDAnisoBucklingRatio;
	public FChaosClothAssetWeightedValue XPBDAnisoBucklingStiffnessWarp;
	public FChaosClothAssetWeightedValue XPBDAnisoBucklingStiffnessWeft;
	public FChaosClothAssetWeightedValue XPBDAnisoBucklingStiffnessBias;
}