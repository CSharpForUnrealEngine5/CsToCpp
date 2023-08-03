#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of DMX Libraries in a movie scene.</summary>
[CppInclude("Sequencer/MovieSceneDMXLibraryTrack.h")]
public partial class UMovieSceneDMXLibraryTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>The sections owned by this track .</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>The DMX Library to manipulate</summary>
	public UDMXLibrary Library;
}
