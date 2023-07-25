#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGMeshSampler.h")]
///<summary>Sample points on a mesh</summary>
public partial class UPCGMeshSamplerSettings : UPCGSettings {
// PCGMeshSamplerSettings
	public EPCGMeshSamplingMethod SamplingMethod;
	public FSoftObjectPath StaticMeshPath;
	public bool bUseRedAsDensity;
	public bool bVoxelize;
	public float VoxelSize;
	public bool bRemoveHiddenTriangles;
	public EGeometryScriptLODType RequestedLODType;
	public int RequestedLODIndex;
	public FGeometryScriptMeshPointSamplingOptions SamplingOptions;
	public FGeometryScriptNonUniformPointSamplingOptions NonUniformSamplingOptions;
}
