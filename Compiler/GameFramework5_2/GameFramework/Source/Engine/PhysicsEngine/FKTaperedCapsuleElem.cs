#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Capsule shape used for collision. Z axis is capsule axis. Has a start and end radius that can differ.</summary>
[CppInclude("PhysicsEngine/TaperedCapsuleElem.h")]
public partial struct FKTaperedCapsuleElem {
	public FVector Center;
	public FRotator Rotation;
	public float Radius0;
	public float Radius1;
	public float Length;
}
