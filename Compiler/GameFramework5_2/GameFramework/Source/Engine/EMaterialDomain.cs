#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialDomain.h")]
///<summary>Defines the domain of a material.</summary>
public enum EMaterialDomain {
	MD_Surface=0,
	MD_DeferredDecal=1,
	MD_LightFunction=2,
	MD_Volume=3,
	MD_PostProcess=4,
	MD_UI=5,
	MD_RuntimeVirtualTexture=6,
	MD_MAX=7,
}
