#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleProResEncoderProtocol.h")]
public partial class UAppleProResEncoderProtocol : UFrameGrabberProtocol {
	///<summary>EncodingFormat</summary>
	public EAppleProResEncoderFormats EncodingFormat;
	///<summary>ColorDescription</summary>
	public EAppleProResEncoderColorDescription ColorDescription;
	///<summary>ScanType</summary>
	public EAppleProResEncoderScanType ScanType;
	///<summary>NumberOfEncodingThreads</summary>
	public int NumberOfEncodingThreads;
	///<summary>bEmbedTimecodeTrack</summary>
	public bool bEmbedTimecodeTrack;
	///<summary>Use Drop Frame Timecode when applicable (29.97p or 59.94i).</summary>
	public bool bDropFrameTimecode;
}
