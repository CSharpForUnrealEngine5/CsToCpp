#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Creates a Spline curve from an array of positions</summary>
[CppInclude("ControlRigSplineUnits.h")]
public partial struct FRigUnit_ControlRigSplineFromPoints {
	public TArray<FVector> Points;
	public ESplineType SplineMode;
	public bool bClosed;
	public int SamplesPerSegment;
	public float Compression;
	public float Stretch;
	public FControlRigSpline Spline;
}
