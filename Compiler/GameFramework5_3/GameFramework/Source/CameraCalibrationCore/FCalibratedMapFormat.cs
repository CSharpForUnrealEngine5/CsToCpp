namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Formatting options for processing a calibrated map</summary>
[CppInclude("CalibratedMapFormat.h")]
public partial struct FCalibratedMapFormat {
	public ECalibratedMapPixelOrigin PixelOrigin;
	public ECalibratedMapChannels UndistortionChannels;
	public ECalibratedMapChannels DistortionChannels;
}
