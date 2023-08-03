#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sample points on a mesh</summary>
[CppInclude("Elements/PCGMeshSampler.h")]
public partial class UPCGMeshSamplerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SamplingMethod</summary>
	public EPCGMeshSamplingMethod SamplingMethod;
	///<summary>Soft Object Path to the mesh to sample from. Will be loaded.</summary>
	public FSoftObjectPath StaticMeshPath;
	///<summary>In &quot;One Point Per Vertex&quot; option, will assign point density from the red component of the vertex color.</summary>
	public bool bUseRedAsDensity;
	///<summary>Enable voxelisation as a preparation pass. Can be more expensive given the VoxelSize.</summary>
	public bool bVoxelize;
	///<summary>Size of a voxel for the voxelization.</summary>
	public float VoxelSize;
	///<summary>Post-processing pass after voxelization to remove hidden triangles.</summary>
	public bool bRemoveHiddenTriangles;
	///<summary>LOD type to use when creating DynamicMesh from specified StaticMesh.</summary>
	public EGeometryScriptLODType RequestedLODType;
	///<summary>RequestedLODIndex</summary>
	public int RequestedLODIndex;
	///<summary>Poisson Sampling parameters</summary>
	public FGeometryScriptMeshPointSamplingOptions SamplingOptions;
	///<summary>NonUniformSamplingOptions</summary>
	public FGeometryScriptNonUniformPointSamplingOptions NonUniformSamplingOptions;
}
