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
