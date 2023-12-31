namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionStreamingSource.h")]
///<summary>Streaming Source Priority</summary>
public enum EStreamingSourcePriority {
	Highest=0,
	High=64,
	Normal=128,
	Low=192,
	Lowest=255,
	Default=-1,
}
