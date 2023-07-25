#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AITask_UseGameplayBehaviorSmartObject.h")]
public partial class UAITask_UseGameplayBehaviorSmartObject : UAITask {
// AITask_UseGameplayBehaviorSmartObject
	public UObject UseGameplayBehaviorSmartObject(UObject Controller,UObject SmartObjectActor,UObject SmartObjectComponent,bool bLockAILogic/*=true*/) { return default; }
	public UObject UseClaimedGameplayBehaviorSmartObject(UObject Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	public FGenericGameplayTaskDelegate OnSucceeded;
	public FGenericGameplayTaskDelegate OnFailed;
	public FGenericGameplayTaskDelegate OnMoveToFailed;
	public UAITask_MoveTo MoveToTask;
	public UGameplayBehavior GameplayBehavior;
}
