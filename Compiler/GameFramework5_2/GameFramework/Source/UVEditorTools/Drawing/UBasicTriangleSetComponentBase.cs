#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for component specific functionality independent of the type of line stored in the component.</summary>
[CppInclude("Drawing/BasicTriangleSetComponent.h")]
public partial class UBasicTriangleSetComponentBase : UMeshComponent {
	///<summary>TriangleMaterial</summary>
	public UMaterialInterface TriangleMaterial;
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
	///<summary>Color</summary>
	public FColor Color;
	///<summary>Normal</summary>
	public FVector3f Normal;
}
