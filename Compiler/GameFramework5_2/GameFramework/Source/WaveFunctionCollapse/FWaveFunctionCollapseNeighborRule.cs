namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseBPLibrary.h")]
public partial struct FWaveFunctionCollapseNeighborRule {
	public FSoftObjectPath KeyObject;
	public TArray<FWaveFunctionCollapseNeighbor> Neighbors;
	public TArray<FSoftObjectPath> SpawnObjects;
	public FTransform SpawnRelativeTransform;
	public float SpawnChance;
}
