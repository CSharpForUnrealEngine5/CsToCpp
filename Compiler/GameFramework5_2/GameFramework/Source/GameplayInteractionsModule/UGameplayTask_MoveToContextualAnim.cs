#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_MoveToContextualAnim.h")]
public partial class UGameplayTask_MoveToContextualAnim : UGameplayTask_MoveTo {
	public static UClass StaticClass() {return default;}
	///<summary>EnterContextualAnim</summary>
	public static UGameplayTask_MoveToContextualAnim EnterContextualAnim(AActor Interactor,string InteractorRole,AActor InteractableObject,string InteractableObjectRole,string SectionName,string ExitSectionName,UContextualAnimSceneAsset SceneAsset) { return default; }
	///<summary>NextState</summary>
	public FGameplayActuationState_ContextualAnim NextState;
}
