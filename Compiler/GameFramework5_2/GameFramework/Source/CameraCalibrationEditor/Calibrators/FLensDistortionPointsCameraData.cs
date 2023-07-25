#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Calibrators/CameraLensDistortionAlgoPoints.h")]
///<summary>Holds information of the camera pose for a given sample of a 2d-3d correlation</summary>
public partial struct FLensDistortionPointsCameraData {
// LensDistortionPointsCameraData
	public bool bIsValid;
	public uint UniqueId;
	public uint CalibratorUniqueId;
	public float InputFocus;
	public float InputZoom;
}
