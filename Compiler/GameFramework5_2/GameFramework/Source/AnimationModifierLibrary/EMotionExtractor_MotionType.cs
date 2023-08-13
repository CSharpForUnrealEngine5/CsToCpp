namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorTypes.h")]
///<summary>Type of motion to extract</summary>
public enum EMotionExtractor_MotionType {
	Translation=0,
	Rotation=1,
	Scale=2,
	TranslationSpeed=3,
	RotationSpeed=4,
}
