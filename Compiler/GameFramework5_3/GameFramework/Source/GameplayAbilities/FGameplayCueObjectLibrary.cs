namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An ObjectLibrary for the GameplayCue Notifies. Wraps 2 underlying UObjectLibraries plus options/delegates for how they are loaded</summary>
[CppInclude("GameplayCueManager.h")]
public partial struct FGameplayCueObjectLibrary {
	public TArray<string> Paths;
	public UObjectLibrary ActorObjectLibrary;
	public UObjectLibrary StaticObjectLibrary;
	public UGameplayCueSet CueSet;
	public bool bShouldSyncScan;
	public bool bShouldAsyncLoad;
	public bool bShouldSyncLoad;
	public bool bHasBeenInitialized;
}
