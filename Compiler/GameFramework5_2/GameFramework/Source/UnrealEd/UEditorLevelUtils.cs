#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelUtils.h")]
public partial class UEditorLevelUtils : UObject {
// EditorLevelUtils
	public UObject CreateNewStreamingLevel(UClass LevelStreamingClass,string NewLevelPath/*=TEXT("")*/,bool bMoveSelectedActorsIntoNewLevel/*=false*/) { return default; }
	public void MakeLevelCurrent(UObject InStreamingLevel) {}
	public int MoveActorsToLevel(TArray<UObject> ActorsToMove,UObject DestStreamingLevel,bool bWarnAboutReferences/*=true*/,bool bWarnAboutRenaming/*=true*/) { return default; }
	public int MoveSelectedActorsToLevel(UObject DestLevel,bool bWarnAboutReferences/*=true*/) { return default; }
	public UObject K2_AddLevelToWorld(UObject World,string LevelPackageName,UClass LevelStreamingClass) { return default; }
	public UObject K2_AddLevelToWorldWithTransform(UObject World,string LevelPackageName,UClass LevelStreamingClass,FTransform LevelTransform) { return default; }
	public void SetLevelVisibility(UObject Level,bool bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode/*=ELevelVisibilityDirtyMode.ModifyOnChange*/) {}
	public void SetLevelsVisibility(TArray<UObject> Levels,TArray<bool> bShouldBeVisible,bool bForceLayersVisible,ELevelVisibilityDirtyMode ModifyMode/*=ELevelVisibilityDirtyMode.ModifyOnChange*/) {}
	public TArray<UObject> GetLevels(UObject World) { return default; }
}
