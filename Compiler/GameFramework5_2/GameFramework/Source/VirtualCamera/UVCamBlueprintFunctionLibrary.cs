#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamBlueprintFunctionLibrary.h")]
public partial class UVCamBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// VCamBlueprintFunctionLibrary
	public static bool IsGameRunning() { return default; }
	public static UVirtualCameraUserSettings GetUserSettings() { return default; }
	public static ULevelSequence GetCurrentLevelSequence() { return default; }
	public static ULevelSequence GetPendingTakeLevelSequence() { return default; }
	public static void PlayCurrentLevelSequence() {}
	public static void PauseCurrentLevelSequence() {}
	public static void SetCurrentLevelSequenceCurrentFrame(int NewFrame) {}
	public static int GetCurrentLevelSequenceCurrentFrame() { return default; }
	public static int GetLevelSequenceLengthInFrames(ULevelSequence LevelSequence) { return default; }
	public static FTimecode GetLevelSequenceFrameAsTimecode(ULevelSequence LevelSequence,int InFrame) { return default; }
	public static FTimecode GetLevelSequenceFrameAsTimecodeWithoutObject(FFrameRate DisplayRate,int InFrame) { return default; }
	public static bool IsCurrentLevelSequencePlaying() { return default; }
	public static UTexture ImportSnapshotTexture(string FileName,string SubFolderName,string AbsolutePathPackage) { return default; }
	public static bool ModifyLevelSequenceMetadataForSelects(UVirtualCameraClipsMetaData LevelSequenceMetaData,bool bIsSelected) { return default; }
	public static bool ModifyLevelSequenceMetadata(UVirtualCameraClipsMetaData LevelSequenceMetaData) { return default; }
	public static bool EditorSaveAsset(string AssetPath) { return default; }
	public static UObject EditorLoadAsset(string AssetPath) { return default; }
	public static void ModifyObjectMetadataTags(UObject InObject,string InTag,string InValue) {}
	public static TMap<string,string> GetObjectMetadataTags(UObject InObject) { return default; }
	public static TArray<FAssetData> SortAssetsByTimecodeAssetData(TArray<FAssetData> LevelSequenceAssets) { return default; }
	public static void PilotActor(AActor SelectedActor) {}
	public static bool UpdatePostProcessSettingsForCapture(USceneCaptureComponent2D CaptureComponent,float DepthOfField,float FStopValue) { return default; }
	public static FFrameRate GetDisplayRate(ULevelSequence LevelSequence) { return default; }
	public static FFrameRate ConvertStringToFrameRate(string InFrameRateString) { return default; }
	public static bool CallFunctionByName(UObject ObjPtr,string FunctionName) { return default; }
	public static void EditorSetGameView(bool bIsToggled) {}
	public static float CalculateAutoFocusDistance(FVector2D ReticlePosition,UCineCameraComponent CineCamera) { return default; }
	public static TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID CameraBindingID) { return default; }
	public static void EnableDebugFocusPlane(UCineCameraComponent CineCamera,bool bEnabled) {}
	public static int TimecodeToFrameAmount(FTimecode Timecode,FFrameRate InFrameRate) { return default; }
	public static string GetNextUndoDescription() { return default; }
	public static bool CopyToCineCameraActor(UCineCameraComponent SourceCameraComponent,ACineCameraActor TargetCameraActor) { return default; }
	public static void SetActorLabel(AActor Actor,string NewActorLabel) {}
	public static bool IsTakeRecorderPanelOpen() { return default; }
	public static bool TryOpenTakeRecorderPanel() { return default; }
	public static bool IsRecording() { return default; }
	public  void FOnTakeRecorderSlateChanged_VCam(string Slate) {}
	public static void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged_VCam OnTakeRecorderSlateChanged) {}
}
