#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/NavigationData/NavigationDataChunkActor.h")]
public partial class ANavigationDataChunkActor : APartitionActor {
// NavigationDataChunkActor
	public TArray<UNavigationDataChunk> NavDataChunks;
	public FBox DataChunkActorBounds;
}
