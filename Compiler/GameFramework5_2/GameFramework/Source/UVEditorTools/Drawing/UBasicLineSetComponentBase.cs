#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for component specific functionality independent of the type of line stored in the component.</summary>
[CppInclude("Drawing/BasicLineSetComponent.h")]
public partial class UBasicLineSetComponentBase : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
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
