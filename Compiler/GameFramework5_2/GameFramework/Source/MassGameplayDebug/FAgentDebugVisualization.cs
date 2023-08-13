namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassGameplayDebugTypes.h")]
public partial struct FAgentDebugVisualization {
	public UStaticMesh Mesh;
	public UMaterialInterface MaterialOverride;
	public uint VisualNearCullDistance;
	public uint VisualFarCullDistance;
	public EMassEntityDebugShape WireShape;
}
