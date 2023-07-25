#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_ViewportRemap.h")]
///<summary>Configuration for all remapping to apply to a single viewport</summary>
public partial struct FDisplayClusterConfigurationViewport_Remap {
// DisplayClusterConfigurationViewport_Remap
	public bool bEnable;
	public FDisplayClusterConfigurationViewport_RemapData BaseRemap;
	public TArray<FDisplayClusterConfigurationViewport_RemapData> RemapRegions;
}
