#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration for all remapping to apply to a single viewport</summary>
[CppInclude("DisplayClusterConfigurationTypes_ViewportRemap.h")]
public partial struct FDisplayClusterConfigurationViewport_Remap {
	public bool bEnable;
	public FDisplayClusterConfigurationViewport_RemapData BaseRemap;
	public TArray<FDisplayClusterConfigurationViewport_RemapData> RemapRegions;
}
