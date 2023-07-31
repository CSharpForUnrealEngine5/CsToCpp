#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dynamic checkerboad actor</summary>
[CppInclude("CameraCalibrationCheckerboard.h")]
public partial class ACameraCalibrationCheckerboard : AActor {
	///<summary>Rebuilds the instanced components that make up this checkerboard</summary>
	public  void Rebuild() {}
	///<summary>Root component, gives the Actor a transform</summary>
	public USceneComponent Root;
	///<summary>TopLeft calibration point</summary>
	public UCalibrationPointComponent TopLeft;
	///<summary>TopRight calibration point</summary>
	public UCalibrationPointComponent TopRight;
	///<summary>BottomLeft calibration point</summary>
	public UCalibrationPointComponent BottomLeft;
	///<summary>BottomRight calibration point</summary>
	public UCalibrationPointComponent BottomRight;
	///<summary>Center calibration point</summary>
	public UCalibrationPointComponent Center;
	///<summary>Number of rows. It is one of the parameters cv::findChessboardCorners needs</summary>
	public int NumCornerRows;
	///<summary>Number of columns. It is one of the parameters cv::findChessboardCorners needs</summary>
	public int NumCornerCols;
	///<summary>Length of the side of each square. It is used when building the object points that cv::calibrateCamera needs</summary>
	public float SquareSideLength;
	///<summary>Thickness of checkerboard. Not used for calibration purposes.</summary>
	public float Thickness;
	///<summary>The static mesh that we are going to use for all the cubes</summary>
	public UStaticMesh CubeMesh;
	///<summary>The material that we are going to use for all the odd cubes</summary>
	public UMaterialInterface OddCubeMaterial;
	///<summary>The material that we are going to use for all the even cubes</summary>
	public UMaterialInterface EvenCubeMaterial;
}
