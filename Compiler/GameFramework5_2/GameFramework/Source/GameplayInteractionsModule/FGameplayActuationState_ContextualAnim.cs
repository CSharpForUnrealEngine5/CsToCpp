#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_PlayContextualAnim.h")]
///<summary>Contextual Animation actuation state</summary>
public partial struct FGameplayActuationState_ContextualAnim {
// GameplayActuationState_ContextualAnim
	public string InteractorRole;
	public AActor InteractableObject;
	public string InteractableObjectRole;
	public string SectionName;
	public string ExitSectionName;
	public UContextualAnimSceneAsset SceneAsset;
	public UContextualAnimSceneInstance SceneInstance;
}
