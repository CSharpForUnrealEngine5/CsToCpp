namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieScenePrimitiveMaterialTrack for scripting</summary>
[CppInclude("ExtensionLibraries/MovieScenePrimitiveMaterialTrackExtensions.h")]
public partial class UMovieScenePrimitiveMaterialTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Set material index of the element that is animated by the primitive material track.</summary>
	public static void SetMaterialIndex(UMovieScenePrimitiveMaterialTrack Track,int MaterialIndex) {}
	///<summary>Get material index of the element that is animated by the primitive material track.</summary>
	public static int GetMaterialIndex(UMovieScenePrimitiveMaterialTrack Track) { return default; }
}
