#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelUtils.h")]
public partial class UEditorLevelUtils : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Creates a new streaming level in the current world</summary>
	public static ULevelStreaming CreateNewStreamingLevel(UClass LevelStreamingClass,string NewLevelPath/*=TEXT("")*/,bool bMoveSelectedActorsIntoNewLevel/*=false*/) { return default; }
	///<summary>Makes the specified streaming level the current level for editing.</summary>
	public static void MakeLevelCurrent(ULevelStreaming InStreamingLevel) {}
	///<summary>Moves the specified list of actors to the specified streaming level. The new actors will be selected</summary>
	public static int MoveActorsToLevel(TArray<AActor> ActorsToMove,ULevelStreaming DestStreamingLevel,bool bWarnAboutReferences/*=true*/,bool bWarnAboutRenaming/*=true*/) { return default; }
	///<summary>Moves the currently selected actors to the specified streaming level. The new actors will be selected</summary>
	public static int MoveSelectedActorsToLevel(ULevelStreaming DestLevel,bool bWarnAboutReferences/*=true*/) { return default; }
	///<summary>Adds the named level package to the world.  Does nothing if the level already exists in the world.</summary>
	public static ULevelStreaming K2_AddLevelToWorld(UWorld World,string LevelPackageName,UClass LevelStreamingClass) { return default; }
	///<summary>Adds the named level package to the world at the given position.  Does nothing if the level already exists in the world.</summary>
	public static ULevelStreaming K2_AddLevelToWorldWithTransform(UWorld World,string LevelPackageName,UClass LevelStreamingClass,FTransform LevelTransform) { return default; }
	///<summary>Sets a level&#39;s visibility in the editor. Less efficient than SetLevelsVisibility when changing the visibility of multiple levels simultaneously.</summary>
	public static void SetLevelVisibility(ULevel Level,bool bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode/*=ELevelVisibilityDirtyMode.ModifyOnChange*/) {}
	///<summary>Sets a level&#39;s visibility in the editor. More efficient than SetLevelsVisibility when changing the visibility of multiple levels simultaneously.</summary>
	public static void SetLevelsVisibility(TArray<ULevel> Levels,TArray<bool> bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode/*=ELevelVisibilityDirtyMode.ModifyOnChange*/) {}
	///<summary>Returns all levels for a world.</summary>
	public static TArray<ULevel> GetLevels(UWorld World) { return default; }
}
