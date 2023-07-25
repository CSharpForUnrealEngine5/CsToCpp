#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
///<summary>Represents a PIE/Game streaming grid level</summary>
public partial struct FSpatialHashStreamingGridLevel {
// SpatialHashStreamingGridLevel
	public TArray<FSpatialHashStreamingGridLayerCell> LayerCells;
	public TMap<long,int> LayerCellsMapping;
}
