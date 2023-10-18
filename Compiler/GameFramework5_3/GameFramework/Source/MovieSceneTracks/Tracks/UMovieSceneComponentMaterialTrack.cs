namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material track which is specialized for animation materials which are owned by actor components.</summary>
[CppInclude("Tracks/MovieSceneMaterialTrack.h")]
public partial class UMovieSceneComponentMaterialTrack : UMovieSceneMaterialTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The index of this material this track is animating.</summary>
	public int MaterialIndex;
}
