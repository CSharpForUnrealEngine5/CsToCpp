#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simulated GameplayTask that starts a contextual anim scene on multiple actors</summary>
[CppInclude("GameplayTask_PlayContextualAnim.h")]
public partial class UGameplayTask_PlayContextualAnim : UGameplayTask {
	///<summary>PlayContextualAnim</summary>
	public static UGameplayTask_PlayContextualAnim PlayContextualAnim(AActor Interactor,string InteractorRole,AActor InteractableObject,string InteractableObjectRole,string SectionName,string ExitSectionName,UContextualAnimSceneAsset SceneAsset) { return default; }
	///<summary>SetExit</summary>
	public  void SetExit(EPlayContextualAnimExitMode ExitMode,string NewExitSectionName) {}
	///<summary>GetStatus</summary>
	public  EPlayContextualAnimStatus GetStatus() { return default; }
	///<summary>OnSectionEndTimeReached</summary>
	public  void OnSectionEndTimeReached(UContextualAnimSceneInstance SceneInstance) {}
	///<summary>OnRequestFailed</summary>
	public FGenericGameplayTaskDelegate OnRequestFailed;
	///<summary>OnCompleted</summary>
	public FGameplayTaskActuationCompleted OnCompleted;
	///<summary>SectionIdx</summary>
	public int SectionIdx;
	///<summary>AnimSetIdx</summary>
	public int AnimSetIdx;
	///<summary>Pivots</summary>
	public TArray<FTransform> Pivots;
	///<summary>SceneAsset</summary>
	public UContextualAnimSceneAsset SceneAsset;
	///<summary>InteractorRole</summary>
	public string InteractorRole;
	///<summary>InteractableObject</summary>
	public AActor InteractableObject;
	///<summary>InteractableObjectRole</summary>
	public string InteractableObjectRole;
	///<summary>ExitSectionName</summary>
	public string ExitSectionName;
	///<summary>SceneInstance</summary>
	public UContextualAnimSceneInstance SceneInstance;
	///<summary>ActuationComponent</summary>
	public UGameplayActuationComponent ActuationComponent;
	///<summary>Rebuilt locally from replicated data</summary>
	public FContextualAnimStartSceneParams SceneParams;
	///<summary>SafeExitPoint</summary>
	public FTransform SafeExitPoint;
	///<summary>Status</summary>
	public EPlayContextualAnimStatus Status;
	///<summary>bTeleportOnTaskEnd</summary>
	public bool bTeleportOnTaskEnd;
}
