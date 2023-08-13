namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of byte properties in a movie scene</summary>
[CppInclude("Tracks/MovieSceneByteTrack.h")]
public partial class UMovieSceneByteTrack : UMovieScenePropertyTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Enum</summary>
	public UEnum Enum;
}
