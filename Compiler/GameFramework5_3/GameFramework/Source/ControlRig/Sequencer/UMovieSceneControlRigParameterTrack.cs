namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles animation of skeletal mesh actors using animation ControlRigs</summary>
[CppInclude("Sequencer/MovieSceneControlRigParameterTrack.h")]
public partial class UMovieSceneControlRigParameterTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Control Rig we control</summary>
	public UControlRig ControlRig;
	///<summary>Section we should Key</summary>
	public UMovieSceneSection SectionToKey;
	///<summary>The sections owned by this track .</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>Unique Name</summary>
	public FName TrackName;
	///<summary>Uses Rotation Order</summary>
	public TMap<FName,FControlRotationOrder> ControlsRotationOrder;
}
