#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/BasicTriangleSetComponent.h")]
///<summary>Base class for component specific functionality independent of the type of line stored in the component.</summary>
public partial class UBasicTriangleSetComponentBase : UMeshComponent {
// BasicTriangleSetComponentBase
	public UMaterialInterface TriangleMaterial;
	public FBoxSphereBounds Bounds;
	public bool bBoundsDirty;
	public FColor Color;
	public FVector3f Normal;
}
