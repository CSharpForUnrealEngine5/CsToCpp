#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replicated state of the destructible HLOD</summary>
[CppInclude("WorldPartition/HLOD/DestructibleHLODComponent.h")]
public partial struct FWorldPartitionDestructibleHLODState {
	public TArray<FWorldPartitionDestructibleHLODDamagedActorState> DamagedActors;
	public UWorldPartitionDestructibleHLODComponent OwnerComponent;
}
