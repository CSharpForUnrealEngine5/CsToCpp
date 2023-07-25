#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigParameterTrack.h")]
///<summary>Handles animation of skeletal mesh actors using animation ControlRigs</summary>
public partial class UMovieSceneControlRigParameterTrack : UMovieSceneNameableTrack {
// MovieSceneControlRigParameterTrack
	public UControlRig ControlRig;
	public UMovieSceneSection SectionToKey;
	public TArray<UMovieSceneSection> Sections;
	public string TrackName;
}
