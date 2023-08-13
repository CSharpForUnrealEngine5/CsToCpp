namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that holds data required to perform the interaction</summary>
[CppInclude("GameplayInteractionContext.h")]
public partial struct FGameplayInteractionContext {
	public FStateTreeInstanceData StateTreeInstanceData;
	public FSmartObjectClaimHandle ClaimedHandle;
	public FGameplayInteractionAbortContext AbortContext;
	public AActor ContextActor;
	public AActor SmartObjectActor;
	public UGameplayInteractionSmartObjectBehaviorDefinition Definition;
}
