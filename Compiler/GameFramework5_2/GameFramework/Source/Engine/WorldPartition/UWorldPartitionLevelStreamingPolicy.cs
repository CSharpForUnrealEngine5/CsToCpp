namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingPolicy.h")]
public partial class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy {
	public static UClass StaticClass() {return default;}
	///<summary>ActorToCellRemapping</summary>
	public TMap<string,string> ActorToCellRemapping;
	///<summary>SubObjectsToCellRemapping</summary>
	public TMap<string,string> SubObjectsToCellRemapping;
}
