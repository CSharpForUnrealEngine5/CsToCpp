#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueManager.h")]
///<summary>An ObjectLibrary for the GameplayCue Notifies. Wraps 2 underlying UObjectLibraries plus options/delegates for how they are loaded</summary>
public partial struct FGameplayCueObjectLibrary {
// GameplayCueObjectLibrary
	public TArray<string> Paths;
	public UObjectLibrary ActorObjectLibrary;
	public UObjectLibrary StaticObjectLibrary;
	public UGameplayCueSet CueSet;
	public bool bShouldSyncScan;
	public bool bShouldAsyncLoad;
	public bool bShouldSyncLoad;
	public bool bHasBeenInitialized;
}
