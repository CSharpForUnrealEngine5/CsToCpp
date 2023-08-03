#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading general scene data.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceScene.h")]
public partial class UOptimusSceneDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SceneComponent</summary>
	public USceneComponent SceneComponent;
}
