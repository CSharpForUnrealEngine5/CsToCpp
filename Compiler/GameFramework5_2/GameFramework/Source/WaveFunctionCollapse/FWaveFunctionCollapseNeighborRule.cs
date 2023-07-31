#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
