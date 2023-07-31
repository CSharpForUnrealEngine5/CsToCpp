#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralArrowToolProperties : UProceduralShapeToolProperties {
	///<summary>Radius of the arrow shaft</summary>
	public float ShaftRadius;
	///<summary>Height of arrow shaft</summary>
	public float ShaftHeight;
	///<summary>Radius of the arrow head base</summary>
	public float HeadRadius;
	///<summary>Height of arrow head</summary>
	public float HeadHeight;
	///<summary>Number of radial slices for the arrow</summary>
	public int RadialSlices;
	///<summary>Number of subdivisions along each part of the arrow, i.e. shaft, head base, head cone</summary>
	public int HeightSubdivisions;
}
