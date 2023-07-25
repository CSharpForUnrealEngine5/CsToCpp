#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureTonemapperPass.h")]
///<summary>Tonemapper only rules used for configuring how UComposurePostProcessingPassProxy executes</summary>
public partial class UComposureTonemapperPassPolicy : UComposurePostProcessPassPolicy {
// ComposureTonemapperPassPolicy
	public FColorGradingSettings ColorGradingSettings;
	public FFilmStockSettings FilmStockSettings;
	public float ChromaticAberration;
}
