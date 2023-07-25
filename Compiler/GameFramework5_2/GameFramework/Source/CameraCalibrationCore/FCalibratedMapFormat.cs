#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CalibratedMapFormat.h")]
///<summary>Formatting options for processing a calibrated map</summary>
public partial struct FCalibratedMapFormat {
// CalibratedMapFormat
	public ECalibratedMapPixelOrigin PixelOrigin;
	public ECalibratedMapChannels UndistortionChannels;
	public ECalibratedMapChannels DistortionChannels;
}
