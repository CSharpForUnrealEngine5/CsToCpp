namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties of representation of an &#39;agent&#39; (or Pawn) used by AI navigation/pathfinding.</summary>
[CppInclude("AI/Navigation/NavigationTypes.h")]
public partial struct FNavAgentProperties {
	public float AgentRadius;
	public float AgentHeight;
	public float AgentStepHeight;
	public float NavWalkingSearchHeightScale;
	public FSoftClassPath PreferredNavData;
}
