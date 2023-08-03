#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieScenePropertyTrack for scripting</summary>
[CppInclude("ExtensionLibraries/MovieScenePropertyTrackExtensions.h")]
public partial class UMovieScenePropertyTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set this track&#39;s property name and path</summary>
	public static void SetPropertyNameAndPath(UMovieScenePropertyTrack Track,string InPropertyName,string InPropertyPath) {}
	///<summary>Get this track&#39;s property name</summary>
	public static string GetPropertyName(UMovieScenePropertyTrack Track) { return default; }
	///<summary>Get this track&#39;s property path</summary>
	public static string GetPropertyPath(UMovieScenePropertyTrack Track) { return default; }
	///<summary>Get this track&#39;s unique name</summary>
	public static string GetUniqueTrackName(UMovieScenePropertyTrack Track) { return default; }
	///<summary>Set this object property track&#39;s property class</summary>
	public static void SetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track,UClass PropertyClass) {}
	///<summary>Get this object property track&#39;s property class</summary>
	public static UClass GetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track) { return default; }
	///<summary>Set this byte track&#39;s enum</summary>
	public static void SetByteTrackEnum(UMovieSceneByteTrack Track,UEnum InEnum) {}
	///<summary>Get this byte track&#39;s enum</summary>
	public static UEnum GetByteTrackEnum(UMovieSceneByteTrack Track) { return default; }
}
