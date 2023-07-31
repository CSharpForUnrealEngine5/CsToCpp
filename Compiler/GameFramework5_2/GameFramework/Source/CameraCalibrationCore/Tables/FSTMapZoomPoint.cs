#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>STMap data associated to a zoom input value</summary>
[CppInclude("Tables/STMapTable.h")]
public partial struct FSTMapZoomPoint {
	public float Zoom;
	public FSTMapInfo STMapInfo;
	public FDerivedDistortionData DerivedDistortionData;
	public bool bIsCalibrationPoint;
}
