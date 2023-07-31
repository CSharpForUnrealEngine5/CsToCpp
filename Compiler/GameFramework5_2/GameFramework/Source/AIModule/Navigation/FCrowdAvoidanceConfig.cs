#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Crowd manager is responsible for handling crowds using Detour (Recast library)</summary>
[CppInclude("Navigation/CrowdManager.h")]
public partial struct FCrowdAvoidanceConfig {
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
