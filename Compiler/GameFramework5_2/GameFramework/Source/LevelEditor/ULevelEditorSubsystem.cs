#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelEditorSubsystem.h")]
///<summary>ULevelEditorSubsystem</summary>
public partial class ULevelEditorSubsystem : UEditorSubsystem {
// LevelEditorSubsystem
	public  void PilotLevelActor(AActor ActorToPilot,string ViewportConfigKey/*=NAME_None*/) {}
	public  void EjectPilotLevelActor(string ViewportConfigKey/*=NAME_None*/) {}
	public  AActor GetPilotLevelActor(string ViewportConfigKey/*=NAME_None*/) { return default; }
	public  void EditorPlaySimulate() {}
	public  void EditorInvalidateViewports() {}
	public  void EditorSetGameView(bool bGameView,string ViewportConfigKey/*=NAME_None*/) {}
	public  bool EditorGetGameView(string ViewportConfigKey/*=NAME_None*/) { return default; }
	public  void EditorRequestEndPlay() {}
	public  bool IsInPlayInEditor() { return default; }
	public  TArray<string> GetViewportConfigKeys() { return default; }
	public  string GetActiveViewportConfigKey() { return default; }
	public  void SetAllowsCinematicControl(bool bAllow,string ViewportConfigKey/*=NAME_None*/) {}
	public  bool GetAllowsCinematicControl(string ViewportConfigKey/*=NAME_None*/) { return default; }
	public  bool NewLevel(string AssetPath) { return default; }
	public  bool NewLevelFromTemplate(string AssetPath,string TemplateAssetPath) { return default; }
	public  bool LoadLevel(string AssetPath) { return default; }
	public  bool SaveCurrentLevel() { return default; }
	public  bool SaveAllDirtyLevels() { return default; }
	public  bool SetCurrentLevelByName(string LevelName) { return default; }
	public  ULevel GetCurrentLevel() { return default; }
	public  UTypedElementSelectionSet GetSelectionSet() { return default; }
	public  bool BuildLightMaps(ELightingBuildQuality Quality/*=ELightingBuildQuality.Quality_Production*/,bool bWithReflectionCaptures/*=false*/) { return default; }
	public FOnLevelEditorPreSaveWorld OnPreSaveWorld;
	public FOnLevelEditorPostSaveWorld OnPostSaveWorld;
	public FOnLevelEditorEditorCameraMoved OnEditorCameraMoved;
	public FOnLevelEditorMapChanged OnMapChanged;
	public FOnLevelEditorMapOpened OnMapOpened;
}
