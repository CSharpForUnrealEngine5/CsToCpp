namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseBPLibrary.h")]
public partial class UWaveFunctionCollapseBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Calculates Shannon Entropy from an array of options and a given model</summary>
	public static float CalculateShannonEntropy(TArray<FWaveFunctionCollapseOption> Options,UWaveFunctionCollapseModel WFCModel) { return default; }
	///<summary>Convert 3D grid position to 2D array index</summary>
	public static int PositionAsIndex(FIntVector Position,FIntVector Resolution) { return default; }
	///<summary>Convert 2D array index to 3D grid position</summary>
	public static FIntVector IndexAsPosition(int Index,FIntVector Resolution) { return default; }
	///<summary>Builds the initial tile which adds every unique option in a model to its RemainingOptions array and calculates its entropy</summary>
	public static FWaveFunctionCollapseTile BuildInitialTile(UWaveFunctionCollapseModel WFCModel) { return default; }
	///<summary>Get adjacent indices of a given index and its adjacency</summary>
	public static TMap<int,EWaveFunctionCollapseAdjacency> GetAdjacentIndices(int Index,FIntVector Resolution) { return default; }
	///<summary>Get adjacent positions of a given position and its adjacency</summary>
	public static TMap<FIntVector,EWaveFunctionCollapseAdjacency> GetAdjacentPositions(FIntVector Position,FIntVector Resolution) { return default; }
	///<summary>Is the option contained in the given options array</summary>
	public static bool IsOptionContained(FWaveFunctionCollapseOption Option,TArray<FWaveFunctionCollapseOption> Options) { return default; }
	///<summary>Get the opposite adjacency for a given adjacency.  For example GetOppositeAdjacency(Front) will return Back.</summary>
	public static EWaveFunctionCollapseAdjacency GetOppositeAdjacency(EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	///<summary>Get the next adjacency in clockwise direction on a Z-axis for a given adjacency.</summary>
	public static EWaveFunctionCollapseAdjacency GetNextZAxisClockwiseAdjacency(EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	///<summary>Add an entry to an AdjacencyToOptionsMap</summary>
	public static void AddToAdjacencyToOptionsMap(FWaveFunctionCollapseAdjacencyToOptionsMap AdjacencyToOptionsMap,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOption Option) {}
	///<summary>IsSoftObjPathEqual</summary>
	public static bool IsSoftObjPathEqual(FSoftObjectPath SoftObjectPathA,FSoftObjectPath SoftObjectPathB) { return default; }
	///<summary>Converts Rotator to Matrix and back to sanitize multiple representations of the same rotation to a common Rotator value</summary>
	public static FRotator SanitizeRotator(FRotator Rotator) { return default; }
	///<summary>Derive constraints from a given layout of actors and append them to a model</summary>
	public static void DeriveModelFromActors(TArray<AActor> Actors,UWaveFunctionCollapseModel WFCModel,float TileSize,bool bIsBorderEmptyOption,bool bIsMinZFloorOption,bool bUseUniformWeightDistribution,bool bAutoDeriveZAxisRotationConstraints,TArray<FSoftObjectPath> SpawnExclusionAssets,TArray<FSoftObjectPath> IgnoreRotationAssets) {}
	///<summary>Get PositionToOptionsMap from a given actor that has ISM components.</summary>
	public static bool GetPositionToOptionMapFromActor(AActor Actor,float TileSize,TMap<FIntVector,FWaveFunctionCollapseOption> PositionToOptionMap) { return default; }
	///<summary>Make FWaveFunctionCollapseOption of type: EmptyOption</summary>
	public static FWaveFunctionCollapseOption MakeEmptyOption() { return default; }
	///<summary>Make FWaveFunctionCollapseOption of type: BorderOption</summary>
	public static FWaveFunctionCollapseOption MakeBorderOption() { return default; }
	///<summary>Make FWaveFunctionCollapseOption of type: VoidOption</summary>
	public static FWaveFunctionCollapseOption MakeVoidOption() { return default; }
}
