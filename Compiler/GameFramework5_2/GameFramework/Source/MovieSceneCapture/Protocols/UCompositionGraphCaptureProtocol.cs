#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/CompositionGraphCaptureProtocol.h")]
public partial class UCompositionGraphCaptureProtocol : UMovieSceneImageCaptureProtocolBase {
	///<summary>A list of render passes to include in the capture. Leave empty to export all available passes.</summary>
	public FCompositionGraphCapturePasses IncludeRenderPasses;
	///<summary>Whether to capture the frames as HDR textures (*.exr format)</summary>
	public bool bCaptureFramesInHDR;
	///<summary>Compression Quality for HDR Frames (0 for no compression, 1 for default compression which can be slow)</summary>
	public int HDRCompressionQuality;
	///<summary>The color gamut to use when storing HDR captured data. The gamut depends on whether the bCaptureFramesInHDR option is enabled.</summary>
	public EHDRCaptureGamut CaptureGamut;
	///<summary>Custom post processing material to use for rendering</summary>
	public FSoftObjectPath PostProcessingMaterial;
	///<summary>Whether to disable screen percentage</summary>
	public bool bDisableScreenPercentage;
	///<summary>PostProcessingMaterialPtr</summary>
	public UMaterialInterface PostProcessingMaterialPtr;
}
