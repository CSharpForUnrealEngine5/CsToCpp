#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VT/VirtualTexture.h")]
///<summary>Virtual Texture with locally configurable build settings.</summary>
public partial class UVirtualTexture2D : UTexture2D {
// VirtualTexture2D
	public FVirtualTextureBuildSettings Settings;
	public bool bContinuousUpdate;
	public bool bSinglePhysicalSpace;
}
