namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingPolicy.h")]
public partial class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy {
	public static UClass StaticClass() {return default;}
	///<summary>ActorToCellRemapping</summary>
	public TMap<FName,FName> ActorToCellRemapping;
	///<summary>SubObjectsToCellRemapping</summary>
	public TMap<FName,FName> SubObjectsToCellRemapping;
}
