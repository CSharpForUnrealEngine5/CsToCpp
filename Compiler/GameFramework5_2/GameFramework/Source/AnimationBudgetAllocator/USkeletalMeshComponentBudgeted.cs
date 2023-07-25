#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshComponentBudgeted.h")]
///<summary>A skeletal mesh component that has its tick rate governed by a global animation budget</summary>
public partial class USkeletalMeshComponentBudgeted : USkeletalMeshComponent {
// SkeletalMeshComponentBudgeted
	public void SetAutoRegisterWithBudgetAllocator(bool bInAutoRegisterWithBudgetAllocator) {}
	public bool bAutoRegisterWithBudgetAllocator;
	public bool bAutoCalculateSignificance;
	public bool bShouldUseActorRenderedFlag;
}
