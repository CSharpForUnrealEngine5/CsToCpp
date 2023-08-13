namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor used to record world partition replay data (streaming sources for now)</summary>
[CppInclude("WorldPartition/WorldPartitionReplay.h")]
public partial class AWorldPartitionReplay : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>StreamingSourceNames</summary>
	public TArray<string> StreamingSourceNames;
}
