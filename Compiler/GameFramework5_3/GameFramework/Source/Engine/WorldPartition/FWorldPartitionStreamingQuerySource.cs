namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing all properties required to query a streaming state</summary>
[CppInclude("WorldPartition/WorldPartitionStreamingSource.h")]
public partial struct FWorldPartitionStreamingQuerySource {
	public FVector Location;
	public float Radius;
	public bool bUseGridLoadingRange;
	public TArray<FName> DataLayers;
	public bool bDataLayersOnly;
	public bool bSpatialQuery;
}
