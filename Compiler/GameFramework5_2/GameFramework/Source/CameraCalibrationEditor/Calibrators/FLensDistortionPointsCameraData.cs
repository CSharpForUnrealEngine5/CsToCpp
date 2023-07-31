#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information of the camera pose for a given sample of a 2d-3d correlation</summary>
[CppInclude("Calibrators/CameraLensDistortionAlgoPoints.h")]
public partial struct FLensDistortionPointsCameraData {
	public bool bIsValid;
	public uint UniqueId;
	public uint CalibratorUniqueId;
	public float InputFocus;
	public float InputZoom;
}
