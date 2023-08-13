namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base object for circle, torus and arc.</summary>
[CppInclude("BaseGizmos/GizmoElementCircleBase.h")]
public partial class UGizmoElementCircleBase : UGizmoElementLineBase {
	public static UClass StaticClass() {return default;}
	///<summary>CircleBase center.</summary>
	public FVector Center;
	///<summary>Axis0 of plane in which circle lies, must perpendicular to normal.</summary>
	public FVector Axis0;
	///<summary>Axis1 of plane in which circle lies, must perpendicular to Axis0.</summary>
	public FVector Axis1;
	///<summary>Radius of main circle, some derived elements have inner radius (e.g. torus and arc)</summary>
	public double Radius;
	///<summary>Number of segments for rendering arc.</summary>
	public int NumSegments;
	///<summary>True when the arc is not full.</summary>
	public EGizmoElementPartialType PartialType;
	///<summary>Start angle to render for partial torus</summary>
	public double PartialStartAngle;
	///<summary>End angle to render for partial torus</summary>
	public double PartialEndAngle;
	///<summary>For PartialViewDependent, max cosine of angle between the normal and view direction</summary>
	public double PartialViewDependentMaxCosTol;
}
