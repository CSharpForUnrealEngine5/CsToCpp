#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information of the calibration row</summary>
[CppInclude("Calibrators/CameraLensDistortionAlgoCheckerboard.h")]
public partial struct FLensDistortionCheckerboardRowData {
	public int Index;
	public TArray<FVector2D> Points2d;
	public TArray<FVector> Points3d;
	public string CalibratorName;
	public int NumCornerRows;
	public int NumCornerCols;
	public float SquareSideInCm;
	public int ImageWidth;
	public int ImageHeight;
	public FLensDistortionCheckerboardCameraData CameraData;
}
