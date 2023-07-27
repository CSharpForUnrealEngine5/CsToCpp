#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseSubsystem.h")]
public partial class UWaveFunctionCollapseSubsystem : UEditorSubsystem {
// WaveFunctionCollapseSubsystem
	public UWaveFunctionCollapseModel WFCModel;
	public FIntVector Resolution;
	public FVector OriginLocation;
	public FRotator Orientation;
	public bool bUseEmptyBorder;
	public TMap<FIntVector,FWaveFunctionCollapseOption> StarterOptions;
	public  AActor Collapse(int TryCount/*=1*/,int RandomSeed/*=0*/) { return default; }
	public  void InitializeWFC(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles) {}
	public  bool Observe(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles,TMap<int,FWaveFunctionCollapseQueueElement> ObservationQueue,int RandomSeed) { return default; }
	public  bool Propagate(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles,TMap<int,FWaveFunctionCollapseQueueElement> ObservationQueue,int PropagationCount) { return default; }
	public  bool ObservationPropagation(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles,TMap<int,FWaveFunctionCollapseQueueElement> ObservationQueue,int RandomSeed) { return default; }
	public  void DeriveGridFromTransformBounds(TArray<FTransform> Transforms) {}
	public  void DeriveGridFromTransforms(TArray<FTransform> Transforms) {}
}
