namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contextual Animation actuation state</summary>
[CppInclude("GameplayTask_PlayContextualAnim.h")]
public partial struct FGameplayActuationState_ContextualAnim {
	public FName InteractorRole;
	public AActor InteractableObject;
	public FName InteractableObjectRole;
	public FName SectionName;
	public FName ExitSectionName;
	public UContextualAnimSceneAsset SceneAsset;
	public UContextualAnimSceneInstance SceneInstance;
}
