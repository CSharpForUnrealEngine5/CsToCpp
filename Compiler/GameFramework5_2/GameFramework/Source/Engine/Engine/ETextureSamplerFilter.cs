#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureDefines.h")]
///<summary>Must match enum ESamplerFilter in RHIDefinitions.h</summary>
public enum ETextureSamplerFilter {
	Point=0,
	Bilinear=1,
	Trilinear=2,
	AnisotropicPoint=3,
	AnisotropicLinear=4,
}
