namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial struct FVehicleInputRateConfig {
	public float RiseRate;
	public float FallRate;
	public EInputFunctionType InputCurveFunction;
	public FRuntimeFloatCurve UserCurve;
}
