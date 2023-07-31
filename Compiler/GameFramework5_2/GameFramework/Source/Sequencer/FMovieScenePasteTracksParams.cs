#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Paste tracks params</summary>
[CppInclude("SequencerUtilities.h")]
public partial struct FMovieScenePasteTracksParams {
	public UMovieSceneSequence Sequence;
	public TArray<FMovieSceneBindingProxy> Bindings;
	public UMovieSceneFolder ParentFolder;
	public TArray<UMovieSceneFolder> Folders;
}
