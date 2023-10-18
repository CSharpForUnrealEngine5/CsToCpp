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
	///<summary>Allow to specify custom tangents for each point, as an attribute. Can&#39;t be set if the spline is linear.</summary>
	public bool bApplyCustomTangents;
	///<summary>ArriveTangentAttribute</summary>
	public FName ArriveTangentAttribute;
	///<summary>LeaveTangentAttribute</summary>
	public FName LeaveTangentAttribute;
	///<summary>TargetActor</summary>
	public TSoftObjectPtr<AActor> TargetActor;
	///<summary>AttachOptions</summary>
	public EPCGAttachOptions AttachOptions;
}
