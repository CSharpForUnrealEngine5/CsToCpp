#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles animation of skeletal mesh actors using animation ControlRigs</summary>
[CppInclude("Sequencer/MovieSceneControlRigParameterTrack.h")]
public partial class UMovieSceneControlRigParameterTrack : UMovieSceneNameableTrack {
	///<summary>Control Rig we control</summary>
	public UControlRig ControlRig;
	///<summary>Section we should Key</summary>
	public UMovieSceneSection SectionToKey;
	///<summary>The sections owned by this track .</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>Unique Name</summary>
	public string TrackName;
}
