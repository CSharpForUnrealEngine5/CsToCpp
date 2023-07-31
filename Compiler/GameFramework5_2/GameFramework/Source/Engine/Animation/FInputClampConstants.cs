#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Input modifier with clamping and interpolation</summary>
[CppInclude("Animation/InputScaleBias.h")]
public partial struct FInputClampConstants {
	public bool bClampResult;
	public bool bInterpResult;
	public float ClampMin;
	public float ClampMax;
	public float InterpSpeedIncreasing;
	public float InterpSpeedDecreasing;
}
