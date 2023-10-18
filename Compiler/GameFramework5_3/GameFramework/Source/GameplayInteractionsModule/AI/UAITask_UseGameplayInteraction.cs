namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AITask_UseGameplayInteraction.h")]
public partial class UAITask_UseGameplayInteraction : UAITask {
	public static UClass StaticClass() {return default;}
	///<summary>Helper function to create an AITask that interacts with the SmartObject slot using the GameplayInteraction definition.</summary>
	public static UAITask_UseGameplayInteraction UseSmartObjectWithGameplayInteraction(AAIController Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	///<summary>Helper function to create an AITask that reaches and interacts with the SmartObject slot using the GameplayInteraction definition</summary>
	public static UAITask_UseGameplayInteraction MoveToAndUseSmartObjectWithGameplayInteraction(AAIController Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	///<summary>RequestAbort</summary>
	public void RequestAbort() {}
	///<summary>OnFinished</summary>
	public FGenericGameplayTaskDelegate OnFinished;
	///<summary>OnSucceeded</summary>
	public FGenericGameplayTaskDelegate OnSucceeded;
	///<summary>OnFailed</summary>
	public FGenericGameplayTaskDelegate OnFailed;
	///<summary>OnMoveToFailed</summary>
	public FGenericGameplayTaskDelegate OnMoveToFailed;
	///<summary>GameplayInteractionContext</summary>
	public FGameplayInteractionContext GameplayInteractionContext;
	///<summary>MoveToTask</summary>
	public UAITask_MoveTo MoveToTask;
	///<summary>ClaimedHandle</summary>
	public FSmartObjectClaimHandle ClaimedHandle;
	///<summary>AbortContext</summary>
	public FGameplayInteractionAbortContext AbortContext;
}
