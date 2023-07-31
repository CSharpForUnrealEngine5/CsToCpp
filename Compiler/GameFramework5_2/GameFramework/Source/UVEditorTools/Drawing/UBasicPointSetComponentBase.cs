#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for component specific functionality independent of the type of point stored in the component.</summary>
[CppInclude("Drawing/BasicPointSetComponent.h")]
public partial class UBasicPointSetComponentBase : UMeshComponent {
	///<summary>PointMaterial</summary>
	public UMaterialInterface PointMaterial;
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
	///<summary>Color</summary>
	public FColor Color;
	///<summary>Size</summary>
	public float Size;
	///<summary>DepthBias</summary>
	public float DepthBias;
}
