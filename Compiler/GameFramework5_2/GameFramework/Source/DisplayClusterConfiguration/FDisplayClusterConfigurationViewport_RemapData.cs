#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remapping configuration for a single remapped region, which can be any subregion of a viewport, and can be remapped to any</summary>
[CppInclude("DisplayClusterConfigurationTypes_ViewportRemap.h")]
public partial struct FDisplayClusterConfigurationViewport_RemapData {
	public FDisplayClusterConfigurationRectangle ViewportRegion;
	public FDisplayClusterConfigurationRectangle OutputRegion;
	public float Angle;
	public bool bFlipH;
	public bool bFlipV;
}
