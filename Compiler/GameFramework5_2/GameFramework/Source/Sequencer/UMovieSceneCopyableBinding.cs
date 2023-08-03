#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCopyableBinding.h")]
public partial class UMovieSceneCopyableBinding : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Spawnables need to know about their Object Template but we cannot rely on automatic serialization due to the object</summary>
	public UObject SpawnableObjectTemplate;
	///<summary>Tracks are also owned by the owning Movie Sequence. We manually copy the tracks out of a binding when we copy,</summary>
	public TArray<UMovieSceneTrack> Tracks;
	///<summary>Binding</summary>
	public FMovieSceneBinding Binding;
	///<summary>Spawnable</summary>
	public FMovieSceneSpawnable Spawnable;
	///<summary>Possessable</summary>
	public FMovieScenePossessable Possessable;
	///<summary>BoundObjectNames</summary>
	public TArray<string> BoundObjectNames;
	///<summary>FolderPath</summary>
	public TArray<string> FolderPath;
}
