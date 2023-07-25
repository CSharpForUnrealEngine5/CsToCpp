#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/PointSetComponent.h")]
///<summary>UPointSetComponent is a Component that draws a set of points, as small squares.</summary>
public partial class UPointSetComponent : UMeshComponent {
// PointSetComponent
	public UMaterialInterface PointMaterial;
	public FBoxSphereBounds Bounds;
	public bool bBoundsDirty;
}
