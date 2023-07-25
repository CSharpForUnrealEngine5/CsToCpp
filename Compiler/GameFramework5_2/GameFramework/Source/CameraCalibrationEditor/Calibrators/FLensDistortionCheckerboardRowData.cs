#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Calibrators/CameraLensDistortionAlgoCheckerboard.h")]
///<summary>Holds information of the calibration row</summary>
public partial struct FLensDistortionCheckerboardRowData {
// LensDistortionCheckerboardRowData
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
