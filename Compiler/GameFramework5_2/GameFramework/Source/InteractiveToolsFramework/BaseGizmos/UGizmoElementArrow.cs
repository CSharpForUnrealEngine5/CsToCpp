#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementArrow.h")]
public partial class UGizmoElementArrow : UGizmoElementBase {
	///<summary>Arrow cylinder body</summary>
	public UGizmoElementCylinder CylinderElement;
	///<summary>Arrow cone head</summary>
	public UGizmoElementCone ConeElement;
	///<summary>Arrow box head</summary>
	public UGizmoElementBox BoxElement;
	///<summary>Location of center of arrow base circle.</summary>
	public FVector Base;
	///<summary>Direction of arrow axis</summary>
	public FVector Direction;
	///<summary>Side direction for box head</summary>
	public FVector SideDirection;
	///<summary>Arrow body length</summary>
	public float BodyLength;
	///<summary>Radius of arrow cylinder</summary>
	public float BodyRadius;
	///<summary>Length of head, cone or box</summary>
	public float HeadLength;
	///<summary>Radius of head cone</summary>
	public float HeadRadius;
	///<summary>Number of sides for tessellating cone and cylinder</summary>
	public int NumSides;
	///<summary>Head type</summary>
	public EGizmoElementArrowHeadType HeadType;
}
