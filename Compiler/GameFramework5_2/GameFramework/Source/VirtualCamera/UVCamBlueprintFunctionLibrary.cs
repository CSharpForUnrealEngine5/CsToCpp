#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamBlueprintFunctionLibrary.h")]
public partial class UVCamBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// VCamBlueprintFunctionLibrary
	public bool IsGameRunning() { return default; }
	public UObject GetUserSettings() { return default; }
	public UObject GetCurrentLevelSequence() { return default; }
	public UObject GetPendingTakeLevelSequence() { return default; }
	public void PlayCurrentLevelSequence() {}
	public void PauseCurrentLevelSequence() {}
	public void SetCurrentLevelSequenceCurrentFrame(int NewFrame) {}
	public int GetCurrentLevelSequenceCurrentFrame() { return default; }
	public int GetLevelSequenceLengthInFrames(UObject LevelSequence) { return default; }
	public FTimecode GetLevelSequenceFrameAsTimecode(UObject LevelSequence,int InFrame) { return default; }
	public FTimecode GetLevelSequenceFrameAsTimecodeWithoutObject(FFrameRate DisplayRate,int InFrame) { return default; }
	public bool IsCurrentLevelSequencePlaying() { return default; }
	public UObject ImportSnapshotTexture(string FileName,string SubFolderName,string AbsolutePathPackage) { return default; }
	public bool ModifyLevelSequenceMetadataForSelects(UObject LevelSequenceMetaData,bool bIsSelected) { return default; }
	public bool ModifyLevelSequenceMetadata(UObject LevelSequenceMetaData) { return default; }
	public bool EditorSaveAsset(string AssetPath) { return default; }
	public UObject EditorLoadAsset(string AssetPath) { return default; }
	public void ModifyObjectMetadataTags(UObject InObject,string InTag,string InValue) {}
	public TMap<string,string> GetObjectMetadataTags(UObject InObject) { return default; }
	public TArray<FAssetData> SortAssetsByTimecodeAssetData(TArray<FAssetData> LevelSequenceAssets) { return default; }
	public void PilotActor(UObject SelectedActor) {}
	public bool UpdatePostProcessSettingsForCapture(UObject CaptureComponent,float DepthOfField,float FStopValue) { return default; }
	public FFrameRate GetDisplayRate(UObject LevelSequence) { return default; }
	public FFrameRate ConvertStringToFrameRate(string InFrameRateString) { return default; }
	public bool CallFunctionByName(UObject ObjPtr,string FunctionName) { return default; }
	public void EditorSetGameView(bool bIsToggled) {}
	public float CalculateAutoFocusDistance(FVector2D ReticlePosition,UObject CineCamera) { return default; }
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID CameraBindingID) { return default; }
	public void EnableDebugFocusPlane(UObject CineCamera,bool bEnabled) {}
	public int TimecodeToFrameAmount(FTimecode Timecode,FFrameRate InFrameRate) { return default; }
	public string GetNextUndoDescription() { return default; }
	public bool CopyToCineCameraActor(UObject SourceCameraComponent,UObject TargetCameraActor) { return default; }
	public void SetActorLabel(UObject Actor,string NewActorLabel) {}
	public bool IsTakeRecorderPanelOpen() { return default; }
	public bool TryOpenTakeRecorderPanel() { return default; }
	public bool IsRecording() { return default; }
	public void FOnTakeRecorderSlateChanged_VCam(string Slate) {}
	public void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged_VCam OnTakeRecorderSlateChanged) {}
}
