#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_LookAt.h")]
///<summary>Various ways to interpolate TAlphaBlend.</summary>
[CppEnumInNamespace]
public enum EInterpolationBlend {
	Linear=0,
	Cubic=1,
	Sinusoidal=2,
	EaseInOutExponent2=3,
	EaseInOutExponent3=4,
	EaseInOutExponent4=5,
	EaseInOutExponent5=6,
	MAX=7,
}
