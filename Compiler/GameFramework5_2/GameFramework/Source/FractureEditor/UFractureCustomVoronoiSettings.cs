#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCustomVoronoi.h")]
public partial class UFractureCustomVoronoiSettings : UFractureToolSettings {
	///<summary>Method to generate next group of voronoi sites</summary>
	public EVoronoiPattern VoronoiPattern;
	///<summary>Offset point samples in the vertex normal directions</summary>
	public float NormalOffset;
	///<summary>Amount to randomly displace each Voronoi site (in cm)</summary>
	public float Variability;
	///<summary>Number of Voronoi sites to add</summary>
	public int SitesToAdd;
	///<summary>Number of sites to add to grid in X</summary>
	public int GridX;
	///<summary>Number of sites to add to grid in Y</summary>
	public int GridY;
	///<summary>Number of sites to add to grid in Z</summary>
	public int GridZ;
	///<summary>Fraction of points to skip</summary>
	public float SkipFraction;
	///<summary>Strategy used for skipping points; only used if SkipFraction is greater than 0</summary>
	public EDownsamplingMode SkipMode;
	///<summary>Static mesh actor to be used as a reference when adding Voronoi sites</summary>
	public TLazyObjectPtr<AStaticMeshActor> ReferenceMesh;
	///<summary>Whether to use the reference mesh actor&#39;s transform when placing the Voronoi sites, or center them at the current gizmo location instead</summary>
	public bool bStartAtActor;
	///<summary>Freeze the current live Voronoi Sites based on the current parameters</summary>
	public  void FreezeLiveSites() {}
	///<summary>Remove all frozen sites</summary>
	public  void ClearFrozenSites() {}
	///<summary>Unfreeze all frozen sites</summary>
	public  void UnfreezeSites() {}
	///<summary>Re-run the live Voronoi sites generator, using the current settings and selection bounds</summary>
	public  void RegenerateLiveSites() {}
}
