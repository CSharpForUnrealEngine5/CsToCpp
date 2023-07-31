#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/ImageSequenceProtocol.h")]
public partial class UImageSequenceProtocol_EXR : UImageSequenceProtocol {
	///<summary>Whether to write out compressed or uncompressed EXRs</summary>
	public bool bCompressed;
	///<summary>The color gamut to use when storing HDR captured data.</summary>
	public EHDRCaptureGamut CaptureGamut;
}
