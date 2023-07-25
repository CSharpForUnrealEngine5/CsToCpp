#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigSplineUnits.h")]
///<summary>* Retrieves the transform from a given Spline and U value based on the given Up Vector and Roll</summary>
public partial struct FRigUnit_TransformFromControlRigSpline {
// RigUnit_TransformFromControlRigSpline
	public FControlRigSpline Spline;
	public FVector UpVector;
	public float Roll;
	public float U;
	public FTransform Transform;
}
