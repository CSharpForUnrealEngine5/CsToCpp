#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseBPLibrary.h")]
public partial class UWaveFunctionCollapseBPLibrary : UBlueprintFunctionLibrary {
// WaveFunctionCollapseBPLibrary
	public static float CalculateShannonEntropy(TArray<FWaveFunctionCollapseOption> Options,UWaveFunctionCollapseModel WFCModel) { return default; }
	public static int PositionAsIndex(FIntVector Position,FIntVector Resolution) { return default; }
	public static FIntVector IndexAsPosition(int Index,FIntVector Resolution) { return default; }
	public static FWaveFunctionCollapseTile BuildInitialTile(UWaveFunctionCollapseModel WFCModel) { return default; }
	public static TMap<int,EWaveFunctionCollapseAdjacency> GetAdjacentIndices(int Index,FIntVector Resolution) { return default; }
	public static TMap<FIntVector,EWaveFunctionCollapseAdjacency> GetAdjacentPositions(FIntVector Position,FIntVector Resolution) { return default; }
	public static bool IsOptionContained(FWaveFunctionCollapseOption Option,TArray<FWaveFunctionCollapseOption> Options) { return default; }
	public static EWaveFunctionCollapseAdjacency GetOppositeAdjacency(EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	public static EWaveFunctionCollapseAdjacency GetNextZAxisClockwiseAdjacency(EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	public static void AddToAdjacencyToOptionsMap(FWaveFunctionCollapseAdjacencyToOptionsMap AdjacencyToOptionsMap,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOption Option) {}
	public static bool IsSoftObjPathEqual(FSoftObjectPath SoftObjectPathA,FSoftObjectPath SoftObjectPathB) { return default; }
	public static FRotator SanitizeRotator(FRotator Rotator) { return default; }
	public static void DeriveModelFromActors(TArray<AActor> Actors,UWaveFunctionCollapseModel WFCModel,float TileSize,bool bIsBorderEmptyOption,bool bIsMinZFloorOption,bool bUseUniformWeightDistribution,bool bAutoDeriveZAxisRotationConstraints,TArray<FSoftObjectPath> SpawnExclusionAssets,TArray<FSoftObjectPath> IgnoreRotationAssets) {}
	public static bool GetPositionToOptionMapFromActor(AActor Actor,float TileSize,TMap<FIntVector,FWaveFunctionCollapseOption> PositionToOptionMap) { return default; }
	public static FWaveFunctionCollapseOption MakeEmptyOption() { return default; }
	public static FWaveFunctionCollapseOption MakeBorderOption() { return default; }
	public static FWaveFunctionCollapseOption MakeVoidOption() { return default; }
}
