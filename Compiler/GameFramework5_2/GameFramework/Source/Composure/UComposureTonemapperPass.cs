#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureTonemapperPass.h")]
///<summary>Tonemapper only pass implemented on top of the in-engine tonemapper.</summary>
public partial class UComposureTonemapperPass : UComposurePostProcessPass {
// ComposureTonemapperPass
	public FColorGradingSettings ColorGradingSettings;
	public FFilmStockSettings FilmStockSettings;
	public float ChromaticAberration;
	public  void TonemapToRenderTarget() {}
}
