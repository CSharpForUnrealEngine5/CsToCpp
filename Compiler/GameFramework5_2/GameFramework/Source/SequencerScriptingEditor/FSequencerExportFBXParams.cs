#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTools.h")]
public partial struct FSequencerExportFBXParams {
// SequencerExportFBXParams
	public UWorld World;
	public ULevelSequence Sequence;
	public ULevelSequence RootSequence;
	public TArray<FMovieSceneBindingProxy> Bindings;
	public TArray<UMovieSceneTrack> Tracks;
	public UFbxExportOption OverrideOptions;
	public string FBXFileName;
}
