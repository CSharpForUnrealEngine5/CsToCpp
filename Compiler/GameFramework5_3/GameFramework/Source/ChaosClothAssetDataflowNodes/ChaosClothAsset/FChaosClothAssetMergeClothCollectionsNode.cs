namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Merge multiple cloth collections into a single cloth collection of multiple patterns.</summary>
[CppInclude("ChaosClothAsset/MergeClothCollectionsNode.h")]
public partial struct FChaosClothAssetMergeClothCollectionsNode {
	public FManagedArrayCollection Collection;
	public FManagedArrayCollection Collection1;
	public FManagedArrayCollection Collection2;
	public FManagedArrayCollection Collection3;
	public FManagedArrayCollection Collection4;
	public FManagedArrayCollection Collection5;
	public int NumInputs;
}
