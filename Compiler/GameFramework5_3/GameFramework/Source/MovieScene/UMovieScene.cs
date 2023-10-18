namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene asset.</summary>
[CppInclude("MovieScene.h")]
public partial class UMovieScene : UMovieSceneSignedObject {
	public static UClass StaticClass() {return default;}
	///<summary>Data-only blueprints for all of the objects that we we&#39;re able to spawn.</summary>
	public TArray<FMovieSceneSpawnable> Spawnables;
	///<summary>Typed slots for already-spawned objects that we are able to control with this MovieScene</summary>
	public TArray<FMovieScenePossessable> Possessables;
	///<summary>Tracks bound to possessed or spawned objects</summary>
	public TArray<FMovieSceneBinding> ObjectBindings;
	///<summary>Map of persistent tagged bindings for this sequence</summary>
	public TMap<FName,FMovieSceneObjectBindingIDs> BindingGroups;
	///<summary>Tracks which are not bound to spawned or possessed objects</summary>
	public TArray<UMovieSceneTrack> Tracks;
	///<summary>The camera cut track is a specialized track for switching between cameras on a cinematic</summary>
	public UMovieSceneTrack CameraCutTrack;
	///<summary>User-defined selection range.</summary>
	public FMovieSceneFrameRange SelectionRange;
	///<summary>User-defined playback range for this movie scene. Must be a finite range. Relative to this movie-scene&#39;s 0-time origin.</summary>
	public FMovieSceneFrameRange PlaybackRange;
	///<summary>The resolution at which all frame numbers within this movie-scene data are stored</summary>
	public FFrameRate TickResolution;
	///<summary>The rate at which we should interact with this moviescene data on UI, and to movie scene players. Also defines the frame locked frame rate.</summary>
	public FFrameRate DisplayRate;
	///<summary>The type of evaluation to use when playing back this sequence</summary>
	public EMovieSceneEvaluationType EvaluationType;
	///<summary>ClockSource</summary>
	public EUpdateClockSource ClockSource;
	///<summary>CustomClockSourcePath</summary>
	public FSoftObjectPath CustomClockSourcePath;
	///<summary>The set of user-marked frames</summary>
	public TArray<FMovieSceneMarkedFrame> MarkedFrames;
	///<summary>Indicates whether this movie scene is read only</summary>
	public bool bReadOnly;
	///<summary>User-defined playback range is locked.</summary>
	public bool bPlaybackRangeLocked;
	///<summary>User-defined marked frames are locked.</summary>
	public bool bMarkedFramesLocked;
	///<summary>Maps object GUIDs to user defined display names.</summary>
	public TMap<string,FText> ObjectsToDisplayNames;
	///<summary>Maps object GUIDs to user defined labels.</summary>
	public TMap<string,FMovieSceneTrackLabels> ObjectsToLabels;
	///<summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
	public FMovieSceneEditorData EditorData;
	///<summary>The root folders for this movie scene.</summary>
	public TArray<UMovieSceneFolder> RootFolders;
	///<summary>Nodes currently marked Solo, stored as node tree paths</summary>
	public TArray<string> SoloNodes;
	///<summary>Nodes currently marked Mute, stored as node tree paths</summary>
	public TArray<string> MuteNodes;
	///<summary>Groups of sections which should maintain the same relative offset</summary>
	public TArray<FMovieSceneSectionGroup> SectionGroups;
	///<summary>Collection of user-defined groups</summary>
	public UMovieSceneNodeGroupCollection NodeGroupCollection;
	///<summary>Whether this scene&#39;s marked frames should be shown globally</summary>
	public bool bGloballyShowMarkedFrames;
	///<summary>InTime_DEPRECATED</summary>
	public float InTime_DEPRECATED;
	///<summary>OutTime_DEPRECATED</summary>
	public float OutTime_DEPRECATED;
	///<summary>StartTime_DEPRECATED</summary>
	public float StartTime_DEPRECATED;
	///<summary>EndTime_DEPRECATED</summary>
	public float EndTime_DEPRECATED;
	///<summary>bForceFixedFrameIntervalPlayback_DEPRECATED</summary>
	public bool bForceFixedFrameIntervalPlayback_DEPRECATED;
	///<summary>FixedFrameInterval_DEPRECATED</summary>
	public float FixedFrameInterval_DEPRECATED;
	///<summary>MasterTracks_DEPRECATED</summary>
	public TArray<UMovieSceneTrack> MasterTracks_DEPRECATED;
}
