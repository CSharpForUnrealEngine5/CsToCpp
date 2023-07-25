#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassFindSmartObjectTask.h")]
public partial struct FMassFindSmartObjectTaskInstanceData {
// MassFindSmartObjectTaskInstanceData
	public FMassSmartObjectCandidateSlots FoundCandidateSlots;
	public bool bHasCandidateSlots;
	public FMassSmartObjectRequestID SearchRequestID;
	public double NextUpdate;
	public FZoneGraphLaneHandle LastLane;
}
