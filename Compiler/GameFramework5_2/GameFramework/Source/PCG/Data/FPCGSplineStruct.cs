#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSplineStruct.h")]
///<summary>Subset of the Spline Component API in a standalone struct</summary>
public partial struct FPCGSplineStruct {
// PCGSplineStruct
	public FSplineCurves SplineCurves;
	public FTransform Transform;
	public FVector DefaultUpVector;
	public int ReparamStepsPerSegment;
	public bool bClosedLoop;
	public FBoxSphereBounds LocalBounds;
	public FBoxSphereBounds Bounds;
}
