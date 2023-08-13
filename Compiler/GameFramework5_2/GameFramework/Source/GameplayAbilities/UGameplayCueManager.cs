namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton manager object that handles dispatching gameplay cues and spawning GameplayCueNotify actors as needed</summary>
[CppInclude("GameplayCueManager.h")]
public partial class UGameplayCueManager : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>RuntimeGameplayCueObjectLibrary</summary>
	public FGameplayCueObjectLibrary RuntimeGameplayCueObjectLibrary;
	///<summary>EditorGameplayCueObjectLibrary</summary>
	public FGameplayCueObjectLibrary EditorGameplayCueObjectLibrary;
	///<summary>Hardref to the gameplaycue notify classes we have async loaded</summary>
	public TArray<UClass> LoadedGameplayCueNotifyClasses;
	///<summary>Classes that we need to preallocate instances for</summary>
	public TArray<UClass> GameplayCueClassesForPreallocation;
	///<summary>List of gameplay cue executes that haven&#39;t been processed yet</summary>
	public TArray<FGameplayCuePendingExecute> PendingExecuteCues;
	///<summary>Number of active gameplay cue send contexts, when it goes to 0 cues are flushed</summary>
	public int GameplayCueSendContextCount;
	///<summary>PreallocationInfoList_Internal</summary>
	public TArray<FPreallocationInfo> PreallocationInfoList_Internal;
}
