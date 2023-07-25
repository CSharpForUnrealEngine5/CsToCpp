#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AITask_UseGameplayInteraction.h")]
public partial class UAITask_UseGameplayInteraction : UAITask {
// AITask_UseGameplayInteraction
	public UObject UseClaimedGameplayInteractionSmartObject(UObject Controller,FSmartObjectClaimHandle ClaimHandle,bool bLockAILogic/*=true*/) { return default; }
	public void RequestAbort() {}
	public FGenericGameplayTaskDelegate OnFinished;
	public FGameplayInteractionContext GameplayInteractionContext;
	public FSmartObjectClaimHandle ClaimedHandle;
	public FGameplayInteractionAbortContext AbortContext;
}
