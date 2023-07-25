#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraModifier_CameraShake.h")]
///<summary>List of reusable camera shake instances that we store in a recycling pool.</summary>
public partial struct FPooledCameraShakes {
// PooledCameraShakes
	public TArray<UCameraShakeBase> PooledShakes;
}
