#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFile.h")]
///<summary>Data categories manipulated in the camera calibration tools</summary>
public enum ELensDataCategory {
	Focus=0,
	Iris=1,
	Zoom=2,
	Distortion=3,
	ImageCenter=4,
	STMap=5,
	NodalOffset=6,
}
