#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralDiscToolProperties : UProceduralShapeToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Type of disc</summary>
	public EProceduralDiscType DiscType;
	///<summary>Radius of the disc</summary>
	public float Radius;
	///<summary>Number of radial slices for the disc</summary>
	public int RadialSlices;
	///<summary>Number of radial subdivisions for each radial slice of the disc</summary>
	public int RadialSubdivisions;
	///<summary>Radius of the hole in the disc. This is only available for Punctured Discs.</summary>
	public float HoleRadius;
}
