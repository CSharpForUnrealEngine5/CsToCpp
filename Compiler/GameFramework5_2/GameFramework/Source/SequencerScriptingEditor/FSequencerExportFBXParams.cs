#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTools.h")]
public partial struct FSequencerExportFBXParams {
	public UWorld World;
	public ULevelSequence Sequence;
	public ULevelSequence RootSequence;
	public TArray<FMovieSceneBindingProxy> Bindings;
	public TArray<UMovieSceneTrack> Tracks;
	public UFbxExportOption OverrideOptions;
	public string FBXFileName;
}
