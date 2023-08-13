namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint API interface implementation</summary>
[CppInclude("Blueprints/DisplayClusterProjectionBlueprintAPIImpl.h")]
public partial class UDisplayClusterProjectionBlueprintAPIImpl : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sets active camera component for camera policy</summary>
	public virtual void CameraPolicySetCamera(string ViewportId,UCameraComponent NewCamera,float FOVMultiplier/*=1.0f*/) {}
}
