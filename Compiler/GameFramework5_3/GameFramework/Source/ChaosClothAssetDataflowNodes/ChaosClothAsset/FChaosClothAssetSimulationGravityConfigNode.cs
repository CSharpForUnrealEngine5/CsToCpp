namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gravity properties configuration node.</summary>
[CppInclude("ChaosClothAsset/SimulationGravityConfigNode.h")]
public partial struct FChaosClothAssetSimulationGravityConfigNode {
	public bool bUseGravityOverride;
	public float GravityScale;
	public FVector3f GravityOverride;
}
