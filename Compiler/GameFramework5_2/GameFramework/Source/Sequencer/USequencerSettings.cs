namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serializable options for sequencer.</summary>
[CppInclude("SequencerSettings.h")]
public partial class USequencerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The auto change mode (auto-key, auto-track or none).</summary>
	public EAutoChangeMode AutoChangeMode;
	///<summary>Allow edits mode.</summary>
	public EAllowEditsMode AllowEditsMode;
	///<summary>Key group mode.</summary>
	public EKeyGroupMode KeyGroupMode;
	///<summary>The interpolation type for newly created keyframes</summary>
	public EMovieSceneKeyInterpolation KeyInterpolation;
	///<summary>When setting keys on properties and transforms automatically update the track default values used when there are no keys.</summary>
	public bool bAutoSetTrackDefaults;
	///<summary>The default location of a spawnable when it is first dragged into the viewport from the content browser.</summary>
	public ESequencerSpawnPosition SpawnPosition;
	///<summary>Enable or disable creating of spawnable cameras whenever cameras are created.</summary>
	public bool bCreateSpawnableCameras;
	///<summary>Show the in/out range in the timeline with respect to the start/end range.</summary>
	public bool bShowRangeSlider;
	///<summary>Enable or disable snapping in the timeline.</summary>
	public bool bIsSnapEnabled;
	///<summary>Enable or disable snapping keys to the time snapping interval.</summary>
	public bool bSnapKeyTimesToInterval;
	///<summary>Enable or disable snapping keys to other keys.</summary>
	public bool bSnapKeyTimesToKeys;
	///<summary>Enable or disable snapping sections to the time snapping interval.</summary>
	public bool bSnapSectionTimesToInterval;
	///<summary>Enable or disable snapping sections to other sections.</summary>
	public bool bSnapSectionTimesToSections;
	///<summary>Enable or disable keeping keys and sections in the playback range.</summary>
	public bool bSnapKeysAndSectionsToPlayRange;
	///<summary>Enable or disable snapping the playhead to keys while scrubbing.</summary>
	public bool bSnapPlayTimeToKeys;
	///<summary>Enable or disable snapping the playhead to section bounds while scrubbing.</summary>
	public bool bSnapPlayTimeToSections;
	///<summary>Enable or disable snapping the playhead to markers while scrubbing.</summary>
	public bool bSnapPlayTimeToMarkers;
	///<summary>Enable or disable snapping the playhead to the time snapping interval while scrubbing.</summary>
	public bool bSnapPlayTimeToInterval;
	///<summary>Enable or disable snapping the playhead to the pressed key.</summary>
	public bool bSnapPlayTimeToPressedKey;
	///<summary>Enable or disable snapping the playhead to the dragged key.</summary>
	public bool bSnapPlayTimeToDraggedKey;
	///<summary>Enable or disable snapping the curve value to the curve value interval.</summary>
	public bool bSnapCurveValueToInterval;
	///<summary>Only show selected nodes in the tree view.</summary>
	public bool bShowSelectedNodesOnly;
	///<summary>Defines whether to jump back to the start of the sequence when a recording is started</summary>
	public bool bRewindOnRecord;
	///<summary>Defines whether left mouse drag does marquee select instead of camera orbit</summary>
	public bool bLeftMouseDragDoesMarquee;
	///<summary>Whether to zoom in on the current position or the current time in the timeline.</summary>
	public ESequencerZoomPosition ZoomPosition;
	///<summary>Enable or disable auto scroll in the timeline when playing.</summary>
	public bool bAutoScrollEnabled;
	///<summary>Enable or disable linking the curve editor time range to the sequencer timeline&#39;s time range.</summary>
	public bool bLinkCurveEditorTimeRange;
	///<summary>When enabled, changing the sequencer tree selection will also select the relevant nodes in the curve editor tree if possible.</summary>
	public bool bSynchronizeCurveEditorSelection;
	///<summary>When enabled, changing the sequencer tree selection will isolate (auto-filter) the selected nodes in the curve editor.</summary>
	public bool bIsolateCurveEditorToSelection;
	///<summary>The loop mode of the playback in timeline.</summary>
	public ESequencerLoopMode LoopMode;
	///<summary>Enable or disable resetting the playhead when navigating in and out of subsequences.</summary>
	public bool bResetPlayheadWhenNavigating;
	///<summary>Enable or disable keeping the playhead in the current playback range while scrubbing.</summary>
	public bool bKeepCursorInPlayRangeWhileScrubbing;
	///<summary>Enable or disable keeping the playback range constrained to the section bounds.</summary>
	public bool bKeepPlayRangeInSectionBounds;
	///<summary>The number of zeros to pad the frame numbers by.</summary>
	public byte ZeroPadFrames;
	///<summary>The number of frames to jump by when jumping forward or backwards.</summary>
	public FFrameNumber JumpFrameIncrement;
	///<summary>Enable or disable the layer bars to edit keyframes in bulk.</summary>
	public bool bShowLayerBars;
	///<summary>Enable or disable key bar connections.</summary>
	public bool bShowKeyBars;
	///<summary>Enable or disable setting key area sections as infinite by default.</summary>
	public bool bInfiniteKeyAreas;
	///<summary>Enable or disable displaying channel bar colors for the key bars.</summary>
	public bool bShowChannelColors;
	///<summary>Enable or disable displaying the status bar for number of items.</summary>
	public bool bShowStatusBar;
	///<summary>Enable or disable displaying the tick lines.</summary>
	public bool bShowTickLines;
	///<summary>Enable or disable displaying the sequencer toolbar.</summary>
	public bool bShowSequencerToolbar;
	///<summary>The key area curve extents, stored per channel name</summary>
	public string KeyAreaCurveExtents;
	///<summary>The key area height when showing curves</summary>
	public float KeyAreaHeightWithCurves;
	///<summary>The tolerance to use when reducing keys</summary>
	public float ReduceKeysTolerance;
	///<summary>Enable or disable deleting keys that fall beyond the section range when trimming.</summary>
	public bool bDeleteKeysWhenTrimming;
	///<summary>Whether to disable sections after baking as opposed to deleting.</summary>
	public bool bDisableSectionsAfterBaking;
	///<summary>Section color tints</summary>
	public TArray<FColor> SectionColorTints;
	///<summary>When enabled, sequencer will playback in clean mode (game view, hide viewport UI)</summary>
	public bool bCleanPlaybackMode;
	///<summary>When enabled, sequencer will activate &#39;Realtime&#39; in viewports</summary>
	public bool bActivateRealtimeViewports;
	///<summary>When enabled, entering a sub sequence will evaluate that sub sequence in isolation, rather than from the root sequence</summary>
	public bool bEvaluateSubSequencesInIsolation;
	///<summary>When enabled, construction scripts will be rerun on bound actors for every frame</summary>
	public bool bRerunConstructionScripts;
	///<summary>Enable or disable showing of debug visualization.</summary>
	public bool bShowDebugVisualization;
	///<summary>Enable or disable showing of pre and post roll visualization.</summary>
	public bool bVisualizePreAndPostRoll;
	///<summary>Whether to recompile the director blueprint when the sequence is evaluated (if one exists)</summary>
	public bool bCompileDirectorOnEvaluate;
	///<summary>Specifies the maximum number of keys to draw when rendering trajectories in viewports</summary>
	public uint TrajectoryPathCap;
	///<summary>What format do we display time in to the user?</summary>
	public EFrameNumberDisplayFormats FrameNumberDisplayFormat;
	///<summary>Which movie renderer to use</summary>
	public string MovieRendererName;
	///<summary>Whether to expand the sequencer tree view when a child element is selected (from outside of the tree view).</summary>
	public bool bAutoExpandNodesOnSelection;
	///<summary>The tree view width percentage</summary>
	public float TreeViewWidth;
}
