namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of float vectors in a movie scene</summary>
[CppInclude("Tracks/MovieSceneVectorTrack.h")]
public partial class UMovieSceneFloatVectorTrack : UMovieScenePropertyTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The number of channels used by the vector (2,3, or 4)</summary>
	public int NumChannelsUsed;
}
