namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Add default simulation properties to the cloth collection in the format of the skeletal mesh cloth editor.</summary>
[CppInclude("ChaosClothAsset/SimulationDefaultConfigNode.h")]
public partial struct FChaosClothAssetSimulationDefaultConfigNode {
	public FManagedArrayCollection Collection;
	public UChaosClothConfig SimulationConfig;
	public UChaosClothSharedSimConfig SharedSimulationConfig;
}
