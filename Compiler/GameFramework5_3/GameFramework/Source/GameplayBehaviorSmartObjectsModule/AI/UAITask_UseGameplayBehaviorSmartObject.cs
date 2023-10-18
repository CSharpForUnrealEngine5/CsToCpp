namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AITask_UseGameplayBehaviorSmartObject.h")]
public partial class UAITask_UseGameplayBehaviorSmartObject : UAITask {
	public static UClass StaticClass() {return default;}
	///<summary>Helper function to create an AITask that interacts with the SmartObject slot using the GameplayBehavior definition</summary>
	public static UAITask_UseGameplayBehaviorSmartObject UseSmartObjectWithGameplayBehavior(AAIController Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	///<summary>Helper function to create an AITask that reaches and interacts with the SmartObject slot using the GameplayBehavior definition.</summary>
	public static UAITask_UseGameplayBehaviorSmartObject MoveToAndUseSmartObjectWithGameplayBehavior(AAIController Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	///<summary>UseGameplayBehaviorSmartObject</summary>
	public static UAITask_UseGameplayBehaviorSmartObject UseGameplayBehaviorSmartObject(AAIController Controller,AActor SmartObjectActor,USmartObjectComponent SmartObjectComponent,bool bLockAILogic/*=true*/) { return default; }
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
