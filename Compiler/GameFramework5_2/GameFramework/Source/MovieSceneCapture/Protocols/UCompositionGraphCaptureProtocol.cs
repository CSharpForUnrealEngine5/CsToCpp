#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/CompositionGraphCaptureProtocol.h")]
public partial class UCompositionGraphCaptureProtocol : UMovieSceneImageCaptureProtocolBase {
// CompositionGraphCaptureProtocol
	public FCompositionGraphCapturePasses IncludeRenderPasses;
	public bool bCaptureFramesInHDR;
	public int HDRCompressionQuality;
	public EHDRCaptureGamut CaptureGamut;
	public FSoftObjectPath PostProcessingMaterial;
	public bool bDisableScreenPercentage;
	public UMaterialInterface PostProcessingMaterialPtr;
}
