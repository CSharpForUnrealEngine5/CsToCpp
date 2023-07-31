#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of an AJA timecode from Video</summary>
[CppInclude("AjaDeviceProvider.h")]
public partial struct FAjaMediaTimecodeConfiguration {
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOTimecodeFormat TimecodeFormat;
}
