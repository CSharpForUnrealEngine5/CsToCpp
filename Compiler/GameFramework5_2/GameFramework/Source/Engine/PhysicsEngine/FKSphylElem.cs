#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/SphylElem.h")]
///<summary>Capsule shape used for collision. Z axis is capsule axis.</summary>
public partial struct FKSphylElem {
// KSphylElem
	public FMatrix TM_DEPRECATED;
	public FQuat Orientation_DEPRECATED;
	public FVector Center;
	public FRotator Rotation;
	public float Radius;
	public float Length;
}
