#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/IDisplayClusterProjectionBlueprintAPI.h")]
public partial class UDisplayClusterProjectionBlueprintAPI : UInterface {
	///<summary>Sets active camera component for camera policy</summary>
	public  void CameraPolicySetCamera(string ViewportId,UCameraComponent NewCamera,float FOVMultiplier/*=1.0f*/) {}
}
