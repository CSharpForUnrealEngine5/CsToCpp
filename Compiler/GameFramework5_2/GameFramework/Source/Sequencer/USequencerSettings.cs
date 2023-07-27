#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerSettings.h")]
///<summary>Serializable options for sequencer.</summary>
public partial class USequencerSettings : UObject {
// SequencerSettings
	public EAutoChangeMode AutoChangeMode;
	public EAllowEditsMode AllowEditsMode;
	public EKeyGroupMode KeyGroupMode;
	public EMovieSceneKeyInterpolation KeyInterpolation;
	public bool bAutoSetTrackDefaults;
	public ESequencerSpawnPosition SpawnPosition;
	public bool bCreateSpawnableCameras;
	public bool bShowRangeSlider;
	public bool bIsSnapEnabled;
	public bool bSnapKeyTimesToInterval;
	public bool bSnapKeyTimesToKeys;
	public bool bSnapSectionTimesToInterval;
	public bool bSnapSectionTimesToSections;
	public bool bSnapKeysAndSectionsToPlayRange;
	public bool bSnapPlayTimeToKeys;
	public bool bSnapPlayTimeToSections;
	public bool bSnapPlayTimeToMarkers;
	public bool bSnapPlayTimeToInterval;
	public bool bSnapPlayTimeToPressedKey;
	public bool bSnapPlayTimeToDraggedKey;
	public bool bSnapCurveValueToInterval;
	public bool bShowSelectedNodesOnly;
	public bool bRewindOnRecord;
	public bool bLeftMouseDragDoesMarquee;
	public ESequencerZoomPosition ZoomPosition;
	public bool bAutoScrollEnabled;
	public bool bLinkCurveEditorTimeRange;
	public bool bSynchronizeCurveEditorSelection;
	public bool bIsolateCurveEditorToSelection;
	public ESequencerLoopMode LoopMode;
	public bool bResetPlayheadWhenNavigating;
	public bool bKeepCursorInPlayRangeWhileScrubbing;
	public bool bKeepPlayRangeInSectionBounds;
	public byte ZeroPadFrames;
	public FFrameNumber JumpFrameIncrement;
	public bool bShowLayerBars;
	public bool bShowKeyBars;
	public bool bInfiniteKeyAreas;
	public bool bShowChannelColors;
	public bool bShowStatusBar;
	public bool bShowTickLines;
	public bool bShowSequencerToolbar;
	public string KeyAreaCurveExtents;
	public float KeyAreaHeightWithCurves;
	public float ReduceKeysTolerance;
	public bool bDeleteKeysWhenTrimming;
	public bool bDisableSectionsAfterBaking;
	public TArray<FColor> SectionColorTints;
	public bool bCleanPlaybackMode;
	public bool bActivateRealtimeViewports;
	public bool bEvaluateSubSequencesInIsolation;
	public bool bRerunConstructionScripts;
	public bool bShowDebugVisualization;
	public bool bVisualizePreAndPostRoll;
	public bool bCompileDirectorOnEvaluate;
	public uint TrajectoryPathCap;
	public EFrameNumberDisplayFormats FrameNumberDisplayFormat;
	public string MovieRendererName;
	public bool bAutoExpandNodesOnSelection;
	public float TreeViewWidth;
}
