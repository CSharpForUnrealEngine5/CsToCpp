#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelUtils.h")]
public partial class UEditorLevelUtils : UObject {
// EditorLevelUtils
	public static ULevelStreaming CreateNewStreamingLevel(UClass LevelStreamingClass,string NewLevelPath/*=TEXT("")*/,bool bMoveSelectedActorsIntoNewLevel/*=false*/) { return default; }
	public static void MakeLevelCurrent(ULevelStreaming InStreamingLevel) {}
	public static int MoveActorsToLevel(TArray<AActor> ActorsToMove,ULevelStreaming DestStreamingLevel,bool bWarnAboutReferences/*=true*/,bool bWarnAboutRenaming/*=true*/) { return default; }
	public static int MoveSelectedActorsToLevel(ULevelStreaming DestLevel,bool bWarnAboutReferences/*=true*/) { return default; }
	public static ULevelStreaming K2_AddLevelToWorld(UWorld World,string LevelPackageName,UClass LevelStreamingClass) { return default; }
	public static ULevelStreaming K2_AddLevelToWorldWithTransform(UWorld World,string LevelPackageName,UClass LevelStreamingClass,FTransform LevelTransform) { return default; }
	public static void SetLevelVisibility(ULevel Level,bool bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode/*=ELevelVisibilityDirtyMode.ModifyOnChange*/) {}
	public static void SetLevelsVisibility(TArray<ULevel> Levels,TArray<bool> bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode/*=ELevelVisibilityDirtyMode.ModifyOnChange*/) {}
	public static TArray<ULevel> GetLevels(UWorld World) { return default; }
}
