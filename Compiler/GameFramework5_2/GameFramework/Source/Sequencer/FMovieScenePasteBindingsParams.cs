#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerUtilities.h")]
///<summary>Paste bindings params</summary>
public partial struct FMovieScenePasteBindingsParams {
// MovieScenePasteBindingsParams
	public TArray<FMovieSceneBindingProxy> Bindings;
	public UMovieSceneFolder ParentFolder;
	public TArray<UMovieSceneFolder> Folders;
	public bool bDuplicateExistingActors;
}
