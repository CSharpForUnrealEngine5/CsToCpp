namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/IDisplayClusterProjectionBlueprintAPI.h")]
public partial class UDisplayClusterProjectionBlueprintAPI : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Sets active camera component for camera policy</summary>
	public virtual void CameraPolicySetCamera(string ViewportId,UCameraComponent NewCamera,float FOVMultiplier/*=1.0f*/) {}
}
