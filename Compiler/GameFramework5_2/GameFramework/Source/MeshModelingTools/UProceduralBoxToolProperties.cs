#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralBoxToolProperties : UProceduralShapeToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Width of the box</summary>
	public float Width;
	///<summary>Depth of the box</summary>
	public float Depth;
	///<summary>Height of the box</summary>
	public float Height;
	///<summary>Number of subdivisions along the width</summary>
	public int WidthSubdivisions;
	///<summary>Number of subdivisions along the depth</summary>
	public int DepthSubdivisions;
	///<summary>Number of subdivisions along the height</summary>
	public int HeightSubdivisions;
}
