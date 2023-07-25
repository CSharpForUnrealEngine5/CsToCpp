#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayInteractionContext.h")]
///<summary>Struct that holds data required to perform the interaction</summary>
public partial struct FGameplayInteractionContext {
// GameplayInteractionContext
	public FStateTreeInstanceData StateTreeInstanceData;
	public FSmartObjectClaimHandle ClaimedHandle;
	public FGameplayInteractionAbortContext AbortContext;
	public AActor ContextActor;
	public AActor SmartObjectActor;
	public UGameplayInteractionSmartObjectBehaviorDefinition Definition;
}
