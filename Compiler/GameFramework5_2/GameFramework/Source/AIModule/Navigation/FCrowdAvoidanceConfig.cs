#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/CrowdManager.h")]
///<summary>Crowd manager is responsible for handling crowds using Detour (Recast library)</summary>
public partial struct FCrowdAvoidanceConfig {
// CrowdAvoidanceConfig
	public float VelocityBias;
	public float DesiredVelocityWeight;
	public float CurrentVelocityWeight;
	public float SideBiasWeight;
	public float ImpactTimeWeight;
	public float ImpactTimeRange;
	public byte CustomPatternIdx;
	public byte AdaptiveDivisions;
	public byte AdaptiveRings;
	public byte AdaptiveDepth;
}
