#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
[CppEnumInNamespace]
public enum ECurveBlendOption {
	Override=0,
	DoNotOverride=1,
	NormalizeByWeight=2,
	BlendByWeight=3,
	UseBasePose=4,
	UseMaxValue=5,
	UseMinValue=6,
}
