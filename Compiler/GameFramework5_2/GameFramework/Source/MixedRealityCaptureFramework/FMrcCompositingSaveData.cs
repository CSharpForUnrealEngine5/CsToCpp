#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial struct FMrcCompositingSaveData {
	public FMrcVideoCaptureFeedIndex CaptureDeviceURL;
	public float DepthOffset;
	public int TrackingLatency;
	public FMrcVideoProcessingParams VideoProcessingParams;
}
