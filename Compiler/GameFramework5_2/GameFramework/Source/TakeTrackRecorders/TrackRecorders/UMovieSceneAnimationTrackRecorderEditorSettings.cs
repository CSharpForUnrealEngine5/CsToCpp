#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TrackRecorders/MovieSceneAnimationTrackRecorderSettings.h")]
public partial class UMovieSceneAnimationTrackRecorderEditorSettings : UMovieSceneTrackRecorderSettings {
// MovieSceneAnimationTrackRecorderEditorSettings
	public string AnimationTrackName;
	public string AnimationAssetName;
	public string AnimationSubDirectory;
	public byte InterpMode;
	public byte TangentMode;
	public bool bRemoveRootAnimation;
	public FTimecodeBoneMethod TimecodeBoneMethod;
}
