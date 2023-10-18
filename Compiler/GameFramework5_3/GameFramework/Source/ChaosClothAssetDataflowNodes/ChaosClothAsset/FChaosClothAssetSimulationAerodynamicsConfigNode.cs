namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Aerodynamics properties configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationAerodynamicsConfigNode.h")]
public partial struct FChaosClothAssetSimulationAerodynamicsConfigNode {
	public float FluidDensity;
	public FChaosClothAssetWeightedValue Drag;
	public FChaosClothAssetWeightedValue Lift;
	public FVector3f WindVelocity;
}
