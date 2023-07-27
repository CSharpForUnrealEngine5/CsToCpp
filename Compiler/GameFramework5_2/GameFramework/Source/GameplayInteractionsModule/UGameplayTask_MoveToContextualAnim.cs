#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_MoveToContextualAnim.h")]
public partial class UGameplayTask_MoveToContextualAnim : UGameplayTask_MoveTo {
// GameplayTask_MoveToContextualAnim
	public static UGameplayTask_MoveToContextualAnim EnterContextualAnim(AActor Interactor,string InteractorRole,AActor InteractableObject,string InteractableObjectRole,string SectionName,string ExitSectionName,UContextualAnimSceneAsset SceneAsset) { return default; }
	public FGameplayActuationState_ContextualAnim NextState;
}
