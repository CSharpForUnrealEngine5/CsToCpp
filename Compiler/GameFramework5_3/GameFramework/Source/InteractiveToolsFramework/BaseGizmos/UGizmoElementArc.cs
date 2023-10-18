namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementArc.h")]
public partial class UGizmoElementArc : UGizmoElementCircleBase {
	public static UClass StaticClass() {return default;}
	///<summary>Arc inner radius.</summary>
	public double InnerRadius;
}
