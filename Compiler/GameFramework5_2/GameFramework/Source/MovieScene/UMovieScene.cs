#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene.h")]
///<summary>Implements a movie scene asset.</summary>
public partial class UMovieScene : UMovieSceneSignedObject {
// MovieScene
	public TArray<FMovieSceneSpawnable> Spawnables;
	public TArray<FMovieScenePossessable> Possessables;
	public TArray<FMovieSceneBinding> ObjectBindings;
	public TMap<string,FMovieSceneObjectBindingIDs> BindingGroups;
	public TArray<UMovieSceneTrack> Tracks;
	public UMovieSceneTrack CameraCutTrack;
	public FMovieSceneFrameRange SelectionRange;
	public FMovieSceneFrameRange PlaybackRange;
	public FFrameRate TickResolution;
	public FFrameRate DisplayRate;
	public EMovieSceneEvaluationType EvaluationType;
	public EUpdateClockSource ClockSource;
	public FSoftObjectPath CustomClockSourcePath;
	public TArray<FMovieSceneMarkedFrame> MarkedFrames;
	public bool bReadOnly;
	public bool bPlaybackRangeLocked;
	public TMap<string,string> ObjectsToDisplayNames;
	public TMap<string,FMovieSceneTrackLabels> ObjectsToLabels;
	public FMovieSceneEditorData EditorData;
	public TArray<UMovieSceneFolder> RootFolders;
	public TArray<string> SoloNodes;
	public TArray<string> MuteNodes;
	public TArray<FMovieSceneSectionGroup> SectionGroups;
	public UMovieSceneNodeGroupCollection NodeGroupCollection;
	public float InTime_DEPRECATED;
	public float OutTime_DEPRECATED;
	public float StartTime_DEPRECATED;
	public float EndTime_DEPRECATED;
	public bool bForceFixedFrameIntervalPlayback_DEPRECATED;
	public float FixedFrameInterval_DEPRECATED;
	public TArray<UMovieSceneTrack> MasterTracks_DEPRECATED;
}
