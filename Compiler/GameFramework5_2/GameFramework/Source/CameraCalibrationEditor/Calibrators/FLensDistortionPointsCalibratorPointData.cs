#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Calibrators/CameraLensDistortionAlgoPoints.h")]
///<summary>Holds information of the identified calibrator 2d point for a given sample of a 2d-3d correlation</summary>
public partial struct FLensDistortionPointsCalibratorPointData {
// LensDistortionPointsCalibratorPointData
	public bool bIsValid;
	public string Name;
	public FVector Point3d;
	public FVector2D Point2d;
}
