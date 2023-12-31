namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tonemapper only pass implemented on top of the in-engine tonemapper.</summary>
[CppInclude("ComposureTonemapperPass.h")]
public partial class UComposureTonemapperPass : UComposurePostProcessPass {
	public static UClass StaticClass() {return default;}
	///<summary>Color grading settings.</summary>
	public FColorGradingSettings ColorGradingSettings;
	///<summary>Film stock settings.</summary>
	public FFilmStockSettings FilmStockSettings;
	///<summary>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners.</summary>
	public float ChromaticAberration;
	///<summary>Tone map the input into the output.</summary>
	public void TonemapToRenderTarget() {}
}
