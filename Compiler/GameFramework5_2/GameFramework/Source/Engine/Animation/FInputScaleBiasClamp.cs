namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Input modifier with remapping, scaling, biasing, clamping, and interpolation</summary>
[CppInclude("Animation/InputScaleBias.h")]
public partial struct FInputScaleBiasClamp {
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
