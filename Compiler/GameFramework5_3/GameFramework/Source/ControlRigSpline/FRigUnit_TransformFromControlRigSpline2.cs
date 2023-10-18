namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Retrieves the transform from a given Spline and U value based on the given Up Vector and Roll</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_TransformFromControlRigSpline2 {
	public FControlRigSpline Spline;
	public float U;
	public FVector PrimaryAxis;
	public FVector SecondaryAxis;
	public FTransform Transform;
}
