#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Windows target platform.</summary>
[CppInclude("MoviePlayerSettings.h")]
public partial class UMoviePlayerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, The game waits for startup movies to complete even if loading has finished.</summary>
	public bool bWaitForMoviesToComplete;
	///<summary>If enabled, Startup movies can be skipped by the user when a mouse button is pressed.</summary>
	public bool bMoviesAreSkippable;
	///<summary>Movies to play on startup. Note that these must be in your game&#39;s Game/Content/Movies directory.</summary>
	public TArray<string> StartupMovies;
}
