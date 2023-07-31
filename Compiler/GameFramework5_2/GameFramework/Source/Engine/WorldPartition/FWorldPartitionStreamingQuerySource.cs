#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing all properties required to query a streaming state</summary>
[CppInclude("WorldPartition/WorldPartitionStreamingSource.h")]
public partial struct FWorldPartitionStreamingQuerySource {
	public FVector Location;
	public float Radius;
	public bool bUseGridLoadingRange;
	public TArray<string> DataLayers;
	public bool bDataLayersOnly;
	public bool bSpatialQuery;
}
