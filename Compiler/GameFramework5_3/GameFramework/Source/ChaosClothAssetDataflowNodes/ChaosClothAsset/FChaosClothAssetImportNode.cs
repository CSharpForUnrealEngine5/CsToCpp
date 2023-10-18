namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import an existing Cloth Asset into the graph.</summary>
[CppInclude("ChaosClothAsset/ImportNode.h")]
public partial struct FChaosClothAssetImportNode {
	public FManagedArrayCollection Collection;
	public UChaosClothAsset ClothAsset;
	public int ImportLod;
}
