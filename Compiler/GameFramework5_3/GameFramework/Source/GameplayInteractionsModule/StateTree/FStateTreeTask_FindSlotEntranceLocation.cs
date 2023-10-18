namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Finds entrance location for a Smart Object slot. The query will use slot entrance annotations as candidates.</summary>
[CppInclude("StateTree/StateTreeTask_FindSlotEntranceLocation.h")]
public partial struct FStateTreeTask_FindSlotEntranceLocation {
	public FSmartObjectSlotEntrySelectionMethod SelectMethod;
	public bool bProjectNavigationLocation;
	public bool bTraceGroundLocation;
	public bool bCheckTransitionTrajectory;
	public bool bCheckEntranceLocationOverlap;
	public bool bCheckSlotLocationOverlap;
	public bool bUseSlotLocationAsFallbackCandidate;
	public ESmartObjectSlotNavigationLocationType LocationType;
	public UClass ValidationFilter;
}
