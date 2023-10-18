namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for media sources that are coming from a capture card.</summary>
[CppInclude("CaptureCardMediaSource.h")]
public partial class UCaptureCardMediaSource : UTimeSynchronizableMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>Should use JITR technique? It enables late sample picking for render.</summary>
	public bool bRenderJIT;
	///<summary>Should wait for some time until requested frame arrives? Requires JIT rendering.</summary>
	public bool bFramelock;
	///<summary>Sample evaluation type.</summary>
	public EMediaIOSampleEvaluationType EvaluationType;
	///<summary>How interlaced video should be treated.</summary>
	public UVideoDeinterlacer Deinterlacer;
	///<summary>The order in which interlace fields should be copied.</summary>
	public EMediaIOInterlaceFieldOrder InterlaceFieldOrder;
	///<summary>Whether to override the source encoding or to use the metadata embedded in the ancillary data of the signal.</summary>
	public bool bOverrideSourceEncoding;
	///<summary>Encoding of the source texture.</summary>
	public EMediaIOCoreSourceEncoding OverrideSourceEncoding;
	///<summary>Whether to override the source color space or to use the metadata embedded in the ancillary data of the signal.</summary>
	public bool bOverrideSourceColorSpace;
	///<summary>Color space of the source texture.</summary>
	public ETextureColorSpace OverrideSourceColorSpace;
	///<summary>OCIO Settings used for applying a color conversion to the incoming source.</summary>
	public FOpenColorIOColorConversionSettings ColorConversionSettings;
}
