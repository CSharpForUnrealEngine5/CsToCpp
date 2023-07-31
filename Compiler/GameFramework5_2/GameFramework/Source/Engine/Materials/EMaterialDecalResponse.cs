#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/Material.h")]
///<summary>Defines how the material reacts on DBuffer decals, later we can expose more variants between None and Default.</summary>
public enum EMaterialDecalResponse {
	MDR_None=0,
	MDR_ColorNormalRoughness=1,
	MDR_Color=2,
	MDR_ColorNormal=3,
	MDR_ColorRoughness=4,
	MDR_Normal=5,
	MDR_NormalRoughness=6,
	MDR_Roughness=7,
	MDR_MAX=8,
}
