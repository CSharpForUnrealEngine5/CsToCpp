#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleInputRateConfig {
	public float RiseRate;
	public float FallRate;
	public EInputFunctionType InputCurveFunction;
	public FRuntimeFloatCurve UserCurve;
}
