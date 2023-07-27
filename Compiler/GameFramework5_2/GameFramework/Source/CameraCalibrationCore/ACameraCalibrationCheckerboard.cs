#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraCalibrationCheckerboard.h")]
///<summary>Dynamic checkerboad actor</summary>
public partial class ACameraCalibrationCheckerboard : AActor {
// CameraCalibrationCheckerboard
	public  void Rebuild() {}
	public USceneComponent Root;
	public UCalibrationPointComponent TopLeft;
	public UCalibrationPointComponent TopRight;
	public UCalibrationPointComponent BottomLeft;
	public UCalibrationPointComponent BottomRight;
	public UCalibrationPointComponent Center;
	public int NumCornerRows;
	public int NumCornerCols;
	public float SquareSideLength;
	public float Thickness;
	public UStaticMesh CubeMesh;
	public UMaterialInterface OddCubeMaterial;
	public UMaterialInterface EvenCubeMaterial;
}
