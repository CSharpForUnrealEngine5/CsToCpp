#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Determines how the refraction offset should be computed for the material.</summary>
public enum ERefractionMode {
	RM_IndexOfRefraction=0,
	RM_PixelNormalOffset=1,
	RM_2DOffset=2,
	RM_None=3,
}
