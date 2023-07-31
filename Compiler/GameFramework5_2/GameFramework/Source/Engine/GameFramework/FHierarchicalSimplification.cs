#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/WorldSettings.h")]
public partial struct FHierarchicalSimplification {
	public float TransitionScreenSize;
	public float OverrideDrawDistance;
	public bool bUseOverrideDrawDistance;
	public bool bAllowSpecificExclusion;
	public bool bOnlyGenerateClustersForVolumes;
	public bool bReusePreviousLevelClusters;
	public EHierarchicalSimplificationMethod SimplificationMethod;
	public FMeshProxySettings ProxySetting;
	public FMeshMergingSettings MergeSetting;
	public FMeshApproximationSettings ApproximateSettings;
	public float DesiredBoundRadius;
	public float DesiredFillingPercentage;
	public int MinNumberOfActorsToBuild;
	public bool bSimplifyMesh_DEPRECATED;
}
