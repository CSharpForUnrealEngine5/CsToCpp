namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of component transforms in a movie scene</summary>
[CppInclude("Tracks/MovieScene3DTransformTrack.h")]
public partial class UMovieScene3DTransformTrack : UMovieScenePropertyTrack {
	public static UClass StaticClass() {return default;}
	///<summary>User-defined blender system to use for this track</summary>
	public UClass BlenderSystemClass;
}
