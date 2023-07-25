#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieScenePropertyTrackExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieScenePropertyTrack for scripting</summary>
public partial class UMovieScenePropertyTrackExtensions : UBlueprintFunctionLibrary {
// MovieScenePropertyTrackExtensions
	public void SetPropertyNameAndPath(UObject Track,string InPropertyName,string InPropertyPath) {}
	public string GetPropertyName(UObject Track) { return default; }
	public string GetPropertyPath(UObject Track) { return default; }
	public string GetUniqueTrackName(UObject Track) { return default; }
	public void SetObjectPropertyClass(UObject Track,UClass PropertyClass) {}
	public UClass GetObjectPropertyClass(UObject Track) { return default; }
	public void SetByteTrackEnum(UObject Track,UObject InEnum) {}
	public UObject GetByteTrackEnum(UObject Track) { return default; }
}
