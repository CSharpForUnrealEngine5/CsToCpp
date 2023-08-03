#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for a UVirtualTexture2D that can be built from a FVirtualTextureBuildDesc description.</summary>
[CppInclude("VT/VirtualTextureBuilder.h")]
public partial class UVirtualTextureBuilder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The UTexture object.</summary>
	public UVirtualTexture2D Texture;
	///<summary>Some client defined hash of that defines how the Texture was built.</summary>
	public ulong BuildHash;
}
