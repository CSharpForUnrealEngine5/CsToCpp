#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTree/ContextualAnimStateTreeTask.h")]
///<summary>FContextualAnimStateTreeTask instance data</summary>
public partial struct FContextualAnimStateTreeTaskInstanceData {
// ContextualAnimStateTreeTaskInstanceData
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
