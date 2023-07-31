#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TrackRecorders/MovieSceneAnimationTrackRecorderSettings.h")]
public partial class UMovieSceneAnimationTrackRecorderEditorSettings : UMovieSceneTrackRecorderSettings {
	///<summary>Name of the recorded animation track.</summary>
	public string AnimationTrackName;
	///<summary>The name of the animation asset.</summary>
	public string AnimationAssetName;
	///<summary>The name of the subdirectory animations will be placed in. Leave this empty to place into the same directory as the sequence base path.</summary>
	public string AnimationSubDirectory;
	///<summary>Interpolation mode for the recorded keys.</summary>
	public ERichCurveInterpMode InterpMode;
	///<summary>Tangent mode for the recorded keys.</summary>
	public ERichCurveTangentMode TangentMode;
	///<summary>If true we remove the root animation and move it to a transform track, if false we leave it on the root bone in the anim sequence</summary>
	public bool bRemoveRootAnimation;
	///<summary>The method to record timecode values onto bones</summary>
	public FTimecodeBoneMethod TimecodeBoneMethod;
}
