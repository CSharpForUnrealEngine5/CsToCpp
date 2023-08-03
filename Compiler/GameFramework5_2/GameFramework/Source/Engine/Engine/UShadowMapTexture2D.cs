#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ShadowMapTexture2D.h")]
public partial class UShadowMapTexture2D : UTexture2D {
	public static UClass StaticClass() {return default;}
	///<summary>Bit-field with shadowmap flags.</summary>
	public EShadowMapFlags ShadowmapFlags;
}
