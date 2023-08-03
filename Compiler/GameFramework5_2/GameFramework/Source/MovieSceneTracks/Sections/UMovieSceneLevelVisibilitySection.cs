#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A section for use with the movie scene level visibility track, which controls streamed level visibility.</summary>
[CppInclude("Sections/MovieSceneLevelVisibilitySection.h")]
public partial class UMovieSceneLevelVisibilitySection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>GetVisibility</summary>
	public  ELevelVisibility GetVisibility() { return default; }
	///<summary>SetVisibility</summary>
	public  void SetVisibility(ELevelVisibility InVisibility) {}
	///<summary>GetLevelNames</summary>
	public  TArray<string> GetLevelNames() { return default; }
	///<summary>SetLevelNames</summary>
	public  void SetLevelNames(TArray<string> InLevelNames) {}
	///<summary>Whether or not the levels in this section should be visible or hidden.</summary>
	public ELevelVisibility Visibility;
	///<summary>The short names of the levels who&#39;s visibility is controlled by this section.</summary>
	public TArray<string> LevelNames;
}
