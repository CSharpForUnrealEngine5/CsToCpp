namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of byte properties in a movie scene</summary>
[CppInclude("Tracks/MovieSceneEnumTrack.h")]
public partial class UMovieSceneEnumTrack : UMovieScenePropertyTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Enum</summary>
	public UEnum Enum;
}
