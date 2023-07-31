#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A skeletal mesh component that has its tick rate governed by a global animation budget</summary>
[CppInclude("SkeletalMeshComponentBudgeted.h")]
public partial class USkeletalMeshComponentBudgeted : USkeletalMeshComponent {
	///<summary>Set this component to automatically register with the budget allocator</summary>
	public  void SetAutoRegisterWithBudgetAllocator(bool bInAutoRegisterWithBudgetAllocator) {}
	///<summary>Whether this component should automatically register with the budget allocator in OnRegister/OnUnregister</summary>
	public bool bAutoRegisterWithBudgetAllocator;
	///<summary>Whether this component should automatically calculate its significance (rather than some external system pushing the significance to it)</summary>
	public bool bAutoCalculateSignificance;
	///<summary>Whether this component should use its owning actor&#39;s rendered state to determine visibility. If this is not set then the component&#39;s visibility will be used</summary>
	public bool bShouldUseActorRenderedFlag;
}
