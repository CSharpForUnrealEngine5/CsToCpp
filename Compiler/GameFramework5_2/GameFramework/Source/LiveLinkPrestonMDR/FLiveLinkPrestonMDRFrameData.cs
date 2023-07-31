#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for dynamic (per-frame) Preston MDR data</summary>
[CppInclude("LiveLinkPrestonMDRTypes.h")]
public partial struct FLiveLinkPrestonMDRFrameData {
	public ushort RawFocusEncoderValue;
	public ushort RawIrisEncoderValue;
	public ushort RawZoomEncoderValue;
}
