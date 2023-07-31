#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraShakeBase.h")]
///<summary>Flags that camera shakes can return to change base-class behaviour.</summary>
public enum ECameraShakeUpdateResultFlags {
	ApplyAsAbsolute=-1,
	SkipAutoScale=-1,
	SkipAutoPlaySpace=-1,
	Default=0,
}
