#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionReplay.h")]
///<summary>Actor used to record world partition replay data (streaming sources for now)</summary>
public partial class AWorldPartitionReplay : AActor {
// WorldPartitionReplay
	public TArray<string> StreamingSourceNames;
}
