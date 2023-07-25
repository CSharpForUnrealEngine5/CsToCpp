#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/RichCurve.h")]
///<summary>If using RCIM_Cubic, this enum describes how the tangents should be controlled in editor.</summary>
public enum ERichCurveTangentMode {
	RCTM_Auto=0,
	RCTM_User=1,
	RCTM_Break=2,
	RCTM_None=3,
}
