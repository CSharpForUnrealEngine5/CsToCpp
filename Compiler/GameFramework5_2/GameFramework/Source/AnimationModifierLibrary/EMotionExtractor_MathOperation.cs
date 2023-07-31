#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorTypes.h")]
///<summary>Math operations that can be applied to the extracted value before add it to the curve</summary>
public enum EMotionExtractor_MathOperation {
	None=0,
	Addition=1,
	Subtraction=2,
	Division=3,
	Multiplication=4,
}
