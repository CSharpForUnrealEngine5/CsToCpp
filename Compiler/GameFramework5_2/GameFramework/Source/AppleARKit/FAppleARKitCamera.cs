namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A model representing the camera and its properties at a single point in time.</summary>
[CppInclude("AppleARKitCamera.h")]
public partial struct FAppleARKitCamera {
	public EARTrackingQuality TrackingQuality;
	public EARTrackingQualityReason TrackingQualityReason;
	public FTransform Transform;
	public FQuat Orientation;
	public FVector Translation;
	public FVector2D ImageResolution;
	public FVector2D FocalLength;
	public FVector2D PrincipalPoint;
}
