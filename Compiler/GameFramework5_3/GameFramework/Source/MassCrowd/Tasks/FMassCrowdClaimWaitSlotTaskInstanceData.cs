namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Claim wait slot and expose slot position for path follow.</summary>
[CppInclude("Tasks/MassCrowdClaimWaitSlotTask.h")]
public partial struct FMassCrowdClaimWaitSlotTaskInstanceData {
	public FMassZoneGraphTargetLocation WaitSlotLocation;
	public int WaitingSlotIndex;
	public FZoneGraphLaneHandle AcquiredLane;
}
