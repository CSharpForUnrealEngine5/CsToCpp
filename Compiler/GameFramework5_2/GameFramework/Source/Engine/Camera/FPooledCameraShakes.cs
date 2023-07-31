#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>List of reusable camera shake instances that we store in a recycling pool.</summary>
[CppInclude("Camera/CameraModifier_CameraShake.h")]
public partial struct FPooledCameraShakes {
	public TArray<UCameraShakeBase> PooledShakes;
}
