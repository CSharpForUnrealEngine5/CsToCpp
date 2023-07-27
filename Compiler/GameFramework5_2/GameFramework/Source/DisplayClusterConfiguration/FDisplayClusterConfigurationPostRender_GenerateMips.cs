#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_PostRender.h")]
public partial struct FDisplayClusterConfigurationPostRender_GenerateMips {
// DisplayClusterConfigurationPostRender_GenerateMips
	public bool bAutoGenerateMips;
	public TextureFilter MipsSamplerFilter;
	public TextureAddress MipsAddressU;
	public TextureAddress MipsAddressV;
	public bool bEnabledMaxNumMips;
	public int MaxNumMips;
}
