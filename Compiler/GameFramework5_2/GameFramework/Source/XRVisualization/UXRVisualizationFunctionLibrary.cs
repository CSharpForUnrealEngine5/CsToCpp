namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRVisualizationFunctionLibrary.h")]
public partial class UXRVisualizationFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Renders HMD Visualization on a system that might not have that HMD as native</summary>
	public static void RenderHMD(FXRHMDData XRHMDData) {}
	///<summary>Renders Motion Controller Visualization on a system that might not have that HMD as native</summary>
	public static void RenderMotionController(FXRMotionControllerData XRControllerData,bool bRight) {}
	///<summary>LoadHelper</summary>
	public UXRVisualizationLoadHelper LoadHelper;
}
