#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/TriangleSetComponent.h")]
///<summary>A component for rendering an arbitrary assortment of triangles. Suitable, for instance, for rendering highlighted faces.</summary>
public partial class UTriangleSetComponent : UMeshComponent {
// TriangleSetComponent
	public FBoxSphereBounds Bounds;
	public bool bBoundsDirty;
}
