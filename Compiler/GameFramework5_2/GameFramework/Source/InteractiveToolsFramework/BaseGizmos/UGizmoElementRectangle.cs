#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementRectangle.h")]
public partial class UGizmoElementRectangle : UGizmoElementLineBase {
	public static UClass StaticClass() {return default;}
	///<summary>Location of rectangle center</summary>
	public FVector Center;
	///<summary>Width</summary>
	public float Width;
	///<summary>Height</summary>
	public float Height;
	///<summary>Up direction</summary>
	public FVector UpDirection;
	///<summary>Side direction</summary>
	public FVector SideDirection;
	///<summary>bDrawMesh</summary>
	public bool bDrawMesh;
	///<summary>bDrawLine</summary>
	public bool bDrawLine;
	///<summary>bHitMesh</summary>
	public bool bHitMesh;
	///<summary>bHitLine</summary>
	public bool bHitLine;
}
