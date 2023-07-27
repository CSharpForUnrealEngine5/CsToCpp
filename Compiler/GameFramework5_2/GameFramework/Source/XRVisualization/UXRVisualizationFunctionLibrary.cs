#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRVisualizationFunctionLibrary.h")]
public partial class UXRVisualizationFunctionLibrary : UBlueprintFunctionLibrary {
// XRVisualizationFunctionLibrary
	public static void RenderHMD(FXRHMDData XRHMDData) {}
	public static void RenderMotionController(FXRMotionControllerData XRControllerData,bool bRight) {}
	public UXRVisualizationLoadHelper LoadHelper;
}
