namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Integer index set selection node</summary>
[CppInclude("ChaosClothAsset/SelectionNode.h")]
public partial struct FChaosClothAssetSelectionNode {
	public FManagedArrayCollection Collection;
	public string Name;
	public EChaosClothAssetSelectionType Type;
	public TSet<int> Indices;
}
