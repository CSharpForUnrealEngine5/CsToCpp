namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementCircle.h")]
public partial class UGizmoElementCircle : UGizmoElementCircleBase {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to render solid circle.</summary>
	public bool bDrawMesh;
	///<summary>Whether to render line circle.</summary>
	public bool bDrawLine;
	///<summary>Whether to perform hit test on mesh.</summary>
	public bool bHitMesh;
	///<summary>Whether to perform hit test on line.</summary>
	public bool bHitLine;
}
