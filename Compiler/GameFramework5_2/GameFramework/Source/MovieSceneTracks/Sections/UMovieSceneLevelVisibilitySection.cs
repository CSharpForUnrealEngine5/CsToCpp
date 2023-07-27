#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneLevelVisibilitySection.h")]
///<summary>A section for use with the movie scene level visibility track, which controls streamed level visibility.</summary>
public partial class UMovieSceneLevelVisibilitySection : UMovieSceneSection {
// MovieSceneLevelVisibilitySection
	public  ELevelVisibility GetVisibility() { return default; }
	public  void SetVisibility(ELevelVisibility InVisibility) {}
	public  TArray<string> GetLevelNames() { return default; }
	public  void SetLevelNames(TArray<string> InLevelNames) {}
	public ELevelVisibility Visibility;
	public TArray<string> LevelNames;
}
