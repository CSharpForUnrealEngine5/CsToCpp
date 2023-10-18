namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneTracks for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneTrackExtensions.h")]
public partial class UMovieSceneTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set this track&#39;s display name</summary>
	public static void SetDisplayName(UMovieSceneTrack Track,FText InName) {}
	///<summary>Get this track&#39;s display name</summary>
	public static FText GetDisplayName(UMovieSceneTrack Track) { return default; }
	///<summary>Set this track row&#39;s display name</summary>
	public static void SetTrackRowDisplayName(UMovieSceneTrack Track,FText InName,int RowIndex) {}
	///<summary>Get this track row&#39;s display name</summary>
	public static FText GetTrackRowDisplayName(UMovieSceneTrack Track,int RowIndex) { return default; }
	///<summary>Add a new section to this track</summary>
	public static UMovieSceneSection AddSection(UMovieSceneTrack Track) { return default; }
	///<summary>Access all this track&#39;s sections</summary>
	public static TArray<UMovieSceneSection> GetSections(UMovieSceneTrack Track) { return default; }
	///<summary>Remove the specified section</summary>
	public static void RemoveSection(UMovieSceneTrack Track,UMovieSceneSection Section) {}
	///<summary>Get the sorting order for this track</summary>
	public static int GetSortingOrder(UMovieSceneTrack Track) { return default; }
	///<summary>Set the sorting order for this track</summary>
	public static void SetSortingOrder(UMovieSceneTrack Track,int SortingOrder) {}
	///<summary>Get the color tint for this track</summary>
	public static FColor GetColorTint(UMovieSceneTrack Track) { return default; }
	///<summary>Set the color tint for this track</summary>
	public static void SetColorTint(UMovieSceneTrack Track,FColor ColorTint) {}
	///<summary>Get the section to key for this track</summary>
	public static UMovieSceneSection GetSectionToKey(UMovieSceneTrack Track) { return default; }
	///<summary>Set the section to key for this track. When properties for this section are modified externally,</summary>
	public static void SetSectionToKey(UMovieSceneTrack Track,UMovieSceneSection Section) {}
}
