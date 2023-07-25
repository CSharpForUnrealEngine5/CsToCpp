#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineComponent.h")]
///<summary>Permitted spline point types for SplineComponent.</summary>
[CppEnumInNamespace]
public enum ESplinePointType {
	Linear=0,
	Curve=1,
	Constant=2,
	CurveClamped=3,
	CurveCustomTangent=4,
}
