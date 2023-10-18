namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/CrowdManager.h")]
public partial class UCrowdManager : UCrowdManagerBase {
	public static UClass StaticClass() {return default;}
	///<summary>MyNavData</summary>
	public ANavigationData MyNavData;
	///<summary>obstacle avoidance params</summary>
	public TArray<FCrowdAvoidanceConfig> AvoidanceConfig;
	///<summary>obstacle avoidance params</summary>
	public TArray<FCrowdAvoidanceSamplingPattern> SamplingPatterns;
	///<summary>max number of agents supported by crowd</summary>
	public int MaxAgents;
	///<summary>max radius of agent that can be added to crowd</summary>
	public float MaxAgentRadius;
	///<summary>max number of neighbor agents for velocity avoidance</summary>
	public int MaxAvoidedAgents;
	///<summary>max number of wall segments for velocity avoidance</summary>
	public int MaxAvoidedWalls;
	///<summary>how often should agents check their position after moving off navmesh?</summary>
	public float NavmeshCheckInterval;
	///<summary>how often should agents try to optimize their paths?</summary>
	public float PathOptimizationInterval;
	///<summary>clamp separation force to left/right when neighbor is behind (dot between forward and dirToNei, -1 = disabled)</summary>
	public float SeparationDirClamp;
	///<summary>agent radius multiplier for offsetting path around corners</summary>
	public float PathOffsetRadiusMultiplier;
	///<summary>should crowd simulation resolve collisions between agents? if not, this will be handled by their movement components</summary>
	public bool bResolveCollisions;
}
