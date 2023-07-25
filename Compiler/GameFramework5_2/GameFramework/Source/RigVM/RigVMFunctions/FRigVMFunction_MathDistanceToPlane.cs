#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Find the point on the plane that is closest to the given point and the distance between them.</summary>
public partial struct FRigVMFunction_MathDistanceToPlane {
// RigVMFunction_MathDistanceToPlane
	public FVector Point;
	public FVector PlanePoint;
	public FVector PlaneNormal;
	public FVector ClosestPointOnPlane;
	public float SignedDistance;
}
