namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Override a channel to use float perlin noise</summary>
[CppInclude("Channels/MovieSceneFloatPerlinNoiseChannelContainer.h")]
public partial class UMovieSceneFloatPerlinNoiseChannelContainer : UMovieSceneChannelOverrideContainer {
	public static UClass StaticClass() {return default;}
	///<summary>PerlinNoiseChannel</summary>
	public FMovieSceneFloatPerlinNoiseChannel PerlinNoiseChannel;
}
