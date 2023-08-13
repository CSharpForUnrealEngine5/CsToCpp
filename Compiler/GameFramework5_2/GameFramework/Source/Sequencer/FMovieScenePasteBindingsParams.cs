namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Paste bindings params</summary>
[CppInclude("SequencerUtilities.h")]
public partial struct FMovieScenePasteBindingsParams {
	public TArray<FMovieSceneBindingProxy> Bindings;
	public UMovieSceneFolder ParentFolder;
	public TArray<UMovieSceneFolder> Folders;
	public bool bDuplicateExistingActors;
}
