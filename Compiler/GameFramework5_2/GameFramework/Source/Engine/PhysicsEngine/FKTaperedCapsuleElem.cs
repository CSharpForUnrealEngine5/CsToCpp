#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/TaperedCapsuleElem.h")]
///<summary>Capsule shape used for collision. Z axis is capsule axis. Has a start and end radius that can differ.</summary>
public partial struct FKTaperedCapsuleElem {
// KTaperedCapsuleElem
	public FVector Center;
	public FRotator Rotation;
	public float Radius0;
	public float Radius1;
	public float Length;
}
