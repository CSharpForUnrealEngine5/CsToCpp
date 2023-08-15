namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MovieScenePossessable is a &quot;typed slot&quot; used to allow the MovieScene to control an already-existing object</summary>
[CppInclude("MovieScenePossessable.h")]
public partial struct FMovieScenePossessable {
	public TArray<FName> Tags;
	public FGuid Guid;
	public string Name;
	public TSoftObjectPtr<UClass> PossessedObjectClass;
	public FGuid ParentGuid;
	public FMovieSceneObjectBindingID SpawnableObjectBindingID;
}
