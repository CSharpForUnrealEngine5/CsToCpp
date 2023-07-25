#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/HLOD/DestructibleHLODComponent.h")]
///<summary>Replicated state of the destructible HLOD</summary>
public partial struct FWorldPartitionDestructibleHLODState {
// WorldPartitionDestructibleHLODState
	public TArray<FWorldPartitionDestructibleHLODDamagedActorState> DamagedActors;
	public UWorldPartitionDestructibleHLODComponent OwnerComponent;
}
