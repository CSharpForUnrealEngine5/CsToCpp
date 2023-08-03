#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPointSetComponent is a Component that draws a set of points, as small squares.</summary>
[CppInclude("Drawing/PointSetComponent.h")]
public partial class UPointSetComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>PointMaterial</summary>
	public UMaterialInterface PointMaterial;
	///<summary>Bounds</summary>
	public FBoxSphereBounds Bounds;
	///<summary>bBoundsDirty</summary>
	public bool bBoundsDirty;
}
