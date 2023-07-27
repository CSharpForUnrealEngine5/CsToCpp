#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneCinePrestreamingSection.h")]
///<summary>Movie Scene Section representing a Prestreaming asset.</summary>
public partial class UMovieSceneCinePrestreamingSection : UMovieSceneSection {
// MovieSceneCinePrestreamingSection
	public  TSoftObjectPtr<UCinePrestreamingData> GetPrestreamingAsset() { return default; }
	public  void SetPrestreamingAsset(UCinePrestreamingData InData) {}
	public  int GetQualityLevel() { return default; }
	public  void SetQualityLevel(int InLevel) {}
	public  void SetStartFrameOffset(int InOffset) {}
	public TSoftObjectPtr<UCinePrestreamingData> PrestreamingAsset;
	public int StartFrameOffset;
	public int QualityLevel;
}
