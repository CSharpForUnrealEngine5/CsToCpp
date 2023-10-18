namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePlayer.h")]
///<summary>In order for a platform to support early movie playback, the platform must support the rendering thread</summary>
public enum EMoviePlaybackType {
	MT_Normal=0,
	MT_Looped=1,
	MT_LoadingLoop=2,
	MT_MAX=3,
}
