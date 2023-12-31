namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/NavigationData/NavigationDataChunkActor.h")]
public partial class ANavigationDataChunkActor : APartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>NavDataChunks</summary>
	public TArray<UNavigationDataChunk> NavDataChunks;
	///<summary>DataChunkActorBounds</summary>
	public FBox DataChunkActorBounds;
}
