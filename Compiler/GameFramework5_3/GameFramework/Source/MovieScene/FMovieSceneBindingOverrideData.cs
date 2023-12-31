namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene binding override data</summary>
[CppInclude("MovieSceneBindingOverrides.h")]
public partial struct FMovieSceneBindingOverrideData {
	public FMovieSceneObjectBindingID ObjectBindingId;
	public TSoftObjectPtr<UObject> Object;
	public bool bOverridesDefault;
}
