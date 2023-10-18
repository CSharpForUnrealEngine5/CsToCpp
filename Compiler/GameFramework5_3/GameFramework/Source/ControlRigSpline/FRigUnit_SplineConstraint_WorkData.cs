namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_SplineConstraint_WorkData {
	public float ChainLength;
	public TArray<FTransform> ItemTransforms;
	public TArray<float> ItemSegments;
	public TArray<FCachedRigElement> CachedItems;
}
