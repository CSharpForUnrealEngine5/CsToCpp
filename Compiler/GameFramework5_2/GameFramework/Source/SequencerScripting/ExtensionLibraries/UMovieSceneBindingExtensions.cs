#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto FMovieSceneBindingProxies for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneBindingExtensions.h")]
public partial class UMovieSceneBindingExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the specified binding is valid</summary>
	public static bool IsValid(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Get this binding&#39;s ID</summary>
	public static FGuid GetId(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Get this binding&#39;s name</summary>
	public static string GetDisplayName(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Set this binding&#39;s name</summary>
	public static void SetDisplayName(FMovieSceneBindingProxy InBinding,string InDisplayName) {}
	///<summary>Get this binding&#39;s object non-display name</summary>
	public static string GetName(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Set this binding&#39;s object non-display name</summary>
	public static void SetName(FMovieSceneBindingProxy InBinding,string InName) {}
	///<summary>Get the sorting order for this binding</summary>
	public static int GetSortingOrder(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Set the sorting order for this binding</summary>
	public static void SetSortingOrder(FMovieSceneBindingProxy InBinding,int SortingOrder) {}
	///<summary>Get all the tracks stored within this binding</summary>
	public static TArray<UMovieSceneTrack> GetTracks(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Find all tracks within a given binding of the specified type</summary>
	public static TArray<UMovieSceneTrack> FindTracksByType(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	///<summary>Find all tracks within a given binding of the specified type, not allowing sub-classed types</summary>
	public static TArray<UMovieSceneTrack> FindTracksByExactType(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	///<summary>Remove the specified track from this binding</summary>
	public static void RemoveTrack(FMovieSceneBindingProxy InBinding,UMovieSceneTrack TrackToRemove) {}
	///<summary>Remove the specified binding</summary>
	public static void Remove(FMovieSceneBindingProxy InBinding) {}
	///<summary>Add a new track to the specified binding</summary>
	public static UMovieSceneTrack AddTrack(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	///<summary>Get all the children of this binding</summary>
	public static TArray<FMovieSceneBindingProxy> GetChildPossessables(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Get this binding&#39;s object template</summary>
	public static UObject GetObjectTemplate(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Get this binding&#39;s possessed object class</summary>
	public static UClass GetPossessedObjectClass(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Get the parent of this binding</summary>
	public static FMovieSceneBindingProxy GetParent(FMovieSceneBindingProxy InBinding) { return default; }
	///<summary>Set the parent to this binding</summary>
	public static void SetParent(FMovieSceneBindingProxy InBinding,FMovieSceneBindingProxy InParentBinding) {}
	///<summary>Move all the contents (tracks, child bindings) of the specified binding ID onto another</summary>
	public static void MoveBindingContents(FMovieSceneBindingProxy SourceBindingId,FMovieSceneBindingProxy DestinationBindingId) {}
	///<summary>Set the spawnable id that the possessable binding should possess</summary>
	public static void SetSpawnableBindingID(FMovieSceneBindingProxy InBinding,FMovieSceneObjectBindingID SpawnableBindingID) {}
}
