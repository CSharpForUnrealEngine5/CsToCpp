namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationScene : UDisplayClusterConfigurationData_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Xforms</summary>
	public TMap<string,UDisplayClusterConfigurationSceneComponentXform> Xforms;
	///<summary>Screens</summary>
	public TMap<string,UDisplayClusterConfigurationSceneComponentScreen> Screens;
	///<summary>Cameras</summary>
	public TMap<string,UDisplayClusterConfigurationSceneComponentCamera> Cameras;
}
