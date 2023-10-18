namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Find the point on the plane that is closest to the given point and the distance between them.</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathDistanceToPlane {
	public FVector Point;
	public FVector PlanePoint;
	public FVector PlaneNormal;
	public FVector ClosestPointOnPlane;
	public float SignedDistance;
}
