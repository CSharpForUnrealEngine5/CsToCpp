namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Focal length associated to a zoom value</summary>
[CppInclude("Tables/FocalLengthTable.h")]
public partial struct FFocalLengthZoomPoint {
	public float Zoom;
	public FFocalLengthInfo FocalLengthInfo;
	public bool bIsCalibrationPoint;
}
