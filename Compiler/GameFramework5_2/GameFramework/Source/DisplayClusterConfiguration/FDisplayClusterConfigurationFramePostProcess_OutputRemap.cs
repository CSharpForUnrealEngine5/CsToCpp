#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Screen space remapping of the final backbuffer output. Applied at the whole window</summary>
[CppInclude("DisplayClusterConfigurationTypes_OutputRemap.h")]
public partial struct FDisplayClusterConfigurationFramePostProcess_OutputRemap {
	public bool bEnable;
	public EDisplayClusterConfigurationFramePostProcess_OutputRemapSource DataSource;
	public UStaticMesh StaticMesh;
	public string MeshComponentName;
	public string ExternalFile;
}
