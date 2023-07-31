#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/PlayerCameraManager.h")]
///<summary>Options that define how to blend when changing view targets.</summary>
public enum EViewTargetBlendFunction {
	VTBlend_Linear=0,
	VTBlend_Cubic=1,
	VTBlend_EaseIn=2,
	VTBlend_EaseOut=3,
	VTBlend_EaseInOut=4,
	VTBlend_PreBlended=5,
	VTBlend_MAX=6,
}
