#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles animation of NiagaraCache</summary>
[CppInclude("Niagara/Sequencer/MovieSceneNiagaraCacheTrack.h")]
public partial class UMovieSceneNiagaraCacheTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>bIsRecording</summary>
	public bool bIsRecording;
	///<summary>List of all animation sections</summary>
	public TArray<UMovieSceneSection> AnimationSections;
	///<summary>bCacheRecordingEnabled</summary>
	public bool bCacheRecordingEnabled;
}
