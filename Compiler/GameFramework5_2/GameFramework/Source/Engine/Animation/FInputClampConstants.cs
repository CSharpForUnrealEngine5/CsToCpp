#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/InputScaleBias.h")]
///<summary>Input modifier with clamping and interpolation</summary>
public partial struct FInputClampConstants {
// InputClampConstants
	public bool bClampResult;
	public bool bInterpResult;
	public float ClampMin;
	public float ClampMax;
	public float InterpSpeedIncreasing;
	public float InterpSpeedDecreasing;
}
