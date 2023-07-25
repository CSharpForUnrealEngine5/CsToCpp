#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationScene : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationScene
	public TMap<string,UDisplayClusterConfigurationSceneComponentXform> Xforms;
	public TMap<string,UDisplayClusterConfigurationSceneComponentScreen> Screens;
	public TMap<string,UDisplayClusterConfigurationSceneComponentCamera> Cameras;
}
