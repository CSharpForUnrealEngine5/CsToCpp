namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FContextualAnimStateTreeTask instance data</summary>
[CppInclude("StateTree/ContextualAnimStateTreeTask.h")]
public partial struct FContextualAnimStateTreeTaskInstanceData {
	public AActor Actor;
	public UContextualAnimSceneAsset ContextualAnimAsset;
	public AActor InteractableObject;
	public UGameplayTask_PlayContextualAnim Task;
	public float Duration;
	public float Time;
	public string InteractorRole;
	public string InteractableObjectRole;
	public FGameplayInteractionAbortContext AbortContext;
}
