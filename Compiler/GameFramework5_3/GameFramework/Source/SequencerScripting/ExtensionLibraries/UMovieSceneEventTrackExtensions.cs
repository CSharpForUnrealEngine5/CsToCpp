namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneEventTrack for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneEventTrackExtensions.h")]
public partial class UMovieSceneEventTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create a new event repeater section for the given track</summary>
	public static UMovieSceneEventRepeaterSection AddEventRepeaterSection(UMovieSceneEventTrack InTrack) { return default; }
	///<summary>Create a new event trigger section for the given track</summary>
	public static UMovieSceneEventTriggerSection AddEventTriggerSection(UMovieSceneEventTrack InTrack) { return default; }
	///<summary>* Return the class of the bound object property</summary>
	public static UClass GetBoundObjectPropertyClass(FMovieSceneEvent EventKey) { return default; }
}
