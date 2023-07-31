#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A one-to-many definition of movie scene object binding IDs to overridden objects that should be bound to that binding.</summary>
[CppInclude("MovieSceneBindingOverrides.h")]
public partial class UMovieSceneBindingOverrides : UObject {
	///<summary>The actual binding data</summary>
	public TArray<FMovieSceneBindingOverrideData> BindingData;
}
