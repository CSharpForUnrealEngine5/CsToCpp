#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationScene : UDisplayClusterConfigurationData_Base {
	///<summary>Xforms</summary>
	public TMap<string,UDisplayClusterConfigurationSceneComponentXform> Xforms;
	///<summary>Screens</summary>
	public TMap<string,UDisplayClusterConfigurationSceneComponentScreen> Screens;
	///<summary>Cameras</summary>
	public TMap<string,UDisplayClusterConfigurationSceneComponentCamera> Cameras;
}
