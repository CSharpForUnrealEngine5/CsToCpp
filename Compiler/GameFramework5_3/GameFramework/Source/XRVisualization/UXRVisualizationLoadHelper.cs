namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRVisualizationFunctionLibrary.h")]
public partial class UXRVisualizationLoadHelper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GenericHMD</summary>
	public UStaticMesh GenericHMD;
	///<summary>OculusControllerMesh</summary>
	public UStaticMesh OculusControllerMesh;
	///<summary>ViveControllerMesh</summary>
	public UStaticMesh ViveControllerMesh;
	///<summary>STEMControllerMesh</summary>
	public UStaticMesh STEMControllerMesh;
}
