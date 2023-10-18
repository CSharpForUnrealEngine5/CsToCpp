namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Computes move target to a smart object based on current location on ZoneGraph.</summary>
[CppInclude("Tasks/MassZoneGraphFindSmartObjectTarget.h")]
public partial struct FMassZoneGraphFindSmartObjectTargetInstanceData {
	public FSmartObjectClaimHandle ClaimedSlot;
	public FMassZoneGraphTargetLocation SmartObjectLocation;
}
