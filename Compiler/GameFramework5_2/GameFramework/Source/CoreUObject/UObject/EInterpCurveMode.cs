#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes shape of an interpolation curve (mirrored from InterpCurvePoint.h).</summary>
public enum EInterpCurveMode {
	CIM_Linear=0,
	CIM_CurveAuto=1,
	CIM_Constant=2,
	CIM_CurveUser=3,
	CIM_CurveBreak=4,
	CIM_CurveAutoClamped=5,
}
