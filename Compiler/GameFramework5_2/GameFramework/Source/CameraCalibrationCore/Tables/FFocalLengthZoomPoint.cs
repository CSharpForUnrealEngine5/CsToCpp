#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tables/FocalLengthTable.h")]
///<summary>Focal length associated to a zoom value</summary>
public partial struct FFocalLengthZoomPoint {
// FocalLengthZoomPoint
	public float Zoom;
	public FFocalLengthInfo FocalLengthInfo;
	public bool bIsCalibrationPoint;
}
