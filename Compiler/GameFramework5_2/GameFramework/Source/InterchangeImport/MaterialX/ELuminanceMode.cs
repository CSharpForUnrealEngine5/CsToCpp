namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionLuminance.h")]
///<summary>A material expression that outputs a grayscale image containing the luminance of the incoming RGB color in all color channels;</summary>
public enum ELuminanceMode {
	ACEScg=0,
	Rec709=1,
	Rec2020=2,
	Rec2100=-1,
	Custom=-1,
}
