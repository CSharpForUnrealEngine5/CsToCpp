#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information of the calibrator 3d point for a given sample of a 2d-3d correlation</summary>
[CppInclude("Calibrators/CameraNodalOffsetAlgoPoints.h")]
public partial struct FNodalOffsetPointsRowData {
	public int Index;
	public FVector2D Point2D;
	public FVector2D UndistortedPoint2D;
	public bool bUndistortedIsValid;
	public FNodalOffsetPointsCalibratorPointData CalibratorPointData;
	public FNodalOffsetPointsCameraData CameraData;
}
