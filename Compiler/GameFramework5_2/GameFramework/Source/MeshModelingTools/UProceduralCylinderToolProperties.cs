namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralCylinderToolProperties : UProceduralShapeToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Radius of the cylinder</summary>
	public float Radius;
	///<summary>Height of the cylinder</summary>
	public float Height;
	///<summary>Number of radial slices for the cylinder</summary>
	public int RadialSlices;
	///<summary>Number of subdivisions along the height of the cylinder</summary>
	public int HeightSubdivisions;
}
