#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassFindSmartObjectTask.h")]
public partial struct FMassFindSmartObjectTaskInstanceData {
	public FMassSmartObjectCandidateSlots FoundCandidateSlots;
	public bool bHasCandidateSlots;
	public FMassSmartObjectRequestID SearchRequestID;
	public double NextUpdate;
	public FZoneGraphLaneHandle LastLane;
}
