#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseBPLibrary.h")]
public partial class UWaveFunctionCollapseBPLibrary : UBlueprintFunctionLibrary {
// WaveFunctionCollapseBPLibrary
	public float CalculateShannonEntropy(TArray<FWaveFunctionCollapseOption> Options,UObject WFCModel) { return default; }
	public int PositionAsIndex(FIntVector Position,FIntVector Resolution) { return default; }
	public FIntVector IndexAsPosition(int Index,FIntVector Resolution) { return default; }
	public FWaveFunctionCollapseTile BuildInitialTile(UObject WFCModel) { return default; }
	public TMap<int,EWaveFunctionCollapseAdjacency> GetAdjacentIndices(int Index,FIntVector Resolution) { return default; }
	public TMap<FIntVector,EWaveFunctionCollapseAdjacency> GetAdjacentPositions(FIntVector Position,FIntVector Resolution) { return default; }
	public bool IsOptionContained(FWaveFunctionCollapseOption Option,TArray<FWaveFunctionCollapseOption> Options) { return default; }
	public EWaveFunctionCollapseAdjacency GetOppositeAdjacency(EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	public EWaveFunctionCollapseAdjacency GetNextZAxisClockwiseAdjacency(EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	public void AddToAdjacencyToOptionsMap(FWaveFunctionCollapseAdjacencyToOptionsMap AdjacencyToOptionsMap,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOption Option) {}
	public bool IsSoftObjPathEqual(FSoftObjectPath SoftObjectPathA,FSoftObjectPath SoftObjectPathB) { return default; }
	public FRotator SanitizeRotator(FRotator Rotator) { return default; }
	public void DeriveModelFromActors(TArray<UObject> Actors,UObject WFCModel,float TileSize,bool bIsBorderEmptyOption,bool bIsMinZFloorOption,bool bUseUniformWeightDistribution,bool bAutoDeriveZAxisRotationConstraints,TArray<FSoftObjectPath> SpawnExclusionAssets,TArray<FSoftObjectPath> IgnoreRotationAssets) {}
	public bool GetPositionToOptionMapFromActor(UObject Actor,float TileSize,TMap<FIntVector,FWaveFunctionCollapseOption> PositionToOptionMap) { return default; }
	public FWaveFunctionCollapseOption MakeEmptyOption() { return default; }
	public FWaveFunctionCollapseOption MakeBorderOption() { return default; }
	public FWaveFunctionCollapseOption MakeVoidOption() { return default; }
}
