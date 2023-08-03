#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseSubsystem.h")]
public partial class UWaveFunctionCollapseSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>WFCModel</summary>
	public UWaveFunctionCollapseModel WFCModel;
	///<summary>Resolution</summary>
	public FIntVector Resolution;
	///<summary>OriginLocation</summary>
	public FVector OriginLocation;
	///<summary>Orientation</summary>
	public FRotator Orientation;
	///<summary>bUseEmptyBorder</summary>
	public bool bUseEmptyBorder;
	///<summary>StarterOptions</summary>
	public TMap<FIntVector,FWaveFunctionCollapseOption> StarterOptions;
	///<summary>Solve a grid using a WFC model.  If successful, spawn an actor.</summary>
	public  AActor Collapse(int TryCount/*=1*/,int RandomSeed/*=0*/) { return default; }
	///<summary>Initialize WFC process which sets up Tiles and RemainingTiles arrays</summary>
	public  void InitializeWFC(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles) {}
	///<summary>Observation phase:</summary>
	public  bool Observe(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles,TMap<int,FWaveFunctionCollapseQueueElement> ObservationQueue,int RandomSeed) { return default; }
	///<summary>Propagation phase:</summary>
	public  bool Propagate(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles,TMap<int,FWaveFunctionCollapseQueueElement> ObservationQueue,int PropagationCount) { return default; }
	///<summary>Recursive Observation and Propagation cycle</summary>
	public  bool ObservationPropagation(TArray<FWaveFunctionCollapseTile> Tiles,TArray<int> RemainingTiles,TMap<int,FWaveFunctionCollapseQueueElement> ObservationQueue,int RandomSeed) { return default; }
	///<summary>Derive grid from the bounds of an array of transforms</summary>
	public  void DeriveGridFromTransformBounds(TArray<FTransform> Transforms) {}
	///<summary>Derive grid from an array of transforms</summary>
	public  void DeriveGridFromTransforms(TArray<FTransform> Transforms) {}
}
