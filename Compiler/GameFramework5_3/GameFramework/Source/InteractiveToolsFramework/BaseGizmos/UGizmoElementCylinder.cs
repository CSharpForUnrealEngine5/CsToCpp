namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementCylinder.h")]
public partial class UGizmoElementCylinder : UGizmoElementBase {
	public static UClass StaticClass() {return default;}
	///<summary>Location of center of cylinder&#39;s base circle.</summary>
	public FVector Base;
	///<summary>Cylinder axis direction.</summary>
	public FVector Direction;
	///<summary>Cylinder height.</summary>
	public float Height;
	///<summary>Cylinder radius.</summary>
	public float Radius;
	///<summary>Number of sides for tessellating cylinder.</summary>
	public int NumSides;
}
