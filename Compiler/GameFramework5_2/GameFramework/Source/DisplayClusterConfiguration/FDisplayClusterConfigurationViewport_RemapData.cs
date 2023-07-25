#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_ViewportRemap.h")]
///<summary>Remapping configuration for a single remapped region, which can be any subregion of a viewport, and can be remapped to any</summary>
public partial struct FDisplayClusterConfigurationViewport_RemapData {
// DisplayClusterConfigurationViewport_RemapData
	public FDisplayClusterConfigurationRectangle ViewportRegion;
	public FDisplayClusterConfigurationRectangle OutputRegion;
	public float Angle;
	public bool bFlipH;
	public bool bFlipV;
}
