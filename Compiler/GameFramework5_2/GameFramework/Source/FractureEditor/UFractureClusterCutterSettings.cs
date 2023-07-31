#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolClusterCutter.h")]
public partial class UFractureClusterCutterSettings : UFractureToolSettings {
	///<summary>Minimum number of clusters of Voronoi sites to create. The amount of clusters created will be chosen at random between Min and Max</summary>
	public int NumberClustersMin;
	///<summary>Maximum number of clusters of Voronoi sites to create. The amount of clusters created will be chosen at random between Min and Max</summary>
	public int NumberClustersMax;
	///<summary>Minimum number of Voronoi sites per cluster. The amount of sites in each cluster will be chosen at random between Min and Max</summary>
	public int SitesPerClusterMin;
	///<summary>Maximum number of Voronoi sites per cluster. The amount of sites in each cluster will be chosen at random between Min and Max</summary>
	public int SitesPerClusterMax;
	///<summary>Minimum cluster radius (as fraction of the overall Voronoi diagram size). Cluster Radius Offset will be added to this</summary>
	public float ClusterRadiusFractionMin;
	///<summary>Maximum cluster radius (as fraction of the overall Voronoi diagram size). Cluster Radius Offset will be added to this</summary>
	public float ClusterRadiusFractionMax;
	///<summary>Cluster radius offset (in cm). This offset will be added to the &#39;Min/Max Dist from Center&#39; distance</summary>
	public float ClusterRadiusOffset;
}
