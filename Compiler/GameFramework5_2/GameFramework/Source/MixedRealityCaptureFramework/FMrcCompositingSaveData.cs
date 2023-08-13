namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial struct FMrcCompositingSaveData {
	public FMrcVideoCaptureFeedIndex CaptureDeviceURL;
	public float DepthOffset;
	public int TrackingLatency;
	public FMrcVideoProcessingParams VideoProcessingParams;
}
