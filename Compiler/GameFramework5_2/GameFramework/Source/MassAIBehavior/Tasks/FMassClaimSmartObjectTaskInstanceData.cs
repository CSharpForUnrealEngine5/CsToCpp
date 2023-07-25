#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/MassClaimSmartObjectTask.h")]
///<summary>Tasks to claim a smart object from search results and release it when done.</summary>
public partial struct FMassClaimSmartObjectTaskInstanceData {
// MassClaimSmartObjectTaskInstanceData
	public FStateTreeStructRef CandidateSlots;
	public FSmartObjectClaimHandle ClaimedSlot;
}
