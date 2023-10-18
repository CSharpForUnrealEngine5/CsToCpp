namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distortion parameters associated to a zoom value</summary>
[CppInclude("Tables/DistortionParametersTable.h")]
public partial struct FDistortionZoomPoint {
	public float Zoom;
	public FDistortionInfo DistortionInfo;
}
