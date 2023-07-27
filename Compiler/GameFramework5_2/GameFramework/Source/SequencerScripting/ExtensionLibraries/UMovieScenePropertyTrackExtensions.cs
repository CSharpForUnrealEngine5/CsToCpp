#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieScenePropertyTrackExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieScenePropertyTrack for scripting</summary>
public partial class UMovieScenePropertyTrackExtensions : UBlueprintFunctionLibrary {
// MovieScenePropertyTrackExtensions
	public static void SetPropertyNameAndPath(UMovieScenePropertyTrack Track,string InPropertyName,string InPropertyPath) {}
	public static string GetPropertyName(UMovieScenePropertyTrack Track) { return default; }
	public static string GetPropertyPath(UMovieScenePropertyTrack Track) { return default; }
	public static string GetUniqueTrackName(UMovieScenePropertyTrack Track) { return default; }
	public static void SetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track,UClass PropertyClass) {}
	public static UClass GetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track) { return default; }
	public static void SetByteTrackEnum(UMovieSceneByteTrack Track,UEnum InEnum) {}
	public static UEnum GetByteTrackEnum(UMovieSceneByteTrack Track) { return default; }
}
