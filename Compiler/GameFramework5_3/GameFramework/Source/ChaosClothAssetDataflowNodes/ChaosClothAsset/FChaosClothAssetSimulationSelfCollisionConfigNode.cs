namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Self-collision repulsion forces (point-face) properties configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationSelfCollisionConfigNode.h")]
public partial struct FChaosClothAssetSimulationSelfCollisionConfigNode {
	public float SelfCollisionThickness;
	public float SelfCollisionStiffness;
	public float SelfCollisionFriction;
	public bool bUseSelfIntersections;
}
