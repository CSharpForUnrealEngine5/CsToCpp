namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cloth terminal node to generate a cloth asset from a cloth collection.</summary>
[CppInclude("ChaosClothAsset/TerminalNode.h")]
public partial struct FChaosClothAssetTerminalNode {
	public FManagedArrayCollection CollectionLod0;
	public FManagedArrayCollection CollectionLod1;
	public FManagedArrayCollection CollectionLod2;
	public FManagedArrayCollection CollectionLod3;
	public FManagedArrayCollection CollectionLod4;
	public FManagedArrayCollection CollectionLod5;
	public int NumLods;
	public TArray<FChaosClothAssetLodTransitionDataCache> LODTransitionDataCache;
}
