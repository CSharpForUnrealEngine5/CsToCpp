#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigSplineUnits.h")]
///<summary>* Creates a Spline curve from an array of positions</summary>
public partial struct FRigUnit_ControlRigSplineFromPoints {
// RigUnit_ControlRigSplineFromPoints
	public TArray<FVector> Points;
	public ESplineType SplineMode;
	public bool bClosed;
	public int SamplesPerSegment;
	public float Compression;
	public float Stretch;
	public FControlRigSpline Spline;
}
