namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
public partial struct FGenerateStaticMeshLODProcess_UVSettings {
	public EGenerateStaticMeshLODProcess_AutoUVMethod UVMethod;
	public int NumUVAtlasCharts;
	public int NumInitialPatches;
	public float MergingThreshold;
	public float MaxAngleDeviation;
	public FGenerateStaticMeshLODProcess_UVSettings_PatchBuilder PatchBuilder;
}
