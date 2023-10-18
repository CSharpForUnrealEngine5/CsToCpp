namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of material parameter collections in a movie scene.</summary>
[CppInclude("Tracks/MovieSceneMaterialParameterCollectionTrack.h")]
public partial class UMovieSceneMaterialParameterCollectionTrack : UMovieSceneMaterialTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The material parameter collection to manipulate</summary>
	public UMaterialParameterCollection MPC;
}
