#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueManager.h")]
///<summary>Singleton manager object that handles dispatching gameplay cues and spawning GameplayCueNotify actors as needed</summary>
public partial class UGameplayCueManager : UDataAsset {
// GameplayCueManager
	public FGameplayCueObjectLibrary RuntimeGameplayCueObjectLibrary;
	public FGameplayCueObjectLibrary EditorGameplayCueObjectLibrary;
	public TArray<UClass> LoadedGameplayCueNotifyClasses;
	public TArray<UClass> GameplayCueClassesForPreallocation;
	public TArray<FGameplayCuePendingExecute> PendingExecuteCues;
	public int GameplayCueSendContextCount;
	public TArray<FPreallocationInfo> PreallocationInfoList_Internal;
}
