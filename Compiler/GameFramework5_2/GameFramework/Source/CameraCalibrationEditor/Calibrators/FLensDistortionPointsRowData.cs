#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information of the calibrator 3d point for a given sample of a 2d-3d correlation</summary>
[CppInclude("Calibrators/CameraLensDistortionAlgoPoints.h")]
public partial struct FLensDistortionPointsRowData {
	public int Index;
	public FLensDistortionPointsCalibratorPointData CalibratorPointData;
	public FLensDistortionPointsCameraData CameraData;
	public uint PatternIndex;
}
