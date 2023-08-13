namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneMaterialTrack for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneMaterialTrackExtensions.h")]
public partial class UMovieSceneMaterialTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set material index of the component that is animated by the material track.</summary>
	public static void SetMaterialIndex(UMovieSceneComponentMaterialTrack Track,int MaterialIndex) {}
	///<summary>Get material index of the component that is animated by the material track.</summary>
	public static int GetMaterialIndex(UMovieSceneComponentMaterialTrack Track) { return default; }
}
