namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/NavMeshBoundsVolume.h")]
public partial class ANavMeshBoundsVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>SupportedAgents</summary>
	public FNavAgentSelector SupportedAgents;
}
