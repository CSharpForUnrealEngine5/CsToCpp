#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMathLibrary.h")]
///<summary>Different methods for interpolating rotation between transforms</summary>
[CppEnumInNamespace]
public enum ELerpInterpolationMode {
	QuatInterp=0,
	EulerInterp=1,
	DualQuatInterp=2,
}
