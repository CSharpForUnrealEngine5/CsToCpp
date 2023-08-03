#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selection state data that will be captured by scoped transactions.</summary>
[CppInclude("WaterSplineComponentVisualizer.h")]
public partial class UWaterSplineComponentVisualizerSelectionState : USplineComponentVisualizerSelectionState {
	public static UClass StaticClass() {return default;}
	///<summary>Whether water velocity handle is selected</summary>
	public bool bWaterVelocityIsSelected;
	///<summary>Whether water depth handle is selected</summary>
	public bool bDepthIsSelected;
	///<summary>Whether water river width handle is selected</summary>
	public bool bRiverWidthIsSelected;
	///<summary>When river width is selected, true if the handle on the positive right vector side was selected</summary>
	public bool bRiverWidthSelectedPosHandle;
}
