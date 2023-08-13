namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AITask_UseGameplayBehaviorSmartObject.h")]
public partial class UAITask_UseGameplayBehaviorSmartObject : UAITask {
	public static UClass StaticClass() {return default;}
	///<summary>UseGameplayBehaviorSmartObject</summary>
	public static UAITask_UseGameplayBehaviorSmartObject UseGameplayBehaviorSmartObject(AAIController Controller,AActor SmartObjectActor,USmartObjectComponent SmartObjectComponent,bool bLockAILogic/*=true*/) { return default; }
	///<summary>UseClaimedGameplayBehaviorSmartObject</summary>
	public static UAITask_UseGameplayBehaviorSmartObject UseClaimedGameplayBehaviorSmartObject(AAIController Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	///<summary>OnSucceeded</summary>
	public FGenericGameplayTaskDelegate OnSucceeded;
	///<summary>OnFailed</summary>
	public FGenericGameplayTaskDelegate OnFailed;
	///<summary>OnMoveToFailed</summary>
	public FGenericGameplayTaskDelegate OnMoveToFailed;
	///<summary>MoveToTask</summary>
	public UAITask_MoveTo MoveToTask;
	///<summary>GameplayBehavior</summary>
	public UGameplayBehavior GameplayBehavior;
}
