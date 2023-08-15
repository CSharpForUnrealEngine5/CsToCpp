namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULevelEditorSubsystem</summary>
[CppInclude("LevelEditorSubsystem.h")]
public partial class ULevelEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>PilotLevelActor</summary>
	public void PilotLevelActor(AActor ActorToPilot,FName ViewportConfigKey/*=NAME_None*/) {}
	///<summary>EjectPilotLevelActor</summary>
	public void EjectPilotLevelActor(FName ViewportConfigKey/*=NAME_None*/) {}
	///<summary>GetPilotLevelActor</summary>
	public AActor GetPilotLevelActor(FName ViewportConfigKey/*=NAME_None*/) { return default; }
	///<summary>EditorPlaySimulate</summary>
	public void EditorPlaySimulate() {}
	///<summary>EditorInvalidateViewports</summary>
	public void EditorInvalidateViewports() {}
	///<summary>EditorSetGameView</summary>
	public void EditorSetGameView(bool bGameView,FName ViewportConfigKey/*=NAME_None*/) {}
	///<summary>EditorGetGameView</summary>
	public bool EditorGetGameView(FName ViewportConfigKey/*=NAME_None*/) { return default; }
	///<summary>EditorRequestEndPlay</summary>
	public void EditorRequestEndPlay() {}
	///<summary>IsInPlayInEditor</summary>
	public bool IsInPlayInEditor() { return default; }
	///<summary>GetViewportConfigKeys</summary>
	public TArray<FName> GetViewportConfigKeys() { return default; }
	///<summary>GetActiveViewportConfigKey</summary>
	public FName GetActiveViewportConfigKey() { return default; }
	///<summary>SetAllowsCinematicControl</summary>
	public void SetAllowsCinematicControl(bool bAllow,FName ViewportConfigKey/*=NAME_None*/) {}
	///<summary>GetAllowsCinematicControl</summary>
	public bool GetAllowsCinematicControl(FName ViewportConfigKey/*=NAME_None*/) { return default; }
	///<summary>Close the current Persistent Level (without saving it). Create a new blank Level and save it. Load the new created level.</summary>
	public bool NewLevel(string AssetPath) { return default; }
	///<summary>Close the current Persistent Level (without saving it). Create a new Level base on another level and save it. Load the new created level.</summary>
	public bool NewLevelFromTemplate(string AssetPath,string TemplateAssetPath) { return default; }
	///<summary>Close the current Persistent Level (without saving it). Loads the specified level.</summary>
	public bool LoadLevel(string AssetPath) { return default; }
	///<summary>Saves the specified Level. Must already be saved at lease once to have a valid path.</summary>
	public bool SaveCurrentLevel() { return default; }
	///<summary>Saves all Level currently loaded by the World Editor.</summary>
	public bool SaveAllDirtyLevels() { return default; }
	///<summary>Set the current level used by the world editor.</summary>
	public bool SetCurrentLevelByName(FName LevelName) { return default; }
	///<summary>Get the current level used by the world editor.</summary>
	public ULevel GetCurrentLevel() { return default; }
	///<summary>Get the selection set for the current world, you can use this to track</summary>
	public UTypedElementSelectionSet GetSelectionSet() { return default; }
	///<summary>Build Light Maps and optionally the reflection captures.</summary>
	public bool BuildLightMaps(ELightingBuildQuality Quality/*=ELightingBuildQuality.Quality_Production*/,bool bWithReflectionCaptures/*=false*/) { return default; }
	///<summary>Expose PreSaveWorld to blueprints</summary>
	public FOnLevelEditorPreSaveWorld OnPreSaveWorld;
	///<summary>Expose PostSaveWorld to blueprints</summary>
	public FOnLevelEditorPostSaveWorld OnPostSaveWorld;
	///<summary>Expose EditorCameraMoved to blueprints</summary>
	public FOnLevelEditorEditorCameraMoved OnEditorCameraMoved;
	///<summary>Expose MapChanged to blueprints. Note: This executes too early for some editor scripting, consider using OnMapOpened if this doesn&#39;t work for you.</summary>
	public FOnLevelEditorMapChanged OnMapChanged;
	///<summary>Expose MapOpened to blueprints</summary>
	public FOnLevelEditorMapOpened OnMapOpened;
}
