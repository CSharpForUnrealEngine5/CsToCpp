#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene Section representing a Prestreaming asset.</summary>
[CppInclude("Sections/MovieSceneCinePrestreamingSection.h")]
public partial class UMovieSceneCinePrestreamingSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Get the prestreaming asset soft pointer. Use for async loading.</summary>
	public  TSoftObjectPtr<UCinePrestreamingData> GetPrestreamingAsset() { return default; }
	///<summary>SetPrestreamingAsset</summary>
	public  void SetPrestreamingAsset(UCinePrestreamingData InData) {}
	///<summary>If MovieScene.PreStream.QualityLevel is less than this then discard this section at runtime.</summary>
	public  int GetQualityLevel() { return default; }
	///<summary>SetQualityLevel</summary>
	public  void SetQualityLevel(int InLevel) {}
	///<summary>SetStartFrameOffset</summary>
	public  void SetStartFrameOffset(int InOffset) {}
	///<summary>The asset containing cinematic prestreaming data to use for this section.</summary>
	public TSoftObjectPtr<UCinePrestreamingData> PrestreamingAsset;
	///<summary>Number of frames by which to offset the evaluation. Larger values cause prestreaming to happen earlier.</summary>
	public int StartFrameOffset;
	///<summary>If If MovieScene.PreStream.QualityLevel is less than this then discard this section at runtime.</summary>
	public int QualityLevel;
}
