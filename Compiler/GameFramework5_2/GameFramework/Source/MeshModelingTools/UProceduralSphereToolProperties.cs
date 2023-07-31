#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralSphereToolProperties : UProceduralShapeToolProperties {
	///<summary>Radius of the sphere</summary>
	public float Radius;
	///<summary>Type of subdivision for the sphere</summary>
	public EProceduralSphereType SubdivisionType;
	///<summary>Number of subdivisions for each side of the sphere. This is only available for spheres with Box subdivision.</summary>
	public int Subdivisions;
	///<summary>Number of horizontal slices of the sphere. This is only available for spheres with Lat Long subdivision.</summary>
	public int HorizontalSlices;
	///<summary>Number of vertical slices of the sphere. This is only available for spheres with Lat Long subdivision.</summary>
	public int VerticalSlices;
}
