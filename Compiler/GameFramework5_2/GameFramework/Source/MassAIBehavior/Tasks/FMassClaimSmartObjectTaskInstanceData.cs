#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tasks to claim a smart object from search results and release it when done.</summary>
[CppInclude("Tasks/MassClaimSmartObjectTask.h")]
public partial struct FMassClaimSmartObjectTaskInstanceData {
	public FStateTreeStructRef CandidateSlots;
	public FSmartObjectClaimHandle ClaimedSlot;
}
