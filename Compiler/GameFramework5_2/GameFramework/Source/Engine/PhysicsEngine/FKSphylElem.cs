namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Capsule shape used for collision. Z axis is capsule axis.</summary>
[CppInclude("PhysicsEngine/SphylElem.h")]
public partial struct FKSphylElem {
	public FMatrix TM_DEPRECATED;
	public FQuat Orientation_DEPRECATED;
	public FVector Center;
	public FRotator Rotation;
	public float Radius;
	public float Length;
}
