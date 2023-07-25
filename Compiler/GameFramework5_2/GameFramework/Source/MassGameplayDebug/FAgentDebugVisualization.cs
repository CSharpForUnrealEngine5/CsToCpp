#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassGameplayDebugTypes.h")]
public partial struct FAgentDebugVisualization {
// AgentDebugVisualization
	public UStaticMesh Mesh;
	public UMaterialInterface MaterialOverride;
	public uint VisualNearCullDistance;
	public uint VisualFarCullDistance;
	public EMassEntityDebugShape WireShape;
}
