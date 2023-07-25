#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Intersects a plane with a vector given a start and direction</summary>
public partial struct FRigVMFunction_MathIntersectPlane {
// RigVMFunction_MathIntersectPlane
	public FVector Start;
	public FVector Direction;
	public FVector PlanePoint;
	public FVector PlaneNormal;
	public FVector Result;
	public float Distance;
}
