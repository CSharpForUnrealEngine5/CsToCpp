#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Calibrators/CameraLensDistortionAlgoPoints.h")]
///<summary>Holds information of the calibrator 3d point for a given sample of a 2d-3d correlation</summary>
public partial struct FLensDistortionPointsRowData {
// LensDistortionPointsRowData
	public int Index;
	public FLensDistortionPointsCalibratorPointData CalibratorPointData;
	public FLensDistortionPointsCameraData CameraData;
	public uint PatternIndex;
}
