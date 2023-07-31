#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
