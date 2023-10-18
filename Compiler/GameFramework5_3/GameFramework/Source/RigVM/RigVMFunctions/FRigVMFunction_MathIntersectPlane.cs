namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Intersects a plane with a vector given a start and direction</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathIntersectPlane {
	public FVector Start;
	public FVector Direction;
	public FVector PlanePoint;
	public FVector PlaneNormal;
	public FVector Result;
	public float Distance;
}
