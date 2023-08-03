#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamBlueprintFunctionLibrary.h")]
public partial class UVCamBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if not in editor or if running the game in PIE or Simulate</summary>
	public static bool IsGameRunning() { return default; }
	///<summary>GetUserSettings</summary>
	public static UVirtualCameraUserSettings GetUserSettings() { return default; }
	///<summary>Get the currently opened level sequence asset</summary>
	public static ULevelSequence GetCurrentLevelSequence() { return default; }
	///<summary>Gets the level sequence associated with the current pending take.</summary>
	public static ULevelSequence GetPendingTakeLevelSequence() { return default; }
	///<summary>Play the current level sequence</summary>
	public static void PlayCurrentLevelSequence() {}
	///<summary>Pause the current level sequence</summary>
	public static void PauseCurrentLevelSequence() {}
	///<summary>Set playback position for the current level sequence in frames</summary>
	public static void SetCurrentLevelSequenceCurrentFrame(int NewFrame) {}
	///<summary>Get the current playback position in frames</summary>
	public static int GetCurrentLevelSequenceCurrentFrame() { return default; }
	///<summary>Get length in frames of a level sequence</summary>
	public static int GetLevelSequenceLengthInFrames(ULevelSequence LevelSequence) { return default; }
	///<summary>Convert a frame from a level sequence to timecode</summary>
	public static FTimecode GetLevelSequenceFrameAsTimecode(ULevelSequence LevelSequence,int InFrame) { return default; }
	///<summary>Convert a frame from a level sequence to timecode using only a provided display rate</summary>
	public static FTimecode GetLevelSequenceFrameAsTimecodeWithoutObject(FFrameRate DisplayRate,int InFrame) { return default; }
	///<summary>Check whether the sequence is actively playing.</summary>
	public static bool IsCurrentLevelSequencePlaying() { return default; }
	///<summary>Imports image as a uasset</summary>
	public static UTexture ImportSnapshotTexture(string FileName,string SubFolderName,string AbsolutePathPackage) { return default; }
	///<summary>Saves UVirtualCameraClipsMetaData with updated selects information.</summary>
	public static bool ModifyLevelSequenceMetadataForSelects(UVirtualCameraClipsMetaData LevelSequenceMetaData,bool bIsSelected) { return default; }
	///<summary>Marks a LevelSequence as dirty and saves it, persisting metadata changes</summary>
	public static bool ModifyLevelSequenceMetadata(UVirtualCameraClipsMetaData LevelSequenceMetaData) { return default; }
	///<summary>Save an asset through path. Returns true on success.</summary>
	public static bool EditorSaveAsset(string AssetPath) { return default; }
	///<summary>Load an asset through path.</summary>
	public static UObject EditorLoadAsset(string AssetPath) { return default; }
	///<summary>Modifies a UObject&#39;s metadata tags, adding a tag if the tag does not exist.</summary>
	public static void ModifyObjectMetadataTags(UObject InObject,string InTag,string InValue) {}
	///<summary>Retrieves UObject&#39;s metadata tags</summary>
	public static TMap<string,string> GetObjectMetadataTags(UObject InObject) { return default; }
	///<summary>Sort array of FAssetData by metadata timecode *</summary>
	public static TArray<FAssetData> SortAssetsByTimecodeAssetData(TArray<FAssetData> LevelSequenceAssets) { return default; }
	///<summary>Pilot the provided actor using editor scripting</summary>
	public static void PilotActor(AActor SelectedActor) {}
	///<summary>Updates the provided USceneCaptureComponent2D&#39;s PostProcessingSettings. Returns true on success.</summary>
	public static bool UpdatePostProcessSettingsForCapture(USceneCaptureComponent2D CaptureComponent,float DepthOfField,float FStopValue) { return default; }
	///<summary>Grab the display rate from a LevelSequences&#39; MovieScene</summary>
	public static FFrameRate GetDisplayRate(ULevelSequence LevelSequence) { return default; }
	///<summary>Converts a double framerate to a FFrameRate</summary>
	public static FFrameRate ConvertStringToFrameRate(string InFrameRateString) { return default; }
	///<summary>Returns true if the function was found &amp; executed correctly.</summary>
	public static bool CallFunctionByName(UObject ObjPtr,string FunctionName) { return default; }
	///<summary>Sets the current game view</summary>
	public static void EditorSetGameView(bool bIsToggled) {}
	///<summary>Calculates auto focus</summary>
	public static float CalculateAutoFocusDistance(FVector2D ReticlePosition,UCineCameraComponent CineCamera) { return default; }
	///<summary>Get UObject from Camera Object Bindings</summary>
	public static TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID CameraBindingID) { return default; }
	///<summary>Enable/Disable debug focus plane</summary>
	public static void EnableDebugFocusPlane(UCineCameraComponent CineCamera,bool bEnabled) {}
	///<summary>Convert timecode to amount of frames at a given framerate</summary>
	public static int TimecodeToFrameAmount(FTimecode Timecode,FFrameRate InFrameRate) { return default; }
	///<summary>Returns the description of the undo action that will be performed next.</summary>
	public static string GetNextUndoDescription() { return default; }
	///<summary>Copies all properties from a CineCameraComponent to a CineCameraActor and ensure the root actor transform is updated so the CameraComponents end up in the same World Space position</summary>
	public static bool CopyToCineCameraActor(UCineCameraComponent SourceCameraComponent,ACineCameraActor TargetCameraActor) { return default; }
	///<summary>SetActorLabel</summary>
	public static void SetActorLabel(AActor Actor,string NewActorLabel) {}
	///<summary>IsTakeRecorderPanelOpen</summary>
	public static bool IsTakeRecorderPanelOpen() { return default; }
	///<summary>TryOpenTakeRecorderPanel</summary>
	public static bool TryOpenTakeRecorderPanel() { return default; }
	///<summary>Check whether a recording is currently active</summary>
	public static bool IsRecording() { return default; }
	///<summary>FOnTakeRecorderSlateChanged_VCam</summary>
	public  void FOnTakeRecorderSlateChanged_VCam(string Slate) {}
	///<summary>Called when the slate is changed.</summary>
	public static void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged_VCam OnTakeRecorderSlateChanged) {}
}
