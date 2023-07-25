#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UCompositingTonemapPass : UCompositingElementTransform {
// CompositingTonemapPass
	public FColorGradingSettings ColorGradingSettings;
	public FFilmStockSettings FilmStockSettings;
	public float ChromaticAberration;
	public UComposureTonemapperPassPolicy TonemapPolicy;
}
