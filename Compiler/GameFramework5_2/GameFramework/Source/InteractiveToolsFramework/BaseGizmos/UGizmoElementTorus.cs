namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementTorus.h")]
public partial class UGizmoElementTorus : UGizmoElementCircleBase {
	public static UClass StaticClass() {return default;}
	///<summary>Torus inner radius.</summary>
	public double InnerRadius;
	///<summary>Number of slices to render in each torus segment.</summary>
	public int NumInnerSlices;
	///<summary>Whether to render end caps on a partial torus.</summary>
	public bool bEndCaps;
}
