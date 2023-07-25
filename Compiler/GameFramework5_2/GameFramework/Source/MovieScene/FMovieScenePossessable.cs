#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScenePossessable.h")]
///<summary>MovieScenePossessable is a "typed slot" used to allow the MovieScene to control an already-existing object</summary>
public partial struct FMovieScenePossessable {
// MovieScenePossessable
	public TArray<string> Tags;
	public FGuid Guid;
	public string Name;
	public TSoftObjectPtr<UClass> PossessedObjectClass;
	public FGuid ParentGuid;
	public FMovieSceneObjectBindingID SpawnableObjectBindingID;
}
