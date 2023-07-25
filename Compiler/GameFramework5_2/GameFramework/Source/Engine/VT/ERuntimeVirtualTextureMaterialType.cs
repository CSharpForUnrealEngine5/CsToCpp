#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VT/RuntimeVirtualTextureEnum.h")]
///<summary>Enumeration of virtual texture stack layouts to support.</summary>
public enum ERuntimeVirtualTextureMaterialType {
	BaseColor=0,
	BaseColor_Normal_DEPRECATED=1,
	BaseColor_Normal_Roughness=2,
	BaseColor_Normal_Specular=3,
	BaseColor_Normal_Specular_YCoCg=4,
	BaseColor_Normal_Specular_Mask_YCoCg=5,
	WorldHeight=6,
	Count=7,
}
