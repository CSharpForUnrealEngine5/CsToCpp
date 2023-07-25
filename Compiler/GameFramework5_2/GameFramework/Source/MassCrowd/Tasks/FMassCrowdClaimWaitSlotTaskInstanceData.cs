#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassCrowdClaimWaitSlotTask.h")]
///<summary>Claim wait slot and expose slot position for path follow.</summary>
public partial struct FMassCrowdClaimWaitSlotTaskInstanceData {
// MassCrowdClaimWaitSlotTaskInstanceData
	public FMassZoneGraphTargetLocation WaitSlotLocation;
	public int WaitingSlotIndex;
	public FZoneGraphLaneHandle AcquiredLane;
}
