#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterSplineComponent.h")]
public partial class UWaterSplineComponent : USplineComponent {
	///<summary>Defaults which are used to propagate values to spline points on instances of this in the world</summary>
	public FWaterSplineCurveDefaults WaterSplineDefaults;
	///<summary>This stores the last defaults propagated to spline points on an instance of this component</summary>
	public FWaterSplineCurveDefaults PreviousWaterSplineDefaults;
	///<summary>* Call to update water spline</summary>
	public  void K2_SynchronizeAndBroadcastDataChange() {}
}
