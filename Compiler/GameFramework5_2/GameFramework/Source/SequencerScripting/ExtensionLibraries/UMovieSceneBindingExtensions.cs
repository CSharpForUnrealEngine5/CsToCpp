#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneBindingExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto FMovieSceneBindingProxies for scripting</summary>
public partial class UMovieSceneBindingExtensions : UBlueprintFunctionLibrary {
// MovieSceneBindingExtensions
	public bool IsValid(FMovieSceneBindingProxy InBinding) { return default; }
	public FGuid GetId(FMovieSceneBindingProxy InBinding) { return default; }
	public string GetDisplayName(FMovieSceneBindingProxy InBinding) { return default; }
	public void SetDisplayName(FMovieSceneBindingProxy InBinding,string InDisplayName) {}
	public string GetName(FMovieSceneBindingProxy InBinding) { return default; }
	public void SetName(FMovieSceneBindingProxy InBinding,string InName) {}
	public int GetSortingOrder(FMovieSceneBindingProxy InBinding) { return default; }
	public void SetSortingOrder(FMovieSceneBindingProxy InBinding,int SortingOrder) {}
	public TArray<UObject> GetTracks(FMovieSceneBindingProxy InBinding) { return default; }
	public TArray<UObject> FindTracksByType(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	public TArray<UObject> FindTracksByExactType(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	public void RemoveTrack(FMovieSceneBindingProxy InBinding,UObject TrackToRemove) {}
	public void Remove(FMovieSceneBindingProxy InBinding) {}
	public UObject AddTrack(FMovieSceneBindingProxy InBinding,UClass TrackType) { return default; }
	public TArray<FMovieSceneBindingProxy> GetChildPossessables(FMovieSceneBindingProxy InBinding) { return default; }
	public UObject GetObjectTemplate(FMovieSceneBindingProxy InBinding) { return default; }
	public UClass GetPossessedObjectClass(FMovieSceneBindingProxy InBinding) { return default; }
	public FMovieSceneBindingProxy GetParent(FMovieSceneBindingProxy InBinding) { return default; }
	public void SetParent(FMovieSceneBindingProxy InBinding,FMovieSceneBindingProxy InParentBinding) {}
	public void MoveBindingContents(FMovieSceneBindingProxy SourceBindingId,FMovieSceneBindingProxy DestinationBindingId) {}
	public void SetSpawnableBindingID(FMovieSceneBindingProxy InBinding,FMovieSceneObjectBindingID SpawnableBindingID) {}
}
