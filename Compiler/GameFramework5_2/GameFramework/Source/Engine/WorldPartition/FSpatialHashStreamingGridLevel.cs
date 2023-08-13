namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a PIE/Game streaming grid level</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial struct FSpatialHashStreamingGridLevel {
	public TArray<FSpatialHashStreamingGridLayerCell> LayerCells;
	public TMap<long,int> LayerCellsMapping;
}
