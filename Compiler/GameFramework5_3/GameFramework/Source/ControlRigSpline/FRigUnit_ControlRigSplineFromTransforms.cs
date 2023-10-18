namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Creates a Spline curve from an array of positions</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_ControlRigSplineFromTransforms {
	public TArray<FTransform> Transforms;
	public ESplineType SplineMode;
	public bool bClosed;
	public int SamplesPerSegment;
	public float Compression;
	public float Stretch;
	public FControlRigSpline Spline;
}
