namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Physics mesh collision properties configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationCollisionConfigNode.h")]
public partial struct FChaosClothAssetSimulationCollisionConfigNode {
	public float CollisionThickness;
	public float FrictionCoefficient;
	public bool bUseCCD;
}
