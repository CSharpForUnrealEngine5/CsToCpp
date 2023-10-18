namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CaptureCardMediaSource.h")]
///<summary>List of texture source encodings that can be converted to linear. (Integer values match the ETextureSourceEncoding values in TextureDefines.h</summary>
public enum EMediaIOCoreSourceEncoding {
	Linear=1,
	sRGB=2,
	ST2084=3,
	SLog3=12,
	MAX=13,
}
