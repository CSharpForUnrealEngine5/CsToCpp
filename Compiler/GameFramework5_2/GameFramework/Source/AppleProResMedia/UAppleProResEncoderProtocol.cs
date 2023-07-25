#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleProResEncoderProtocol.h")]
public partial class UAppleProResEncoderProtocol : UFrameGrabberProtocol {
// AppleProResEncoderProtocol
	public EAppleProResEncoderFormats EncodingFormat;
	public EAppleProResEncoderColorDescription ColorDescription;
	public EAppleProResEncoderScanType ScanType;
	public int NumberOfEncodingThreads;
	public bool bEmbedTimecodeTrack;
	public bool bDropFrameTimecode;
}
