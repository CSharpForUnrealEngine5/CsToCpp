#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementCircleBase.h")]
///<summary>Abstract base object for circle, torus and arc.</summary>
public partial class UGizmoElementCircleBase : UGizmoElementLineBase {
// GizmoElementCircleBase
	public FVector Center;
	public FVector Axis0;
	public FVector Axis1;
	public double Radius;
	public int NumSegments;
	public EGizmoElementPartialType PartialType;
	public double PartialStartAngle;
	public double PartialEndAngle;
	public double PartialViewDependentMaxCosTol;
}
