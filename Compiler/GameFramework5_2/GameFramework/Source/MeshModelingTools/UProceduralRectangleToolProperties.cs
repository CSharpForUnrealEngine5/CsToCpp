#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralRectangleToolProperties : UProceduralShapeToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Type of rectangle</summary>
	public EProceduralRectType RectangleType;
	///<summary>Width of the rectangle</summary>
	public float Width;
	///<summary>Depth of the rectangle</summary>
	public float Depth;
	///<summary>Number of subdivisions along the width</summary>
	public int WidthSubdivisions;
	///<summary>Number of subdivisions along the depth</summary>
	public int DepthSubdivisions;
	///<summary>Radius of rounded corners. This is only available for Rounded Rectangles.</summary>
	public float CornerRadius;
	///<summary>Number of radial slices for each rounded corner. This is only available for Rounded Rectangles.</summary>
	public int CornerSlices;
}
