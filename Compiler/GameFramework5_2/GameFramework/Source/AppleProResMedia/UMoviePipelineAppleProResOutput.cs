#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Forward Declare</summary>
[CppInclude("MoviePipelineAppleProResOutput.h")]
public partial class UMoviePipelineAppleProResOutput : UMoviePipelineVideoOutputBase {
	///<summary>Which Apple ProRes codec should we use? See Apple documentation for more specifics. Uses Rec 709 color primaries.</summary>
	public EAppleProResEncoderCodec Codec;
	///<summary>Should the embedded timecode track be written using drop-frame format? Only applicable if the sequence framerate is 29.97</summary>
	public bool bDropFrameTimecode;
	///<summary>Should we override the maximum number of encoding threads?</summary>
	public bool bOverrideMaximumEncodingThreads;
	///<summary>What is the maximum number of threads the encoder should use to encode frames with? Zero means auto-determine based on hardware.</summary>
	public int MaxNumberOfEncodingThreads;
}
