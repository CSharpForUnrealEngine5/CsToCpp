#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneTrackExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneTracks for scripting</summary>
public partial class UMovieSceneTrackExtensions : UBlueprintFunctionLibrary {
// MovieSceneTrackExtensions
	public static void SetDisplayName(UMovieSceneTrack Track,string InName) {}
	public static string GetDisplayName(UMovieSceneTrack Track) { return default; }
	public static void SetTrackRowDisplayName(UMovieSceneTrack Track,string InName,int RowIndex) {}
	public static string GetTrackRowDisplayName(UMovieSceneTrack Track,int RowIndex) { return default; }
	public static UMovieSceneSection AddSection(UMovieSceneTrack Track) { return default; }
	public static TArray<UMovieSceneSection> GetSections(UMovieSceneTrack Track) { return default; }
	public static void RemoveSection(UMovieSceneTrack Track,UMovieSceneSection Section) {}
	public static int GetSortingOrder(UMovieSceneTrack Track) { return default; }
	public static void SetSortingOrder(UMovieSceneTrack Track,int SortingOrder) {}
	public static FColor GetColorTint(UMovieSceneTrack Track) { return default; }
	public static void SetColorTint(UMovieSceneTrack Track,FColor ColorTint) {}
	public static UMovieSceneSection GetSectionToKey(UMovieSceneTrack Track) { return default; }
	public static void SetSectionToKey(UMovieSceneTrack Track,UMovieSceneSection Section) {}
}
