#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolUniform.h")]
public partial class UFractureUniformSettings : UFractureToolSettings {
	///<summary>Minimum Number of Voronoi sites. The amount of sites per Voronoi diagram will be chosen at random between Min and Max</summary>
	public int NumberVoronoiSitesMin;
	///<summary>Maximum Number of Voronoi sites. The amount of sites per Voronoi diagram will be chosen at random between Min and Max</summary>
	public int NumberVoronoiSitesMax;
}
