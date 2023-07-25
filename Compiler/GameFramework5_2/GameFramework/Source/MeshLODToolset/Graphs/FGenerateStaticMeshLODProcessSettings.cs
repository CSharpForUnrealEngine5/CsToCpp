#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
public partial struct FGenerateStaticMeshLODProcessSettings {
// GenerateStaticMeshLODProcessSettings
	public EGenerateStaticMeshLODProcess_MeshGeneratorModes MeshGenerator;
	public int SolidifyVoxelResolution;
	public float WindingThreshold;
	public float ClosureDistance;
	public bool bPrefilterVertices;
	public int PrefilterGridResolution;
}
