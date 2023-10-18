namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scene hierarchy</summary>
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationSceneComponent : UDisplayClusterConfigurationData_Base {
	public static UClass StaticClass() {return default;}
	///<summary>ParentId</summary>
	public string ParentId;
	///<summary>Location</summary>
	public FVector Location;
	///<summary>Rotation</summary>
	public FRotator Rotation;
}
