namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_MoveToContextualAnim.h")]
public partial class UGameplayTask_MoveToContextualAnim : UGameplayTask_MoveTo {
	public static UClass StaticClass() {return default;}
	///<summary>EnterContextualAnim</summary>
	public static UGameplayTask_MoveToContextualAnim EnterContextualAnim(AActor Interactor,FName InteractorRole,AActor InteractableObject,FName InteractableObjectRole,FName SectionName,FName ExitSectionName,UContextualAnimSceneAsset SceneAsset) { return default; }
	///<summary>NextState</summary>
	public FGameplayActuationState_ContextualAnim NextState;
}
