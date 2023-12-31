namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PCG node that creates a spline presentation from the input points data, with optional tangents</summary>
[CppInclude("Elements/PCGCreateSpline.h")]
public partial class UPCGCreateSplineSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Mode</summary>
	public EPCGCreateSplineMode Mode;
	///<summary>bClosedLoop</summary>
	public bool bClosedLoop;
	///<summary>Controls whether the segment between control points is a curve (when false) or a straight line (when true).</summary>
	public bool bLinear;
	///<summary>bApplyCustomTangents</summary>
	public bool bApplyCustomTangents;
	///<summary>ArriveTangentAttribute</summary>
	public FName ArriveTangentAttribute;
	///<summary>LeaveTangentAttribute</summary>
	public FName LeaveTangentAttribute;
}
