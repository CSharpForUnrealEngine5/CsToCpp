#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes_OutputRemap.h")]
///<summary>Screen space remapping of the final backbuffer output. Applied at the whole window</summary>
public partial struct FDisplayClusterConfigurationFramePostProcess_OutputRemap {
// DisplayClusterConfigurationFramePostProcess_OutputRemap
	public bool bEnable;
	public EDisplayClusterConfigurationFramePostProcess_OutputRemapSource DataSource;
	public UStaticMesh StaticMesh;
	public string MeshComponentName;
	public string ExternalFile;
}
