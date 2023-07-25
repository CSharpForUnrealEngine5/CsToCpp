#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGCreateSpline.h")]
///<summary>PCG node that creates a spline presentation from the input points data, with optional tangents</summary>
public partial class UPCGCreateSplineSettings : UPCGSettings {
// PCGCreateSplineSettings
	public EPCGCreateSplineMode Mode;
	public bool bClosedLoop;
	public bool bLinear;
	public bool bApplyCustomTangents;
	public string ArriveTangentAttribute;
	public string LeaveTangentAttribute;
}
