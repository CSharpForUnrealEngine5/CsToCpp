#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingPolicy.h")]
public partial class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy {
	///<summary>ActorToCellRemapping</summary>
	public TMap<string,string> ActorToCellRemapping;
	///<summary>SubObjectsToCellRemapping</summary>
	public TMap<string,string> SubObjectsToCellRemapping;
}
