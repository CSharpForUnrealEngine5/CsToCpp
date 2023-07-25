#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleARKitCamera.h")]
///<summary>A model representing the camera and its properties at a single point in time.</summary>
public partial struct FAppleARKitCamera {
// AppleARKitCamera
	public EARTrackingQuality TrackingQuality;
	public EARTrackingQualityReason TrackingQualityReason;
	public FTransform Transform;
	public FQuat Orientation;
	public FVector Translation;
	public FVector2D ImageResolution;
	public FVector2D FocalLength;
	public FVector2D PrincipalPoint;
}
