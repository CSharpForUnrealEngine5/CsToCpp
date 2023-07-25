#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionStreamingSource.h")]
///<summary>Structure containing all properties required to query a streaming state</summary>
public partial struct FWorldPartitionStreamingQuerySource {
// WorldPartitionStreamingQuerySource
	public FVector Location;
	public float Radius;
	public bool bUseGridLoadingRange;
	public TArray<string> DataLayers;
	public bool bDataLayersOnly;
	public bool bSpatialQuery;
}
