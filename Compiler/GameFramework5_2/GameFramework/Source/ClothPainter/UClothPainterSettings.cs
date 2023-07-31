#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothPaintSettings.h")]
public partial class UClothPainterSettings : UMeshPaintSettings {
	///<summary>When painting float/1D values, this is considered the zero or black point</summary>
	public float ViewMin;
	///<summary>When painting float/1D values, this is considered the one or white point</summary>
	public float ViewMax;
	///<summary>When set, the view min and max values will be calculated from the values present in the currently editable mask</summary>
	public bool bAutoViewRange;
	///<summary>Storage for auto calculated view min value</summary>
	public float AutoCalculatedViewMin;
	///<summary>Storage for auto calculated view max value</summary>
	public float AutoCalculatedViewMax;
	///<summary>Array of Clothing assets</summary>
	public TArray<UClothingAssetCommon> ClothingAssets;
	///<summary>Whether to flip normals on the mesh preview</summary>
	public bool bFlipNormal;
	///<summary>Whether to cull backfacing triangles when rendering the mesh preview</summary>
	public bool bCullBackface;
	///<summary>Opacity of the mesh preview</summary>
	public float Opacity;
}
