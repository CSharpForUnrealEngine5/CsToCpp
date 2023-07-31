#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subset of the Spline Component API in a standalone struct</summary>
[CppInclude("Data/PCGSplineStruct.h")]
public partial struct FPCGSplineStruct {
	public FSplineCurves SplineCurves;
	public FTransform Transform;
	public FVector DefaultUpVector;
	public int ReparamStepsPerSegment;
	public bool bClosedLoop;
	public FBoxSphereBounds LocalBounds;
	public FBoxSphereBounds Bounds;
}
