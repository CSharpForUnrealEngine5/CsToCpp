#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonAnimationTypes.h")]
///<summary>An easing type defining how to ease float values.</summary>
public enum EEasingFuncType {
	Linear=0,
	Sinusoidal=1,
	Cubic=2,
	QuadraticInOut=3,
	CubicInOut=4,
	HermiteCubic=5,
	QuarticInOut=6,
	QuinticInOut=7,
	CircularIn=8,
	CircularOut=9,
	CircularInOut=10,
	ExpIn=11,
	ExpOut=12,
	ExpInOut=13,
	CustomCurve=14,
}
