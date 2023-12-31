namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VT/VirtualTexturePoolConfig.h")]
public partial class UVirtualTexturePoolConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultSizeInMegabyte</summary>
	public int DefaultSizeInMegabyte;
	///<summary>Size in tiles of any pools not explicitly specified in the config</summary>
	public TArray<FVirtualTextureSpacePoolConfig> Pools;
}
