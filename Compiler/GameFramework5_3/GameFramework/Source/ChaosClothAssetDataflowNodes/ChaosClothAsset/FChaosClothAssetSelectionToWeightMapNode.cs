namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convert an integer index selection to a vertex weight map where different map values can be set for selected and unselected vertices.</summary>
[CppInclude("ChaosClothAsset/SelectionToWeightMapNode.h")]
public partial struct FChaosClothAssetSelectionToWeightMapNode {
	public FManagedArrayCollection Collection;
	public string SelectionName;
	public string WeightMapName;
	public float UnselectedValue;
	public float SelectedValue;
}
