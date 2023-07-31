#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Box shape used for collision</summary>
[CppInclude("PhysicsEngine/BoxElem.h")]
public partial struct FKBoxElem {
	public FMatrix TM_DEPRECATED;
	public FQuat Orientation_DEPRECATED;
	public FVector Center;
	public FRotator Rotation;
	public float X;
	public float Y;
	public float Z;
}
