namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureDefines.h")]
///<summary>List of (advanced) texture source encodings, matching the list in ColorManagementDefines.h.</summary>
public enum ETextureSourceEncoding {
	TSE_None=0,
	TSE_Linear=1,
	TSE_sRGB=2,
	TSE_ST2084=3,
	TSE_Gamma22=4,
	TSE_BT1886=5,
	TSE_Gamma26=6,
	TSE_Cineon=7,
	TSE_REDLog=8,
	TSE_REDLog3G10=9,
	TSE_SLog1=10,
	TSE_SLog2=11,
	TSE_SLog3=12,
	TSE_AlexaV3LogC=13,
	TSE_CanonLog=14,
	TSE_ProTune=15,
	TSE_VLog=16,
	TSE_MAX=17,
}
