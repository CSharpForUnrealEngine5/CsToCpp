namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mass properties configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationMassConfigNode.h")]
public partial struct FChaosClothAssetSimulationMassConfigNode {
	public EClothMassMode MassMode;
	public float UniformMass;
	public float TotalMass;
	public float Density;
}
