#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tables/STMapTable.h")]
///<summary>STMap data associated to a zoom input value</summary>
public partial struct FSTMapZoomPoint {
// STMapZoomPoint
	public float Zoom;
	public FSTMapInfo STMapInfo;
	public FDerivedDistortionData DerivedDistortionData;
	public bool bIsCalibrationPoint;
}
