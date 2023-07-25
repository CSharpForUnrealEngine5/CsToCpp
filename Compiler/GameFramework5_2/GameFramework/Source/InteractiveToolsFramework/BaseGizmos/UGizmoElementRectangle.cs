#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementRectangle.h")]
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoElementRectangle : UGizmoElementLineBase {
// GizmoElementRectangle
	public FVector Center;
	public float Width;
	public float Height;
	public FVector UpDirection;
	public FVector SideDirection;
	public bool bDrawMesh;
	public bool bDrawLine;
	public bool bHitMesh;
	public bool bHitLine;
}
