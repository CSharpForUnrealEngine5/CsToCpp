#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureLightProfile.h")]
public partial class UTextureLightProfile : UTexture2D {
	public static UClass StaticClass() {return default;}
	///<summary>Light brightness in Candelas, imported from IES profile, &lt;= 0 if the profile is used for masking only. Use with InverseSquareFalloff.</summary>
	public float Brightness;
	///<summary>Multiplier to map texture value to result to integrate over the sphere to 1.0f</summary>
	public float TextureMultiplier;
}
