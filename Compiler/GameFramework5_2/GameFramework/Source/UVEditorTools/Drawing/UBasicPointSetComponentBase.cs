#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/BasicPointSetComponent.h")]
///<summary>Base class for component specific functionality independent of the type of point stored in the component.</summary>
public partial class UBasicPointSetComponentBase : UMeshComponent {
// BasicPointSetComponentBase
	public UMaterialInterface PointMaterial;
	public FBoxSphereBounds Bounds;
	public bool bBoundsDirty;
	public FColor Color;
	public float Size;
	public float DepthBias;
}
