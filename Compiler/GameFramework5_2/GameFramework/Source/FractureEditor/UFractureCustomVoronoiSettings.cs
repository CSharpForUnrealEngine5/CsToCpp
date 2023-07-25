#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCustomVoronoi.h")]
public partial class UFractureCustomVoronoiSettings : UFractureToolSettings {
// FractureCustomVoronoiSettings
	public EVoronoiPattern VoronoiPattern;
	public float NormalOffset;
	public float Variability;
	public int SitesToAdd;
	public int GridX;
	public int GridY;
	public int GridZ;
	public float SkipFraction;
	public EDownsamplingMode SkipMode;
	public TLazyObjectPtr<AStaticMeshActor> ReferenceMesh;
	public bool bStartAtActor;
	public void FreezeLiveSites() {}
	public void ClearFrozenSites() {}
	public void UnfreezeSites() {}
	public void RegenerateLiveSites() {}
}
