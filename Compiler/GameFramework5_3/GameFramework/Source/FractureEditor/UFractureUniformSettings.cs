namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolUniform.h")]
public partial class UFractureUniformSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Minimum Number of Voronoi sites. The amount of sites per Voronoi diagram will be chosen at random between Min and Max</summary>
	public int NumberVoronoiSitesMin;
	///<summary>Maximum Number of Voronoi sites. The amount of sites per Voronoi diagram will be chosen at random between Min and Max</summary>
	public int NumberVoronoiSitesMax;
}
