namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replicated state of the destructible HLOD</summary>
[CppInclude("WorldPartition/HLOD/DestructibleHLODComponent.h")]
public partial struct FWorldPartitionDestructibleHLODState {
	public TArray<FWorldPartitionDestructibleHLODDamagedActorState> DamagedActors;
	public UWorldPartitionDestructibleHLODComponent OwnerComponent;
}
