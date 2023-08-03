#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>note : UTexture2DDynamic derives directly from UTexture not from UTexture2D</summary>
[CppInclude("Engine/Texture2DDynamic.h")]
public partial class UTexture2DDynamic : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>The format of the texture.</summary>
	public EPixelFormat Format;
}
