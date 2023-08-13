namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contextual Animation actuation state</summary>
[CppInclude("GameplayTask_PlayContextualAnim.h")]
public partial struct FGameplayActuationState_ContextualAnim {
	public string InteractorRole;
	public AActor InteractableObject;
	public string InteractableObjectRole;
	public string SectionName;
	public string ExitSectionName;
	public UContextualAnimSceneAsset SceneAsset;
	public UContextualAnimSceneInstance SceneInstance;
}
