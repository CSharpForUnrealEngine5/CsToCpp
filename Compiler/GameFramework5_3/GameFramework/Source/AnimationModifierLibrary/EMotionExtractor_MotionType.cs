namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionExtractorTypes.h")]
///<summary>Type of motion to extract</summary>
public enum EMotionExtractor_MotionType {
	None=0,
	Translation=-1,
	Rotation=-1,
	Scale=-1,
	TranslationSpeed=-1,
	RotationSpeed=-1,
}
