#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraPlayerControllerBase.h")]
public partial class AVirtualCameraPlayerControllerBase : APlayerController {
// VirtualCameraPlayerControllerBase
	public ETrackerInputSource InputSource;
	public string LiveLinkTargetName;
	public FTrackingOffset TrackerPreOffset;
	public FTrackingOffset TrackerPostOffset;
	public UClass TargetCameraActorClass;
	public TArray<string> RequiredSequencerRecorderCameraSettings;
	public FVirtualCameraResetOffsetsDelegate OnOffsetReset;
	public AVPRootActor RootActor;
	public  void GetCustomTrackerLocationAndRotation(FVector OutTrackerLocation,FRotator OutTrackerRotation) {}
	public  void UpdateFocusReticle(FVector NewReticleLocation) {}
	public  void OnRecordEnabledStateChanged(bool bIsRecordEnabled) {}
	public  void OnStopped() {}
	public  void InitializeAutoFocusPoint() {}
	public  ACineCameraActor GetTargetCamera() { return default; }
	public  void SetInputSource(ETrackerInputSource InInputSource) {}
	public  void FocusMethodChanged(EVirtualCameraFocusMethod NewFocusMethod) {}
	public  string GetDistanceInDesiredUnits(float InputDistance,EUnit ConversionUnit) { return default; }
	public ULevelSequencePlaybackController LevelSequencePlaybackController;
	public ACineCameraActor TargetCameraActor;
	public bool bCachedIsVirtualCameraControlledByRemoteSession;
	public bool bCachedShouldUpdateTargetCameraTransform;
	public  void BroadcastOffsetReset() {}
	public  bool IsVirtualCameraControlledByRemoteSession() { return default; }
	public  bool ShouldUpdateTargetCameraTransform() { return default; }
	public  void AddBlendableToCamera(object /*BlendableToAdd*/ BlendableToAdd,float Weight) {}
	public  float ChangeAperturePreset(bool bShiftUp) { return default; }
	public  float ChangeFocalLengthPreset(bool bShiftUp) { return default; }
	public  void ClearActiveLevelSequence() {}
	public  int DeletePreset(string PresetName) { return default; }
	public  int DeleteScreenshot(string ScreenshotName) { return default; }
	public  int DeleteWaypoint(string WaypointName) { return default; }
	public  string GetActiveLevelSequenceName() { return default; }
	public  ULevelSequence GetActiveLevelSequence() { return default; }
	public  float GetAxisStabilizationScale(EVirtualCameraAxis AxisToRetrieve) { return default; }
	public  float GetAxisMovementScale(EVirtualCameraAxis AxisToRetrieve) { return default; }
	public  float GetCurrentAperture() { return default; }
	public  string GetCurrentFilmbackName() { return default; }
	public  float GetCurrentFocalLength() { return default; }
	public  float GetCurrentFocusDistance() { return default; }
	public  EVirtualCameraFocusMethod GetCurrentFocusMethod() { return default; }
	public  FFrameNumber GetCurrentSequencePlaybackEnd() { return default; }
	public  FFrameNumber GetCurrentSequencePlaybackStart() { return default; }
	public  bool IsSequencerLockedToCameraCut() { return default; }
	public  void SetSequencerLockedToCameraCut(bool bLockView) {}
	public  FFrameRate GetCurrentSequenceFrameRate() { return default; }
	public  EUnit GetDesiredDistanceUnits() { return default; }
	public  FColor GetFocusPlaneColor() { return default; }
	public  bool GetFilmbackPresetOptions(TArray<string> OutFilmbackPresetsArray) { return default; }
	public  FFrameNumber GetLevelSequenceLength() { return default; }
	public  void GetLevelSequences(TArray<FLevelSequenceData> OutLevelSequenceNames) {}
	public  float GetMatteAspectRatio() { return default; }
	public  float GetMatteOpacity() { return default; }
	public  void GetMatteValues(TArray<float> OutMatteValues) {}
	public  FFrameTime GetPlaybackPosition() { return default; }
	public  FTimecode GetPlaybackTimecode() { return default; }
	public  void GetScreenshotInfo(string ScreenshotName,FVirtualCameraScreenshot OutScreenshotInfo) {}
	public  void GetScreenshotNames(TArray<string> OutArray) {}
	public  TMap<string,FVirtualCameraSettingsPreset> GetSettingsPresets() { return default; }
	public  ETouchInputState GetTouchInputState() { return default; }
	public  void GetWaypointInfo(string WaypointName,FVirtualCameraWaypoint OutWaypointInfo) {}
	public  void GetWaypointNames(TArray<string> OutArray) {}
	public  bool IsAxisLocked(EVirtualCameraAxis AxisToCheck) { return default; }
	public  bool IsFocusVisualizationAllowed() { return default; }
	public  bool IsPlaying() { return default; }
	public  bool IsTouchInputInFocusMode() { return default; }
	public  bool IsUsingGlobalBoom() { return default; }
	public  void JumpToLevelSequenceEnd() {}
	public  void JumpToLevelSequenceStart() {}
	public  void JumpToPlaybackPosition(FFrameNumber InFrameNumber) {}
	public  bool LoadPreset(string PresetName) { return default; }
	public  bool LoadScreenshotView(string ScreenshotName) { return default; }
	public  void PauseLevelSequence() {}
	public  void PlayLevelSequence() {}
	public  void PlayLevelSequenceInReverse() {}
	public  void ResetCameraOffsetsToTracker() {}
	public  void ResumeLevelSequencePlay() {}
	public  void SaveHomeWaypoint(string NewHomeWaypointName) {}
	public  string SavePreset(bool bSaveCameraSettings,bool bSaveStabilization,bool bSaveAxisLocking,bool bSaveMotionScale) { return default; }
	public  string SaveWaypoint() { return default; }
	public  bool SetActiveLevelSequence(ULevelSequence InNewLevelSequence) { return default; }
	public  void SetAllowFocusPlaneVisualization(bool bShouldAllowFocusVisualization) {}
	public  float SetAxisStabilizationScale(EVirtualCameraAxis AxisToAdjust,float NewStabilizationAmount) { return default; }
	public  void SetCurrentAperture(float NewAperture) {}
	public  void SetCurrentFocalLength(float NewFocalLength) {}
	public  void SetCurrentFocusDistance(float NewFocusDistance) {}
	public  void SetDesiredDistanceUnits(EUnit DesiredUnits) {}
	public  bool SetFilmbackPresetOption(string NewFilmbackPreset) { return default; }
	public  void SetFocusMethod(EVirtualCameraFocusMethod NewFocusMethod) {}
	public  void SetFocusPlaneColor(FColor NewFocusPlaneColor) {}
	public  void SetFocusVisualization(bool bShowFocusVisualization) {}
	public  bool IsFocusVisualizationActivated() { return default; }
	public  bool SetMatteAspectRatio(float NewMatteAspectRatio) { return default; }
	public  void SetMatteOpacity(float NewMatteOpacity) {}
	public  void SetMovementScale(EVirtualCameraAxis AxisToAdjust,float NewMovementScale) {}
	public  void SetPresetFavoriteStatus(string PresetName,bool bIsFavorite) {}
	public  void SetSaveSettingsWhenClosing(bool bShouldSettingsSave) {}
	public  void SetScreenshotFavoriteStatus(string ScreenshotName,bool bIsFavorite) {}
	public  void SetTouchInputState(ETouchInputState NewInputState) {}
	public  void SetUseGlobalBoom(bool bShouldUseGlobalBoom) {}
	public  void SetWaypointFavoriteStatus(string WaypointName,bool bIsFavorite) {}
	public  void SetZeroDutchOnLock(bool bInValue) {}
	public  bool ShouldSaveSettingsWhenClosing() { return default; }
	public  void StopLevelSequencePlay() {}
	public  string TakeScreenshot() { return default; }
	public  void TeleportToHomeWaypoint() {}
	public  bool TeleportToWaypoint(string WaypointIndex) { return default; }
	public  bool ToggleAxisFreeze(EVirtualCameraAxis AxisToToggle) { return default; }
	public  bool ToggleAxisLock(EVirtualCameraAxis AxisToToggle) { return default; }
	public  void ActivateGameViewport() {}
}
