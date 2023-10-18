namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementCone.h")]
public partial class UGizmoElementCone : UGizmoElementBase {
	public static UClass StaticClass() {return default;}
	///<summary>Cone tip location.</summary>
	public FVector Origin;
	///<summary>Cone axis direction pointing from tip toward base of cone.</summary>
	public FVector Direction;
	///<summary>Cone height.</summary>
	public float Height;
	///<summary>Cone radius.</summary>
	public float Radius;
	///<summary>Number of sides for tessellating cone.</summary>
	public int NumSides;
}
