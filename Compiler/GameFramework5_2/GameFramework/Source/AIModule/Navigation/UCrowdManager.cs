#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/CrowdManager.h")]
public partial class UCrowdManager : UCrowdManagerBase {
// CrowdManager
	public ANavigationData MyNavData;
	public TArray<FCrowdAvoidanceConfig> AvoidanceConfig;
	public TArray<FCrowdAvoidanceSamplingPattern> SamplingPatterns;
	public int MaxAgents;
	public float MaxAgentRadius;
	public int MaxAvoidedAgents;
	public int MaxAvoidedWalls;
	public float NavmeshCheckInterval;
	public float PathOptimizationInterval;
	public float SeparationDirClamp;
	public float PathOffsetRadiusMultiplier;
	public bool bResolveCollisions;
}
