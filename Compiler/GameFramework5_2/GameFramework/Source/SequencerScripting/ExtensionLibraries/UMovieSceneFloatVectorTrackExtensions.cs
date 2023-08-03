#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneFloatVectorTrack for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneVectorTrackExtensions.h")]
public partial class UMovieSceneFloatVectorTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set the number of channels used for this track</summary>
	public static void SetNumChannelsUsed(UMovieSceneFloatVectorTrack Track,int InNumChannelsUsed) {}
	///<summary>Get the number of channels used for this track</summary>
	public static int GetNumChannelsUsed(UMovieSceneFloatVectorTrack Track) { return default; }
}
