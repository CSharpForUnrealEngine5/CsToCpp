namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Override a channel to use double perlin noise</summary>
[CppInclude("Channels/MovieSceneDoublePerlinNoiseChannelContainer.h")]
public partial class UMovieSceneDoublePerlinNoiseChannelContainer : UMovieSceneChannelOverrideContainer {
	public static UClass StaticClass() {return default;}
	///<summary>PerlinNoiseChannel</summary>
	public FMovieSceneDoublePerlinNoiseChannel PerlinNoiseChannel;
}
