namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for a UVirtualTexture2D that can be built from a FVirtualTextureBuildDesc description.</summary>
[CppInclude("VT/VirtualTextureBuilder.h")]
public partial class UVirtualTextureBuilder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The UTexture object.</summary>
	public UVirtualTexture2D Texture;
	///<summary>The UTexture object for Mobile rendering.</summary>
	public UVirtualTexture2D TextureMobile;
	///<summary>Some client defined hash of that defines how the Texture was built.</summary>
	public ulong BuildHash;
	///<summary>Whether to use a separate texture for Mobile rendering. A separate texure will be built using mobile preview editor mode</summary>
	public bool bSeparateTextureForMobile;
}
