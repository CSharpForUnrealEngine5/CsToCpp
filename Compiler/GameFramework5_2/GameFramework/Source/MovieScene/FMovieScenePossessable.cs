#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MovieScenePossessable is a &quot;typed slot&quot; used to allow the MovieScene to control an already-existing object</summary>
[CppInclude("MovieScenePossessable.h")]
public partial struct FMovieScenePossessable {
	public TArray<string> Tags;
	public FGuid Guid;
	public string Name;
	public TSoftObjectPtr<UClass> PossessedObjectClass;
	public FGuid ParentGuid;
	public FMovieSceneObjectBindingID SpawnableObjectBindingID;
}
