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
	///<summary>Whether to preserve the overall Width and Depth for a Rounded Rectangle, or to allow the rounded corners to extend outside those dimensions.</summary>
	public bool bMaintainDimension;
	///<summary>Radius of rounded corners. This is only available for Rounded Rectangles.</summary>
	public float CornerRadius;
	///<summary>Number of radial slices for each rounded corner. This is only available for Rounded Rectangles.</summary>
	public int CornerSlices;
}
