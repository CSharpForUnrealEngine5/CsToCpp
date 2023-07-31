#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/InputScaleBias.h")]
public partial struct FInputScaleBiasClampConstants {
	public bool bMapRange;
	public bool bClampResult;
	public bool bInterpResult;
	public FInputRange InRange;
	public FInputRange OutRange;
	public float Scale;
	public float Bias;
	public float ClampMin;
	public float ClampMax;
	public float InterpSpeedIncreasing;
	public float InterpSpeedDecreasing;
}
