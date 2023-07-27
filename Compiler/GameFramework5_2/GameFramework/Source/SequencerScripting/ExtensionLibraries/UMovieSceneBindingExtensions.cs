#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneBindingExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto FMovieSceneBindingProxies for scripting</summary>
public partial class UMovieSceneBindingExtensions : UBlueprintFunctionLibrary {
// MovieSceneBindingExtensions
	public static bool IsValid(FMovieSceneBindingProxy InBinding) { return default; }
	public static FGuid GetId(FMovieSceneBindingProxy InBinding) { return default; }
	public static string GetDisplayName(FMovieSceneBindingProxy InBinding) { return default; }
	public static void SetDisplayName(FMovieSceneBindingProxy InBinding,string InDisplayName) {}
	public static string GetName(FMovieSceneBindingProxy InBinding) { return default; }
	public static void SetName(FMovieSceneBindingProxy InBinding,string InName) {}
	public static int GetSortingOrder(FMovieSceneBindingProxy InBinding) { return default; }
	public static void SetSortingOrder(FMovieSceneBindingProxy InBinding,int SortingOrder) {}
	public static TArray<UMovieSceneTrack> GetTracks(FMovieSceneBindingProxy InBinding) { return default; }
	public static TArray<UMovieSceneTrack> FindTracksByType(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	public static TArray<UMovieSceneTrack> FindTracksByExactType(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	public static void RemoveTrack(FMovieSceneBindingProxy InBinding,UMovieSceneTrack TrackToRemove) {}
	public static void Remove(FMovieSceneBindingProxy InBinding) {}
	public static UMovieSceneTrack AddTrack(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	public static TArray<FMovieSceneBindingProxy> GetChildPossessables(FMovieSceneBindingProxy InBinding) { return default; }
	public static UObject GetObjectTemplate(FMovieSceneBindingProxy InBinding) { return default; }
	public static UClass GetPossessedObjectClass(FMovieSceneBindingProxy InBinding) { return default; }
	public static FMovieSceneBindingProxy GetParent(FMovieSceneBindingProxy InBinding) { return default; }
	public static void SetParent(FMovieSceneBindingProxy InBinding,FMovieSceneBindingProxy InParentBinding) {}
	public static void MoveBindingContents(FMovieSceneBindingProxy SourceBindingId,FMovieSceneBindingProxy DestinationBindingId) {}
	public static void SetSpawnableBindingID(FMovieSceneBindingProxy InBinding,FMovieSceneObjectBindingID SpawnableBindingID) {}
}
