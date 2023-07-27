#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_PlayContextualAnim.h")]
///<summary>Simulated GameplayTask that starts a contextual anim scene on multiple actors</summary>
public partial class UGameplayTask_PlayContextualAnim : UGameplayTask {
// GameplayTask_PlayContextualAnim
	public static UGameplayTask_PlayContextualAnim PlayContextualAnim(AActor Interactor,string InteractorRole,AActor InteractableObject,string InteractableObjectRole,string SectionName,string ExitSectionName,UContextualAnimSceneAsset SceneAsset) { return default; }
	public  void SetExit(EPlayContextualAnimExitMode ExitMode,string NewExitSectionName) {}
	public  EPlayContextualAnimStatus GetStatus() { return default; }
	public  void OnSectionEndTimeReached(UContextualAnimSceneInstance SceneInstance) {}
	public FGenericGameplayTaskDelegate OnRequestFailed;
	public FGameplayTaskActuationCompleted OnCompleted;
	public int SectionIdx;
	public int AnimSetIdx;
	public TArray<FTransform> Pivots;
	public UContextualAnimSceneAsset SceneAsset;
	public string InteractorRole;
	public AActor InteractableObject;
	public string InteractableObjectRole;
	public string ExitSectionName;
	public UContextualAnimSceneInstance SceneInstance;
	public UGameplayActuationComponent ActuationComponent;
	public FContextualAnimStartSceneParams SceneParams;
	public FTransform SafeExitPoint;
	public EPlayContextualAnimStatus Status;
	public bool bTeleportOnTaskEnd;
}
