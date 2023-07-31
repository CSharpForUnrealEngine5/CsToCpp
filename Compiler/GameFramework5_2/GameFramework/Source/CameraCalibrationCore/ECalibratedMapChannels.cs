#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CalibratedMapFormat.h")]
///<summary>Specifies which two channels contain the calibrated map data (or None if there is no data)</summary>
public enum ECalibratedMapChannels {
	RG=0,
	BA=1,
	None=2,
	MAX=3,
}
