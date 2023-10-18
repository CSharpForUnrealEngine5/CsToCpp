namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Copy the simulation mesh to the render mesh to be able to render the simulation mesh, or when not using a different mesh for rendering.</summary>
[CppInclude("ChaosClothAsset/CopySimulationToRenderMeshNode.h")]
public partial struct FChaosClothAssetCopySimulationToRenderMeshNode {
	public FManagedArrayCollection Collection;
	public UMaterialInterface Material;
	public bool bGenerateSingleRenderPattern;
}
