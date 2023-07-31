#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Retrieves the transform from a given Spline and U value based on the given Up Vector and Roll</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_TransformFromControlRigSpline {
	public FControlRigSpline Spline;
	public FVector UpVector;
	public float Roll;
	public float U;
	public FTransform Transform;
}
