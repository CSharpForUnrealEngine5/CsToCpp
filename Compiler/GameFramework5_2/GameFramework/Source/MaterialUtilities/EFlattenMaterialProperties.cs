#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialUtilities.h")]
///<summary>TODO replace this with rendering property enum when extending the system</summary>
public enum EFlattenMaterialProperties {
	Diffuse=0,
	Metallic=1,
	Specular=2,
	Roughness=3,
	Anisotropy=4,
	Normal=5,
	Tangent=6,
	Opacity=7,
	Emissive=8,
	SubSurface=9,
	OpacityMask=10,
	AmbientOcclusion=16,
	NumFlattenMaterialProperties=17,
}
