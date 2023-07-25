#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneBindingOverrides.h")]
///<summary>Movie scene binding override data</summary>
public partial struct FMovieSceneBindingOverrideData {
// MovieSceneBindingOverrideData
	public FMovieSceneObjectBindingID ObjectBindingId;
	public TSoftObjectPtr<UObject> Object;
	public bool bOverridesDefault;
}
