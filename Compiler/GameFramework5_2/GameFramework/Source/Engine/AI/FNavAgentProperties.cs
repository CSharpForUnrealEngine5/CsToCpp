#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavigationTypes.h")]
///<summary>Properties of representation of an 'agent' (or Pawn) used by AI navigation/pathfinding.</summary>
public partial struct FNavAgentProperties {
// NavAgentProperties
	public float AgentRadius;
	public float AgentHeight;
	public float AgentStepHeight;
	public float NavWalkingSearchHeightScale;
	public FSoftClassPath PreferredNavData;
}
