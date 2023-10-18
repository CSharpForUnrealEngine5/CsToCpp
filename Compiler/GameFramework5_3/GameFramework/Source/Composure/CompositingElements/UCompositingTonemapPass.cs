namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UCompositingTonemapPass : UCompositingElementTransform {
	public static UClass StaticClass() {return default;}
	///<summary>Color grading settings.</summary>
	public FColorGradingSettings ColorGradingSettings;
	///<summary>Film stock settings.</summary>
	public FFilmStockSettings FilmStockSettings;
	///<summary>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.</summary>
	public float ChromaticAberration;
	///<summary>TonemapPolicy</summary>
	public UComposureTonemapperPassPolicy TonemapPolicy;
}
