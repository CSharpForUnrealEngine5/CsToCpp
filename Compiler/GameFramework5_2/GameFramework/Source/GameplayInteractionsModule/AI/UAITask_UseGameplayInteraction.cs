#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AITask_UseGameplayInteraction.h")]
public partial class UAITask_UseGameplayInteraction : UAITask {
	public static UClass StaticClass() {return default;}
	///<summary>UseClaimedGameplayInteractionSmartObject</summary>
	public static UAITask_UseGameplayInteraction UseClaimedGameplayInteractionSmartObject(AAIController Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	///<summary>RequestAbort</summary>
	public  void RequestAbort() {}
	///<summary>OnFinished</summary>
	public FGenericGameplayTaskDelegate OnFinished;
	///<summary>GameplayInteractionContext</summary>
	public FGameplayInteractionContext GameplayInteractionContext;
	///<summary>ClaimedHandle</summary>
	public FSmartObjectClaimHandle ClaimedHandle;
	///<summary>AbortContext</summary>
	public FGameplayInteractionAbortContext AbortContext;
}
