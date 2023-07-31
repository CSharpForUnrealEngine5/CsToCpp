#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component for rendering an arbitrary assortment of triangles. Suitable, for instance, for rendering highlighted faces.</summary>
[CppInclude("Drawing/TriangleSetComponent.h")]
public partial class UTriangleSetComponent : UMeshComponent {
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
}
