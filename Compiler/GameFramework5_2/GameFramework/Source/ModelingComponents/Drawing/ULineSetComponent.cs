#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/LineSetComponent.h")]
public partial class ULineSetComponent : UMeshComponent {
// LineSetComponent
	public UMaterialInterface LineMaterial;
	public FBoxSphereBounds Bounds;
	public bool bBoundsDirty;
}
