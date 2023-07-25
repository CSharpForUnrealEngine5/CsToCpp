#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePlayerSettings.h")]
///<summary>Implements the settings for the Windows target platform.</summary>
public partial class UMoviePlayerSettings : UObject {
// MoviePlayerSettings
	public bool bWaitForMoviesToComplete;
	public bool bMoviesAreSkippable;
	public TArray<string> StartupMovies;
}
