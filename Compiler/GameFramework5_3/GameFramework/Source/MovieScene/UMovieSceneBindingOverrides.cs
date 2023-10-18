namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A one-to-many definition of movie scene object binding IDs to overridden objects that should be bound to that binding.</summary>
[CppInclude("MovieSceneBindingOverrides.h")]
public partial class UMovieSceneBindingOverrides : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The actual binding data</summary>
	public TArray<FMovieSceneBindingOverrideData> BindingData;
}
