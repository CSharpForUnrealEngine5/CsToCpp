namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimEnums.h")]
[CppEnumInNamespace]
public enum ERootMotionMode {
	NoRootMotionExtraction=0,
	IgnoreRootMotion=1,
	RootMotionFromEverything=2,
	RootMotionFromMontagesOnly=3,
}
