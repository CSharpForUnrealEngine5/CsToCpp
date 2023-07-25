#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerUtilities.h")]
///<summary>Paste tracks params</summary>
public partial struct FMovieScenePasteTracksParams {
// MovieScenePasteTracksParams
	public UMovieSceneSequence Sequence;
	public TArray<FMovieSceneBindingProxy> Bindings;
	public UMovieSceneFolder ParentFolder;
	public TArray<UMovieSceneFolder> Folders;
}
