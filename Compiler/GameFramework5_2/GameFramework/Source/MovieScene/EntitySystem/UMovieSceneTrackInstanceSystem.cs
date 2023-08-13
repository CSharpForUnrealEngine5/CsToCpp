namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EntitySystem/TrackInstance/MovieSceneTrackInstanceSystem.h")]
public partial class UMovieSceneTrackInstanceSystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
	///<summary>Instantiator</summary>
	public UMovieSceneTrackInstanceInstantiator Instantiator;
}
