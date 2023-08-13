namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcCalibrationData.h")]
public partial struct FMrcAlignmentSaveData {
	public FVector CameraOrigin;
	public FRotator Orientation;
	public string TrackingAttachmentId;
	public EHMDTrackingOrigin TrackingOrigin;
}
