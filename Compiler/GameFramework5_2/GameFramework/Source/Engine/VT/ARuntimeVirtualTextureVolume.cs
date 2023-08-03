#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor used to place a URuntimeVirtualTexture in the world.</summary>
[CppInclude("VT/RuntimeVirtualTextureVolume.h")]
public partial class ARuntimeVirtualTextureVolume : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Component that owns the runtime virtual texture.</summary>
	public URuntimeVirtualTextureComponent VirtualTextureComponent;
	///<summary>Box for visualizing virtual texture extents.</summary>
	public UBoxComponent Box;
}
