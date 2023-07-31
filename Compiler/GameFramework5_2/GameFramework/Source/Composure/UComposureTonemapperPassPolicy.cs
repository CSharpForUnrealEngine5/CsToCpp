#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tonemapper only rules used for configuring how UComposurePostProcessingPassProxy executes</summary>
[CppInclude("ComposureTonemapperPass.h")]
public partial class UComposureTonemapperPassPolicy : UComposurePostProcessPassPolicy {
	///<summary>Color grading settings.</summary>
	public FColorGradingSettings ColorGradingSettings;
	///<summary>Film stock settings.</summary>
	public FFilmStockSettings FilmStockSettings;
	///<summary>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.</summary>
	public float ChromaticAberration;
}
