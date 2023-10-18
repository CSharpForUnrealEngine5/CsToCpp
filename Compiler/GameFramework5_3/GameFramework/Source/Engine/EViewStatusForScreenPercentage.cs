namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LegacyScreenPercentageDriver.h")]
///<summary>Status of view being rendered to select the corresponding screen percentage setting</summary>
public enum EViewStatusForScreenPercentage {
	NonRealtime=0,
	Desktop=1,
	Mobile=2,
	VR=3,
	PathTracer=4,
}
