namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>XPBD anisotropic stretch constraint property configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationXPBDAnisoStretchConfigNode.h")]
public partial struct FChaosClothAssetSimulationXPBDAnisoStretchConfigNode {
	public bool bXPBDAnisoStretchUse3dRestLengths;
	public FChaosClothAssetWeightedValue XPBDAnisoStretchStiffnessWarp;
	public FChaosClothAssetWeightedValue XPBDAnisoStretchStiffnessWeft;
	public FChaosClothAssetWeightedValue XPBDAnisoStretchStiffnessBias;
	public FChaosClothAssetWeightedValue XPBDAnisoStretchDamping;
	public FChaosClothAssetWeightedValue XPBDAnisoStretchWarpScale;
	public FChaosClothAssetWeightedValue XPBDAnisoStretchWeftScale;
}
