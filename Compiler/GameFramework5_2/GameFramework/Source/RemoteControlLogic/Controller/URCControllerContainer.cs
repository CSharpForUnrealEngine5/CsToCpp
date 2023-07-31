#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controller Container which holds all virtual controller properties</summary>
[CppInclude("Controller/RCControllerContainer.h")]
public partial class URCControllerContainer : URCVirtualPropertyContainerBase {
	///<summary>Slider exponent for Vector Controller sliders. Determines how fast the value change travels while scrubbing the X/Y/Z sliders in UI</summary>
	public float VectorSliderDelta;
	///<summary>Linear Delta Sensitivity for Vector Controller sliders. Multiplied inversely with mouse movement to determine actual slider change</summary>
	public float VectorLinearDeltaSensitivity;
	///<summary>Slider exponent for Rotator Controller sliders.</summary>
	public float RotatorSliderDelta;
	///<summary>Linear Delta Sensitivity for Rotator Controller sliders</summary>
	public float RotatorLinearDeltaSensitivity;
	///<summary>Controller Container could holds the set of shared Action containers which is holds some action but independent from the behaviour</summary>
	public TSet<URCActionContainer> SharedActionContainers;
}
